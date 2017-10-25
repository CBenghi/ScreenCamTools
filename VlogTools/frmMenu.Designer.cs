namespace ScreenCast
{
    partial class frmMenu
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lstProcesses = new System.Windows.Forms.ListBox();
            this.cmdRefresh = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdAnnotate = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(6, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(248, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Open target window";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(260, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Webcam window";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lstProcesses
            // 
            this.lstProcesses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstProcesses.FormattingEnabled = true;
            this.lstProcesses.Location = new System.Drawing.Point(6, 46);
            this.lstProcesses.Name = "lstProcesses";
            this.lstProcesses.Size = new System.Drawing.Size(248, 173);
            this.lstProcesses.TabIndex = 2;
            this.lstProcesses.SelectedIndexChanged += new System.EventHandler(this.lstProcesses_SelectedIndexChanged);
            this.lstProcesses.DoubleClick += new System.EventHandler(this.lstProcesses_DoubleClick);
            // 
            // cmdRefresh
            // 
            this.cmdRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdRefresh.Location = new System.Drawing.Point(6, 225);
            this.cmdRefresh.Name = "cmdRefresh";
            this.cmdRefresh.Size = new System.Drawing.Size(248, 23);
            this.cmdRefresh.TabIndex = 3;
            this.cmdRefresh.Text = "Refresh";
            this.cmdRefresh.UseVisualStyleBackColor = true;
            this.cmdRefresh.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lstProcesses);
            this.groupBox1.Controls.Add(this.cmdRefresh);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 255);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Windows";
            // 
            // cmdAnnotate
            // 
            this.cmdAnnotate.Location = new System.Drawing.Point(12, 41);
            this.cmdAnnotate.Name = "cmdAnnotate";
            this.cmdAnnotate.Size = new System.Drawing.Size(260, 23);
            this.cmdAnnotate.TabIndex = 5;
            this.cmdAnnotate.Text = "Annotate";
            this.cmdAnnotate.UseVisualStyleBackColor = true;
            this.cmdAnnotate.Click += new System.EventHandler(this.cmdAnnotate_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 337);
            this.Controls.Add(this.cmdAnnotate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox lstProcesses;
        private System.Windows.Forms.Button cmdRefresh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdAnnotate;
    }
}