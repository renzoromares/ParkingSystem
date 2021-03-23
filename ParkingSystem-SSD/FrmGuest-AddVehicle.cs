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
    public partial class FrmGuest_AddVehicle : Form
    {
        public FrmGuest_AddVehicle()
        {
            InitializeComponent();
        }

        private void FrmGuest_AddVehicle_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            validation();
            if (validation() == true)
            {
                checkDuplicatePlateID();
                if (checkDuplicatePlateID() == true)
                {
                    registeredVehicle();
                    if (string.Equals(User.status, "Student") && registeredVehicle() == true)
                    {
                        save2Credential();
                        encode();
                        refresh();
                        MessageBox.Show("Registration Successful!");
                    }
                    else if (string.Equals(User.status, "Staff"))
                    {
                        save2Credential();
                        encode();
                        refresh();
                        MessageBox.Show("Registration Successful!");
                    }
                    else if (string.Equals(User.status, "Faculty"))
                    {
                        save2Credential();
                        encode();
                        refresh();
                        MessageBox.Show("Registration Successful!");
                    }
                    else
                    {
                        MessageBox.Show("Student can only register 1 Vehicle!");
                    }

                }
                else
                {
                    MessageBox.Show("Plate number already exist!");
                }

            }
            else
            {
                MessageBox.Show(" Please Complete Registration");
            }
        }

        public void encode()
        {
            System.Diagnostics.ProcessStartInfo start = new System.Diagnostics.ProcessStartInfo();
            start.FileName = @"E:\Encoding\venv\Scripts\python.exe";
            start.Arguments = string.Format("{0} {1} {2}", @"E:\Encoding\main.py", txtFaceImage.Text, User.ownerID);
            start.UseShellExecute = false;
            start.CreateNoWindow = true;
            start.RedirectStandardOutput = true;
            start.RedirectStandardError = true;
            start.LoadUserProfile = true;
            using (System.Diagnostics.Process process = System.Diagnostics.Process.Start(start))
            {
                using (StreamReader reader = process.StandardOutput)
                {
                    string stderr = process.StandardError.ReadToEnd();
                    string result = reader.ReadToEnd();
                    Console.WriteLine(result);
                    Console.WriteLine(stderr);
                }
            }
        }

        public bool validation()
        {
            bool validator = false;
            if (!string.Equals(txtPlateNumber.Text, "Plate Number") && !string.Equals(txtPlateNumber.Text, ""))
            {
                if (!string.Equals(txtVehicleModel.Text, "Vehicle Model") && !string.Equals(txtVehicleModel.Text, ""))
                {
                    if (!string.Equals(txtCarmake.Text, "Car make") && !string.Equals(txtCarmake.Text, ""))
                    {
                        if (!string.Equals(txtVehicleColor.Text, "Color") && !string.Equals(txtVehicleColor.Text, ""))
                        {
                            if (cmbVehicleType.selectedIndex != -1)
                            {
                                if (!string.Equals(txtFaceImage.Text, "Face Image"))
                                {
                                    if (!string.Equals(txtOfficialReceipt.Text, "Official Receipt") && !string.Equals(txtOfficialReceipt.Text, ""))
                                    {
                                        if (!string.Equals(txtCR.Text, "Certificate of Registration"))
                                        {
                                            validator = true;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return validator;
        }

        public bool checkDuplicatePlateID()
        {
            bool isValidator = false;
            using (SqlConnection conn = new SqlConnection(ConnectionString.connect))
            {

                try
                {
                    string query = "SELECT * FROM cREDENTIALS WHERE PlateID = '" + txtPlateNumber.Text.ToUpper() + "'  ";
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

        public bool registeredVehicle()
        {
            bool isValidator = false;
            using (SqlConnection conn = new SqlConnection(ConnectionString.connect))
            {

                try
                {
                    string query = "SELECT * FROM cREDENTIALS WHERE Id_Number = '" + User.ownerID + "'  ";
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

        public void refresh()
        {
            txtPlateNumber.Text = "";
            txtVehicleModel.Text = "";
            txtCarmake.Text = "";
            txtVehicleColor.Text = "";
            cmbVehicleType.selectedIndex = -1;
            txtFaceImage.Text = "";
            txtOfficialReceipt.Text = "";
            txtCR.Text = "";
        }
        private void save2Credential()
        {

            using (SqlConnection conn = new SqlConnection(ConnectionString.connect))
            {
                string query = "INSERT INTO CREDENTIALS VALUES(@PlateID," +
                                                                "@Vehicle_Type," +
                                                                "@Vehicle_Model," +
                                                                "@Vehicle_Carmake," +
                                                                "@Vehicle_Color," +
                                                                "@Official_Receipt, " +
                                                                "@Cert_Registration," +
                                                                "@Face_Image," +
                                                                "@Status," +
                                                                "@Time_Submitted," +
                                                                "@Time_Approved," +
                                                                "@Time_Due," +
                                                                "@Id_Number)";



                using (SqlCommand cmd = new SqlCommand(query, conn))
                {

                    conn.Open();
                    try
                    {
                        byte[] img = null;
                        FileStream fs = new FileStream(txtFaceImage.Text.ToString(), FileMode.Open, FileAccess.Read);
                        BinaryReader br = new BinaryReader(fs);
                        img = br.ReadBytes((int)fs.Length);


                        byte[] img1 = null;
                        FileStream fs1 = new FileStream(txtOfficialReceipt.Text.ToString(), FileMode.Open, FileAccess.Read);
                        BinaryReader br1 = new BinaryReader(fs1);
                        img1 = br1.ReadBytes((int)fs1.Length);


                        byte[] img2 = null;
                        FileStream fs2 = new FileStream(txtCR.Text.ToString(), FileMode.Open, FileAccess.Read);
                        BinaryReader br2 = new BinaryReader(fs2);
                        img2 = br2.ReadBytes((int)fs2.Length);

                        cmd.Parameters.AddWithValue("@PlateID", txtPlateNumber.Text.ToUpper());
                        cmd.Parameters.AddWithValue("@Vehicle_Type", cmbVehicleType.selectedValue.ToString());
                        cmd.Parameters.AddWithValue("@Vehicle_Model", txtVehicleModel.Text);
                        cmd.Parameters.AddWithValue("@Vehicle_Carmake", txtCarmake.Text);
                        cmd.Parameters.AddWithValue("@Vehicle_Color", txtVehicleColor.Text);
                        cmd.Parameters.AddWithValue("@Official_Receipt", img1);
                        cmd.Parameters.AddWithValue("@Cert_Registration", img2);
                        cmd.Parameters.AddWithValue("@Face_Image", img);
                        cmd.Parameters.AddWithValue("@Status", 0);
                        cmd.Parameters.AddWithValue("@Time_Submitted", DateTime.Now.ToShortDateString());
                        cmd.Parameters.AddWithValue("@Time_Approved", "");
                        cmd.Parameters.AddWithValue("@Time_Due", "");
                        cmd.Parameters.AddWithValue("@Id_Number", User.ownerID);


                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }


                }
            }
        }

        private void btnAddFace_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "(*.jpg; *.jpeg; *.png; )| *.jpg; *.jpeg; *.png;";
                if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    txtFaceImage.Text = open.FileName;
                }
            }
            catch
            {
                //ErrorCatch
            }
        }

        private void btnAddFileOR_Click(object sender, EventArgs e)
        {

            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "(*.jpg; *.jpeg; *.png; )| *.jpg; *.jpeg; *.png;";
                if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    txtOfficialReceipt.Text = open.FileName;
                }
            }
            catch
            {
                //ErrorCatch
            }   
        }

        private void btnAddFileCR_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "(*.jpg; *.jpeg; *.png; )| *.jpg; *.jpeg; *.png;";
                if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    txtCR.Text = open.FileName;
                }
            }
            catch
            {
                //ErrorCatch
            }
        }
    }
}
