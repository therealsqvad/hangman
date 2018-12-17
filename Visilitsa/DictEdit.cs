using System;
using System.Windows.Forms;
using System.IO;

namespace Visilitsa
{
    public partial class DictEdit : Form
    {
        string selected = ""; //переменная, в которой выбранное слово хранится
        public DictEdit()
        {
            InitializeComponent();
        }

        private void Start_Button_Click(object sender, EventArgs e)  // обработчик нажатия кнопки "Начать игру"
        {
            Form ifrm = new Game();
            ifrm.Show();
            this.Hide();
        }

        private void Help_Button_Click(object sender, EventArgs e)  // обработчик нажатия кнопки "Правила"
        {
            Form ifrm = new Help();
            ifrm.Show();
            this.Hide();
        }

        private void DictEdit_Load(object sender, EventArgs e) // обработчик загрузки формы
        {
            try 
            {
                StreamReader sr = new StreamReader("Dictionary.txt"); // чтение файла и вывод слов на экран
                while (!sr.EndOfStream)
                {
                    Word_List.Items.Add(sr.ReadLine());
                }
                sr.Close();
            }
            catch
            {
                StreamWriter sw = new StreamWriter("Dictionary.txt", false); // создание файла, если отсутствовал
                sw.Close();
            }
        }

        private void DictEdit_Closed(object sender, FormClosedEventArgs e) // обработчик закрытия формы и сохранение словаря в файл
        {                                                                   
            try 
            {
                StreamWriter sw = new StreamWriter("Dictionary.txt", false);    
                for (int i = 0; i < Word_List.Items.Count; i++)
                {
                    sw.WriteLine(Word_List.Items[i]);
                }
                sw.Close();
                Form ifrm = new Menu();
                ifrm.Show();
            }
            catch
            {
                MessageBox.Show("Ошибка при сохранении файла");
            }
        }

        private void Add_Button_Click(object sender, EventArgs e)  // обработчик нажатия кнопки "Добавить"
        {
            OK_button.Visible = true; 
            Add_TextBox.Visible = true;
        }

        private void Del_Button_Click(object sender, EventArgs e)  // обработчик нажатия кнопки "Удалить"
        {
            try
            {
                Word_List.Items.Remove(selected); 
            }
            catch
            {
                 
            }
        }

        private void OK_Button_Click(object sender, EventArgs e)  // обработчик нажатия кнопки "ОК" и добавление слова в коллекцию ListBox
        {
            Word_List.Items.Add(Add_TextBox.Text.ToUpper()); 
            Add_TextBox.Text = ""; 
            OK_button.Visible = false; 
            Add_TextBox.Visible = false;
        }

        private void Word_List_Select(object sender, EventArgs e)  // обработчик выбора слова в ListBox
        {
            selected = Word_List.SelectedItem.ToString(); 
        }
    }
}
