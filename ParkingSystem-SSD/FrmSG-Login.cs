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
    public partial class FrmSG_Login : Form
    {
        public FrmSG_Login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FrmSG_Login_Load(object sender, EventArgs e)
        {
            txtUsername.Text = "pabloescobar";
            txtPassword.Text = "123";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
             validateLevel1();
            
        }

        private void validateLevel1()
        {

            if (!string.Equals(txtUsername.Text, "Username") && !string.Equals(txtUsername.Text, ""))
            {
                if (!string.Equals(txtPassword.Text, "Password") && !string.Equals(txtPassword.Text, ""))
                {
                    validateLevel2();
                }
                else
                {
                    MessageBox.Show("Invalid Credentials!");
                }
            }
            else
            {
                MessageBox.Show("Invalid Credentials!");
            }
        }

        private void validateLevel2()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString.connect))
            {

                try
                {
                    conn.Open();

                    string query = "SELECT * FROM Security_Staff WHERE Username='" + txtUsername.Text + "' and Password = '" + txtPassword.Text + "' ";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                var userID = reader.GetValue(0).ToString();
                                var username = reader.GetValue(3).ToString();
                                var password = reader.GetValue(4).ToString();
                                var lastname = reader.GetValue(2).ToString();
                                validateLevel3(userID, username, password, lastname);
                            }
                            reader.Close();
                        }
                        else
                        {
                            conn.Close();
                            MessageBox.Show("Username or password is incorrect!");
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

            
        }

        private void validateLevel3(string userID, string username, string password, string lastname)
        {
            if (string.Equals(txtUsername.Text, username) && (string.Equals(txtPassword.Text, password)))
            {
                User.lastname = lastname;
                User.userID = userID;
                Visible = false;
                FrmSG_Menu menu = new FrmSG_Menu();
                menu.Show();
                 
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
    }
}
