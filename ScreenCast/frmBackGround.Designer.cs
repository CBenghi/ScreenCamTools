namespace ScreenCast
{
    partial class frmBackGround
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
            this.nudW = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdBorder = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.x1200ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nudH = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmdSave = new System.Windows.Forms.Button();
            this.cmdOpen = new System.Windows.Forms.Button();
            this.cmdClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudW)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // nudW
            // 
            this.nudW.Location = new System.Drawing.Point(38, 20);
            this.nudW.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudW.Name = "nudW";
            this.nudW.Size = new System.Drawing.Size(120, 20);
            this.nudW.TabIndex = 12;
            this.nudW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudW.Value = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.nudW.ValueChanged += new System.EventHandler(this.nudW_ValueChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "H";
            // 
            // cmdBorder
            // 
            this.cmdBorder.ContextMenuStrip = this.contextMenuStrip1;
            this.cmdBorder.Location = new System.Drawing.Point(38, 72);
            this.cmdBorder.Name = "cmdBorder";
            this.cmdBorder.Size = new System.Drawing.Size(120, 23);
            this.cmdBorder.TabIndex = 11;
            this.cmdBorder.Text = "Border";
            this.cmdBorder.UseVisualStyleBackColor = true;
            this.cmdBorder.Click += new System.EventHandler(this.cmdBorder_Click_1);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.x1200ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(134, 26);
            // 
            // x1200ToolStripMenuItem
            // 
            this.x1200ToolStripMenuItem.Name = "x1200ToolStripMenuItem";
            this.x1200ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.x1200ToolStripMenuItem.Text = "1600 x 1200";
            this.x1200ToolStripMenuItem.Click += new System.EventHandler(this.x1200ToolStripMenuItem_Click);
            // 
            // nudH
            // 
            this.nudH.Location = new System.Drawing.Point(38, 46);
            this.nudH.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudH.Name = "nudH";
            this.nudH.Size = new System.Drawing.Size(120, 20);
            this.nudH.TabIndex = 14;
            this.nudH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudH.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nudH.ValueChanged += new System.EventHandler(this.nudH_ValueChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "W";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(38, 101);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 18;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Delta";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(166, 20);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(221, 261);
            this.textBox1.TabIndex = 20;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.textBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseDoubleClick);
            // 
            // cmdSave
            // 
            this.cmdSave.Location = new System.Drawing.Point(38, 127);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(120, 23);
            this.cmdSave.TabIndex = 21;
            this.cmdSave.Text = "Save";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmdOpen
            // 
            this.cmdOpen.Location = new System.Drawing.Point(38, 156);
            this.cmdOpen.Name = "cmdOpen";
            this.cmdOpen.Size = new System.Drawing.Size(120, 23);
            this.cmdOpen.TabIndex = 22;
            this.cmdOpen.Text = "Open";
            this.cmdOpen.UseVisualStyleBackColor = true;
            this.cmdOpen.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmdClose
            // 
            this.cmdClose.Location = new System.Drawing.Point(38, 258);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(120, 23);
            this.cmdClose.TabIndex = 23;
            this.cmdClose.Text = "Close Window";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // frmBackGround
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 300);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.cmdOpen);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.nudW);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmdBorder);
            this.Controls.Add(this.nudH);
            this.Controls.Add(this.label1);
            this.Name = "frmBackGround";
            this.Text = "BackGround";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBackGround_FormClosing);
            this.Load += new System.EventHandler(this.frmBackGround_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.nudW)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudW;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdBorder;
        private System.Windows.Forms.NumericUpDown nudH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem x1200ToolStripMenuItem;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Button cmdOpen;
        private System.Windows.Forms.Button cmdClose;

    }
}

