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
    public partial class FrmGuest_UpdateAccount : Form
    {
        public FrmGuest_UpdateAccount()
        {
            InitializeComponent();
        }

        private void FrmGuest_UpdateAccount_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString.connect))
            {

                try
                {
                    conn.Open();

                    string query = "SELECT Id_Number" +
                                         ",FirstName" +
                                         ",LastName" +
                                         ",Position" +
                                         ",Contacts" +
                                         ",Department" +
                                         ",Password FROM " +
                                         "VEHICLE_OWNER WHERE Id_Number = '"+User.ownerID+"' ";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                txtIdNumber.Text = reader.GetValue(0).ToString();
                                txtfname.Text = reader.GetValue(1).ToString().ToUpper();
                                txtlname.Text = reader.GetValue(2).ToString().ToUpper();
                                txtPosition.Text = reader.GetValue(3).ToString();
                                string result = getNumber(reader.GetValue(4).ToString());
                                txtContact.Text = result;
                                txtDepartment.Text = reader.GetValue(5).ToString().ToUpper();
                                txtPassword.Text = reader.GetValue(6).ToString();
                                txtConfirmPass.Text = reader.GetValue(6).ToString();
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

        private void save2Registration()
        {

            using (SqlConnection conn = new SqlConnection(ConnectionString.connect))
            {
                conn.Open();
                string query = "UPDATE VEHICLE_OWNER SET FirstName=@FirstName" +
                                                        ",LastName=@LastName" +
                                                        ",Contacts=@Contacts" +
                                                        ",Department=@Department" +
                                                        ",Password=@Password WHERE Id_Number = @Id_Number";
                try
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))

                    {

                        int id = Convert.ToInt32(txtIdNumber.Text);

                        cmd.Parameters.AddWithValue("@Id_Number", txtIdNumber.Text);
                        cmd.Parameters.AddWithValue("@FirstName", txtfname.Text);
                        cmd.Parameters.AddWithValue("@LastName", txtlname.Text);
                        cmd.Parameters.AddWithValue("@Contacts", "+63" + "" + txtContact.Text);
                        cmd.Parameters.AddWithValue("@Department", txtDepartment.Text);
                        cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        panelContainer.Visible = true;
                        MessageBox.Show("Update Successful!");


                    }
                }
                catch
                {
                    MessageBox.Show("Invalid details!");

                }

            }
        }

        private string getNumber(string number)
        {
            char[] array = new char[number.Length];
            array = number.ToCharArray();

            string result = string.Empty;
            for (int i = 3; i < array.Length; i++)
            {
                result += array[i];
            }
            return result;
        }

        private bool checkValidation()
        {

            bool checker = false;
            if (!string.Equals(txtfname.Text, "") || !string.Equals(txtfname.Text, "First Name"))
            {
                if (!string.Equals(txtlname.Text, "") || !string.Equals(txtlname.Text, "Surname"))
                {
                    if (!string.Equals(txtDepartment.Text, "") || !string.Equals(txtDepartment.Text, "Department"))
                    {
                        if (!string.Equals(txtContact.Text, "") && txtContact.Text.Length == 10)
                        {
                            if (string.Equals(txtPassword.Text, txtConfirmPass.Text))
                            {
                                checker = true;
                            }
                            else
                            {
                                MessageBox.Show("Password don't match!");
                            }

                        }

                    }
                }
            }
            return checker;
        }



        private void btnEdit_Click(object sender, EventArgs e)
        {
            panelContainer.Enabled = true;
            btnUpdate.Enabled = true;
            btnEdit.Enabled = false;

        }

        private void refresh()
        {
            btnEdit.Enabled = true;
            panelContainer.Enabled = false;
            btnUpdate.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool checker = checkValidation();
            if(checker)
            {
                refresh();
                save2Registration();
                loadData();
            }
            else
            {
                MessageBox.Show("Please complete the details!");
            }
            
        }



        private void txtContact_KeyPress(object sender, KeyPressEventArgs e)
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

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panelContainer.ClientRectangle, Color.Gray, ButtonBorderStyle.Solid);
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtPassword.isPassword = true;
        }

        private void txtConfirmPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtConfirmPass.isPassword = true;
        }
    }
}
