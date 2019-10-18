using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mirea_Simulator.Elements
{
    public class Switcher
    {
        public bool On { get; private set; }
        private PictureBox pictureBox;

        /// <summary> Создание элемента </summary>
        /// <param name="pos"> Массив позиций элемента </param>
        /// <param name="index"> Индекс текущей позиции элемента </param>
        /// <param name="degrees"> Шаг позиции в градусах </param>
        public Switcher(PictureBox pic, bool isOn)
        {
            pictureBox = pic;
            On = isOn;
        }

        public void ChangePosition()
        {
            pictureBox.Image = Utils.ImageUtils.RotatePictureBox(pictureBox, 180);
            On = !On;
        }
    }
}
