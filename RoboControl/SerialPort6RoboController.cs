using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vector;

namespace RoboControl
{
    class SerialPort6RoboController
    {
        private SerialPort port;
        private double Z = 10;
        
        private double a;
        private double c;

        public double A;
        public double B;
        public double H;

        Vector3d currentPoint;
        Vector3d robotCoords;

        private int brushAngle;
        private bool isOpen;

        public bool IsOpen { get => isOpen; set => isOpen = value; }

        public SerialPort6RoboController(string portName, double armLength, double forearmLength)
        {
            if (portName != null)
                port = new SerialPort(portName, 9600, Parity.None, 8, StopBits.One);
            a = armLength;
            c = forearmLength;
            robotCoords = new Vector3d(0, 0, 0);
            port?.Open();
            brushAngle = 90;
        }

        public SerialPort6RoboController(string portName, double armLength, double forearmLength, Vector3d robotPoint)
        {
            if(portName != null)
                port = new SerialPort(portName, 9600, Parity.None, 8, StopBits.One);
            a = armLength;
            c = forearmLength;
            robotCoords = robotPoint;
            port?.Open();
        }

        ~SerialPort6RoboController()
        {
            port?.Close();
        }

        public void SetScaleFactor(double coeff)
        {
            a *= coeff;
            c *= coeff;
            Z *= coeff;
            robotCoords.Z *= coeff;
            Debug.Print("robot coords: " + robotCoords.ToString());
        }

        public void SetRobotCoords(Vector2d point)
        {
            robotCoords = new Vector3d(point.X, point.Y, Z);
        }

        private void MooveVertical(Vector3d point)
        {
            double Y = point.Z;
            double X = new Vector2d(point.X - robotCoords.X, point.Y - robotCoords.Y).Magnitude();
            Debug.Print(X.ToString());
            Debug.Print(Y.ToString());
            Vector2d pointVector = new Vector2d(X, Y);
            double b = pointVector.Magnitude();
            //double atan = Math.Atan((Y - robotCoords.Y) / (X - robotCoords.X)) * 57.3f;
            double atan = Math.Atan((Y) / (X)) * 57.3f;
            if (a + c < b)
            {
                Debug.Print("Не дотянуться!");
                A = atan;
                B = 0;
            }
            else
            {
                A = ((b * b) + (c * c) - (a * a)) / (2 * b * c);
                A = Math.Acos(A) * 57.3f;
                A = atan + A;
                B = (Math.PI - Math.Acos((Math.Pow(a, 2) + Math.Pow(c, 2) - Math.Pow(b, 2)) / (2 * a * c))) * 57.3f;
            }

            A = Math.Clamp(A, 0, 180);
            B = Math.Clamp(B, 0, 180);
            port?.Write("r" + ((int)A).ToString());
            port?.Write("l" + ((int)B).ToString());
        }

        public void MooveHorizontal(Vector3d point)
        {
            if (robotCoords.IsNull())
                return;
            if (point.X - robotCoords.X != 0)
            {
                int angle = 180 - Math.Abs((int)Math.Round(Math.Atan2((point.Y - robotCoords.Y),
                    (point.X - robotCoords.X)) * (180 / Math.PI)));
                string command = "d" + angle.ToString();
                //"d" + angle.ToString();
                port.Write(command);
                //Debug.Print(command);
                //horizaontalAngleDebug.Text = angle.ToString();
            }
        }

        public void Lift(int delta)
        {
            if (delta > 0)
                Z += 1;
            else
                Z -= 1;
            brushAngle = 90 - (int)Z - 100;
            Debug.Print("Z = " + Z.ToString());
            MooveVertical(new Vector3d(currentPoint.X, currentPoint.Y, Z));
            port.Write("b" + brushAngle.ToString());
        }

        public void OpenGrab()
        {
            port.Write("o");
            isOpen = true;
        }

        public void CloseGrab()
        {
            port.Write("c");
            isOpen = false;
        }

        public void MooveTo(Vector3d point)
        {
            currentPoint = point;
            MooveVertical(point);
            MooveHorizontal(point);
        }

        public void MooveTo(Vector2d point)
        {
            currentPoint = new Vector3d(point.X, point.Y, Z);
            MooveVertical(new Vector3d(point.X, point.Y, Z));
            MooveHorizontal(new Vector3d(point.X, point.Y, Z));
        }
    }
}
