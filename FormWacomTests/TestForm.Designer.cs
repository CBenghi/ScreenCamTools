namespace FormTestApp
{
    partial class TestForm
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
            this.testButton = new System.Windows.Forms.Button();
            this.testTextBox = new System.Windows.Forms.RichTextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.scribblePanel = new System.Windows.Forms.Panel();
            this.scribbleButton = new System.Windows.Forms.Button();
            this.scribbleLabel = new System.Windows.Forms.Label();
            this.testLabel = new System.Windows.Forms.Label();
            this.testQDPButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // testButton
            // 
            this.testButton.BackColor = System.Drawing.Color.Lime;
            this.testButton.Location = new System.Drawing.Point(6, 6);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(75, 23);
            this.testButton.TabIndex = 0;
            this.testButton.Text = "Test...";
            this.testButton.UseVisualStyleBackColor = false;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // testTextBox
            // 
            this.testTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.testTextBox.BackColor = System.Drawing.Color.Black;
            this.testTextBox.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testTextBox.ForeColor = System.Drawing.Color.Lime;
            this.testTextBox.Location = new System.Drawing.Point(6, 64);
            this.testTextBox.Name = "testTextBox";
            this.testTextBox.Size = new System.Drawing.Size(579, 438);
            this.testTextBox.TabIndex = 1;
            this.testTextBox.Text = "";
            // 
            // clearButton
            // 
            this.clearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clearButton.Location = new System.Drawing.Point(520, 16);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "Background";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // scribblePanel
            // 
            this.scribblePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scribblePanel.BackColor = System.Drawing.Color.Gainsboro;
            this.scribblePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scribblePanel.Location = new System.Drawing.Point(6, 55);
            this.scribblePanel.Name = "scribblePanel";
            this.scribblePanel.Size = new System.Drawing.Size(589, 447);
            this.scribblePanel.TabIndex = 3;
            this.scribblePanel.Resize += new System.EventHandler(this.scribblePanel_Resize);
            // 
            // scribbleButton
            // 
            this.scribbleButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.scribbleButton.Location = new System.Drawing.Point(6, 15);
            this.scribbleButton.Name = "scribbleButton";
            this.scribbleButton.Size = new System.Drawing.Size(77, 24);
            this.scribbleButton.TabIndex = 4;
            this.scribbleButton.Text = "Scribble";
            this.scribbleButton.UseVisualStyleBackColor = false;
            this.scribbleButton.Click += new System.EventHandler(this.scribbleButton_Click);
            // 
            // scribbleLabel
            // 
            this.scribbleLabel.AutoSize = true;
            this.scribbleLabel.Location = new System.Drawing.Point(84, 21);
            this.scribbleLabel.Name = "scribbleLabel";
            this.scribbleLabel.Size = new System.Drawing.Size(191, 13);
            this.scribbleLabel.TabIndex = 5;
            this.scribbleLabel.Text = "Scribble on the tablet surface with pen.";
            this.scribbleLabel.Visible = false;
            // 
            // testLabel
            // 
            this.testLabel.AutoSize = true;
            this.testLabel.Location = new System.Drawing.Point(82, 11);
            this.testLabel.Name = "testLabel";
            this.testLabel.Size = new System.Drawing.Size(162, 13);
            this.testLabel.TabIndex = 6;
            this.testLabel.Text = "Press Test button to start testing.";
            // 
            // testQDPButton
            // 
            this.testQDPButton.BackColor = System.Drawing.Color.Yellow;
            this.testQDPButton.Location = new System.Drawing.Point(6, 35);
            this.testQDPButton.Name = "testQDPButton";
            this.testQDPButton.Size = new System.Drawing.Size(75, 23);
            this.testQDPButton.TabIndex = 7;
            this.testQDPButton.Text = "Test QDP...";
            this.testQDPButton.UseVisualStyleBackColor = false;
            this.testQDPButton.Click += new System.EventHandler(this.testQDPButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Query Data Packets.";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 17);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(609, 534);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.scribbleButton);
            this.tabPage2.Controls.Add(this.clearButton);
            this.tabPage2.Controls.Add(this.scribblePanel);
            this.tabPage2.Controls.Add(this.scribbleLabel);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(601, 508);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Draw";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(359, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "ColorToggle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.testTextBox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.testButton);
            this.tabPage1.Controls.Add(this.testQDPButton);
            this.tabPage1.Controls.Add(this.testLabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(601, 508);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "API";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(439, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(634, 572);
            this.Controls.Add(this.tabControl1);
            this.Name = "TestForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Test";
            this.Load += new System.EventHandler(this.TestForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button testButton;
        public System.Windows.Forms.RichTextBox testTextBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Panel scribblePanel;
        private System.Windows.Forms.Button scribbleButton;
        private System.Windows.Forms.Label scribbleLabel;
        private System.Windows.Forms.Label testLabel;
        private System.Windows.Forms.Button testQDPButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

