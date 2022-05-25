using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Vector;

using Emgu;
using Emgu.CV;
using Emgu.CV.Util;
using Emgu.CV.Structure;
using Emgu.Util;
using Emgu.CV.Dnn;


using System.IO.Ports;

using DirectShowLib;
using System.Threading;
using Emgu.CV.UI;
using System.Diagnostics;
using System.IO;
using Emgu.CV.CvEnum;

namespace RoboControl
{
    public partial class MainForm : Form
    {
        private VideoCapture capture = null;
        private DsDevice[] webCams = null;
        private string[] availablePortsNames = null;
        private int selectedCameraId = 0;
        private Graphics painter;
        private Vector2d robotCoords;
        private Vector2d boundCoords;
        private Mat frame;
        private SerialPortRoboController roboController;
        private SerialPort6RoboController roboController6;
        private List<DetectedObject> currentDetections;

        private bool isDetectionModeOn;

        // Yolo
        Detector detector;

        private bool inCalibrationMode;
        public MainForm()
        {
            InitializeComponent();
            painter = mainVideoBox.CreateGraphics();
            inCalibrationMode = false;
            robotCoords = new Vector2d(0, 0);
            frame = new Mat();
            detector = new Detector();
            isDetectionModeOn = false;
            confidenceTrashHoldTextBox.Text = "10%";
            MouseWheel += new MouseEventHandler(MouseWheel_event);
            KeyDown += new KeyEventHandler(SpaceKeyDownEvent);
            manipulatorComboBox.SelectedItem = manipulatorComboBox.Items[0];
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        void MouseWheel_event(object sender, MouseEventArgs e)
        {
            if (roboController != null)
            {
                roboController.Lift(e.Delta);
            }
            if (roboController6 != null)
            {
                roboController6.Lift(e.Delta);
            }
        }

        void SpaceKeyDownEvent(object sender, KeyEventArgs e)
        {
            Debug.Print("Space pressed!");
            if (roboController != null)
            {
                if (e.KeyCode == Keys.Space)
                {
                    if (roboController.IsOpen) roboController.CloseGrab();
                    else roboController.OpenGrab();
                }
            }
            if (roboController6 != null)
            {
                if (e.KeyCode == Keys.Space)
                {
                    if (roboController6.IsOpen) roboController6.CloseGrab();
                    else roboController6.OpenGrab();
                }
            }
        }

        private void serialPortNamesComboBox_DropDown(object sender, EventArgs e)
        {
            GetPortsAndDisplayThem();
        }

        private void toolStripComboBox1_DropDown(object sender, EventArgs e)
        {
            GetCamerasAndDisplayThem();
        }

        private void GetPortsAndDisplayThem()
        {
            serialPortNamesComboBox.Items.Clear();
            availablePortsNames = SerialPort.GetPortNames();
            foreach (string port in availablePortsNames)
            {
                serialPortNamesComboBox.Items.Add(port);
            }
        }

        private void GetCamerasAndDisplayThem()
        {
            camerasComboBox.Items.Clear();
            webCams = DsDevice.GetDevicesOfCat(FilterCategory.VideoInputDevice);
            for (int i = 0; i < webCams.Length; i++)
            {
                camerasComboBox.Items.Add(webCams[i].Name);
            }
        }

        private void CamerasComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedCameraId = camerasComboBox.SelectedIndex;
        }

        private void CaptureBegin()
        {
            try
            {
                if (webCams?.Length == 0)
                {
                    throw new Exception("Нет доступных камер!");
                }
                else if (camerasComboBox.SelectedItem == null)
                {
                    throw new Exception("Необходимо выбрать камеру");
                }
                else if (capture != null)
                {
                    capture.Start();
                }
                else
                {
                    capture = new VideoCapture(selectedCameraId);
                    Size newVideoBoxSize = new Size(capture.Width, capture.Height);
                    resolutionText.Text = newVideoBoxSize.ToString();
                    mainVideoBox.Size = newVideoBoxSize;
                    capture.ImageGrabbed += Capture_ImageGrabbed;
                    videoBoxPanel.BackColor = SystemColors.MenuHighlight;
                    capture.Start();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CaptureButton_Click(object sender, EventArgs e)
        {
            CaptureBegin();
        }

        private void Capture_ImageGrabbed(object sender, EventArgs e)
        {
            try
            {
                frame = capture.QueryFrame();
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                if(isDetectionModeOn)
                {
                    using (Image<Bgr, byte> image = SetDetectionsObjectsToImage(frame.ToImage<Bgr, byte>().Flip(Emgu.CV.CvEnum.FlipType.Horizontal)))
                    {
                        mainVideoBox.Image = image.ToBitmap();
                    }
                }
                else
                {
                    using (Image<Bgr, byte> image = frame.ToImage<Bgr, byte>().Flip(Emgu.CV.CvEnum.FlipType.Horizontal))
                    {
                        mainVideoBox.Image = image.ToBitmap();
                    }
                }
                stopwatch.Stop();
                //Debug.Print(stopwatch.ElapsedMilliseconds.ToString());
                //mainVideoBox.Image = m.ToImage<Bgr, byte>().Flip(Emgu.CV.CvEnum.FlipType.Horizontal).AsBitmap<Bgr, byte>();
                //Emgu.CV.Image<Bgr, byte> frame = m.ToImage<Bgr, byte>().Flip(Emgu.CV.CvEnum.FlipType.Horizontal);
                //mainVideoBox.Image = frame.AsBitmap();
                //mainVideoBox.Image = capture.QueryFrame().ToImage<Bgr, byte>().AsBitmap();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CapturePause()
        {
            try
            {
                if (capture != null)
                {
                    capture.Pause();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            CapturePause();
        }

        private void CaptureEnd()
        {
            try
            {
                if (capture != null)
                {
                    capture.Pause();
                    capture.Dispose();
                    capture = null;

                    mainVideoBox.Image.Dispose();
                    mainVideoBox.Image = null;

                    selectedCameraId = 0;
                    videoBoxPanel.BackColor = SystemColors.WindowFrame;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            CaptureEnd();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ScreenShotButton_Click(object sender, EventArgs e)
        {
            try
            {
                capture.Retrieve(frame);

                MakeScreenShotForm screenShotForm =
                    new MakeScreenShotForm(frame.ToImage<Bgr, byte>().Flip(Emgu.CV.CvEnum.FlipType.Horizontal));

                screenShotForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (inCalibrationMode) return;
            if (manipulatorComboBox.SelectedIndex == 0)
            {
                var direction = new Vector2d(e.Location.X, e.Location.Y);
                //Debug.Print(direction.ToString());
                coordsText.Text = e.Location.ToString();
                int angle = -(int)Math.Round(Math.Atan2((direction.Y - robotCoords.Y), (direction.X - robotCoords.X)) * (180 / Math.PI));
                string command = "d" + angle.ToString();
                horizaontalAngleDebug.Text = command;
                roboController?.TurnHorizontal(direction);
                roboController?.Stretch(direction);
            }
            else
            {
                return;
                //var direction = new Vector2d(e.Location.X, e.Location.Y);
                //coordsText.Text = direction.ToString();
                //roboController6?.MooveTo(direction);
            }
        }

        private void mainVideoBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (roboController6 != null)
            {
                var direction = new Vector2d(e.Location.X, e.Location.Y);
                coordsText.Text = direction.ToString();
                roboController6?.MooveTo(direction);
            }
            return;
            //roboController?.TurnHorizontal(e.Location);
        }

        private void calibrationButton_Click(object sender, EventArgs e)
        {
            if (capture == null)
            {
                MessageBox.Show("Сначала необходимо начать захват", "Нет захватываемого изображения",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (serialPortNamesComboBox.SelectedItem == null)
            {
                MessageBox.Show("Сначала необходимо выбрать порт, к которому подключен робот", "Не выбран порт для связи",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            inCalibrationMode = true;
            mainVideoBox.Cursor = Cursors.Cross;

            videoBoxPanel.BackColor = Color.OrangeRed;//SystemColors.MenuHighlight;

            MessageBox.Show("Укажите местоположение робота", "Калибровка",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (manipulatorComboBox.SelectedIndex == 0)
            {
                roboController = new SerialPortRoboController(serialPortNamesComboBox.SelectedItem.ToString());
                roboController.TurnHorizontalDefault();
                roboController.StretchMin();
                roboController.GetUp();
                mainVideoBox.MouseClick -= mainVideoBox_MouseClick;
                mainVideoBox.MouseClick += new MouseEventHandler(mainVideoBox_RobotCoordsPointer);
            }
            else
            {
                roboController6 = new SerialPort6RoboController(serialPortNamesComboBox.SelectedItem.ToString(), 13.5f, 23f);
                mainVideoBox.MouseClick -= mainVideoBox_MouseClick;
                mainVideoBox.MouseClick += new MouseEventHandler(mainVideoBox_RobotCoordsPointer);
            }
        }

        private void mainVideoBox_RobotCoordsPointer(object sender, MouseEventArgs e)
        {
            if (manipulatorComboBox.SelectedIndex == 0)
            {
                robotCoords = new Vector2d(e.Location.X, e.Location.Y);
                robotCoordsText.Text = robotCoords.ToString();
                roboController.RobotCoords = robotCoords;
                mainVideoBox.MouseClick -= mainVideoBox_RobotCoordsPointer;
                mainVideoBox.MouseClick += new MouseEventHandler(mainVideoBox_BoundCoordsPointer);
                roboController.StretchMax();
                MessageBox.Show("Укажите на конец манипулятора, задав границу действия робота", "Калибровка",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                robotCoords = new Vector2d(e.Location.X, e.Location.Y);
                roboController6.SetRobotCoords(robotCoords);
                mainVideoBox.MouseClick -= mainVideoBox_RobotCoordsPointer;
                mainVideoBox.MouseClick += new MouseEventHandler(mainVideoBox_BoundCoordsPointer);
                MessageBox.Show("Укажите на расстояние в 20 см от манипулятора", "Калибровка",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void mainVideoBox_BoundCoordsPointer(object sender, MouseEventArgs e)
        {
            if (manipulatorComboBox.SelectedIndex == 0)
            {
                roboController.StretchMin();
                boundCoords = new Vector2d(e.Location.X, e.Location.Y);
                roboController.BoundCoords = boundCoords;
                boundCoordsText.Text = boundCoords.ToString();
                videoBoxPanel.BackColor = SystemColors.WindowFrame;
                mainVideoBox.MouseClick -= mainVideoBox_BoundCoordsPointer;
                mainVideoBox.MouseClick += new MouseEventHandler(mainVideoBox_MouseClick);
                mainVideoBox.Cursor = Cursors.Default;
                inCalibrationMode = false;
            }
            else
            {
                videoBoxPanel.BackColor = SystemColors.WindowFrame;
                mainVideoBox.MouseClick -= mainVideoBox_BoundCoordsPointer;
                mainVideoBox.MouseClick += new MouseEventHandler(mainVideoBox_MouseClick);
                mainVideoBox.Cursor = Cursors.Default;
                double coeff = new Vector2d(e.Location.X - robotCoords.X, e.Location.Y - robotCoords.Y).Magnitude() / 20;
                Debug.Print("coeff" + coeff.ToString());
                roboController6.SetScaleFactor(coeff);
                inCalibrationMode = false;

            }
           
        }

        private void LoadModel_Click(object sender, EventArgs e)
        {
            /*
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Multiselect = true;
                if(dialog.ShowDialog() == DialogResult.OK)
                {
                    var PathWeights = dialog.FileNames.Where(x => x.ToLower().EndsWith(".weights")).First();
                    var PathConfig = dialog.FileNames.Where(x => x.ToLower().EndsWith(".cfg")).First();
                    var PathClasses = dialog.FileNames.Where(x => x.ToLower().EndsWith(".names")).First();

                    model = DnnInvoke.ReadNetFromDarknet(PathConfig, PathWeights);
                    ClassLabels = File.ReadAllLines(PathClasses).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            */

            /*
            model = detector.Model;
            ClassLabels = detector.ClassLabels;
            */
        }

        private void TestModelButton_Click(object sender, EventArgs e)
        {
            try
            {
                Image<Bgr, byte> img = null;
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files(*.jpg, *.png) | *.jpg; *.png;";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    img = new Image<Bgr, byte>(dialog.FileName).Resize(608, 608, Inter.Cubic);
                }
                else
                {
                    return;
                }
                float confidenceTrashHold = int.Parse(confidenceTrashHoldTextBox.Text.Replace('%', ' ')) / 100f;
                List<Rectangle> rectsToShow = detector.GetBoundingBoxes(img, confidenceTrashHold, 
                    nmsTreshhold: 0.4f);

                Image<Bgr, byte> imgOutput = img.Clone();
                for (int i = 0; i < rectsToShow.Count(); i++)
                {
                    imgOutput.Draw(rectsToShow[i], new Bgr(0, 255, 0), 2);

                    //CvInvoke.PutText(imgOutput, ClassLabels[indices[index]], new Point(bbox.X, bbox.Y + 20),
                    //    FontFace.HersheySimplex, 1.0, new MCvScalar(0, 0, 255), 2);
                }

                mainVideoBox.Image = imgOutput.Resize(640, 480, Inter.Cubic).ToBitmap();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                CapturePause();
            }
        }

        private Image<Bgr, byte> SetDetectionsObjectsToImage(Image<Bgr, byte> inputImage)
        {
            //List<Rectangle> rectsToShow = detector.GetBoundingBoxes(inputImage, 0.4f, 0.4f);
            float confidenceTrashHold = int.Parse(confidenceTrashHoldTextBox.Text.Replace('%', ' ')) / 100f;
            currentDetections = detector.GetDetectedObjects(inputImage, confidenceTrashHold, nmsTreshhold: 0.4f);
            //Image<Bgr, byte> imgOutput = inputImage.Clone();
            for (int i = 0; i < currentDetections.Count(); i++)
            {
                inputImage.Draw(currentDetections[i].bbox, new Bgr(141, 137, 61), 2);
                CvInvoke.PutText(inputImage, currentDetections[i].name, new Point(currentDetections[i].bbox.X, currentDetections[i].bbox.Y + 20),
                        FontFace.HersheySimplex, 1.0, new MCvScalar(217, 235, 133), 2);
                Cross2DF cross = new Cross2DF(currentDetections[i].centre.ToPoint(), 20, 15);
                inputImage.Draw(cross, new Bgr(141, 137, 61), 2);
                //CvInvoke.PutText(imgOutput, ClassLabels[indices[index]], new Point(bbox.X, bbox.Y + 20),
                //    FontFace.HersheySimplex, 1.0, new MCvScalar(0, 0, 255), 2);
            }
            return inputImage;
        }

        private void DetectionModeButton_Click(object sender, EventArgs e)
        {
            (sender as ToolStripButton).Checked = isDetectionModeOn = !isDetectionModeOn;
        }

        private void mainVideoBox_DoubleClick(object sender, EventArgs e)
        {
            if (roboController == null) return;
            try
            {
                if (roboController.IsUp)
                    roboController.GetDown();
                else
                    roboController.GetUp();
            }
            catch(Exception ex)
            {
                    MessageBox.Show(ex.Message);
                    CapturePause();
            }
        }

        private void TakeItems_Click(object sender, EventArgs e)
        {
            try
            {
                frame = capture.QueryFrame();
                capture.Pause();
                using (Image<Bgr, byte> image = SetDetectionsObjectsToImage(frame.ToImage<Bgr, byte>().Flip(Emgu.CV.CvEnum.FlipType.Horizontal)))
                {
                    mainVideoBox.Image = image.ToBitmap();
                }
                if(currentDetections.Count > 0)
                {
                    TakeItems();
                }
                System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
                t.Interval = 2000;
                t.Tick += new EventHandler(t_Tick);
                t.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void TakeItems()
        {
            int delay = 3000;
            if (roboController6 != null)
            {
                Debug.Print(currentDetections[0].centre.ToString());
                Vector3d point = new Vector3d(currentDetections[0].centre.X, currentDetections[0].centre.Y, 200);
                roboController6?.MooveTo(point);
                await Task.Delay(delay);
                point = new Vector3d(currentDetections[0].centre.X, currentDetections[0].centre.Y, 50);
                roboController6?.MooveTo(point);
                await Task.Delay(delay);
                point = new Vector3d(currentDetections[0].centre.X, currentDetections[0].centre.Y, 200);
                roboController6?.MooveTo(point);
                await Task.Delay(delay);
                roboController6?.MooveTo(new Vector3d(140, 400, 200));
                /*
                await Task.Delay(delay);
                point = new Vector3d(currentDetections[0].centre.X, currentDetections[0].centre.Y, 4);
                roboController6?.MooveTo(point);
                await Task.Delay(delay);
                roboController6?.MooveTo(new Vector3d (140, 400, 5)); 
                await Task.Delay(delay);
                roboController6?.MooveTo(new Vector3d(140, 400, 10));
                await Task.Delay(delay);
                */
            }
            if (roboController != null)
            {
                Debug.Print(currentDetections[0].centre.ToString());
                roboController?.MooveTo(currentDetections[0].centre.ToPoint());
                await Task.Delay(delay);
                roboController?.GetDown();
                await Task.Delay(delay);
                //roboController.GetUp();
                await Task.Delay(delay);
                roboController?.MooveTo(new Point(140, 400));
                await Task.Delay(delay);
            }
        }

        void t_Tick(object sender, EventArgs e)
        {
            (sender as System.Windows.Forms.Timer).Stop();
            capture.Start();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ControlForm form;
            if (serialPortNamesComboBox.SelectedItem == null)
                form = new ControlForm(null);
            else
                form = new ControlForm(serialPortNamesComboBox.SelectedItem.ToString());
            form.Show();
        }
    }
}
