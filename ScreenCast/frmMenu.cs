using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;


namespace ScreenCast
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        frmBackGround SizeForm;

        private void button1_Click(object sender, EventArgs e)
        {
            SizeForm = new frmBackGround();
            SizeForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmWebcam wc = new frmWebcam();
            wc.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lstProcesses.Items.Clear();
            Process[] processes = Process.GetProcesses(".");
            foreach (var process in processes)
            {
                if (process.MainWindowTitle != "")
                {
                    Duple d = new Duple();
                    d.text = process.MainWindowTitle;
                    d.obj = process;
                    lstProcesses.Items.Add(d);
                }
                //var handle = process.MainWindowHandle;
                //var form = Control.FromHandle(handle);
            }
        }

        private class Duple 
        {
            internal string text;
            internal object obj;
            public override string ToString()
            {
                return text;
            }
        }

        // window resizing mechanisms modified from source at: 
        // http://stackoverflow.com/questions/1190423/using-setwindowpos-in-c-sharp-to-move-windows-around

        [DllImport("user32.dll", EntryPoint = "SetWindowPos")]
        public static extern IntPtr SetWindowPos(IntPtr hWnd, int hWndInsertAfter, int x, int Y, int cx, int cy, int wFlags);


        private void lstProcesses_DoubleClick(object sender, EventArgs e)
        {
            const short SWP_NOMOVE = 0X2;
            const short SWP_NOSIZE = 1;
            const short SWP_NOZORDER = 0X4;
            const int SWP_SHOWWINDOW = 0x0040;

            if (SizeForm == null)
                return;
            Duple item = lstProcesses.SelectedItem as Duple;
            if (item == null)
                return;
            Process p = item.obj as Process;
            if (p == null)
                return;

            var handle = p.MainWindowHandle;
            SetWindowPos(handle, 0, SizeForm.Location.X, SizeForm.Location.Y, SizeForm.Bounds.Width, SizeForm.Bounds.Height, SWP_NOZORDER | SWP_SHOWWINDOW);
        }
    }
}
