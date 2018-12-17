using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace Visilitsa
{
    public partial class Game : Form
    {
        private string hidden_word = ""; // переменная, в которое будет храниться загаданное слово
        private int stage = 0; // переменная, информирующая о текущем этапе виселицы
        private int input_length = 0; // количество введенных букв, для проверки полностью введенного слова ( так как буквы в слове могут повторяться)

        public Game()
        {
            InitializeComponent();
        }

        private void Game_Shown(object sender, EventArgs e) // обработчик открытия формы Game
        {
            string str = "АБВГДЕЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ"; // переменная, содержащая алфавит
            int posX = 20, posY = 135; // начальные позиции первой строки букв
            for (int i = 0; i < str.Count(); i++)
            {
                Button button = new Button // добавление кнопок-букв на форму
                {
                    Name = "letterbutton" + i, 
                    Enabled = false, 
                    BackColor = Color.Transparent,
                    Font = new Font("Mistral", 14), 
                    Location = new System.Drawing.Point(posX, posY),
                    Size = new System.Drawing.Size(30, 25),
                    Text = str[i] + ""
                }; 
                button.Click += new EventHandler(this.Letter_Button_Click);
                this.Controls.Add(button); 
                posX += button.Width + 3;
                if ((i + 1) % 8 == 0)
                {
                    posX = 20;
                    posY += button.Height + 3;
                }
            }


        }
        private void Letter_Button_Click(object sender, EventArgs e) // обработчик нажатия на кнопку-букву
        {
            Button letter_btn = sender as Button; 
            string guessed_letter = letter_btn.Text; 
            bool is_find = false; 
            for (int i = 0; i < hidden_word.Length; i++)
            {
                if(hidden_word[i] == guessed_letter[0])
                {
                    is_find = true; 
                    input_length++; 
                    if (i == 0) 
                    {           
                    
                        string temp = label_for_word.Text.Remove(0, 1); 
                        temp = temp.Insert(0, guessed_letter);  
                        label_for_word.Text = temp;
                    }
                    else
                    {
                        string temp = label_for_word.Text.Remove(2 * i, 1);
                        temp = temp.Insert(2 * i , guessed_letter);
                        label_for_word.Text = temp;
                    }
                }
             }
            if (!is_find)
            {
                stage++; 
                switch (stage) 
                {

                    case 1:
                        {
                            pictureBox.BackgroundImage = Properties.Resources.stage1;
                            break;
                        }
                    case 2:
                        {
                            pictureBox.BackgroundImage = Properties.Resources.stage2;
                            break;
                        }
                    case 3:
                        {
                            pictureBox.BackgroundImage = Properties.Resources.stage3;
                            break;
                        }
                    case 4:
                        {
                            pictureBox.BackgroundImage = Properties.Resources.stage4;
                            break;
                        }
                    case 5:
                        {
                            pictureBox.BackgroundImage = Properties.Resources.stage5;
                            break;
                        }
                    case 6:
                        {
                            pictureBox.BackgroundImage = Properties.Resources.stage6;
                            break;
                        }
                    case 7:
                        {
                            pictureBox.BackgroundImage = Properties.Resources.stage7;
                            break;
                        }
                    case 8:
                        {
                            pictureBox.BackgroundImage = Properties.Resources.stage8;
                            break;
                        }
                    case 9:
                        {
                            Gameover(); 
                            break;
                        }
                }

            }
            if (input_length == hidden_word.Length)
            {
                Disable_All_Buttons(); 
                pictureBox.BackgroundImage = Properties.Resources.win; 
            }
            letter_btn.Enabled = false;
        }

        private int Count_Words() // функция подсчета слов в словаре
        {
            int count = 0;
            StreamReader sr = new StreamReader("Dictionary.txt");
            while (!sr.EndOfStream) 
                {
                    sr.ReadLine(); 
                }
                sr.Close(); 
            return count;
        }
        private void New_Game_Button_Click(object sender, EventArgs e) // обработчик нажатия кнопки "Новая игра"
        {
            pictureBox.BackgroundImage = Properties.Resources.start; 
            Random rnd = new Random(); 
            int value = rnd.Next(0, Count_Words()); 
            try 
            {     
                StreamReader sr = new StreamReader("Dictionary.txt");
                int j = 0; 
                while (!sr.EndOfStream && j != value) 
                {
                    hidden_word = sr.ReadLine();
                    j++; 
                }
                sr.Close();
                stage = 0; 
                input_length = 0; 
                label_for_word.Text = ""; 

                for (int i = 0; i < hidden_word.Length; i++)
                {
                    label_for_word.Text += "* ";  
                }
                if (label_for_word.Text == "") 
                {
                    New_Game_Button_Click(sender, e);
                }
                Enable_All_Buttons();
            }
            catch 
            {
                MessageBox.Show("Отсутствует словарь! Воспользуйтесь редактором");
            }
 
        }

        private void Game_Closed(object sender, FormClosedEventArgs e) // обработчик закрытия формы (выхода из игры)
        {
            Application.Exit(); 
        }

        private void Disable_All_Buttons() // функция "отключения" кнопок-букв
        {
            for (int i = 0; i < 32; i++) 
            {
                (Controls["letterbutton" + i] as Button).Enabled = false;
            }
        }

        private void Enable_All_Buttons() // функция "включения" кнопок-букв
        {
            for (int i = 0; i < 32; i++) 
            {
                (Controls["letterbutton" + i] as Button).Enabled = true;
            }
        }

        private void Gameover() // функция проигрыша
        {
            pictureBox.BackgroundImage = Properties.Resources.lose;
            label_for_word.Text = hidden_word; 
            Disable_All_Buttons(); 
        }

        private void Menu_Button_Click(object sender, EventArgs e) // обработчик нажатия кнопки "Меню"
        {
            Form ifrm = new Menu(); 
            ifrm.Show();  
            this.Hide(); 
        }

        private void Help_Button_Click(object sender, EventArgs e)  // обработчик нажатия кнопки "Правила"
        {
            Form ifrm = new Help();
            ifrm.Show(); 
        }
    }
}
