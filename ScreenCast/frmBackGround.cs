using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using System.Text.RegularExpressions;



namespace ScreenCast
{
    public partial class frmBackGround : Form
    {
        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;

        public frmBackGround()
        {
            InitializeComponent();
            GetSizeUI();
        }

        private void GetSizeUI()
        {
            nudW.Value = this.Width - numericUpDown1.Value;
            nudH.Value = this.Height - numericUpDown1.Value; 
        }

        private void nudW_ValueChanged_1(object sender, EventArgs e)
        {
            ResizeForm();
        }

        private void ResizeForm()
        {
            this.Width = (int)(nudW.Value + numericUpDown1.Value);
            this.Height = (int)(nudH.Value + numericUpDown1.Value);
        }

        private void nudH_ValueChanged_1(object sender, EventArgs e)
        {
            ResizeForm();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            GetSizeUI();
        }

        /// <summary>
        /// Handling the window messages
        /// </summary>
        /// <param name="m"></param>
        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            if (message.Msg == WM_NCHITTEST && (int)message.Result == HTCLIENT)
                message.Result = (IntPtr)HTCAPTION;
        }

        private void cmdBorder_Click_1(object sender, EventArgs e)
        {
            if (this.FormBorderStyle == System.Windows.Forms.FormBorderStyle.None)
            {
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            }
            else
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        private void textBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (textBox1.Dock == DockStyle.Fill)
            {
                //panelBottom.Visible = true;
                //panelTop.Visible = true;
                textBox1.Dock = DockStyle.None;
            }
            else
            {
                //panelBottom.Visible = false;
                //panelTop.Visible = false;
                textBox1.Dock = DockStyle.Fill;
            }
        }

        private void x1200ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nudW.Value = 1600;
            nudH.Value = 1200;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            string kc = e.KeyCode.ToString();
            Regex re = new Regex(@"F([\d+])");
            var m = re.Match(kc);
            if (m.Success)
            {
                Status.setText(textBox1.Text);
                int id = Convert.ToInt32( m.Groups[1].Value);
                textBox1.Text = Status.getText(id - 1);
            }
            else if (e.KeyCode == Keys.ControlKey)
            {
            }
            else if (e.KeyCode == Keys.D && e.Control)
            {
                //Status.setText(textBox1.Text);
                Status.Remove();
                textBox1.Text = Status.getText();
            }
            else if (e.KeyCode == Keys.I && e.Control)
            {
                Status.setText(textBox1.Text);
                Status.Insert();
                textBox1.Text = Status.getText();
                // textBox1.SelectAll();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.OemCloseBrackets && e.Control)
            {
                Status.setText(textBox1.Text);
                Status.NextContent();
                textBox1.Text = Status.getText();
            }
            else if (e.KeyCode == Keys.OemOpenBrackets && e.Control)
            {
                Status.setText(textBox1.Text);
                Status.PreviousContent();
                textBox1.Text = Status.getText();
            }
            else if (e.KeyCode == Keys.Down && e.Control)
            {
                SetFontSize(0.9f);
            }
            else if (e.KeyCode == Keys.Up && e.Control)
            {
                SetFontSize(1.1f);
            }
            else if (e.KeyCode == Keys.A && e.Control)
            {
                textBox1.SelectAll();
            } 
        }

        private void SetFontSize(float ratio)
        {
            var size = this.textBox1.Font.Size;
            Font f = new Font("Calibri", size * ratio);
            this.textBox1.Font = f;
        }

        internal BackgroundStatus Status = new BackgroundStatus();

        private void button2_Click(object sender, EventArgs e)
        {
            LoadDefault();
        }

        private void LoadDefault()
        {
            if (!File.Exists("Background.xml"))
                return;
            TextReader tw = new StreamReader("Background.xml");

            // write a line of text to the file
            string data = tw.ReadToEnd();

            // close the stream
            tw.Close();

            XmlSerializer ser = new XmlSerializer(typeof(BackgroundStatus));
            BackgroundStatus c1 = (BackgroundStatus)Utf8Xml.Utf8XMLDeserializer(ser, data);
            if (c1.Border)
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            else
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            this.Location = c1.Position;
            nudW.Value = c1.Width;
            nudH.Value = c1.Height;

            textBox1.Text = c1.getText();
            this.Status = c1;

        }

        private void frmBackGround_FormClosing(object sender, FormClosingEventArgs e)
        {

            SaveDefault();
        }

        private void SaveDefault()
        {
            this.Status.Position = this.Location;
            this.Status.Width = (int)nudW.Value;
            this.Status.Height = (int)nudH.Value;

            XmlSerializer ser = new XmlSerializer(typeof(BackgroundStatus));
            string data = Utf8Xml.Utf8XMLSerializer(ser, Status);

            TextWriter tw = new StreamWriter("Background.xml");

            // write a line of text to the file
            tw.Write(data);

            // close the stream
            tw.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveDefault();
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmBackGround_Load(object sender, EventArgs e)
        {
            LoadDefault();
        }
    }
}
