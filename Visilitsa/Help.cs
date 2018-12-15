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
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void Help_Closed(object sender, FormClosedEventArgs e) // событие закрытия формы, то есть если ты нажмешь крестик в правилах, то откроется меню
        {
            Form ifrm = new Menu();
            ifrm.Show();
        }

        private void Start_Button_Click(object sender, EventArgs e)
        {
            Form ifrm = new Game(); // создаем форму Game, необходимо для того, чтобы её отобразить
            ifrm.Show();  // показываем форму Game
            this.Hide(); // скрываем текущую, чтобы не получилось 2 окна
        }
    }
}
