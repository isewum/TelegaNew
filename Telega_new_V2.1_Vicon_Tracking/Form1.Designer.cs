namespace Telega_new_V2._1_Vicon_Tracking
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.status = new System.Windows.Forms.TextBox();
            this.refreshButton = new System.Windows.Forms.Button();
            this.connectButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.baudRate = new System.Windows.Forms.ComboBox();
            this.portName = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.driveButton = new System.Windows.Forms.Button();
            this.trackButton = new System.Windows.Forms.Button();
            this.logBox = new System.Windows.Forms.TextBox();
            this.speedValue1 = new System.Windows.Forms.TextBox();
            this.speedValue2 = new System.Windows.Forms.TextBox();
            this.speedValue3 = new System.Windows.Forms.TextBox();
            this.speedValue4 = new System.Windows.Forms.TextBox();
            this.angleManual = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.forwardButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.modeRadioButton2 = new System.Windows.Forms.RadioButton();
            this.modeRadioButton1 = new System.Windows.Forms.RadioButton();
            this.yTargetBox = new System.Windows.Forms.TextBox();
            this.xTargetBox = new System.Windows.Forms.TextBox();
            this.angleAuto = new System.Windows.Forms.TextBox();
            this.speedValueMain = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.backwardButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.status);
            this.groupBox1.Controls.Add(this.refreshButton);
            this.groupBox1.Controls.Add(this.connectButton);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.baudRate);
            this.groupBox1.Controls.Add(this.portName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 106);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SerialPort";
            // 
            // status
            // 
            this.status.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.status.Enabled = false;
            this.status.ForeColor = System.Drawing.SystemColors.InfoText;
            this.status.Location = new System.Drawing.Point(63, 74);
            this.status.MaxLength = 16;
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Size = new System.Drawing.Size(85, 20);
            this.status.TabIndex = 6;
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(154, 44);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(73, 23);
            this.refreshButton.TabIndex = 5;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(154, 73);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(73, 23);
            this.connectButton.TabIndex = 4;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Baud";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Port";
            // 
            // baudRate
            // 
            this.baudRate.FormattingEnabled = true;
            this.baudRate.Items.AddRange(new object[] {
            "9600",
            "115200"});
            this.baudRate.Location = new System.Drawing.Point(63, 47);
            this.baudRate.Name = "baudRate";
            this.baudRate.Size = new System.Drawing.Size(75, 21);
            this.baudRate.TabIndex = 1;
            // 
            // portName
            // 
            this.portName.FormattingEnabled = true;
            this.portName.Location = new System.Drawing.Point(63, 19);
            this.portName.Name = "portName";
            this.portName.Size = new System.Drawing.Size(75, 21);
            this.portName.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.resetButton);
            this.groupBox3.Controls.Add(this.driveButton);
            this.groupBox3.Controls.Add(this.trackButton);
            this.groupBox3.Controls.Add(this.logBox);
            this.groupBox3.Location = new System.Drawing.Point(260, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(253, 278);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Motion Capture";
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(172, 243);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 3;
            this.resetButton.Text = "Reset all";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // driveButton
            // 
            this.driveButton.Location = new System.Drawing.Point(89, 243);
            this.driveButton.Name = "driveButton";
            this.driveButton.Size = new System.Drawing.Size(75, 23);
            this.driveButton.TabIndex = 2;
            this.driveButton.Text = "Drive";
            this.driveButton.UseVisualStyleBackColor = true;
            this.driveButton.Click += new System.EventHandler(this.DriveButton_Click);
            // 
            // trackButton
            // 
            this.trackButton.Location = new System.Drawing.Point(6, 243);
            this.trackButton.Name = "trackButton";
            this.trackButton.Size = new System.Drawing.Size(75, 23);
            this.trackButton.TabIndex = 1;
            this.trackButton.Text = "Track";
            this.trackButton.UseVisualStyleBackColor = true;
            this.trackButton.Click += new System.EventHandler(this.TrackButton_Click);
            // 
            // logBox
            // 
            this.logBox.BackColor = System.Drawing.SystemColors.Window;
            this.logBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logBox.Location = new System.Drawing.Point(6, 19);
            this.logBox.Multiline = true;
            this.logBox.Name = "logBox";
            this.logBox.ReadOnly = true;
            this.logBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logBox.Size = new System.Drawing.Size(241, 216);
            this.logBox.TabIndex = 0;
            // 
            // speedValue1
            // 
            this.speedValue1.Location = new System.Drawing.Point(59, 6);
            this.speedValue1.MaxLength = 3;
            this.speedValue1.Name = "speedValue1";
            this.speedValue1.Size = new System.Drawing.Size(75, 20);
            this.speedValue1.TabIndex = 0;
            // 
            // speedValue2
            // 
            this.speedValue2.Location = new System.Drawing.Point(59, 32);
            this.speedValue2.MaxLength = 3;
            this.speedValue2.Name = "speedValue2";
            this.speedValue2.Size = new System.Drawing.Size(75, 20);
            this.speedValue2.TabIndex = 0;
            // 
            // speedValue3
            // 
            this.speedValue3.Location = new System.Drawing.Point(59, 58);
            this.speedValue3.MaxLength = 3;
            this.speedValue3.Name = "speedValue3";
            this.speedValue3.Size = new System.Drawing.Size(75, 20);
            this.speedValue3.TabIndex = 0;
            // 
            // speedValue4
            // 
            this.speedValue4.Location = new System.Drawing.Point(59, 84);
            this.speedValue4.MaxLength = 3;
            this.speedValue4.Name = "speedValue4";
            this.speedValue4.Size = new System.Drawing.Size(75, 20);
            this.speedValue4.TabIndex = 0;
            // 
            // angleManual
            // 
            this.angleManual.Location = new System.Drawing.Point(59, 111);
            this.angleManual.MaxLength = 3;
            this.angleManual.Name = "angleManual";
            this.angleManual.Size = new System.Drawing.Size(75, 20);
            this.angleManual.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "#1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "#2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "#3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "#4";
            // 
            // forwardButton
            // 
            this.forwardButton.Location = new System.Drawing.Point(150, 51);
            this.forwardButton.Name = "forwardButton";
            this.forwardButton.Size = new System.Drawing.Size(73, 23);
            this.forwardButton.TabIndex = 3;
            this.forwardButton.Text = "Forward";
            this.forwardButton.UseVisualStyleBackColor = true;
            this.forwardButton.Click += new System.EventHandler(this.ForwardButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(150, 109);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(73, 23);
            this.stopButton.TabIndex = 3;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Angle";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 124);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(242, 167);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.modeRadioButton2);
            this.tabPage1.Controls.Add(this.modeRadioButton1);
            this.tabPage1.Controls.Add(this.yTargetBox);
            this.tabPage1.Controls.Add(this.xTargetBox);
            this.tabPage1.Controls.Add(this.angleAuto);
            this.tabPage1.Controls.Add(this.speedValueMain);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(234, 141);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Auto";
            // 
            // modeRadioButton2
            // 
            this.modeRadioButton2.AutoSize = true;
            this.modeRadioButton2.Location = new System.Drawing.Point(150, 74);
            this.modeRadioButton2.Name = "modeRadioButton2";
            this.modeRadioButton2.Size = new System.Drawing.Size(61, 17);
            this.modeRadioButton2.TabIndex = 5;
            this.modeRadioButton2.TabStop = true;
            this.modeRadioButton2.Text = "Mode 2";
            this.modeRadioButton2.UseVisualStyleBackColor = true;
            // 
            // modeRadioButton1
            // 
            this.modeRadioButton1.AutoSize = true;
            this.modeRadioButton1.Location = new System.Drawing.Point(150, 51);
            this.modeRadioButton1.Name = "modeRadioButton1";
            this.modeRadioButton1.Size = new System.Drawing.Size(61, 17);
            this.modeRadioButton1.TabIndex = 5;
            this.modeRadioButton1.TabStop = true;
            this.modeRadioButton1.Text = "Mode 1";
            this.modeRadioButton1.UseVisualStyleBackColor = true;
            // 
            // yTargetBox
            // 
            this.yTargetBox.Location = new System.Drawing.Point(59, 100);
            this.yTargetBox.MaxLength = 3;
            this.yTargetBox.Name = "yTargetBox";
            this.yTargetBox.Size = new System.Drawing.Size(75, 20);
            this.yTargetBox.TabIndex = 4;
            // 
            // xTargetBox
            // 
            this.xTargetBox.Location = new System.Drawing.Point(59, 74);
            this.xTargetBox.MaxLength = 3;
            this.xTargetBox.Name = "xTargetBox";
            this.xTargetBox.Size = new System.Drawing.Size(75, 20);
            this.xTargetBox.TabIndex = 4;
            // 
            // angleAuto
            // 
            this.angleAuto.Location = new System.Drawing.Point(59, 48);
            this.angleAuto.MaxLength = 3;
            this.angleAuto.Name = "angleAuto";
            this.angleAuto.Size = new System.Drawing.Size(75, 20);
            this.angleAuto.TabIndex = 4;
            // 
            // speedValueMain
            // 
            this.speedValueMain.Location = new System.Drawing.Point(59, 22);
            this.speedValueMain.MaxLength = 3;
            this.speedValueMain.Name = "speedValueMain";
            this.speedValueMain.Size = new System.Drawing.Size(75, 20);
            this.speedValueMain.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 103);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Target Y";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Target X";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Angle";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Speed";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.backwardButton);
            this.tabPage2.Controls.Add(this.speedValue1);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.angleManual);
            this.tabPage2.Controls.Add(this.stopButton);
            this.tabPage2.Controls.Add(this.speedValue4);
            this.tabPage2.Controls.Add(this.forwardButton);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.speedValue3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.speedValue2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(234, 141);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Manual";
            // 
            // backwardButton
            // 
            this.backwardButton.Location = new System.Drawing.Point(150, 80);
            this.backwardButton.Name = "backwardButton";
            this.backwardButton.Size = new System.Drawing.Size(73, 23);
            this.backwardButton.TabIndex = 5;
            this.backwardButton.Text = "Backward";
            this.backwardButton.UseVisualStyleBackColor = true;
            this.backwardButton.Click += new System.EventHandler(this.BackwardButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 303);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Telega New V3.0 [Vicon Tracking]";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox baudRate;
        private System.Windows.Forms.ComboBox portName;
        private System.Windows.Forms.TextBox status;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox logBox;
        private System.Windows.Forms.Button trackButton;
        private System.Windows.Forms.Button driveButton;
        private System.Windows.Forms.TextBox speedValue1;
        private System.Windows.Forms.TextBox speedValue2;
        private System.Windows.Forms.TextBox speedValue3;
        private System.Windows.Forms.TextBox speedValue4;
        private System.Windows.Forms.TextBox angleManual;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button forwardButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button backwardButton;
        private System.Windows.Forms.TextBox speedValueMain;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox angleAuto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox yTargetBox;
        private System.Windows.Forms.TextBox xTargetBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.RadioButton modeRadioButton2;
        private System.Windows.Forms.RadioButton modeRadioButton1;
    }
}

