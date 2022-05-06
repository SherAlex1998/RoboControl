using Emgu.CV.Dnn;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu;
using Emgu.CV;
using Emgu.CV.Util;
using Emgu.CV.Structure;
using Emgu.Util;
using Emgu.CV.Dnn;
using Emgu.CV.CvEnum;
using Vector;

namespace RoboControl
{

    struct DetectedObject
    {
        public Rectangle bbox;
        public Vector2d centre;
        public string name;
    }

    class Detector
    {
        // Yolo
        Net model = null;
        List<string> classLabels = null;

        public Detector()
        {
            string weightsPath = "./Resources/yolov3.weights";
            string confidPath = "./Resources/yolov3.cfg";
            string namesPath = "./Resources/coco.names";
            try
            {
                model = DnnInvoke.ReadNetFromDarknet(confidPath, weightsPath);
                classLabels = File.ReadAllLines(namesPath).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private Rectangle ScaleCoords(Rectangle bbox, Vector2d from, Vector2d to)
        {
            int scaleFactorX = (int)(to.X / from.X);
            int scaleFactorY = (int)(to.Y / from.Y);
            bbox.X *= scaleFactorX;
            bbox.Y *= scaleFactorY;
            bbox.Width *= scaleFactorX;
            bbox.Height *= scaleFactorY;
            return bbox;
        }

        public List<DetectedObject> GetDetectedObjects(Image<Bgr, byte> inputImage, float confidenceTreshhold, float nmsTreshhold)
        {
            List<DetectedObject> detectedObjects = new List<DetectedObject>();
            try
            {
                if (model == null)
                {
                    throw new Exception("Модель не загружена!");
                }

                //int imgDefaultSize = 608;

                //inputImage = inputImage.Resize(imgDefaultSize, imgDefaultSize, Inter.Cubic);

                Mat input = DnnInvoke.BlobFromImage(inputImage, 1 / 255.0, swapRB: true);
                model.SetInput(input);
                model.SetPreferableBackend(Emgu.CV.Dnn.Backend.OpenCV);
                //model.SetPreferableTarget(Target.OpenCL);
                model.SetPreferableTarget(Target.Cpu);

                VectorOfMat vectorOfMat = new VectorOfMat();
                model.Forward(vectorOfMat, model.UnconnectedOutLayersNames);

                // post proccesing

                VectorOfRect bboxes = new VectorOfRect();
                VectorOfFloat scores = new VectorOfFloat();
                VectorOfInt indices = new VectorOfInt();

                for (int k = 0; k < vectorOfMat.Size; k++)
                {
                    var mat = vectorOfMat[k];
                    var data = UtilityInteractor.ArrayTo2dList(mat.GetData());

                    for (int i = 0; i < data.Count; i++)
                    {
                        var row = data[i];
                        var rowsscores = row.Skip(5).ToArray();
                        var classId = rowsscores.ToList().IndexOf(rowsscores.Max());
                        var confidence = rowsscores[classId];

                        if (confidence > confidenceTreshhold)
                        {
                            var center_x = (int)(row[0] * inputImage.Width); // центральные координаты ограничеговающего поля
                            var center_y = (int)(row[1] * inputImage.Height);

                            var width = (int)(row[2] * inputImage.Width); // его ширина и высота
                            var height = (int)(row[3] * inputImage.Height);

                            var x = (int)(center_x - (width / 2));
                            var y = (int)(center_y - (height / 2));

                            bboxes.Push(new Rectangle[] { new Rectangle(x, y, width, height) });
                            indices.Push(new int[] { classId });
                            scores.Push(new float[] { confidence });
                        }
                    }
                }

                var idx = DnnInvoke.NMSBoxes(bboxes.ToArray(), scores.ToArray(), confidenceTreshhold, nmsTreshhold);

                //Debug.Print(idx.Length.ToString());


                //Image<Bgr, byte> imgOutput = inputImage.Clone();
                for (int i = 0; i < idx.Length; i++)
                {
                    int index = idx[i];
                    var boundingbox = bboxes[index];
                    DetectedObject detection = new DetectedObject()
                    {
                        bbox = boundingbox,
                        centre = new Vector2d((int)(boundingbox.X + (boundingbox.Width / 2)), (int)(boundingbox.Y + (boundingbox.Height / 2))),
                        name = ClassLabels[indices[index]],
                    };
                    detectedObjects.Add(detection);
                    //outputbbxoes.Add(boundingbox);
                    //imgOutput.Draw(bbox, new Bgr(0, 255, 0), 2);

                    //CvInvoke.PutText(imgOutput, ClassLabels[indices[index]], new Point(bbox.X, bbox.Y + 20),
                    //    FontFace.HersheySimplex, 1.0, new MCvScalar(0, 0, 255), 2);
                }

                //mainVideoBox.Image = imgOutput.Resize(640, 480, Inter.Cubic).ToBitmap();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return detectedObjects;
        }

        public List<Rectangle> GetBoundingBoxes(Image<Bgr, byte> inputImage, float confidenceTreshhold, float nmsTreshhold)
        {
            List<Rectangle> outputbbxoes = new List<Rectangle>();
            try
            {
                if (model == null)
                {
                    throw new Exception("Модель не загружена!");
                }

                //int imgDefaultSize = 608;

                //inputImage = inputImage.Resize(imgDefaultSize, imgDefaultSize, Inter.Cubic);

                Mat input = DnnInvoke.BlobFromImage(inputImage, 1 / 255.0, swapRB: true);
                model.SetInput(input);
                model.SetPreferableBackend(Emgu.CV.Dnn.Backend.OpenCV);
                model.SetPreferableTarget(Target.OpenCL);

                VectorOfMat vectorOfMat = new VectorOfMat();
                model.Forward(vectorOfMat, model.UnconnectedOutLayersNames);

                // post proccesing

                VectorOfRect bboxes = new VectorOfRect();
                VectorOfFloat scores = new VectorOfFloat();
                VectorOfInt indices = new VectorOfInt();

                for (int k = 0; k < vectorOfMat.Size; k++)
                {
                    var mat = vectorOfMat[k];
                    var data = UtilityInteractor.ArrayTo2dList(mat.GetData());

                    for (int i = 0; i < data.Count; i++)
                    {
                        var row = data[i];
                        var rowsscores = row.Skip(5).ToArray();
                        var classId = rowsscores.ToList().IndexOf(rowsscores.Max());
                        var confidence = rowsscores[classId];

                        if (confidence > confidenceTreshhold)
                        {
                            var center_x = (int)(row[0] * inputImage.Width); // центральные координаты ограничеговающего поля
                            var center_y = (int)(row[1] * inputImage.Height);

                            var width = (int)(row[2] * inputImage.Width); // его ширина и высота
                            var height = (int)(row[3] * inputImage.Height);

                            var x = (int)(center_x - (width / 2));
                            var y = (int)(center_y - (height / 2));

                            bboxes.Push(new Rectangle[] { new Rectangle(x, y, width, height) });
                            indices.Push(new int[] { classId });
                            scores.Push(new float[] { confidence });

                        }
                    }
                }

                var idx = DnnInvoke.NMSBoxes(bboxes.ToArray(), scores.ToArray(), confidenceTreshhold, nmsTreshhold);

                //Debug.Print(idx.Length.ToString());

                
                //Image<Bgr, byte> imgOutput = inputImage.Clone();
                for (int i = 0; i < idx.Length; i++)
                {
                    int index = idx[i];
                    var bbox = bboxes[index];
                    outputbbxoes.Add(bbox);
                    //imgOutput.Draw(bbox, new Bgr(0, 255, 0), 2);

                    //CvInvoke.PutText(imgOutput, ClassLabels[indices[index]], new Point(bbox.X, bbox.Y + 20),
                    //    FontFace.HersheySimplex, 1.0, new MCvScalar(0, 0, 255), 2);
                }

                //mainVideoBox.Image = imgOutput.Resize(640, 480, Inter.Cubic).ToBitmap();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return outputbbxoes;
        }

        public Net Model { get => model; set => model = value; }
        public List<string> ClassLabels { get => classLabels; set => classLabels = value; }
    }
}
