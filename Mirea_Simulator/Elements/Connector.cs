using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mirea_Simulator.Elements
{
    public class Connector
    {
        PictureBox pictureBox;
        Image image;
        public bool Visible { get; private set; } = true;

        public Connector(PictureBox pic)
        {
            pictureBox = pic;
            image = pic.Image;
        }

        public void ChangePosition()
        {
            if (Visible)
                pictureBox.Image = null;
            else
                pictureBox.Image = image;

            Visible = !Visible;
        }
    }
}
