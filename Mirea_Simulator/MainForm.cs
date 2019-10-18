using Mirea_Simulator.bin.Debug.Commutators.P302;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mirea_Simulator
{
    public partial class MainForm : Form
    {
        /// <summary> Перечисление доступных коммутаторов </summary>
        public enum Commutator
        {
            P302
        }


        /// <summary> Перечисление доступных коммутаторов </summary>
        static public Commutator CurrentCommutator { get; private set; }

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnTtd_Click(object sender, EventArgs e)
        {
            // Подгружаем теоритическую программу по конкретному коммутатору
            Process.Start($@"Commutators\{ CurrentCommutator.ToString()}\Theory.exe");
        }

        private void cbChooseCommutator_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Запоминаем выбранный коммутатор
            CurrentCommutator = (Commutator)cbChooseCommutator.SelectedIndex;

            // Подгружаем фотографию коммутатора
            picCommutator.Image = new Bitmap($@"Commutators\{CurrentCommutator.ToString()}\Photo.png");

            // Активируем кнопки работы с коммутатором
            btnTtd.Enabled = true;
            btnTraining.Enabled = true;
            btnTesting.Enabled = true;
            btnWebTesting.Enabled = true;
        }

        private void btnTraining_Click(object sender, EventArgs e)
        {
            Form commutatorForm = null;
            switch (CurrentCommutator)
            {
                case (Commutator.P302):
                    commutatorForm = new P302Form();
                    break;

                default:
                    MessageBox.Show("Выбран неверный тип аппаратуры");
                    return;
            }
            
            commutatorForm.Show();
            this.Hide();

        }

        private void btnWebTesting_Click(object sender, EventArgs e)
        {
            switch (CurrentCommutator)
            {
                case (Commutator.P302):
                    Process.Start("http://18.222.201.152");
                    break;

                default:
                    MessageBox.Show("Выбран неверный тип аппаратуры");
                    return;
            }
        }
    }
}
