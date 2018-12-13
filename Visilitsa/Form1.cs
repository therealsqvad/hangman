using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visilitsa
{
    public partial class Form1 : Form
    {
        string word = "НИКИТА";
        int life = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            //this.Size = new Size(500, 500);
            string str = "АБВГДЕЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";//строковая перем. с алфавитом
            int posX = 20, posY = 150;//начальные позиции первой строки букв
            for (int i = 0; i < str.Count(); i++)//создание цикла
            {
                Button button = new Button();//метод создания новой кнопки
                button.Name = "letterbutton" + i;
                button.Enabled = false;
                button.BackColor = Color.White;//цвет кнопки
                button.Text = str[i] + "";//присваивает значение след.буквы
                button.Click += new EventHandler(this.button_Click);
                button.Location = new System.Drawing.Point(posX, posY);//рисование кнопки
                button.Size = new System.Drawing.Size(30, 25);//задание размера кнопки
                this.Controls.Add(button);//добавление кнопки
                posX += button.Width;//ширина кнопки
                if ((i + 1) % 8 == 0)
                {
                    posX = 20;
                    posY += button.Height;//высота кнопки
                }
            }
            label2.Text = word;


        }
        private void button_Click(object sender, EventArgs e)
        {
            Button letter_btn = sender as Button;
            string guessedLetter = letter_btn.Text;
            bool isFind = false;
            for (int i = 0; i < word.Length; i++)
            {
                if(word[i] == guessedLetter[0])
                {
                    isFind = true;
                    if (i == 0)
                    {
                    
                        label2.Text = guessedLetter;
                        string temp = label1.Text.Remove(0, 1);

                        string ins = temp.Insert(0, guessedLetter);
                        label1.Text = ins;
                    }
                    else
                    {

                        string temp = label1.Text.Remove(2*i, 1);

                        string ins = temp.Insert(2 * i , guessedLetter);
                        label1.Text = ins;
                    }
                }
             }
            if (!isFind)
            {
                life++;
                switch (life)
                {

                    case 1:
                        {
                            pictureBox1.BackgroundImage = Properties.Resources.stage1;
                            break;
                        }
                    case 2:
                        {
                            pictureBox1.BackgroundImage = Properties.Resources.stage2;
                            break;
                        }
                    case 3:
                        {
                            pictureBox1.BackgroundImage = Properties.Resources.stage3;
                            break;
                        }
                    case 4:
                        {
                            pictureBox1.BackgroundImage = Properties.Resources.stage4;
                            break;
                        }
                    case 5:
                        {
                            pictureBox1.BackgroundImage = Properties.Resources.stage5;
                            break;
                        }
                    case 6:
                        {
                            pictureBox1.BackgroundImage = Properties.Resources.stage6;
                            break;
                        }
                    case 7:
                        {
                            pictureBox1.BackgroundImage = Properties.Resources.stage7;
                            break;
                        }
                    case 8:
                        {
                            pictureBox1.BackgroundImage = Properties.Resources.stage8;
                            gameover();
                            break;
                        }
                }

            }
            letter_btn.Enabled = false;
        }

        private void gameover()
        {
            MessageBox.Show("Game Over");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "* * * * * *";
            for (int i =0; i<32; i++)
            {
                (Controls["letterbutton" + i] as Button).Enabled = true;
            }
        }
    }
}
