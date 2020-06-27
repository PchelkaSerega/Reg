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

namespace Авторизация
{
    public partial class Menu : Form
    {

        public Menu()
        {
            InitializeComponent();
        }


        private void ButLogin_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader sr = new StreamReader("user.txt"))
                {
                    string line = sr.ReadToEnd();
                    string[] array = line.Split("\r\n;".ToCharArray());
                    if ((TbLogin.Text == array[0] && TbPassword.Text == array[1]) || (TbLogin.Text == array[3] && TbPassword.Text == array[4]) ||
                    (TbLogin.Text == array[6] && TbPassword.Text == array[7]))
                    {
                        MessageBox.Show("Вход выполнен", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    else
                    {
                        throw new Exception();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Не все условия выполнены", "Information");
            }
        }

        private void ButReg_Click(object sender, EventArgs e)
        {
           
                RegMenu frm2 = new RegMenu();
            frm2.Show(this);
        }
    }
}


    

