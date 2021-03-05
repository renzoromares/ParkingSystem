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
    public partial class FrmRegisterSecurityGuard : Form
    {
        public FrmRegisterSecurityGuard()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
           validateFormLevel1();
        }

        private void validateFormLevel1()
        {
            if (!string.Equals(txtUsername.Text, "Username") && !string.Equals(txtUsername.Text,""))
            {
                if(!string.Equals(txtfname.Text,"First Name") && !string.Equals(txtfname.Text,""))
                {
                    if(!string.Equals(txtlname.Text, "Surname") && !string.Equals(txtlname.Text,""))
                    {
                        if(!string.Equals(txtPassword.Text,"") && !string.Equals(txtConfirmPass.Text,""))
                        {
                            if(string.Equals(txtPassword.Text,txtConfirmPass.Text))
                            {
                                bool checker = checkUsername();
                                if(checker == true)
                                {
                                    registerGuard();
                                    MessageBox.Show("Registration successful!");
                                    refresh();
                                }
                                else
                                {
                                    MessageBox.Show("Username already exist!");
                                }
                                
                            }
                            else{
                                MessageBox.Show("Password don't match!");
                            }
                        }
                        else{
                            MessageBox.Show("Please complete the details!");
                        }
                    }
                    else{
                        MessageBox.Show("Please complete the details!");
                    }
                }
                else{
                    MessageBox.Show("Please complete the details!");
                }
            }
            else{
                MessageBox.Show("Please complete the details!");
            }
            
            
        }

        private void refresh()
        {
            txtUsername.Text = "";
            txtfname.Text = "";
            txtlname.Text = "";
            txtPassword.Text = "";
            txtConfirmPass.Text = "";
        }



        private void registerGuard()
        {

            using (SqlConnection conn = new SqlConnection(ConnectionString.connect))
            {
                conn.Open();
                string query = "INSERT INTO Security_Staff VALUES(@FirstName" +
                                                                ",@LastName" +
                                                                ",@Username" +
                                                                ",@Password" +
                                                                ",@Status)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {

                    

                    cmd.Parameters.AddWithValue("@FirstName",txtfname.Text);
                    cmd.Parameters.AddWithValue("@LastName", txtlname.Text);
                    cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@Status", 0);
                    cmd.ExecuteNonQuery();
                    conn.Close();

                }
            }
        }


        private bool checkUsername()
        {
            bool isValidator = false;
            using (SqlConnection conn = new SqlConnection(ConnectionString.connect))
            {

                try
                {
                    string query = "SELECT * FROM Security_Staff WHERE Username = '" + txtUsername.Text + "'  ";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            isValidator = false;
                        }
                        else
                        {
                            isValidator = true;
                        }
                        reader.Close();
                        conn.Close();

                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                    conn.Close();
                }

            }

            return isValidator;
        }
        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtPassword.isPassword = true;

        }

        private void txtConfirmPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtConfirmPass.isPassword = true;
        }

        private void FrmRegisterSecurityGuard_Load(object sender, EventArgs e)
        {

        }
    }
}
