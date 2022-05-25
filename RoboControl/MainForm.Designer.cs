
using System.Drawing;

namespace RoboControl
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.RobotRelatedToolStrip = new System.Windows.Forms.ToolStrip();
            this.comPortsToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.serialPortNamesComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.horizaontalAngleDebug = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.calibrationButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator15 = new System.Windows.Forms.ToolStripSeparator();
            this.takeItems = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator16 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.manipulatorComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.mainVideoBox = new System.Windows.Forms.PictureBox();
            this.videoBoxPanel = new System.Windows.Forms.Panel();
            this.videoBoxToolStrip = new System.Windows.Forms.ToolStrip();
            this.coordsText = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.resolutionText = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.robotCoordsText = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.boundCoordsText = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.DetectionModeButton = new System.Windows.Forms.ToolStripButton();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cameraRelatedToolStrip = new System.Windows.Forms.ToolStrip();
            this.cameraToolStripLable = new System.Windows.Forms.ToolStripLabel();
            this.camerasComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.captureButton = new System.Windows.Forms.ToolStripButton();
            this.pauseButton = new System.Windows.Forms.ToolStripButton();
            this.stopButton = new System.Windows.Forms.ToolStripButton();
            this.makeScreenShotButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.TestModelButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.confidenceTrashHoldLabel = new System.Windows.Forms.ToolStripLabel();
            this.confidenceTrashHoldTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.RobotRelatedToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainVideoBox)).BeginInit();
            this.videoBoxPanel.SuspendLayout();
            this.videoBoxToolStrip.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.cameraRelatedToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // RobotRelatedToolStrip
            // 
            this.RobotRelatedToolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(172)))), ((int)(((byte)(176)))));
            this.RobotRelatedToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comPortsToolStripLabel,
            this.serialPortNamesComboBox,
            this.toolStripSeparator2,
            this.horizaontalAngleDebug,
            this.toolStripSeparator8,
            this.calibrationButton,
            this.toolStripSeparator15,
            this.takeItems,
            this.toolStripButton1,
            this.toolStripSeparator16,
            this.toolStripLabel1,
            this.manipulatorComboBox});
            this.RobotRelatedToolStrip.Location = new System.Drawing.Point(0, 0);
            this.RobotRelatedToolStrip.Name = "RobotRelatedToolStrip";
            this.RobotRelatedToolStrip.Size = new System.Drawing.Size(1222, 25);
            this.RobotRelatedToolStrip.TabIndex = 1;
            this.RobotRelatedToolStrip.Text = "toolStrip1";
            // 
            // comPortsToolStripLabel
            // 
            this.comPortsToolStripLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(64)))), ((int)(((byte)(77)))));
            this.comPortsToolStripLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(64)))), ((int)(((byte)(77)))));
            this.comPortsToolStripLabel.Name = "comPortsToolStripLabel";
            this.comPortsToolStripLabel.Size = new System.Drawing.Size(109, 22);
            this.comPortsToolStripLabel.Text = "Доступные порты:";
            // 
            // serialPortNamesComboBox
            // 
            this.serialPortNamesComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(221)))), ((int)(((byte)(223)))));
            this.serialPortNamesComboBox.Name = "serialPortNamesComboBox";
            this.serialPortNamesComboBox.Size = new System.Drawing.Size(121, 25);
            this.serialPortNamesComboBox.DropDown += new System.EventHandler(this.serialPortNamesComboBox_DropDown);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // horizaontalAngleDebug
            // 
            this.horizaontalAngleDebug.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(221)))), ((int)(((byte)(223)))));
            this.horizaontalAngleDebug.Name = "horizaontalAngleDebug";
            this.horizaontalAngleDebug.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // calibrationButton
            // 
            this.calibrationButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.calibrationButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(64)))), ((int)(((byte)(77)))));
            this.calibrationButton.Image = ((System.Drawing.Image)(resources.GetObject("calibrationButton.Image")));
            this.calibrationButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.calibrationButton.Name = "calibrationButton";
            this.calibrationButton.Size = new System.Drawing.Size(118, 22);
            this.calibrationButton.Text = "&Начать калибровку";
            this.calibrationButton.Click += new System.EventHandler(this.calibrationButton_Click);
            // 
            // toolStripSeparator15
            // 
            this.toolStripSeparator15.Name = "toolStripSeparator15";
            this.toolStripSeparator15.Size = new System.Drawing.Size(6, 25);
            // 
            // takeItems
            // 
            this.takeItems.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.takeItems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(64)))), ((int)(((byte)(77)))));
            this.takeItems.Image = ((System.Drawing.Image)(resources.GetObject("takeItems.Image")));
            this.takeItems.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.takeItems.Name = "takeItems";
            this.takeItems.Size = new System.Drawing.Size(129, 22);
            this.takeItems.Text = "Подобрать предметы";
            this.takeItems.Click += new System.EventHandler(this.TakeItems_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(64)))), ((int)(((byte)(77)))));
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(161, 22);
            this.toolStripButton1.Text = "Управлять по координатам";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator16
            // 
            this.toolStripSeparator16.Name = "toolStripSeparator16";
            this.toolStripSeparator16.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(64)))), ((int)(((byte)(77)))));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(131, 22);
            this.toolStripLabel1.Text = "Выбрать манипулятор";
            // 
            // manipulatorComboBox
            // 
            this.manipulatorComboBox.Items.AddRange(new object[] {
            "4 оси",
            "6 осей"});
            this.manipulatorComboBox.Name = "manipulatorComboBox";
            this.manipulatorComboBox.Size = new System.Drawing.Size(121, 25);
            // 
            // mainVideoBox
            // 
            this.mainVideoBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(64)))), ((int)(((byte)(77)))));
            this.mainVideoBox.Location = new System.Drawing.Point(4, 4);
            this.mainVideoBox.Name = "mainVideoBox";
            this.mainVideoBox.Size = new System.Drawing.Size(640, 480);
            this.mainVideoBox.TabIndex = 2;
            this.mainVideoBox.TabStop = false;
            this.mainVideoBox.DoubleClick += new System.EventHandler(this.mainVideoBox_DoubleClick);
            this.mainVideoBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mainVideoBox_MouseClick);
            this.mainVideoBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // videoBoxPanel
            // 
            this.videoBoxPanel.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.videoBoxPanel.Controls.Add(this.videoBoxToolStrip);
            this.videoBoxPanel.Controls.Add(this.mainVideoBox);
            this.videoBoxPanel.Location = new System.Drawing.Point(12, 81);
            this.videoBoxPanel.Name = "videoBoxPanel";
            this.videoBoxPanel.Padding = new System.Windows.Forms.Padding(1);
            this.videoBoxPanel.Size = new System.Drawing.Size(649, 514);
            this.videoBoxPanel.TabIndex = 3;
            // 
            // videoBoxToolStrip
            // 
            this.videoBoxToolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(172)))), ((int)(((byte)(176)))));
            this.videoBoxToolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.videoBoxToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.coordsText,
            this.toolStripSeparator4,
            this.resolutionText,
            this.toolStripSeparator5,
            this.robotCoordsText,
            this.toolStripSeparator6,
            this.boundCoordsText,
            this.toolStripSeparator7,
            this.DetectionModeButton});
            this.videoBoxToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.videoBoxToolStrip.Location = new System.Drawing.Point(1, 488);
            this.videoBoxToolStrip.Name = "videoBoxToolStrip";
            this.videoBoxToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.videoBoxToolStrip.Size = new System.Drawing.Size(647, 25);
            this.videoBoxToolStrip.TabIndex = 3;
            this.videoBoxToolStrip.Text = "toolStrip2";
            // 
            // coordsText
            // 
            this.coordsText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(221)))), ((int)(((byte)(223)))));
            this.coordsText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(64)))), ((int)(((byte)(77)))));
            this.coordsText.Name = "coordsText";
            this.coordsText.ReadOnly = true;
            this.coordsText.Size = new System.Drawing.Size(100, 25);
            this.coordsText.ToolTipText = "Координаты указателя относительно захватываемой плоскости";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // resolutionText
            // 
            this.resolutionText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(221)))), ((int)(((byte)(223)))));
            this.resolutionText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(64)))), ((int)(((byte)(77)))));
            this.resolutionText.Name = "resolutionText";
            this.resolutionText.ReadOnly = true;
            this.resolutionText.Size = new System.Drawing.Size(100, 25);
            this.resolutionText.ToolTipText = "Разрешение видео захвата.";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // robotCoordsText
            // 
            this.robotCoordsText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(221)))), ((int)(((byte)(223)))));
            this.robotCoordsText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(64)))), ((int)(((byte)(77)))));
            this.robotCoordsText.Name = "robotCoordsText";
            this.robotCoordsText.Size = new System.Drawing.Size(100, 25);
            this.robotCoordsText.ToolTipText = "Координаты робота относительно видео захватываемой области.";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // boundCoordsText
            // 
            this.boundCoordsText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(221)))), ((int)(((byte)(223)))));
            this.boundCoordsText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(64)))), ((int)(((byte)(77)))));
            this.boundCoordsText.Name = "boundCoordsText";
            this.boundCoordsText.ReadOnly = true;
            this.boundCoordsText.Size = new System.Drawing.Size(100, 25);
            this.boundCoordsText.ToolTipText = "Координаты границы действия робота.";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // DetectionModeButton
            // 
            this.DetectionModeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.DetectionModeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(64)))), ((int)(((byte)(77)))));
            this.DetectionModeButton.Image = ((System.Drawing.Image)(resources.GetObject("DetectionModeButton.Image")));
            this.DetectionModeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DetectionModeButton.Name = "DetectionModeButton";
            this.DetectionModeButton.Size = new System.Drawing.Size(102, 22);
            this.DetectionModeButton.Text = "&Режим детекции";
            this.DetectionModeButton.ToolTipText = "Активировать режим детекции";
            this.DetectionModeButton.Click += new System.EventHandler(this.DetectionModeButton_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1222, 24);
            this.menuStrip2.TabIndex = 4;
            this.menuStrip2.Text = "menuStrip2";
            this.menuStrip2.Visible = false;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator10,
            this.printToolStripMenuItem,
            this.printPreviewToolStripMenuItem,
            this.toolStripSeparator11,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.newToolStripMenuItem.Text = "&New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(143, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(143, 6);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.printToolStripMenuItem.Text = "&Print";
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printPreviewToolStripMenuItem.Image")));
            this.printPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.printPreviewToolStripMenuItem.Text = "Print Pre&view";
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(143, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator12,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator13,
            this.selectAllToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.undoToolStripMenuItem.Text = "&Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.redoToolStripMenuItem.Text = "&Redo";
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(141, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
            this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.cutToolStripMenuItem.Text = "Cu&t";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.copyToolStripMenuItem.Text = "&Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
            this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.pasteToolStripMenuItem.Text = "&Paste";
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(141, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.selectAllToolStripMenuItem.Text = "Select &All";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customizeToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // customizeToolStripMenuItem
            // 
            this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            this.customizeToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.customizeToolStripMenuItem.Text = "&Customize";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator14,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.contentsToolStripMenuItem.Text = "&Contents";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator14
            // 
            this.toolStripSeparator14.Name = "toolStripSeparator14";
            this.toolStripSeparator14.Size = new System.Drawing.Size(119, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // cameraRelatedToolStrip
            // 
            this.cameraRelatedToolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(172)))), ((int)(((byte)(176)))));
            this.cameraRelatedToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cameraToolStripLable,
            this.camerasComboBox,
            this.toolStripSeparator1,
            this.captureButton,
            this.pauseButton,
            this.stopButton,
            this.makeScreenShotButton,
            this.toolStripSeparator3,
            this.TestModelButton,
            this.toolStripSeparator9,
            this.confidenceTrashHoldLabel,
            this.confidenceTrashHoldTextBox});
            this.cameraRelatedToolStrip.Location = new System.Drawing.Point(0, 25);
            this.cameraRelatedToolStrip.Name = "cameraRelatedToolStrip";
            this.cameraRelatedToolStrip.Size = new System.Drawing.Size(1222, 25);
            this.cameraRelatedToolStrip.TabIndex = 5;
            this.cameraRelatedToolStrip.Text = "toolStrip1";
            // 
            // cameraToolStripLable
            // 
            this.cameraToolStripLable.AutoSize = false;
            this.cameraToolStripLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(64)))), ((int)(((byte)(77)))));
            this.cameraToolStripLable.Name = "cameraToolStripLable";
            this.cameraToolStripLable.Size = new System.Drawing.Size(109, 22);
            this.cameraToolStripLable.Text = "Камера:";
            this.cameraToolStripLable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // camerasComboBox
            // 
            this.camerasComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(221)))), ((int)(((byte)(223)))));
            this.camerasComboBox.Name = "camerasComboBox";
            this.camerasComboBox.Size = new System.Drawing.Size(121, 25);
            this.camerasComboBox.DropDown += new System.EventHandler(this.toolStripComboBox1_DropDown);
            this.camerasComboBox.SelectedIndexChanged += new System.EventHandler(this.CamerasComboBox_SelectedIndexChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // captureButton
            // 
            this.captureButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.captureButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(64)))), ((int)(((byte)(77)))));
            this.captureButton.Image = ((System.Drawing.Image)(resources.GetObject("captureButton.Image")));
            this.captureButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.captureButton.Name = "captureButton";
            this.captureButton.Size = new System.Drawing.Size(47, 22);
            this.captureButton.Text = "&Захват";
            this.captureButton.Click += new System.EventHandler(this.CaptureButton_Click);
            // 
            // pauseButton
            // 
            this.pauseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.pauseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(64)))), ((int)(((byte)(77)))));
            this.pauseButton.Image = ((System.Drawing.Image)(resources.GetObject("pauseButton.Image")));
            this.pauseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(43, 22);
            this.pauseButton.Text = "&Пауза";
            this.pauseButton.Click += new System.EventHandler(this.PauseButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.stopButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(64)))), ((int)(((byte)(77)))));
            this.stopButton.Image = ((System.Drawing.Image)(resources.GetObject("stopButton.Image")));
            this.stopButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(38, 22);
            this.stopButton.Text = "&Стоп";
            this.stopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // makeScreenShotButton
            // 
            this.makeScreenShotButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.makeScreenShotButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(64)))), ((int)(((byte)(77)))));
            this.makeScreenShotButton.Image = ((System.Drawing.Image)(resources.GetObject("makeScreenShotButton.Image")));
            this.makeScreenShotButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.makeScreenShotButton.Name = "makeScreenShotButton";
            this.makeScreenShotButton.Size = new System.Drawing.Size(114, 22);
            this.makeScreenShotButton.Text = "&Сделать скриншот";
            this.makeScreenShotButton.Click += new System.EventHandler(this.ScreenShotButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripSeparator3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // TestModelButton
            // 
            this.TestModelButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TestModelButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(64)))), ((int)(((byte)(77)))));
            this.TestModelButton.Image = ((System.Drawing.Image)(resources.GetObject("TestModelButton.Image")));
            this.TestModelButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TestModelButton.Name = "TestModelButton";
            this.TestModelButton.Size = new System.Drawing.Size(151, 22);
            this.TestModelButton.Text = "&Протестировать детектор";
            this.TestModelButton.Click += new System.EventHandler(this.TestModelButton_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 25);
            // 
            // confidenceTrashHoldLabel
            // 
            this.confidenceTrashHoldLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(64)))), ((int)(((byte)(77)))));
            this.confidenceTrashHoldLabel.Name = "confidenceTrashHoldLabel";
            this.confidenceTrashHoldLabel.Size = new System.Drawing.Size(126, 22);
            this.confidenceTrashHoldLabel.Text = "Уровень уверенности";
            // 
            // confidenceTrashHoldTextBox
            // 
            this.confidenceTrashHoldTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(221)))), ((int)(((byte)(223)))));
            this.confidenceTrashHoldTextBox.Name = "confidenceTrashHoldTextBox";
            this.confidenceTrashHoldTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(221)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(1222, 607);
            this.Controls.Add(this.cameraRelatedToolStrip);
            this.Controls.Add(this.videoBoxPanel);
            this.Controls.Add(this.RobotRelatedToolStrip);
            this.Controls.Add(this.menuStrip2);
            this.Name = "MainForm";
            this.Text = "RoboControl";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.RobotRelatedToolStrip.ResumeLayout(false);
            this.RobotRelatedToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainVideoBox)).EndInit();
            this.videoBoxPanel.ResumeLayout(false);
            this.videoBoxPanel.PerformLayout();
            this.videoBoxToolStrip.ResumeLayout(false);
            this.videoBoxToolStrip.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.cameraRelatedToolStrip.ResumeLayout(false);
            this.cameraRelatedToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip RobotRelatedToolStrip;
        private System.Windows.Forms.PictureBox mainVideoBox;
        private System.Windows.Forms.ToolStripLabel comPortsToolStripLabel;
        private System.Windows.Forms.ToolStripComboBox serialPortNamesComboBox;
        private System.Windows.Forms.Panel videoBoxPanel;
        private System.Windows.Forms.ToolStrip videoBoxToolStrip;
        private System.Windows.Forms.ToolStripTextBox coordsText;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripTextBox resolutionText;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripTextBox robotCoordsText;
        private System.Windows.Forms.ToolStripTextBox horizaontalAngleDebug;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripTextBox boundCoordsText;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator14;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStrip cameraRelatedToolStrip;
        private System.Windows.Forms.ToolStripLabel cameraToolStripLable;
        private System.Windows.Forms.ToolStripComboBox camerasComboBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton captureButton;
        private System.Windows.Forms.ToolStripButton pauseButton;
        private System.Windows.Forms.ToolStripButton stopButton;
        private System.Windows.Forms.ToolStripButton makeScreenShotButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton TestModelButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripButton DetectionModeButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton calibrationButton;
        private System.Windows.Forms.ToolStripLabel confidenceTrashHoldLabel;
        private System.Windows.Forms.ToolStripTextBox confidenceTrashHoldTextBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator15;
        private System.Windows.Forms.ToolStripButton takeItems;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator16;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox manipulatorComboBox;
    }
}

