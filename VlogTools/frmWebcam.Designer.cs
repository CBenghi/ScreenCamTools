namespace ScreenCast
{
    partial class frmWebcam
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
            this.components = new System.ComponentModel.Container();
            this.pictureBoxDisplay = new System.Windows.Forms.PictureBox();
            this.comboBoxCameras = new System.Windows.Forms.ComboBox();
            this.btnConfig = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.PanelCommands = new System.Windows.Forms.TableLayoutPanel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCaptureFolder = new System.Windows.Forms.TextBox();
            this.nudSecondsGap = new System.Windows.Forms.NumericUpDown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cmdFixVideo = new System.Windows.Forms.Button();
            this.lblticks = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisplay)).BeginInit();
            this.PanelCommands.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSecondsGap)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxDisplay
            // 
            this.pictureBoxDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxDisplay.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxDisplay.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxDisplay.Name = "pictureBoxDisplay";
            this.pictureBoxDisplay.Size = new System.Drawing.Size(853, 591);
            this.pictureBoxDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDisplay.TabIndex = 13;
            this.pictureBoxDisplay.TabStop = false;
            this.pictureBoxDisplay.DoubleClick += new System.EventHandler(this.pictureBoxDisplay_DoubleClick);
            this.pictureBoxDisplay.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Dragging_MouseDown);
            this.pictureBoxDisplay.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Dragging_MouseMove);
            // 
            // comboBoxCameras
            // 
            this.comboBoxCameras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxCameras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCameras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxCameras.FormattingEnabled = true;
            this.comboBoxCameras.Location = new System.Drawing.Point(430, 5);
            this.comboBoxCameras.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxCameras.Name = "comboBoxCameras";
            this.comboBoxCameras.Size = new System.Drawing.Size(205, 24);
            this.comboBoxCameras.TabIndex = 12;
            // 
            // btnConfig
            // 
            this.btnConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfig.Location = new System.Drawing.Point(430, 40);
            this.btnConfig.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(205, 28);
            this.btnConfig.TabIndex = 10;
            this.btnConfig.Text = "Configuration";
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Location = new System.Drawing.Point(217, 4);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(205, 28);
            this.btnStop.TabIndex = 9;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Location = new System.Drawing.Point(4, 4);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(205, 28);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // PanelCommands
            // 
            this.PanelCommands.ColumnCount = 4;
            this.PanelCommands.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.PanelCommands.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.PanelCommands.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.PanelCommands.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.99813F));
            this.PanelCommands.Controls.Add(this.button3, 0, 2);
            this.PanelCommands.Controls.Add(this.button2, 0, 1);
            this.PanelCommands.Controls.Add(this.btnStart, 0, 0);
            this.PanelCommands.Controls.Add(this.btnStop, 1, 0);
            this.PanelCommands.Controls.Add(this.btnConfig, 2, 1);
            this.PanelCommands.Controls.Add(this.comboBoxCameras, 2, 0);
            this.PanelCommands.Controls.Add(this.button1, 0, 1);
            this.PanelCommands.Controls.Add(this.txtCaptureFolder, 1, 2);
            this.PanelCommands.Controls.Add(this.nudSecondsGap, 2, 2);
            this.PanelCommands.Controls.Add(this.cmdFixVideo, 3, 1);
            this.PanelCommands.Controls.Add(this.lblticks, 3, 2);
            this.PanelCommands.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelCommands.Location = new System.Drawing.Point(0, 485);
            this.PanelCommands.Margin = new System.Windows.Forms.Padding(4);
            this.PanelCommands.Name = "PanelCommands";
            this.PanelCommands.RowCount = 3;
            this.PanelCommands.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.PanelCommands.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.PanelCommands.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PanelCommands.Size = new System.Drawing.Size(853, 106);
            this.PanelCommands.TabIndex = 15;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(4, 76);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(205, 26);
            this.button3.TabIndex = 15;
            this.button3.Text = "Capture";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(217, 40);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(205, 28);
            this.button2.TabIndex = 14;
            this.button2.Text = "Fix Ratio";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(4, 40);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 28);
            this.button1.TabIndex = 13;
            this.button1.Text = "Autosize";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCaptureFolder
            // 
            this.txtCaptureFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCaptureFolder.Location = new System.Drawing.Point(216, 75);
            this.txtCaptureFolder.Name = "txtCaptureFolder";
            this.txtCaptureFolder.Size = new System.Drawing.Size(207, 22);
            this.txtCaptureFolder.TabIndex = 16;
            this.txtCaptureFolder.Text = "C:\\timelapse\\InstallationRunning";
            // 
            // nudSecondsGap
            // 
            this.nudSecondsGap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudSecondsGap.Location = new System.Drawing.Point(429, 75);
            this.nudSecondsGap.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.nudSecondsGap.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSecondsGap.Name = "nudSecondsGap";
            this.nudSecondsGap.Size = new System.Drawing.Size(207, 22);
            this.nudSecondsGap.TabIndex = 17;
            this.nudSecondsGap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudSecondsGap.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudSecondsGap.ValueChanged += new System.EventHandler(this.nudSecondsGap_ValueChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cmdFixVideo
            // 
            this.cmdFixVideo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdFixVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdFixVideo.Location = new System.Drawing.Point(643, 40);
            this.cmdFixVideo.Margin = new System.Windows.Forms.Padding(4);
            this.cmdFixVideo.Name = "cmdFixVideo";
            this.cmdFixVideo.Size = new System.Drawing.Size(206, 28);
            this.cmdFixVideo.TabIndex = 18;
            this.cmdFixVideo.Text = "Fix video";
            this.cmdFixVideo.UseVisualStyleBackColor = true;
            this.cmdFixVideo.Click += new System.EventHandler(this.cmdFixVideo_Click);
            // 
            // lblticks
            // 
            this.lblticks.AutoSize = true;
            this.lblticks.Location = new System.Drawing.Point(642, 72);
            this.lblticks.Name = "lblticks";
            this.lblticks.Size = new System.Drawing.Size(55, 17);
            this.lblticks.TabIndex = 19;
            this.lblticks.Text = "lblTicks";
            // 
            // frmWebcam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 591);
            this.Controls.Add(this.PanelCommands);
            this.Controls.Add(this.pictureBoxDisplay);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmWebcam";
            this.Text = "Frameless webcam";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisplay)).EndInit();
            this.PanelCommands.ResumeLayout(false);
            this.PanelCommands.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSecondsGap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxDisplay;
        private System.Windows.Forms.ComboBox comboBoxCameras;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TableLayoutPanel PanelCommands;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtCaptureFolder;
        private System.Windows.Forms.NumericUpDown nudSecondsGap;
        private System.Windows.Forms.Button cmdFixVideo;
        private System.Windows.Forms.Label lblticks;
    }
}

