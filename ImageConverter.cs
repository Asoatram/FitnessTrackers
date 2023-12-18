using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FitnessTrackers
{
    internal class ImageConverter
    {
        public static Image ConvertBytesToImage(byte[] imageData)
        {
            if (imageData == null || imageData.Length == 0)
            {
                return null;
            }

            using (MemoryStream stream = new MemoryStream(imageData))
            {
                return Image.FromStream(stream);
            }
        }
    }
}
