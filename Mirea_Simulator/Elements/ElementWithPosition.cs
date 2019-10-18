using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mirea_Simulator.Elements
{
    public class ElementWithPosition
    {
        public double[] Positions { get; }
        public int PositionIndex { get; private set; }
        public float StepDegree { get; }
        PictureBox pictureBox;

        /// <summary> Создание элемента </summary>
        /// <param name="pos"> Массив позиций элемента </param>
        /// <param name="index"> Индекс текущей позиции элемента </param>
        /// <param name="degrees"> Шаг позиции в градусах </param>
        public ElementWithPosition(PictureBox pic, double[] pos, int index, float degree)
        {
            pictureBox = pic;
            Positions = pos;
            PositionIndex = index;
            StepDegree = degree;
        }

        public void ChangePosition(MouseEventArgs e)
        {
            float angle = 0;
            if (e.Button == MouseButtons.Left)
                angle = PreviousPosition();
            else if (e.Button == MouseButtons.Right)
                angle = NextPosition();

            pictureBox.Image = Utils.ImageUtils.RotatePictureBox(pictureBox, angle);
        }

        private float NextPosition()
        {
            if (PositionIndex + 1 < Positions.Length)
            {
                PositionIndex++;
                return StepDegree;
            }
            else
            {
                return 0;
            }
        }


        private float PreviousPosition()
        {
            if (PositionIndex - 1 >= 0)
            {
                PositionIndex--;
                return -StepDegree;
            }
            else
            {
                return 0;
            }
        }
    }
}
