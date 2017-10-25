using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using Touchless.Vision.Camera;

namespace Touchless.Vision
{
    public class StillPictureTaker
    {
        private CameraFrameSource _frameSource;
        private string SavePath;

        public void TakeShot(Touchless.Vision.Camera.Camera c, Size capSize, string path)
        {
            SavePath = path;

            c.CaptureWidth = capSize.Width;
            c.CaptureHeight = capSize.Height;
            setFrameSource(new CameraFrameSource(c));
            _frameSource.Camera.CaptureWidth = capSize.Width;
            _frameSource.Camera.CaptureHeight = capSize.Height;
            _frameSource.Camera.Fps = 20;
            _frameSource.NewFrame += OnImageCaptured;
            
            
            _frameSource.StartFrameCapture();
        }

        private void OnImageCaptured(Touchless.Vision.Contracts.IFrameSource frameSource, Touchless.Vision.Contracts.Frame frame, double fps)
        {
            string fileNameNow = DateTime.Now.ToString("yyyyMMdd_HHmmss");
            string outName = Path.Combine(SavePath, fileNameNow + ".bmp");

            Bitmap b = new Bitmap(frame.Image);
            b.Save(outName);


            // here it is all closed down
            if (_frameSource != null)
            {
                _frameSource.NewFrame -= OnImageCaptured;
                _frameSource.Camera.Dispose();
                setFrameSource(null);
                // pictureBoxDisplay.Paint -= new PaintEventHandler(drawLatestImage);
            }
        }

        private void setFrameSource(CameraFrameSource cameraFrameSource)
        {
            if (_frameSource == cameraFrameSource)
                return;

            _frameSource = cameraFrameSource;
        }
    }
}
