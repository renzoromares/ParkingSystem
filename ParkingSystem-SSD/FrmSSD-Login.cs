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
using System.Data.SqlClient;

namespace ParkingSystem_SSD
{
    public partial class FrmSSD_Login : Form
    {
        public FrmSSD_Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            validateLevel1();
        }

        private void validateLevel1()
        {
            if(!string.Equals(txtUsername.Text,"ID Number") && !string.Equals(txtUsername.Text,""))
            {
                if (!string.Equals(txtPassword.Text, "Password") && !string.Equals(txtPassword.Text, ""))
                {
                    validateLevel2();
                }
                else
                {
                    MessageBox.Show("Invalid credentials!");
                }
            }
            else
            {
                MessageBox.Show("Invalid credentials!");
            }

        }

        private void validateLevel2()
        {
            if(string.Equals(txtUsername.Text,User.username) && string.Equals(txtPassword.Text,User.password))
            {
                Visible = false;
                FrmSSD_Menu menu = new FrmSSD_Menu();
                menu.Show();
               
            }
            else
            {
                MessageBox.Show("Username or password is incorrect!");
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Visible = false;
            FrmMainMenu menu = new FrmMainMenu();
            menu.Show();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtPassword.isPassword = true;
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtUsername.Text = "usjrssd";
            txtPassword.Text = "usjrssd";
        }
    }
}
