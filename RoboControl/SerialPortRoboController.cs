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
        private int liftValue;

        private int calibrationConstant;

        private bool isUp;
        private bool isOpen;

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
        public bool IsOpen { get => isOpen; set => isOpen = value; }

        public SerialPortRoboController(string portName)
        {
            isUp = true;
            isOpen = false;
            port = new SerialPort(portName, 9600, Parity.None, 8, StopBits.One);
            robotCoords = new Vector2d(0, 0);
            BoundCoords = new Vector2d(0, 0);
            calibrationConstant = 130;
            liftValue = 60;
            OpenPort();
            CloseGrab();
            StretchMin();
            TurnHorizontalDefault();
            GetUp();
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

        public void Lift(int delta)
        {
            if (delta > 0)
            {
                liftValue += 2;
                liftValue = Math.Clamp(liftValue, 50, 110);
            }
            else
            {
                liftValue -= 2;
                liftValue = Math.Clamp(liftValue, 50, 110);
            }
            string command = "l" + liftValue.ToString() + "n";
            Debug.Print(command);
            port.Write(command);
        }

        public void GetDown()
        {
            isUp = false;
            port.Write("l60");
            Debug.Print("l60");
        }

        public void GetUp()
        {
            isUp = true;
            port.Write("l100");
            Debug.Print("l100");
        }

        public void OpenGrab()
        {
            string command = "o";
            Debug.Print(command);
            port.Write(command);
            isOpen = true;
        }

        public void CloseGrab()
        {
            string command = "c";
            Debug.Print(command);
            port.Write(command);
            isOpen = false;
        }

        public void StretchMax()
        {
            port.Write("r90");
            Debug.Print("r90");
        }

        public void StretchMin()
        {
            port.Write("r20");
            Debug.Print("r20");
        }

        public void TurnHorizontalDefault()
        {
            string command = "d90";
            port.Write(command);
        }
    }
}
