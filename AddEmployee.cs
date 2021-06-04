using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace FighyGym2
{
    public partial class AddEmployee : DevExpress.XtraEditors.XtraUserControl
    {
        private static AddEmployee _instance;
        Database db = new Database();
        DataTable tbl = new DataTable();
        public static AddEmployee Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AddEmployee();
                return _instance;
            }
        }
        public AddEmployee()
        {
            InitializeComponent();
        }
        //private void AutoNumber()
        //{
        //    string ConString = System.Configuration.ConfigurationManager.ConnectionStrings["Database1ConnectionString"].ConnectionString;
        //    // ds.Clear();
        //    SqlConnection conn = new SqlConnection(ConString);
        //    SqlDataAdapter da = new SqlDataAdapter("select max (ID) from Tbl_eshtrackat", conn);
        //    DataSet ds = new DataSet();
        //    da.Fill(ds, "Tbl_eshtrackat");
        //    //     firstName.DataSource = ds.Tables[0].DefaultView;
        //    //    firstName.DisplayMember = ds.Tables[0].Columns["Employee_Id"].ToString();
        //    // firstName.DisplayMember = ds.Tables[1].Columns["Employee_Name"].ToString();
        //    //tbl.Clear();
        //    //tbl = db.readData("", "");

        //    if (ds.Tables[0].Rows[0][0].ToString() == "")
        //    {
        //        txtID.Text = "1";
        //    }
        //    else
        //    {
        //        txtID.Text = (Convert.ToInt16(ds.Tables[0].Rows[0][0]) + 1).ToString();
        //        //(Convert.ToInt32(tbl.Rows[0][0]) + 1).ToString();
        //    }
        //    //  firstName.Clear();
        //    //     txtEmpname.Clear();
        //    // txtName.Clear();
        //    // txtPenStatus.Clear();
        //    //txtratio.Clear();

        //    btnDelete.Enabled = false;
        //    ////   btnNew.Enabled = true;
        //    btnSave.Enabled = false;

        //    btnAdd.Enabled = true;
        //}
      
        private void btnAdd_Click(object sender, EventArgs e)
        {
           
            string ConString = System.Configuration.ConfigurationManager.ConnectionStrings["Database1ConnectionString"].ConnectionString;
            SqlConnection cnn = new SqlConnection(ConString);
            SqlCommand sc, insertStudent, scd, cscd3;
            cnn.Open();
            //   string datecurrent = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            //  string datecreatinAccount = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
            //   string sql = "INSERT INTO [dbo].[Tbl_eshtrackat]   ([ID]   ,[Student_id],[From]   ,[To]   ,[emp_id]     ,[class_name],mount)  values ('" + txtID.Text + "','" + firstName.SelectedValue + "','" + date1 + "', '" + date2 + "','" + txtEmpname.SelectedValue + "','" + typecourse.Text + "','" + txtMony.Text + "')";
            DataTable tblemp = new DataTable();
            tblemp = db.readData("SELECT  [Employee_Id],[Employee_Name] ,[Phone_Number] ,[Employee_Job] FROM [fightGym].[dbo].[Employees] where  Employee_Name='"+txtEmpname.Text+"'", "");
            if(tblemp.Rows.Count > 0)
            {
                MessageBox.Show("تم حفظ الموظف سابقاً  ");
                return;
            }
            else
            {

          
            string sql = "INSERT INTO[dbo].[Employees]([Employee_Name]  ,[Phone_Number] ,[Employee_Job] ) VALUES('" + txtEmpname.Text + "','" + txtPhonNumb.Text + "','" + comboBox1.Text + "')";
            try
            {
                //cnn.Open();
                //  MessageBox.Show("Data Saved..");
                sc = new SqlCommand(sql, cnn);
                sc.ExecuteNonQuery();
                sc.Dispose();
                MessageBox.Show("تم الحفظ  بنجاح");
               // AutoNumber();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                }
            }
        }
       

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string ConString = System.Configuration.ConfigurationManager.ConnectionStrings["Database1ConnectionString"].ConnectionString;
     
            tbl = db.readData("SELECT  [Employee_Name] ,[Phone_Number],[Employee_Job]  FROM [fightGym].[dbo].[Employees] where Employee_Name like N'%" +texname.Text+ "%'", "");

            try
            {
            
                txtPhonNumb.Text = tbl.Rows[0][1].ToString();
                txtEmpname.Text = tbl.Rows[0][0].ToString();
                comboBox1.Text= tbl.Rows[0][2].ToString();
                btnDelete.Enabled = true;
                ////   btnNew.Enabled = true;
                btnSave.Enabled = true;

                btnAdd.Enabled = true;
                // }
            }
            catch (Exception) { }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //date2 = To.Value.ToString("yyyy-MM-dd");
            string ConString = System.Configuration.ConfigurationManager.ConnectionStrings["Database1ConnectionString"].ConnectionString;
            SqlConnection cnn = new SqlConnection(ConString);
            SqlCommand sc, insertStudent, scd, cscd3;
            cnn.Open();
            //   string datecurrent = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            //  string datecreatinAccount = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
            //     string sql = "INSERT INTO [dbo].[Tbl_eshtrackat]   ([ID]   ,[Student_id],[From]   ,[To]   ,[emp_id]     ,[class_name])  values ('" + txtID.Text + "','" + firstName.SelectedValue + "','" + date1 + "', '" + date2 + "','" + txtEmpname.SelectedValue + "','" + typecourse.Text + "')";
            // string sql = "UPDATE [dbo].[Tbl_eshtrackat] set Student_id='" + firstName.SelectedValue + "', [From]='" + date1 + "', [To]='" + date2 + "' , emp_id='" + txtEmpname.SelectedValue + "',class_name='" + typecourse.Text + "',mount='" + txtMony.Text + "' where Tbl_eshtrackat.[ID]='" + txtID.Text + "' ";
            if (txtEmpname.Text == "") { }
            else
            {
                string sql = "UPDATE [dbo].[Employees] SET [Employee_Name] = '" + txtEmpname.Text + "' ,[Phone_Number] =  '" + txtPhonNumb.Text + "'   ,[Employee_Job] = '" + comboBox1.Text + "'     WHERE Employee_Name='" + txtEmpname.Text + "'";
                try
                {
                    //cnn.Open();
                    //  MessageBox.Show("Data Saved..");
                    sc = new SqlCommand(sql, cnn);
                    sc.ExecuteNonQuery();
                    sc.Dispose();
                    MessageBox.Show("تم التعديل  بنجاح");
                    //  AutoNumber();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //date2 = To.Value.ToString("yyyy-MM-dd");
            if (MessageBox.Show("هل انت متاكد من المسح ", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string ConString = System.Configuration.ConfigurationManager.ConnectionStrings["Database1ConnectionString"].ConnectionString;
                SqlConnection cnn = new SqlConnection(ConString);
                SqlCommand sc, insertStudent, scd, cscd3;
                cnn.Open();
                //   string datecurrent = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                //  string datecreatinAccount = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
                //     string sql = "INSERT INTO [dbo].[Tbl_eshtrackat]   ([ID]   ,[Student_id],[From]   ,[To]   ,[emp_id]     ,[class_name])  values ('" + txtID.Text + "','" + firstName.SelectedValue + "','" + date1 + "', '" + date2 + "','" + txtEmpname.SelectedValue + "','" + typecourse.Text + "')";
                // string sql = "UPDATE [dbo].[Tbl_eshtrackat] set Student_id='" + firstName.SelectedValue + "', [From]='" + date1 + "', [To]='" + date2 + "' , emp_id='" + txtEmpname.SelectedValue + "',class_name='" + typecourse.Text + "',mount='" + txtMony.Text + "' where Tbl_eshtrackat.[ID]='" + txtID.Text + "' ";

                if (txtEmpname.Text == "") { }
                else
                {
                    string sql = "Delete  from [dbo].[Employees]     WHERE Phone_Number='" + txtPhonNumb.Text + "'";
                    try
                    {
                        //cnn.Open();
                        //  MessageBox.Show("Data Saved..");
                        sc = new SqlCommand(sql, cnn);
                        sc.ExecuteNonQuery();
                        sc.Dispose();
                        MessageBox.Show("تم الحذف  بنجاح");
                        //  AutoNumber();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
        private void AddEmployee_Load(object sender, EventArgs e)
        {

        }
    }
}
