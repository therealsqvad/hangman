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

       

        private void button1_Click(object sender, EventArgs e)
        {
            Form ifrm = new Menu();
            ifrm.Show(); // отображаем Form2
            this.Hide(); // скрываем Form1 (this - текущая форма)
        }
    }
}
