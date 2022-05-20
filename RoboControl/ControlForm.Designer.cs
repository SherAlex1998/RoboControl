
namespace RoboControl
{
    partial class ControlForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.XPointBox = new System.Windows.Forms.TextBox();
            this.YPointBox = new System.Windows.Forms.TextBox();
            this.ZPointBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MooveButton = new System.Windows.Forms.Button();
            this.AAngleBox = new System.Windows.Forms.TextBox();
            this.BAngleBox = new System.Windows.Forms.TextBox();
            this.XRobotBox = new System.Windows.Forms.TextBox();
            this.YRobotBox = new System.Windows.Forms.TextBox();
            this.ZRobotBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Initialize = new System.Windows.Forms.Button();
            this.horAngleBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // XPointBox
            // 
            this.XPointBox.Location = new System.Drawing.Point(72, 52);
            this.XPointBox.Name = "XPointBox";
            this.XPointBox.Size = new System.Drawing.Size(100, 23);
            this.XPointBox.TabIndex = 0;
            // 
            // YPointBox
            // 
            this.YPointBox.Location = new System.Drawing.Point(72, 81);
            this.YPointBox.Name = "YPointBox";
            this.YPointBox.Size = new System.Drawing.Size(100, 23);
            this.YPointBox.TabIndex = 1;
            // 
            // ZPointBox
            // 
            this.ZPointBox.Location = new System.Drawing.Point(72, 111);
            this.ZPointBox.Name = "ZPointBox";
            this.ZPointBox.Size = new System.Drawing.Size(100, 23);
            this.ZPointBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Z";
            // 
            // MooveButton
            // 
            this.MooveButton.Location = new System.Drawing.Point(454, 81);
            this.MooveButton.Name = "MooveButton";
            this.MooveButton.Size = new System.Drawing.Size(100, 23);
            this.MooveButton.TabIndex = 6;
            this.MooveButton.Text = "Переместить";
            this.MooveButton.UseVisualStyleBackColor = true;
            this.MooveButton.Click += new System.EventHandler(this.MooveButton_Click);
            // 
            // AAngleBox
            // 
            this.AAngleBox.Location = new System.Drawing.Point(454, 51);
            this.AAngleBox.Name = "AAngleBox";
            this.AAngleBox.Size = new System.Drawing.Size(100, 23);
            this.AAngleBox.TabIndex = 7;
            // 
            // BAngleBox
            // 
            this.BAngleBox.Location = new System.Drawing.Point(560, 52);
            this.BAngleBox.Name = "BAngleBox";
            this.BAngleBox.Size = new System.Drawing.Size(100, 23);
            this.BAngleBox.TabIndex = 8;
            // 
            // XRobotBox
            // 
            this.XRobotBox.Location = new System.Drawing.Point(293, 51);
            this.XRobotBox.Name = "XRobotBox";
            this.XRobotBox.Size = new System.Drawing.Size(100, 23);
            this.XRobotBox.TabIndex = 9;
            // 
            // YRobotBox
            // 
            this.YRobotBox.Location = new System.Drawing.Point(293, 80);
            this.YRobotBox.Name = "YRobotBox";
            this.YRobotBox.Size = new System.Drawing.Size(100, 23);
            this.YRobotBox.TabIndex = 10;
            // 
            // ZRobotBox
            // 
            this.ZRobotBox.Location = new System.Drawing.Point(293, 110);
            this.ZRobotBox.Name = "ZRobotBox";
            this.ZRobotBox.Size = new System.Drawing.Size(100, 23);
            this.ZRobotBox.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(249, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(249, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Y";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(249, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Z";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(454, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Угол A";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(560, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "Угол B";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(289, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 15);
            this.label9.TabIndex = 17;
            this.label9.Text = "Координаты руки";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(66, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 15);
            this.label10.TabIndex = 18;
            this.label10.Text = "Точка назначения";
            // 
            // Initialize
            // 
            this.Initialize.Location = new System.Drawing.Point(28, 140);
            this.Initialize.Name = "Initialize";
            this.Initialize.Size = new System.Drawing.Size(365, 23);
            this.Initialize.TabIndex = 19;
            this.Initialize.Text = "Инициализировать";
            this.Initialize.UseVisualStyleBackColor = true;
            this.Initialize.Click += new System.EventHandler(this.Initialize_Click);
            // 
            // horAngleBox
            // 
            this.horAngleBox.Location = new System.Drawing.Point(666, 51);
            this.horAngleBox.Name = "horAngleBox";
            this.horAngleBox.Size = new System.Drawing.Size(100, 23);
            this.horAngleBox.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(666, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 15);
            this.label11.TabIndex = 21;
            this.label11.Text = "Горизонтальный угол";
            // 
            // ControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.horAngleBox);
            this.Controls.Add(this.Initialize);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ZRobotBox);
            this.Controls.Add(this.YRobotBox);
            this.Controls.Add(this.XRobotBox);
            this.Controls.Add(this.BAngleBox);
            this.Controls.Add(this.AAngleBox);
            this.Controls.Add(this.MooveButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ZPointBox);
            this.Controls.Add(this.YPointBox);
            this.Controls.Add(this.XPointBox);
            this.Name = "ControlForm";
            this.Text = "Нацеливание по координатам";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox XPointBox;
        private System.Windows.Forms.TextBox YPointBox;
        private System.Windows.Forms.TextBox ZPointBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button MooveButton;
        private System.Windows.Forms.TextBox AAngleBox;
        private System.Windows.Forms.TextBox BAngleBox;
        private System.Windows.Forms.TextBox XRobotBox;
        private System.Windows.Forms.TextBox YRobotBox;
        private System.Windows.Forms.TextBox ZRobotBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button Initialize;
        private System.Windows.Forms.TextBox horAngleBox;
        private System.Windows.Forms.Label label11;
    }
}