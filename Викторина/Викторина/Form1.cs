using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Викторина
{
    public partial class Nac : Form
    {
        int NumberPicture = 0;
        int[] Answer;
        public Nac()
        {
            InitializeComponent();
            Answer = new int[16];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NumberPicture++;
            if (NumberPicture > 15) NumberPicture = 15;
            show(NumberPicture);
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NumberPicture--;
            if (NumberPicture < 0) NumberPicture = 0;
            show(NumberPicture);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int correct = 0;
            if (Answer[0] == 2)
                correct++;
            if (Answer[1] == 3)
                correct++;
            if (Answer[2] == 3)
                correct++;
            if (Answer[3] == 3)
                correct++;
            if (Answer[4] == 2)
                correct++;
            if (Answer[5] == 3)
                correct++;
            if (Answer[6] == 1)
                correct++;
            if (Answer[7] == 2)
                correct++;
            if (Answer[8] == 2)
                correct++;
            if (Answer[9] == 2)
                correct++;
            if (Answer[10] == 2)
                correct++;
            if (Answer[11] == 3)
                correct++;
            if (Answer[12] == 1)
                correct++;
            if (Answer[13] == 3)
                correct++;
            if (Answer[14] == 1)
                correct++;
            string msg = "Вы не справились с тестом";
            int prcnt = correct * 100 / 15;
            if (prcnt >= 75) msg = "Вы справились с тестом";
            MessageBox.Show("Вы ответили на " + prcnt + "% вопросов верно. " + msg);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Answer[NumberPicture] = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Answer[NumberPicture] = 2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Answer[NumberPicture] = 3;
        }

        private void Nac_Load(object sender, EventArgs e)
        {
            var bmp = new Bitmap(Викторина.Properties.Resources.тест11);
            pictureBox1.BackgroundImage = bmp;
        }
        public void show(int NumberPicture)
        {
            int NumLabel = NumberPicture + 1;
            if (NumLabel > 15) NumLabel = 15;
            label1.Text = "Вопрос №" + NumLabel;
            switch (Answer[NumberPicture])
            {
                case 0:
                    radioButton1.Checked = false;
                    radioButton2.Checked = true;
                    radioButton3.Checked = false;
                    break;
                case 1:
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = true;
                    break;
                case 2:
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = true;
                    break;
                case 3:
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = true;
                    break;
                case 4:
                    radioButton1.Checked = false;
                    radioButton2.Checked = true;
                    radioButton3.Checked = false;
                    break;
                case 5:
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = true;
                    break;
                case 6:
                    radioButton1.Checked = true;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    break;
                case 7:
                    radioButton1.Checked = false;
                    radioButton2.Checked = true;
                    radioButton3.Checked = false;
                    break;
                case 8:
                    radioButton1.Checked = false;
                    radioButton2.Checked = true;
                    radioButton3.Checked = false;
                    break;
                case 9:
                    radioButton1.Checked = false;
                    radioButton2.Checked = true;
                    radioButton3.Checked = false;
                    break;
                case 10:
                    radioButton1.Checked = false;
                    radioButton2.Checked = true;
                    radioButton3.Checked = false;
                    break;
                case 11:
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = true;
                    break;
                case 12:
                    radioButton1.Checked = true;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    break;
                case 13:
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = true;
                    break;
                case 14:
                    radioButton1.Checked = true;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    break;

            }
            switch (NumberPicture)
            {
                case 0:
                    pictureBox1.BackgroundImage = new Bitmap(Викторина.Properties.Resources.тест11);
                    break;
                case 1:
                    pictureBox1.BackgroundImage = new Bitmap(Викторина.Properties.Resources.тест12);
                    break;
                case 2:
                    pictureBox1.BackgroundImage = new Bitmap(Викторина.Properties.Resources.тест13);
                    break;
                case 3:
                    pictureBox1.BackgroundImage = new Bitmap(Викторина.Properties.Resources.тест14);
                    break;
                case 4:
                    pictureBox1.BackgroundImage = new Bitmap(Викторина.Properties.Resources.тест15);
                    break;
                case 5:
                    pictureBox1.BackgroundImage = new Bitmap(Викторина.Properties.Resources.тест16);
                    break;
                case 6:
                    pictureBox1.BackgroundImage = new Bitmap(Викторина.Properties.Resources.тест17);
                    break;
                case 7:
                    pictureBox1.BackgroundImage = new Bitmap(Викторина.Properties.Resources.тест18);
                    break;
                case 8:
                    pictureBox1.BackgroundImage = new Bitmap(Викторина.Properties.Resources.тест19);
                    break;
                case 9:
                    pictureBox1.BackgroundImage = new Bitmap(Викторина.Properties.Resources.тест110);
                    break;
                case 10:
                    pictureBox1.BackgroundImage = new Bitmap(Викторина.Properties.Resources.тест111);
                    break;
                case 11:
                    pictureBox1.BackgroundImage = new Bitmap(Викторина.Properties.Resources.тест112);
                    break;
                case 12:
                    pictureBox1.BackgroundImage = new Bitmap(Викторина.Properties.Resources.тест113);
                    break;
                case 13:
                    pictureBox1.BackgroundImage = new Bitmap(Викторина.Properties.Resources.тест114);
                    break;
                case 14:
                    pictureBox1.BackgroundImage = new Bitmap(Викторина.Properties.Resources.тест115);
                    break;
            }
        }
    }
}

