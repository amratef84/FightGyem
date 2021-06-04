using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using System.Data.SqlClient;

namespace FighyGym2
{
    public partial class RibbonForm1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public RibbonForm1()
        {
            InitializeComponent();
        }
        DataTable dt;
        string ConString = System.Configuration.ConfigurationManager.ConnectionStrings["Database1ConnectionString"].ConnectionString;
        SqlConnection conn;
        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            getuserid();
            // conn = new SqlConnection(ConString);
            tbl = db.readData(" SELECT dbo.PermisionSetting.[Permisission_Particpiation] FROM   dbo.PermisionSetting INNER JOIN dbo.Roles ON dbo.PermisionSetting.Role_id = '" + User_id + "' Group by   Permisission_Particpiation", "");
            //  string da = "SELECT   dbo.Tbl_eshtrackat.ID, dbo.Students.Student_Name, dbo.Tbl_eshtrackat.class_name, dbo.Tbl_eshtrackat.[From], dbo.Tbl_eshtrackat.[To], dbo.Tbl_eshtrackat.mount FROM       dbo.Students INNER JOIN   dbo.Tbl_eshtrackat ON dbo.Students.Student_Id = dbo.Tbl_eshtrackat.Student_id INNER JOIN     dbo.Employees ON dbo.Tbl_eshtrackat.emp_id = dbo.Employees.Employee_Id where   dbo.Tbl_eshtrackat.[From] between '" + date1 + "' and '" + date2 + "' ";
            // SqlCommand comandReader = new SqlCommand(selectCmd, conn);
            //   comandReader.ExecuteNonQuery();
            //   conn.Open();
            // dt = new DataTable();
            //  SqlDataAdapter adapt = new SqlDataAdapter(comandReader);

            //   adapt.Fill(dt);
            if (tbl.Rows.Count <= 0)
            {
                if (!panel1.Controls.Contains(CondetialsEshtracat.Instance))
                {

                    panel1.Controls.Add(CondetialsEshtracat.Instance);
                    CondetialsEshtracat.Instance.Dock = DockStyle.Fill;
                    CondetialsEshtracat.Instance.BringToFront();

                }
                CondetialsEshtracat.Instance.BringToFront();
            }
            else
            {
                if (Convert.ToDecimal(tbl.Rows[0][0]) == 0)
                {
                    MessageBox.Show(" انت لاتملك صلاحية الدخول لهذه الشاشه", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    if (!panel1.Controls.Contains(CondetialsEshtracat.Instance))
                    {

                        panel1.Controls.Add(CondetialsEshtracat.Instance);
                        CondetialsEshtracat.Instance.Dock = DockStyle.Fill;
                        CondetialsEshtracat.Instance.BringToFront();

                    }
                    CondetialsEshtracat.Instance.BringToFront();
                }
            }
       
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            getuserid();
            // conn = new SqlConnection(ConString);
            tbl = db.readData(" SELECT dbo.PermisionSetting.[Permisission_TrainerTech] FROM   dbo.PermisionSetting INNER JOIN dbo.Roles ON dbo.PermisionSetting.Role_id = '" + User_id + "' Group by dbo.PermisionSetting.[Permisission_TrainerTech]", "");
          
            if (tbl.Rows.Count <= 0)
            {
                if (!panel1.Controls.Contains(AddEmployee.Instance))
                {

                    panel1.Controls.Add(AddEmployee.Instance);
                    AddEmployee.Instance.Dock = DockStyle.Fill;
                    AddEmployee.Instance.BringToFront();

                }
                AddEmployee.Instance.BringToFront();
            }
            else
            {
                if (Convert.ToDecimal(tbl.Rows[0][0]) == 0)
                {
                    MessageBox.Show(" انت لاتملك صلاحية الدخول لهذه الشاشه", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    if (!panel1.Controls.Contains(AddEmployee.Instance))
                    {

                        panel1.Controls.Add(AddEmployee.Instance);
                        AddEmployee.Instance.Dock = DockStyle.Fill;
                        AddEmployee.Instance.BringToFront();

                    }
                    AddEmployee.Instance.BringToFront();
                }
            }
       
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            getuserid();
            // conn = new SqlConnection(ConString);
            tbl = db.readData(" SELECT dbo.PermisionSetting.[Permisission_Users] FROM   dbo.PermisionSetting INNER JOIN dbo.Roles ON dbo.PermisionSetting.Role_id = '" + User_id + "' Group by dbo.PermisionSetting.[Permisission_Users]", "");
            //  string da = "SELECT   dbo.Tbl_eshtrackat.ID, dbo.Students.Student_Name, dbo.Tbl_eshtrackat.class_name, dbo.Tbl_eshtrackat.[From], dbo.Tbl_eshtrackat.[To], dbo.Tbl_eshtrackat.mount FROM       dbo.Students INNER JOIN   dbo.Tbl_eshtrackat ON dbo.Students.Student_Id = dbo.Tbl_eshtrackat.Student_id INNER JOIN     dbo.Employees ON dbo.Tbl_eshtrackat.emp_id = dbo.Employees.Employee_Id where   dbo.Tbl_eshtrackat.[From] between '" + date1 + "' and '" + date2 + "' ";
            // SqlCommand comandReader = new SqlCommand(selectCmd, conn);
            //   comandReader.ExecuteNonQuery();
            //   conn.Open();
            // dt = new DataTable();
            //  SqlDataAdapter adapt = new SqlDataAdapter(comandReader);

            //   adapt.Fill(dt);
            if (tbl.Rows.Count <= 0)
            {
                if (!panel1.Controls.Contains(Con_Permission.Instance))
                {

                    panel1.Controls.Add(Con_Permission.Instance);
                    Con_Permission.Instance.Dock = DockStyle.Fill;
                    Con_Permission.Instance.BringToFront();

                }
                Con_Permission.Instance.BringToFront();
            }
            else
            {
                if (Convert.ToDecimal(tbl.Rows[0][0]) == 0)
                {
                    MessageBox.Show(" انت لاتملك صلاحية الدخول لهذه الشاشه", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    if (!panel1.Controls.Contains(Con_Permission.Instance))
                    {

                        panel1.Controls.Add(Con_Permission.Instance);
                        Con_Permission.Instance.Dock = DockStyle.Fill;
                        Con_Permission.Instance.BringToFront();

                    }
                    Con_Permission.Instance.BringToFront();
                }
            }

     
        }
        int User_id;
        public void getuserid()
        {

            try
            {
                 conn = new SqlConnection(ConString);
                string selectCmd = " SELECT  [role_Id]  FROM [fightGym].[dbo].[Roles] where Employee_Name='" + Properties.Settings.Default.USER_NAME + "' ";
                //  string da = "SELECT   dbo.Tbl_eshtrackat.ID, dbo.Students.Student_Name, dbo.Tbl_eshtrackat.class_name, dbo.Tbl_eshtrackat.[From], dbo.Tbl_eshtrackat.[To], dbo.Tbl_eshtrackat.mount FROM       dbo.Students INNER JOIN   dbo.Tbl_eshtrackat ON dbo.Students.Student_Id = dbo.Tbl_eshtrackat.Student_id INNER JOIN     dbo.Employees ON dbo.Tbl_eshtrackat.emp_id = dbo.Employees.Employee_Id where   dbo.Tbl_eshtrackat.[From] between '" + date1 + "' and '" + date2 + "' ";
                SqlCommand comandReader = new SqlCommand(selectCmd, conn);
                conn.Open();
                comandReader.ExecuteNonQuery();
                //   conn.Open();
                dt = new DataTable();
                SqlDataAdapter adapt = new SqlDataAdapter(comandReader);

                adapt.Fill(dt);
                User_id = Convert.ToInt16(dt.Rows[0][0].ToString());
                //  User_id = Convert.ToInt16(db.readData("select User_ID from Users where User_Name=N'" + Properties.Settings.Default.USER_NAME + "'", "").Rows[0][0]);
            }

            catch { }
        }
        DataTable tbl = new DataTable();
        Database db = new Database();
        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            getuserid();
            //getuserid();
            // conn = new SqlConnection(ConString);
            tbl =db.readData( " SELECT dbo.PermisionSetting.Permisission_Player FROM   dbo.PermisionSetting INNER JOIN dbo.Roles ON dbo.PermisionSetting.Role_id = '"+User_id+ "' Group by dbo.PermisionSetting.Permisission_Player", "");
          
            if (tbl.Rows.Count <= 0)
            {
                if (!panel1.Controls.Contains(ConEditStudents.Instance))
                {
                    panel1.Controls.Add(ConEditStudents.Instance);
                    ConEditStudents.Instance.Dock = DockStyle.Fill;
                    ConEditStudents.Instance.BringToFront();
                }
                ConEditStudents.Instance.BringToFront();
            }
            else
            {
                if (Convert.ToDecimal(tbl.Rows[0][0]) == 0)
                {
                    MessageBox.Show(" انت لاتملك صلاحية الدخول لهذه الشاشه", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }else
                {
                    if (!panel1.Controls.Contains(ConEditStudents.Instance))
                    {
                        panel1.Controls.Add(ConEditStudents.Instance);
                        ConEditStudents.Instance.Dock = DockStyle.Fill;
                        ConEditStudents.Instance.BringToFront();
                    }
                    ConEditStudents.Instance.BringToFront();
                }
            }
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            getuserid();
          
            tbl = db.readData(" SELECT dbo.PermisionSetting.[Permisission_Game] FROM   dbo.PermisionSetting INNER JOIN dbo.Roles ON dbo.PermisionSetting.Role_id = '" + User_id + "' Group by dbo.PermisionSetting.[Permisission_Game]", "");
         
            if (tbl.Rows.Count <= 0)
            {

                if (!panel1.Controls.Contains(ConGames.Instance))
                {
                    panel1.Controls.Add(ConGames.Instance);
                    ConGames.Instance.Dock = DockStyle.Fill;
                    ConGames.Instance.BringToFront();
                }
                ConGames.Instance.BringToFront();
            }
            else
            {
                if (Convert.ToDecimal(tbl.Rows[0][0]) == 0)
                {
                    MessageBox.Show(" انت لاتملك صلاحية الدخول لهذه الشاشه", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {

                    if (!panel1.Controls.Contains(ConGames.Instance))
                    {
                        panel1.Controls.Add(ConGames.Instance);
                        ConGames.Instance.Dock = DockStyle.Fill;
                        ConGames.Instance.BringToFront();
                    }
                    ConGames.Instance.BringToFront();
                }
            }

        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            getuserid();

            tbl = db.readData(" SELECT dbo.PermisionSetting.[Permisission_Game] FROM   dbo.PermisionSetting INNER JOIN dbo.Roles ON dbo.PermisionSetting.Role_id = '" + User_id + "' Group by dbo.PermisionSetting.[Permisission_Game]", "");

            if (tbl.Rows.Count <= 0)
            {

                if (!panel1.Controls.Contains(ConGameSett.Instance))
                {
                    panel1.Controls.Add(ConGameSett.Instance);
                    ConGameSett.Instance.Dock = DockStyle.Fill;
                    ConGameSett.Instance.BringToFront();
                }
                ConGameSett.Instance.BringToFront();
            }
            else
            {
                if (Convert.ToDecimal(tbl.Rows[0][0]) == 0)
                {
                    MessageBox.Show(" انت لاتملك صلاحية الدخول لهذه الشاشه", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {

                    if (!panel1.Controls.Contains(ConGameSett.Instance))
                    {
                        panel1.Controls.Add(ConGameSett.Instance);
                        ConGameSett.Instance.Dock = DockStyle.Fill;
                        ConGameSett.Instance.BringToFront();
                    }
                    ConGameSett.Instance.BringToFront();
                }
            }
           
        }

        private void barEditItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {
            aboutus a = new aboutus();
            a.Show();
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barEditItem4_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void RibbonForm1_Load(object sender, EventArgs e)
        {

        }

        private void barButtonItem16_ItemClick(object sender, ItemClickEventArgs e)
        {
            aboutus a = new aboutus();
            a.Show();
        }

        private void RibbonForm1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}