using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void login_Click(object sender, EventArgs e)
        {
            StreamReader streamReader = new StreamReader(path: "Users.txt");
            string line = string.Empty;
            bool ok = false;
            do
            {
                line = streamReader.ReadLine();
                if (line != null)
                {
                    string[] vs = line.Split(' ');
                    if (vs[0] == username.Text)
                    {
                        if (vs[1] == password.Text)
                        {
                            this.Hide();
                            Form2 f2 = new Form2();
                            f2.ShowDialog();
                            this.Close();
                            ok = true;
                            break;
                        }
                    }
                }
            } while (line != null);
            if (ok == false)
            {
                MessageBox.Show("Wrong username or password");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

