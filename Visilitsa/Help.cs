using System;
using System.Windows.Forms;

namespace Visilitsa
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void Start_Button_Click(object sender, EventArgs e) // обработчик нажатия кнопки "Начать игру"
        {
            Form ifrm = new Game(); 
            ifrm.Show(); 
            this.Hide();
        }
    }
}
