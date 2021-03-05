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
    public partial class FrmGuest_Register : Form
    {
        public FrmGuest_Register()
        {
            InitializeComponent();
        }

        private void FrmGuest_Register_Load(object sender, EventArgs e)
        {
           
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            verifyRegistration();
        }

        private void verifyRegistration()
        {
            try
            {

                bool checker = checkValidation();
                if (checker == true)
                {
                    bool isDuplicateID = checkDuplicateID();
                    if (isDuplicateID == true)
                    {
                        save2Registration();
                        MessageBox.Show("Registration Successful!");
                        refresh();
                    }
                    else
                    {
                        MessageBox.Show("Id already registered!");

                    }
                }
                else
                {
                    MessageBox.Show("Please complete the registration!");
                }

            }
            catch
            {
                MessageBox.Show("Please complete the registration!");
            }
        }

        private bool checkDuplicateID()
        {
            bool isValidator = false;
            using (SqlConnection conn = new SqlConnection(ConnectionString.connect))
            {

                try
                {
                    string query = "SELECT * FROM VEHICLE_OWNER WHERE Id_Number = '" + txtIdNumber.Text + "'  ";
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

        private bool checkValidation()
        {

            bool isValidator = false;
            if (!string.Equals(txtIdNumber.Text, "ID Number") && !string.Equals(txtIdNumber.Text, ""))
            {
                if (string.Equals(txtPassword.Text, txtConfirmPass.Text))
                {
                    if (!string.Equals(txtfname.Text, "First Name") && !string.Equals(txtfname.Text, ""))
                    {
                        if (!string.Equals(txtlname.Text, "Surname") && !string.Equals(txtlname.Text, ""))
                        {
                            if (!string.Equals(txtContact.Text, ""))
                            {
                                if (txtContact.Text.Length == 10)
                                {
                                    if (!string.Equals(txtDepartment.Text, "Department") && !string.Equals(txtDepartment.Text, ""))
                                    {
                                        if (cmbPosition.selectedIndex != -1)
                                        {

                                            isValidator = true;

                                        }
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Invalid Phone number!");
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Password don't match!");
                    isValidator = false;
                }
            }
            else
            {

                isValidator = false;

            }
            return isValidator;


        }
        private void refresh()
        {
            txtIdNumber.Text = "";
            txtfname.Text = "";
            txtlname.Text = "";
            txtDepartment.Text = "";
            txtContact.Text = "";
            txtPassword.Text = "";
            txtConfirmPass.Text = "";
            cmbPosition.selectedIndex = -1;
        }

        private void save2Registration()
        {

            using (SqlConnection conn = new SqlConnection(ConnectionString.connect))
            {
                conn.Open();
                try
                {
                    string query = "INSERT INTO VEHICLE_OWNER VALUES(@Id_Number," +
                                                                   "@FirstName," +
                                                                   "@LastName," +
                                                                   "@Position," +
                                                                   "@Contacts," +
                                                                   "@Department," +
                                                                   "@Password," +
                                                                   "@Status)";


                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {

                        cmd.Parameters.AddWithValue("@Id_Number", txtIdNumber.Text);
                        cmd.Parameters.AddWithValue("@FirstName", txtfname.Text);
                        cmd.Parameters.AddWithValue("@LastName", txtlname.Text);
                        cmd.Parameters.AddWithValue("@Position", cmbPosition.selectedValue.ToString());
                        cmd.Parameters.AddWithValue("@Contacts", "+63" + "" + txtContact.Text);
                        cmd.Parameters.AddWithValue("@Department", txtDepartment.Text);
                        cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                        cmd.Parameters.AddWithValue("@Status", 0);

                        cmd.ExecuteNonQuery();
                        conn.Close();

                    }

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                    conn.Close();
                }
            }

        }

        private void txtIdNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtfname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar);
        }

        private void txtlname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar);
        }

        private void txtDepartment_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar);
        }

        private void txtContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtPassword.isPassword = true;
        }

        private void txtConfirmPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtConfirmPass.isPassword = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Visible = false;
            FrmGuest_Login login = new FrmGuest_Login();
            login.Show();
        }

        private void txtContact_Enter(object sender, EventArgs e)
        {
            txtCountryCode.LineIdleColor = Color.FromArgb(2, 48, 15);
        }

        private void txtContact_MouseLeave(object sender, EventArgs e)
        {
            txtCountryCode.LineIdleColor = Color.Gray;
        }

        /* Renzo N. Romares C# Devoper - USJR PARKING MANAGEMENT RRJL - RENZO ROBERT JANICSEL AGENT JANI**/
    }
}
