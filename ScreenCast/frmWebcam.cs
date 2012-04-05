using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Touchless.Vision.Camera;

namespace ScreenCast
{
    public partial class frmWebcam : Form
    {
        public frmWebcam()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                // Refresh the list of available cameras
                comboBoxCameras.Items.Clear();
                foreach (Camera cam in CameraService.AvailableCameras)
                {
                    comboBoxCameras.Items.Add(cam);
                }

                if (comboBoxCameras.Items.Count > 0)
                    comboBoxCameras.SelectedIndex = 0;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            thrashOldCamera();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            thrashOldCamera();
        }

        private CameraFrameSource _frameSource;
        private static Bitmap _latestFrame;

        private void btnStart_Click(object sender, EventArgs e)
        {
            // Early return if we've selected the current camera
            if (_frameSource != null && _frameSource.Camera == comboBoxCameras.SelectedItem)
                return;

            thrashOldCamera();
            startCapturing();
        }

        private void startCapturing()
        {
            try
            {
                Camera c = (Camera)comboBoxCameras.SelectedItem;
                c.CaptureWidth = 320;
                c.CaptureHeight = 240;
                setFrameSource(new CameraFrameSource(c));
                _frameSource.Camera.CaptureWidth = 320;
                _frameSource.Camera.CaptureHeight = 240;
                _frameSource.Camera.Fps = 20;
                _frameSource.NewFrame += OnImageCaptured;

                // pictureBoxDisplay.Paint += new PaintEventHandler(drawLatestImage);
                _frameSource.StartFrameCapture();
            }
            catch (Exception ex)
            {
                comboBoxCameras.Text = "Select A Camera";
                MessageBox.Show(ex.Message);
            }
        }

        public void OnImageCaptured(Touchless.Vision.Contracts.IFrameSource frameSource, Touchless.Vision.Contracts.Frame frame, double fps)
        {
            if (_SetAutoSize)
            {
                SetSize(frame.Image.Size);
                _SetAutoSize = false;
            }
            if (_FixRatio)
            {
                float r = (float)frame.Image.Height / (float)frame.Image.Width;
                System.Drawing.Size s = new Size(pictureBoxDisplay.Width, (int)(r * pictureBoxDisplay.Width));
                SetSize(s);
                _FixRatio = false;
            }

            try
            {
                pictureBoxDisplay.Image = frame.Image; // _latestFrame = frame.Image;
                pictureBoxDisplay.Invalidate();
            }
            catch
            {
            }
        }

        delegate void SetSizeCallback(Size newsize);

        private void SetSize(Size newsize)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.InvokeRequired)
            {
                SetSizeCallback d = new SetSizeCallback(SetSize);
                this.Invoke(d, new object[] { newsize });
            }
            else
            {
                var backup = this.FormBorderStyle;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                this.Size = newsize;
                this.FormBorderStyle = backup;
            }
        }

        private void setFrameSource(CameraFrameSource cameraFrameSource)
        {
            if (_frameSource == cameraFrameSource)
                return;

            _frameSource = cameraFrameSource;
        }

        //

        private void thrashOldCamera()
        {
            // Trash the old camera
            if (_frameSource != null)
            {
                _frameSource.NewFrame -= OnImageCaptured;
                _frameSource.Camera.Dispose();
                setFrameSource(null);
                // pictureBoxDisplay.Paint -= new PaintEventHandler(drawLatestImage);
            }
        }

        //

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_frameSource == null)
                return;

            Bitmap current = (Bitmap)_latestFrame.Clone();
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "*.bmp|*.bmp";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    current.Save(sfd.FileName);
                }
            }

            current.Dispose();
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            // snap camera
            if (_frameSource != null)
                _frameSource.Camera.ShowPropertiesDialog();
        }

        // Dragging functions
        //
        Point lastClick; //Holds where the Form was clicked
        MouseAction _lastAction;
        Size _lastSize;

        private void Dragging_MouseDown(object sender, MouseEventArgs e)
        {
            //We'll need this for when the Form starts to move
            lastClick = new Point(e.X, e.Y);
            _lastAction = GetMouseAction(e);
            if (_lastAction == MouseAction.formResize)
            {
                _lastSize = this.Size;
            }
        }

        enum MouseAction
        {
            formMove,
            formResize
        }

        private MouseAction GetMouseAction(MouseEventArgs e)
        {
            if (e.Location.X > 3 * pictureBoxDisplay.Width / 4 && e.Location.Y > 2 * pictureBoxDisplay.Height / 3)
            {
                return MouseAction.formResize;
            }
            return MouseAction.formMove;
        }

        private void Dragging_MouseMove(object sender, MouseEventArgs e)
        {
            if (GetMouseAction(e) == MouseAction.formResize)
                this.Cursor = Cursors.SizeNWSE;
            else
                this.Cursor = Cursors.SizeAll;

            //Point newLocation = new Point(e.X - lastE.X, e.Y - lastE.Y);
            if (e.Button == MouseButtons.Left && _lastAction == MouseAction.formMove) //Only when mouse is clicked
            {
                //Move the Form the same difference the mouse cursor moved;
                this.Left += e.X - lastClick.X;
                this.Top += e.Y - lastClick.Y;
            }
            else if (e.Button == MouseButtons.Left && _lastAction == MouseAction.formResize) //Only when mouse is clicked
            {
                //Move the Form the same difference the mouse cursor moved;
                int initial = lastClick.X - this.Left;
                int current = e.X - this.Left;
                float r = (float)current / initial;
                
                System.Drawing.Size s = new Size((int)(_lastSize.Width * r), (int)(_lastSize.Height * r));
                System.Diagnostics.Debug.WriteLine(s.ToString());
                if (s.Width > 150 && s.Width < 1280)
                    this.Size = s;
            }
        }

        // toggle visibility and commands
        //
        private void pictureBoxDisplay_DoubleClick(object sender, EventArgs e)
        {
            if (this.FormBorderStyle == System.Windows.Forms.FormBorderStyle.None)
            {
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
                PanelCommands.Visible = true;
                this.TopMost = false;
            }
            else
            {
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                PanelCommands.Visible = false;
                this.TopMost = true;
            }
        }

        bool _SetAutoSize = false;
        bool _FixRatio = true;
        private void button1_Click(object sender, EventArgs e)
        {
            _SetAutoSize = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _FixRatio = true;
        }
    }
}
