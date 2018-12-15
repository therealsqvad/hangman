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
    public partial class Menu : Form
    {
        public Menu()
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
    }
}
