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
    public partial class FrmSG_ParkingSpace : Form
    {
        public FrmSG_ParkingSpace()
        {
            InitializeComponent();
        }
        public FrmSG_ParkingSpace(int val)
        {
            InitializeComponent();
        }

        private void FrmSG_ParkingSpace_Load(object sender, EventArgs e)
        {
            viewExpiration();
            LoadPermission();
            LoadData();
        }

        private void viewExpiration()
        {

            using (SqlConnection conn = new SqlConnection(ConnectionString.connect))
            {
                conn.Open();
                string query = "SELECT PlateID" +
                                     ",Id_Number" +
                                     ",Time_Due FROM CREDENTIALS  WHERE Status = '1' ";
                try
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))

                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string plateID = reader.GetValue(0).ToString();
                                string ID = reader.GetValue(1).ToString();
                                string expiryDate = reader.GetValue(2).ToString();
                                checkifEXpired(ID, plateID, expiryDate);
                            }
                            reader.Close();
                        }
                        conn.Close();
                    }
                }
                catch
                {
                    MessageBox.Show("Invalid details!");

                }

            }
        }

        private void checkifEXpired(string ID, string plateID, string expiryDate)
        {
            DateTime dateTime = Convert.ToDateTime(expiryDate);
            DateTime today = DateTime.Now;

            if (dateTime < today)
            {
                UpdateStatusExpired(ID, plateID);
            }
        }

        private void UpdateStatusExpired(string ID, string plateID)
        {

            using (SqlConnection conn = new SqlConnection(ConnectionString.connect))
            {
                conn.Open();
                string query = "UPDATE CREDENTIALS SET Status = @Status WHERE PlateID = @PlateID AND Id_Number = @Id_Number";
                try
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Status", '3' );
                        cmd.Parameters.AddWithValue("@PlateID", plateID);
                        cmd.Parameters.AddWithValue("@Id_Number", ID);
                    }
                }
                catch
                {
                    MessageBox.Show("System Error!");

                }

            }
        }

        private void FrmSG_ParkingSpace_FormClosing(object sender, FormClosingEventArgs e)
        {
            SqlDependency.Stop(ConnectionString.connect);
        }

        public void LoadPermission()
        {
            SqlClientPermission sqlClientPermission = new SqlClientPermission(System.Security.Permissions.PermissionState.Unrestricted);
            sqlClientPermission.Demand();
            SqlDependency.Start(ConnectionString.connect);
            LoadData();
        }

        public void LoadData()
        {
            string query = "SELECT VIP,Employee_MotoR,Employee_Car,Student_Motor FROM dbo.Parking_Slot";
            using (SqlConnection cn = new SqlConnection(ConnectionString.connect))
            {
                if (cn.State == ConnectionState.Closed)
                    cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                SqlDependency sqlDependency = new SqlDependency(cmd);
                sqlDependency.OnChange += new OnChangeEventHandler(OnDependencyChange);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int vip = Convert.ToInt32(reader.GetValue(0).ToString());
                        int emp_motor = 24 - Convert.ToInt32(reader.GetValue(1).ToString());
                        int emp_car = 60 - Convert.ToInt32(reader.GetValue(2).ToString());
                        int stu_motor = 24 - Convert.ToInt32(reader.GetValue(3).ToString());

                        btnVIP.Text = vip.ToString();
                        btnCarFaculty.Text = emp_car.ToString();
                        btnMotorFaculty.Text = emp_motor.ToString();
                        btnStudentMotor.Text = stu_motor.ToString();
                        
                    }
                    reader.Close();
                }


            }
        }

        delegate void UpdateData();
        public void OnDependencyChange(object sender, SqlNotificationEventArgs e)
        {
            SqlDependency sqlDependency = sender as SqlDependency;
            sqlDependency.OnChange -= OnDependencyChange;
            UpdateData updateData = new UpdateData(LoadData);
            this.Invoke(updateData, null);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
             Environment.Exit(0);
        }

       
        private void btnMainmenu_Click(object sender, EventArgs e)
        {


            Form form = Application.OpenForms["FrmMainMenu"];
            if (form != null)
            {
                form.Close();
            }
            else
            {
                this.Hide();
                FrmMainMenu mainMenu = new FrmMainMenu();
                mainMenu.Show();
            }
            
           
        }

    }
}
