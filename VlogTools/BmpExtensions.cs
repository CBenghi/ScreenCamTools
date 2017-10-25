using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;

namespace ScreenCast
{
    public static class BitmapExtensions
    {
        public static void SaveJPG(this Bitmap bmp, string filename, long quality)
        {
            EncoderParameters encoderParameters = new EncoderParameters(1);
            encoderParameters.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, quality);
            bmp.Save(filename, GetEncoder(ImageFormat.Jpeg), encoderParameters);
        }

        public static void SaveJPG(this Bitmap bmp, Stream stream, long quality)
        {
            EncoderParameters encoderParameters = new EncoderParameters(1);
            encoderParameters.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, quality);
            bmp.Save(stream, GetEncoder(ImageFormat.Jpeg), encoderParameters);
        }

        public static ImageCodecInfo GetEncoder(ImageFormat format)
        {

            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageDecoders();

            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.FormatID == format.Guid)
                {
                    return codec;
                }
            }
            return null;
        }
    }
}
