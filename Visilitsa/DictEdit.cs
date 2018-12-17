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
        string selected = "";
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

        private void DictEdit_Load(object sender, EventArgs e)
        {
            try 
            {
                StreamReader sr = new StreamReader("words.txt");
                while (!sr.EndOfStream)
                {
                    Word_List.Items.Add(sr.ReadLine());
                }
                sr.Close();
            }
            catch
            {
                StreamWriter sw = new StreamWriter("words.txt", false);
                sw.Close();
            }
        }

        private void DictEdit_Closed(object sender, FormClosedEventArgs e)
        {
            StreamWriter sw = new StreamWriter("words.txt", false);
            for(int i = 0; i<Word_List.Items.Count; i++)
            {
                sw.WriteLine(Word_List.Items[i]);
            }
            sw.Close();
            Form ifrm = new Menu();
            ifrm.Show();
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            OK_button.Visible = true;
            Add_TextBox.Visible = true;
        }

        private void Del_Button_Click(object sender, EventArgs e)
        {
            try
            {
                Word_List.Items.Remove(selected);
            }
            catch
            {

            }
        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            Word_List.Items.Add(Add_TextBox.Text.ToUpper());
            Add_TextBox.Text = "";
            OK_button.Visible = false;
            Add_TextBox.Visible = false;
        }

        private void Word_List_Select(object sender, EventArgs e)
        {
            selected = Word_List.SelectedItem.ToString();
        }
    }
}
