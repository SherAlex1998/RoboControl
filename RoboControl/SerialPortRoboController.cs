using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Drawing;
using System.Diagnostics;
using Vector;

namespace RoboControl
{
    class SerialPortRoboController
    {
        private SerialPort port;
        private Vector2d robotCoords;
        private Vector2d boundCoords;
        private Vector2d boundVector;
        private double lengthOfBoundVector;

        private int calibrationConstant;

        private bool isUp;

        public Vector2d RobotCoords { get => robotCoords; set => robotCoords = value; }
        public Vector2d BoundCoords 
        { get => boundCoords; 
            set
            {
                boundCoords = value;
                boundVector = boundCoords - robotCoords - (boundCoords - robotCoords).Normalize() * calibrationConstant;//new Vector2d(boundCoords.X - robotCoords.X, boundCoords.Y + calibrationConstant - robotCoords.Y);
                lengthOfBoundVector = boundVector.Magnitude();
                Debug.Print("Length of bound Vector" + lengthOfBoundVector.ToString());
            }
        }

        public bool IsUp { get => isUp; }

        public SerialPortRoboController(string portName)
        {
            isUp = true;
            port = new SerialPort(portName, 9600, Parity.None, 8, StopBits.One);
            robotCoords = new Vector2d(0, 0);
            BoundCoords = new Vector2d(0, 0);
            calibrationConstant = 130;
            OpenPort();
            StretchMin();
            TurnHorizontalDefault();
        }

        public void MooveTo(Point point)
        {
            var direction = new Vector2d(point.X, point.Y);
            //Debug.Print(direction.ToString());
            int angle = -(int)Math.Round(Math.Atan2((direction.Y - robotCoords.Y), (direction.X - robotCoords.X)) * (180 / Math.PI));
            TurnHorizontal(direction);
            Stretch(direction);
        }

        public void ClosePort()
        {
            port.Close();
        }

        public void OpenPort()
        {
            port.Open();
        }

        public void ProcessCommand(Vector2d direction)
        {
            TurnHorizontal(direction);
            Stretch(direction);

        }

        public void TurnHorizontal(Vector2d direction)
        {
            if (robotCoords.IsNull())
                return;
            if (direction.X - robotCoords.X != 0)
            {
                int angle = 180 - Math.Abs((int)Math.Round(Math.Atan2((direction.Y - robotCoords.Y),
                    (direction.X - robotCoords.X)) * (180 / Math.PI)));
                string command = "d" + angle.ToString() + "n";//"d" + angle.ToString();
                port.Write(command);
                Debug.Print(command);
                //horizaontalAngleDebug.Text = angle.ToString();
            }
        }

        public void Stretch(Vector2d direction)
        {
            if (robotCoords.IsNull())
                return;
            if (boundCoords.IsNull())
                return;
            Vector2d vectorToPointer = direction - robotCoords - (direction - robotCoords).Normalize() * calibrationConstant;
            int angle = 20;
            /*
            Debug.Print("Vector to pointer: " + vectorToPointer.ToString());
            Debug.Print("Vector to pointer without calibration: " + (direction - robotCoords).ToString());
            */
            if ((direction - robotCoords).Magnitude() < ((direction - robotCoords).Normalize() * calibrationConstant).Magnitude())
            {
                angle = 20;
            }
            else
            {
                double lengthOfVectorToPoint = vectorToPointer.Magnitude();

                angle += (int)(70 * (lengthOfVectorToPoint / lengthOfBoundVector));
                if (angle > 90)
                {
                    angle = 90;
                }
            }
            string command = "r" + angle.ToString() + "n";
            port.Write(command);
            Debug.Print(command);
        }

        public void GetDown()
        {
            isUp = false;
            port.Write("l1");
            Debug.Print("l1");
        }

        public void GetUp()
        {
            isUp = true;
            port.Write("l0");
            Debug.Print("l0");
        }

        public void StretchMax()
        {
            port.Write("r90n");
            Debug.Print("r90n");
        }

        public void StretchMin()
        {
            port.Write("r20n");
            Debug.Print("r20n");
        }

        public void TurnHorizontalDefault()
        {
            string command = "d90n";
            port.Write(command);
        }
    }
}
