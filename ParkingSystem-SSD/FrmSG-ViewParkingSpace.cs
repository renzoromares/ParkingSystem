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
    public partial class FrmSG_ViewParkingSpace : Form
    {
        public FrmSG_ViewParkingSpace()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Visible = false;
            FrmSG_Menu menu = new FrmSG_Menu();
            menu.Show();
        }

        private void FrmSG_ViewParkingSpace_Load(object sender, EventArgs e)
        {
            LoadPermission();
            LoadData();
        }

        private void FrmSG_ViewParkingSpace_FormClosing(object sender, FormClosingEventArgs e)
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

    }
}
