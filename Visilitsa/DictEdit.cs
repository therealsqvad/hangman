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
    public partial class DictEdit : Form
    {
        string selected = ""; //переменная в которой выбранное слово хранится
        public DictEdit()
        {
            InitializeComponent();
        }

        private void Start_Button_Click(object sender, EventArgs e)
        {
            Form ifrm = new Game();
            ifrm.Show();
            this.Hide();
        }

        private void Help_Button_Click(object sender, EventArgs e)
        {
            Form ifrm = new Help();
            ifrm.Show();
            this.Hide();
        }

        private void DictEdit_Load(object sender, EventArgs e) // обработка загрузки формы , то есть когда форма открывается только
        {
            try  // делаем попытку открыть файл для чтения словаря, если невозможно (то есть файла нет или он сразу пуст, то создаем файл в блоке catch
            {
                StreamReader sr = new StreamReader("Dictionary.txt");
                while (!sr.EndOfStream)
                {
                    Word_List.Items.Add(sr.ReadLine());
                }
                sr.Close();
            }
            catch
            {
                StreamWriter sw = new StreamWriter("Dictionary.txt", false); // если файла не было, то создается пустой файл с названием Dictionary, а в него через редактор сохраняются слова
                sw.Close();
            }
        }

        private void DictEdit_Closed(object sender, FormClosedEventArgs e) // момент закрытия формы. Логика такая: при  переходе в редактор слова из файла загружаются в listbox на экране
        {                                                                   //далее ты добавляешь и удаляешь слова именно из коллекции в listbox, файл пока не меняется
            try // все действия с файлами желательно оборачивать в try / catch
            {
                StreamWriter sw = new StreamWriter("Dictionary.txt", false);    // а когда ты закрываешь редактор - все что было в listbox сохраняется в файл, false означает, что файл не дозаписывается, а перезаписывается в любом случае
                for (int i = 0; i < Word_List.Items.Count; i++) // то есть по количеству элементов в листбокс каждый элемент сохраняется в строчку в файле
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

        private void Add_Button_Click(object sender, EventArgs e)
        {
            OK_button.Visible = true; // отображаем на форме текстовое поле и кнопку ок
            Add_TextBox.Visible = true;
        }

        private void Del_Button_Click(object sender, EventArgs e)
        {
            try
            {
                Word_List.Items.Remove(selected); //удаляем выбранное слово
            }
            catch
            {
                 // ничего не делаем, если такого слова нет или не было выбрано ничего из listbox
            }
        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            Word_List.Items.Add(Add_TextBox.Text.ToUpper()); // добавляем то, что было введено в коллекцию листбокса . обязательно делаем ToUpper, это приводит к верхнему РЕГИСТРУ
            Add_TextBox.Text = ""; // очищаем поле ввода
            OK_button.Visible = false; // скрываем кнопку и поле ввода для красоты
            Add_TextBox.Visible = false;
        }

        private void Word_List_Select(object sender, EventArgs e)
        {
            selected = Word_List.SelectedItem.ToString(); // когда выделяешь что то в листбокс - оно сохраняется в переменную селектед
        }
    }
}
