using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mirea_Simulator.Utils
{
    class ImageUtils
    {
        /// <summary>
     /// Creates a new Image containing the same image only rotated
     /// </summary>
     /// <param name=""image"">The <see cref=""System.Drawing.Image"/"> to rotate
     /// <param name=""offset"">The position to rotate from.
     /// <param name=""angle"">The amount to rotate the image, clockwise, in degrees
     /// <returns>A new <see cref=""System.Drawing.Bitmap"/"> of the same size rotated.</see>
     /// <exception cref=""System.ArgumentNullException"">Thrown if <see cref=""image"/"> 
     /// is null.</see>
        public static Bitmap RotatePictureBox(PictureBox pictureBox, float angle)
        {
            //Store our old image so we can delete it
            Image image = pictureBox.Image;

            //create a new empty bitmap to hold rotated image
            Bitmap rotatedBmp = new Bitmap(image.Width, image.Height);
            rotatedBmp.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            //make a graphics object from the empty bitmap
            Graphics g = Graphics.FromImage(rotatedBmp);

            //Put the rotation point in the center of the image
            PointF offset = new Point(image.Width / 2, image.Height / 2);
            g.TranslateTransform(offset.X, offset.Y);

            //rotate the image
            g.RotateTransform(angle);

            //move the image back
            g.TranslateTransform(-offset.X, -offset.Y);

            //draw passed in image onto graphics object
            g.DrawImage(image, new PointF(0, 0));
            
            if (image != null)
                image.Dispose();

            return rotatedBmp;
        }
    }
}
