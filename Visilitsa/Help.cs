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
            Form ifrm = new Game();
            ifrm.Show(); 
            this.Hide();
        }

        private void Help_Closed(object sender, FormClosedEventArgs e)
        {
            Form ifrm = new Menu();
            ifrm.Show();
        }
    }
}
