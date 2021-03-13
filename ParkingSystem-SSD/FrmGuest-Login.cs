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
    public partial class FrmGuest_Login : Form
    {
        public FrmGuest_Login()
        {
            InitializeComponent();
        }

        private void FrmGuest_Login_Load(object sender, EventArgs e)
        {

        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtPassword.isPassword = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            validate();
        }

        private void validate()
        {
            if (!string.Equals(txtIdNumber.Text, "") && !string.Equals(txtIdNumber.Text, "Id Number"))
            {
                if (!string.Equals(txtPassword.Text, "") && !string.Equals(txtPassword.Text, "Password"))
                {
                    validateCredentials();
                }
                else
                {
                    MessageBox.Show("Invalid Credentails!");
                }
            }
            else
            {
                MessageBox.Show("Invalid Credentials!");
            }

        }

        private void validateCredentials()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString.connect))
            {

                try
                {
                    conn.Open();

                    string query = "SELECT * FROM VEHICLE_OWNER WHERE Id_NUmber ='" + txtIdNumber.Text + "' and Password = '" + txtPassword.Text + "'";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                if (string.Equals(reader.GetValue(7).ToString(), "1"))
                                {
                                    User.ownerID = reader.GetValue(0).ToString();
                                    User.fullName = reader.GetValue(1).ToString() + " " + reader.GetValue(2).ToString();
                                    User.status = reader.GetValue(3).ToString();
                                    User.phone = reader.GetValue(4).ToString();
                                    openMenu();
                                }
                                else if(string.Equals(reader.GetValue(7).ToString(), "0"))
                                {
                                    MessageBox.Show("Account application Pending!");
                                }
                                else if (string.Equals(reader.GetValue(7).ToString(), "2"))
                                {
                                    MessageBox.Show("Account application Disapproved!");
                                }

                            }
                            reader.Close();
                        }
                        else
                        {
                            conn.Close();
                            MessageBox.Show("Account don't Exist!");
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void openMenu()
        {
            Visible = false;
            FrmGuest_Menu menu = new FrmGuest_Menu();
            menu.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            Visible = false;
            FrmMainMenu menu = new FrmMainMenu();
            menu.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Visible = false;
            FrmGuest_Register register = new FrmGuest_Register();
            register.Show();
        }

        private void txtIdNumber_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
