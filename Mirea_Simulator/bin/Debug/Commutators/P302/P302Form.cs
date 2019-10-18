using Mirea_Simulator.Elements;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mirea_Simulator.bin.Debug.Commutators.P302
{
    public partial class P302Form : Form
    {
        ElementWithPosition element, element2, element3, element11, element12, element13;

        Connector element4, element5, element6, element7, element10, element14, element15, element16, element17, element22;

        Switcher element8, element9, element18, element19, element20, element21, element23, element24, element25;

        public P302Form()
        {
            InitializeComponent();

            pictureBox1.Controls.Add(pictureBox2);
            pictureBox2.BackColor = Color.Transparent;
            element = new ElementWithPosition(pictureBox2,
                new double[] { 0, 0.5, 1, 1.5, 2, 2.5, 3, 3.5, 4, 4.5, 5 }, 5, 30);

            pictureBox1.Controls.Add(pictureBox3);
            pictureBox3.BackColor = Color.Transparent;
            element2 = new ElementWithPosition(pictureBox3,
                new double[] { 0, 0.5, 1, 1.5, 2, 2.5, 3, 3.5, 4, 4.5, 5 }, 5, 30);

            pictureBox1.Controls.Add(pictureBox4);
            pictureBox4.BackColor = Color.Transparent;
            element3 = new ElementWithPosition(pictureBox4,
                new double[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 4, 30);

            element4 = new Connector(pictureBox5);
            pictureBox1.Controls.Add(pictureBox5);
            pictureBox5.BackColor = Color.Transparent;
            element4.ChangePosition();

            element5 = new Connector(pictureBox6);
            pictureBox1.Controls.Add(pictureBox6);
            pictureBox6.BackColor = Color.Transparent;
            element5.ChangePosition();

            element6 = new Connector(pictureBox7);
            pictureBox1.Controls.Add(pictureBox7);
            pictureBox7.BackColor = Color.Transparent;
            element6.ChangePosition();

            element7 = new Connector(pictureBox8);
            pictureBox1.Controls.Add(pictureBox8);
            pictureBox8.BackColor = Color.Transparent;
            element7.ChangePosition();

            pictureBox1.Controls.Add(pictureBox9);
            pictureBox9.BackColor = Color.Transparent;
            element8 = new Switcher(pictureBox9, true);

            pictureBox1.Controls.Add(pictureBox10);
            pictureBox10.BackColor = Color.Transparent;
            element9 = new Switcher(pictureBox10, true);

            element10 = new Connector(pictureBox11);
            pictureBox1.Controls.Add(pictureBox11);
            pictureBox11.BackColor = Color.Transparent;
            element10.ChangePosition();

            pictureBox1.Controls.Add(pictureBox12);
            pictureBox12.BackColor = Color.Transparent;
            element11 = new ElementWithPosition(pictureBox12,
                new double[] { 1, 2, 3, 4, 5 }, 2, 30);

            pictureBox1.Controls.Add(pictureBox13);
            pictureBox13.BackColor = Color.Transparent;
            element12 = new ElementWithPosition(pictureBox13,
                new double[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }, 5, 30);

            pictureBox1.Controls.Add(pictureBox14);
            pictureBox14.BackColor = Color.Transparent;
            element13 = new ElementWithPosition(pictureBox14,
                new double[] { 1, 2, 3, 4, 5, 6, 7 }, 3, 45);

            pictureBox1.Controls.Add(pictureBox15);
            pictureBox15.BackColor = Color.Transparent;
            element14 = new Connector(pictureBox15);

            pictureBox1.Controls.Add(pictureBox16);
            pictureBox16.BackColor = Color.Transparent;
            element15 = new Connector(pictureBox16);

            element16 = new Connector(pictureBox17);
            pictureBox1.Controls.Add(pictureBox17);
            pictureBox17.BackColor = Color.Transparent;
            element16.ChangePosition();

            element17 = new Connector(pictureBox18);
            pictureBox1.Controls.Add(pictureBox18);
            pictureBox18.BackColor = Color.Transparent;
            element17.ChangePosition();

            element18 = new Switcher(pictureBox19, false);
            pictureBox1.Controls.Add(pictureBox19);
            pictureBox19.BackColor = Color.Transparent;

            element19 = new Switcher(pictureBox20, false);
            pictureBox1.Controls.Add(pictureBox20);
            pictureBox20.BackColor = Color.Transparent;

            element20 = new Switcher(pictureBox21, false);
            pictureBox1.Controls.Add(pictureBox21);
            pictureBox21.BackColor = Color.Transparent;

            element21 = new Switcher(pictureBox22, false);
            pictureBox1.Controls.Add(pictureBox22);
            pictureBox22.BackColor = Color.Transparent;
            
            pictureBox1.Controls.Add(pictureBox23);
            pictureBox23.BackColor = Color.Transparent;
            element22 = new Connector(pictureBox23);

            element23 = new Switcher(pictureBox24, false);
            pictureBox1.Controls.Add(pictureBox24);
            pictureBox24.BackColor = Color.Transparent;

            element24 = new Switcher(pictureBox25, false);
            pictureBox1.Controls.Add(pictureBox25);
            pictureBox25.BackColor = Color.Transparent;

            element25 = new Switcher(pictureBox26, false);
            pictureBox1.Controls.Add(pictureBox26);
            pictureBox26.BackColor = Color.Transparent;
        }

        private void P302Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[0].Show();
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            element.ChangePosition(e);
        }

        private void pictureBox2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            pictureBox2_MouseClick(sender, e);
        }

        private void pictureBox3_MouseClick(object sender, MouseEventArgs e)
        {
            element2.ChangePosition(e);
        }

        private void pictureBox3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            pictureBox3_MouseClick(sender, e);
        }

        private void pictureBox4_MouseClick(object sender, MouseEventArgs e)
        {
            element3.ChangePosition(e);
        }

        private void pictureBox4_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            pictureBox4_MouseClick(sender, e);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            element4.ChangePosition();
        }

        private void pictureBox5_DoubleClick(object sender, EventArgs e)
        {
            pictureBox5_Click(sender, e);
        }

        private void pictureBox6_DoubleClick(object sender, EventArgs e)
        {
            pictureBox6_Click(sender, e);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            element5.ChangePosition();
        }

        private void pictureBox7_DoubleClick(object sender, EventArgs e)
        {
            pictureBox7_Click(sender, e);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            element6.ChangePosition();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            element16.ChangePosition();
        }

        private void pictureBox17_DoubleClick(object sender, EventArgs e)
        {
            pictureBox17_Click(sender, e);
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            element17.ChangePosition();
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            element19.ChangePosition();
        }

        private void pictureBox20_DoubleClick(object sender, EventArgs e)
        {
            pictureBox20_Click(sender, e);
        }

        private void pictureBox19_DoubleClick(object sender, EventArgs e)
        {
            pictureBox19_Click(sender, e);
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            element24.ChangePosition();
        }

        private void pictureBox25_DoubleClick(object sender, EventArgs e)
        {
            pictureBox25_Click(sender, e);
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            element25.ChangePosition();
        }

        private void pictureBox26_DoubleClick(object sender, EventArgs e)
        {
            pictureBox26_Click(sender, e);
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            element23.ChangePosition();
        }

        private void pictureBox24_DoubleClick(object sender, EventArgs e)
        {
            pictureBox24_Click(sender, e);
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            element20.ChangePosition();
        }

        private void pictureBox21_DoubleClick(object sender, EventArgs e)
        {
            pictureBox21_Click(sender, e);
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            element21.ChangePosition();
        }

        private void pictureBox22_DoubleClick(object sender, EventArgs e)
        {
            pictureBox22_Click(sender, e);
        }

        private void pictureBox18_DoubleClick(object sender, EventArgs e)
        {
            pictureBox18_Click(sender, e);
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            element18.ChangePosition();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            element7.ChangePosition();
        }

        private void pictureBox12_MouseClick(object sender, MouseEventArgs e)
        {
            element11.ChangePosition(e);
        }

        private void pictureBox13_MouseClick(object sender, MouseEventArgs e)
        {
            element12.ChangePosition(e);
        }

        private void pictureBox14_MouseClick(object sender, MouseEventArgs e)
        {
            element13.ChangePosition(e);
        }

        private void pictureBox14_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            pictureBox14_MouseClick(sender, e);
        }

        private void pictureBox13_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            pictureBox13_MouseClick(sender, e);
        }

        private void pictureBox12_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            pictureBox12_MouseClick(sender, e);
        }

        private void pictureBox8_DoubleClick(object sender, EventArgs e)
        {
            pictureBox8_Click(sender, e);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            element8.ChangePosition();
        }

        private void pictureBox9_DoubleClick(object sender, EventArgs e)
        {
            pictureBox9_Click(sender, e);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            element9.ChangePosition();
        }

        private void pictureBox10_DoubleClick(object sender, EventArgs e)
        {
            pictureBox10_Click(sender, e);
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            element10.ChangePosition();
        }

        private void pictureBox11_DoubleClick(object sender, EventArgs e)
        {
            pictureBox11_Click(sender, e);
        }
    }
}
