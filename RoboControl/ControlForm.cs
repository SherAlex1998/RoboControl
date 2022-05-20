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

namespace RoboControl
{
    public partial class ControlForm : Form
    {
        private SerialPort6RoboController controller;

        private string portName;

        private double armLength = 14f;
        private double foreArmLength = 13.5f;

        Vector3d robotCoords;
        Vector3d targetPoint;
        public ControlForm(string port)
        {
            portName = port; 
            InitializeComponent();
            XRobotBox.Text = "0";
            YRobotBox.Text = "0";
            ZRobotBox.Text = "10";
            robotCoords = new Vector3d(Double.Parse(XRobotBox.Text), Double.Parse(YRobotBox.Text), Double.Parse(ZRobotBox.Text));
            controller = new SerialPort6RoboController(portName, foreArmLength, armLength, robotCoords);
        }

        private void Initialize_Click(object sender, EventArgs e)
        {
            robotCoords = new Vector3d(Double.Parse(XRobotBox.Text), Double.Parse(YRobotBox.Text), Double.Parse(ZRobotBox.Text));
            controller = new SerialPort6RoboController(portName, foreArmLength, armLength, robotCoords);
        }

        private void MooveButton_Click(object sender, EventArgs e)
        {
            targetPoint = new Vector3d(Double.Parse(XPointBox.Text), Double.Parse(YPointBox.Text), Double.Parse(ZPointBox.Text));
            controller.MooveTo(targetPoint);
            AAngleBox.Text = controller.A.ToString();
            BAngleBox.Text = controller.B.ToString();
            horAngleBox.Text = controller.H.ToString();
        }
    }
}
