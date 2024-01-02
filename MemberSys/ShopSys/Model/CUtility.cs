using Clinicsys;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Color = System.Drawing.Color;

namespace ClinicSys
{
    public class CUtility
    {
        public static byte[] getBytesbyPicture(PictureBox pictureBox)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            Image image = pictureBox.Image;
            pictureBox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] bytes = ms.GetBuffer();
            return bytes;
        }

        public static Image getImagebyBytes(byte[] bytes)
        {
            try
            {
                System.IO.MemoryStream ms = new System.IO.MemoryStream(bytes);
                return Image.FromStream(ms);
            }
            catch { return null; }
        }
    }
}
