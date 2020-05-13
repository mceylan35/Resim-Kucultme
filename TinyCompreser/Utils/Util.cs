using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyCompreser.Utils
{
    public class Util
    {
        public static string APIKEY = "GPG6n2gsqR86VwW9JcDdY7JjGF3VsJ1b";
        public static byte[] ImgToByte(Image image)//Bitmap /Image
        {
            ImageConverter imageConverter = new ImageConverter();
            return (byte[])imageConverter.ConvertTo(image, typeof(byte[]));
        }
        public static Image ByteToImage(byte[] buffer)
        {
            var ms = new MemoryStream(buffer);
            return Image.FromStream(ms);
        }
    }
}
