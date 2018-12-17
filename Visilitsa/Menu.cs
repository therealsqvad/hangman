using System;
using System.Windows.Forms;

namespace Visilitsa
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Start_Button_Click(object sender, EventArgs e) // обработчик нажатия кнопки "Начать игру"
        {
            Form ifrm = new Game();
            ifrm.Show();
            this.Hide();
        }

        private void Help_Button_Click(object sender, EventArgs e) // обработчик нажатия кнопки "Правила"
        {
            Form ifrm = new Help();
            ifrm.Show();
        }

        private void Menu_Closed(object sender, FormClosedEventArgs e) // обработчик закрытия программы
        {
            Application.Exit();
        }

        private void DictEdit_Button_Click(object sender, EventArgs e) // обработчик нажатия кнопки "Редактор"
        {
            Form ifrm = new DictEdit();
            ifrm.Show();
            this.Hide();
        }
    }
}
