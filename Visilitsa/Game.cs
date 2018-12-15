using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Visilitsa
{
    public partial class Game : Form
    {
        private string hidden_word = ""; // инициализация переменной под слово
        private int stage = 0; // жизни, точнее этапы виселицы
        private int input_length = 0; // количество введенных букв, для проверки на победу ( так как буквы в слове могут повторяться)

        public Game()
        {
            InitializeComponent();
        }

        private void Game_Shown(object sender, EventArgs e)
        {
            string str = "АБВГДЕЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ"; // строковая перем. с алфавитом
            int posX = 20, posY = 135; // начальные позиции первой строки букв
            for (int i = 0; i < str.Count(); i++) //создание цикла
            {
                Button button = new Button // создание кнопки
                {
                    Name = "letterbutton" + i, // задаем название кнопки вида letterbutton1 .. letterbutton32 (кнопок будет 32, так как нет буквы ё)
                    Enabled = false, // изначально кнопка неактивна, пока не запустишь игру
                    BackColor = Color.Transparent, // цвет кнопки 
                    Font = new Font("Mistral", 14), // шрифт
                    Location = new System.Drawing.Point(posX, posY), // позиция кнопки
                    Size = new System.Drawing.Size(30, 25), // задание размера кнопки
                    Text = str[i] + ""//присваивает значение след.буквы
                }; 
                button.Click += new EventHandler(this.Letter_Button_Click); // связываем с методом button_click
                this.Controls.Add(button); // добавление кнопки на форму
                posX += button.Width + 3;// смещение позиции для следующей кнопки
                if ((i + 1) % 8 == 0)
                {
                    posX = 20;
                    posY += button.Height + 3;//высота кнопки
                }
            }


        }
        private void Letter_Button_Click(object sender, EventArgs e)
        {
            Button letter_btn = sender as Button; // получаем кнопку, которую нажали. то есть у нас один обработчик для всех кнопок и этой строчкой мы даем понять какая именно буква нажата
            string guessed_letter = letter_btn.Text; // кладем в строковую переменную букву, которую нажали
            bool is_find = false; // флаг найдено ли, нужен для того, чтобы понять найдена ли буква в слове вообще
            for (int i = 0; i < hidden_word.Length; i++) // пробегаемся в цикле по слову
            {
                if(hidden_word[i] == guessed_letter[0]) // сравниваем каждую букву слова с нажатой
                {
                    is_find = true; // если нашли - меняем флажок
                    input_length++; // количество введенных букв увеличиваем (чтобы потом понять, что слово отгадано полностью) 
                    if (i == 0) // так как у нас в label выводится все в виде * * * чтобы понятно было количество букв, а не сливались звездочки , 1 буква будет на позиции 0
                    {               // а вторая буква на позиции 2, поэтому мы нулевую позицию рассматриваем отдельно, а дальше 2*i
                    
                        string temp = label_for_word.Text.Remove(0, 1); // строковые переменные неизменяемые, поэтому мы не можем как в С++ сделать str[2] = "Y" чтобы поменять какую то букву в слове
                        temp = temp.Insert(0, guessed_letter);  // нам необходимо удалить букву с позиции, а на эту позицию вставить новую букву, для этого создаем переменную temp
                        label_for_word.Text = temp; // а уже измененную строку выводим на экран. типа нажали Л было  * * * -> удалили * добавили Л получили Л * * 
                    }
                    else // как писал выше , все то же самое, только для позиции 2*i (потому что между звездочками пробел)
                    {
                        string temp = label_for_word.Text.Remove(2 * i, 1);
                        temp = temp.Insert(2 * i , guessed_letter);
                        label_for_word.Text = temp;
                    }
                }
             }
            if (!is_find) // если не найдена буква в слове, то рисуется часть виселицы
            {
                stage++; // увеличиваем этап так сказать
                switch (stage) // через switch выбираем какое изображение вывести
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
                            Gameover(); // если уже 9 стадия, то все, геймовер 
                            break;
                        }
                }

            }
            if (input_length == hidden_word.Length) // если введенное количество достигло длины загаданного слова, то победа
            {
                Disable_All_Buttons(); // все кнопки отключаем
                pictureBox.BackgroundImage = Properties.Resources.win; // а изображение ставим победное
            }
            letter_btn.Enabled = false; // "выключаем" нажатую кнопку, чтобы не нажимать её повторно
        }

        private void New_Game_Button_Click(object sender, EventArgs e) // обработчик кнопки новая игра
        {
            pictureBox.BackgroundImage = Properties.Resources.start; // выводим лого , ну просто так
            Random rnd = new Random(); // создаем генератор 
            int value = rnd.Next(0, 45); // генерируем случайное число от 0 до 45, это количество слов в словаре. если будет время и придумаю как оптимально сделать - сделаю автоматические расчет
            try // вот тут уже начинается интересное: try - это блок попытка, то есть программа попытается выполнить все это, но если например файла нет , или сгенерированное число больше 
            {       // количества строк, то выбрасываем исключение
                StreamReader sr = new StreamReader("words.txt"); // ну это стандартное открытие файла в си#
                int j = 0; // текущая строка
                while (!sr.EndOfStream && j != value) // пока не конец файла и не дошли до случайной строки - делаем цикл
                {
                    hidden_word = sr.ReadLine(); // читаем строку, а указатель переместится на следующую. на следующем шаге прочитаем вторую и тд
                    j++; // итерируем число, чтобы достигнуть случайного
                }
                sr.Close(); // ОБЯЗАТЕЛЬНО закрываем файл
                stage = 0; // сбрасываем счетчик стадий
                input_length = 0; // сбрасываем счетчик введенных букв
                label_for_word.Text = ""; // очищаем лейбл под слово

                for (int i = 0; i < hidden_word.Length; i++)
                {
                    label_for_word.Text += "* "; // выводи "* " по количеству букв в слове ) 
                }
                if (label_for_word.Text == "") // несколько раз замечал, что игра запускалась с пустым словом, не знаю как, но вот так, видимо из файла считывала пустую строку
                {
                    New_Game_Button_Click(sender, e); // поэтому пересоздаем игру с теми же аргументами
                }
                Enable_All_Buttons(); // включаем все кнопки, чтобы можно было тыкать
            }
            catch 
            {
                MessageBox.Show("Файла нет!"); // если файла нет, выбрасываем исключение, что файла нет . если останется время, сделаю, чтобы создавался тогда файл с 5 словами, например
            }
 
        }

        private void Game_Closed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); // это нужно для того, чтобы когда ты из игры нажмешь крестик - процесс завершился
        }

        private void Disable_All_Buttons()
        {
            for (int i = 0; i < 32; i++) // перебираем все буквы и получается оставшиеся делаем неактивными , то есть чтобы нельзя было во время не игры тыкать кнопочки
            {
                (Controls["letterbutton" + i] as Button).Enabled = false;
            }
        }

        private void Enable_All_Buttons()
        {
            for (int i = 0; i < 32; i++) // перебираем все буквы и делаем активными , то есть чтобы можно было во время игры тыкать кнопочки
            {
                (Controls["letterbutton" + i] as Button).Enabled = true;
            }
        }

        private void Gameover() // функция проигрыша
        {
            pictureBox.BackgroundImage = Properties.Resources.lose; // устанавливаем изображение проигрыш
            label_for_word.Text = hidden_word; // выводим исходное слово
            Disable_All_Buttons(); // отключаем кнопочки
        }
    }
}
