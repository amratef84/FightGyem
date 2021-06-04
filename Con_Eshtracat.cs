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
    public partial class Con_Eshtracat : DevExpress.XtraEditors.XtraUserControl
    {
        private static Con_Eshtracat _instance;
        //Database db = new Database();
        DataTable tbl = new DataTable();
        public Con_Eshtracat()
        {
            InitializeComponent();
        }
        public static Con_Eshtracat Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Con_Eshtracat();
                return _instance;
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string date2;
            string date1 =from.Value.ToString("yyyy-MM-dd");
            date2 = To.Value.ToString("yyyy-MM-dd");
            string ConString = System.Configuration.ConfigurationManager.ConnectionStrings["Database1ConnectionString"].ConnectionString;
            SqlConnection cnn = new SqlConnection(ConString);
            SqlCommand sc, insertStudent, scd, cscd3;
            cnn.Open();
            //   string datecurrent = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            //  string datecreatinAccount = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
            string sql = "INSERT INTO [dbo].[Tbl_eshtrackat]   ([ID]   ,[Student_id],[From]   ,[To]   ,[emp_id]     ,[class_name],mount)  values ('" + txtID.Text + "','" + firstName.SelectedValue + "','" + date1 + "', '" + date2+ "','" + txtEmpname.SelectedValue + "','" + typecourse.Text + "','"+txtMony.Text+"')";
            try
            {
                //cnn.Open();
                //  MessageBox.Show("Data Saved..");
                sc = new SqlCommand(sql, cnn);
                sc.ExecuteNonQuery();
                sc.Dispose();
                MessageBox.Show("تم الحفظ  بنجاح");
                AutoNumber();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

    }
        private void getStuName()
        {
            string ConString = System.Configuration.ConfigurationManager.ConnectionStrings["Database1ConnectionString"].ConnectionString;

            SqlConnection conn = new SqlConnection(ConString);
            SqlDataAdapter da = new SqlDataAdapter("SELECT  [Student_Id] ,[Student_Name] ,[Phone_Number] ,[Classroom_Id]  FROM [fightGym].[dbo].[Students]", conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Students");
            firstName.DataSource = ds.Tables[0].DefaultView;
            firstName.ValueMember = ds.Tables[0].Columns["Student_Id"].ToString();
            firstName.DisplayMember = ds.Tables[0].Columns["Student_Name"].ToString();
        }
        private void getEmpName()
        {
            string ConString = System.Configuration.ConfigurationManager.ConnectionStrings["Database1ConnectionString"].ConnectionString;

            SqlConnection conn = new SqlConnection(ConString);
            SqlDataAdapter da = new SqlDataAdapter("SELECT [Employee_Id] ,[Employee_Name] FROM [fightGym].[dbo].[Employees]", conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Employees");
            txtEmpname.DataSource = ds.Tables[0].DefaultView;
            txtEmpname.ValueMember = ds.Tables[0].Columns["Employee_Id"].ToString();
            txtEmpname.DisplayMember = ds.Tables[0].Columns["Employee_Name"].ToString();
        }
        private void Con_Eshtracat_Load(object sender, EventArgs e)
        {
            getStuName();
            getEmpName();
            AutoNumber();

        }
        private void AutoNumber()
        {
            string ConString = System.Configuration.ConfigurationManager.ConnectionStrings["Database1ConnectionString"].ConnectionString;
           // ds.Clear();
            SqlConnection conn = new SqlConnection(ConString);
            SqlDataAdapter da = new SqlDataAdapter("select max (ID) from Tbl_eshtrackat", conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Tbl_eshtrackat");
       //     firstName.DataSource = ds.Tables[0].DefaultView;
        //    firstName.DisplayMember = ds.Tables[0].Columns["Employee_Id"].ToString();
           // firstName.DisplayMember = ds.Tables[1].Columns["Employee_Name"].ToString();
            //tbl.Clear();
            //tbl = db.readData("", "");

            if (ds.Tables[0].Rows[0][0].ToString()== "")
            {
                txtID.Text = "1";
            }
            else
            {
              txtID.Text = (Convert.ToInt16(ds.Tables[0].Rows[0][0])+1).ToString();
                //(Convert.ToInt32(tbl.Rows[0][0]) + 1).ToString();
            }
          //  firstName.Clear();
      //     txtEmpname.Clear();
            // txtName.Clear();
            // txtPenStatus.Clear();
            //txtratio.Clear();

            btnDelete.Enabled = false;
            ////   btnNew.Enabled = true;
            btnSave.Enabled = false;

            btnAdd.Enabled = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string ConString = System.Configuration.ConfigurationManager.ConnectionStrings["Database1ConnectionString"].ConnectionString;
            // ds.Clear();
            SqlConnection conn = new SqlConnection(ConString);
            SqlDataAdapter da = new SqlDataAdapter("SELECT   dbo.Tbl_eshtrackat.ID, dbo.Students.Student_Name, dbo.Tbl_eshtrackat.[From], dbo.Tbl_eshtrackat.[To], dbo.Employees.Employee_Name, dbo.Tbl_eshtrackat.class_name, dbo.Tbl_eshtrackat.mount FROM   dbo.Students INNER JOIN      dbo.Tbl_eshtrackat ON dbo.Students.Student_Id = dbo.Tbl_eshtrackat.Student_id INNER JOIN   dbo.Employees ON dbo.Tbl_eshtrackat.emp_id = dbo.Employees.Employee_Id where   dbo.Students.Student_Name like N'%" + txtSearch2.Text + "%'", conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Tbl_eshtrackat");
          
           try { 
                //  tblSearch = db.readData("SELECT [Penf_ID],[HC_ID],[Emp_ID],[penf_Age],[Penf_Name],[Social_Status],[TBL_Departments].Dpt_Name,[TBL_penfType].NametypePenf FROM [HC_YC].[dbo].[TBL_penfdata],[TBL_penfType],[TBL_Departments]  where Emp_ID like N'%" + txtSearch2.Text + "%'", "");
                txtID.Text = ds.Tables[0].Rows[0][0].ToString();
                firstName.Text = ds.Tables[0].Rows[0][1].ToString();
                from.Text = ds.Tables[0].Rows[0][2].ToString();
                To.Text = ds.Tables[0].Rows[0][3].ToString();
                txtEmpname.Text = ds.Tables[0].Rows[0][4].ToString();
                typecourse.Text = ds.Tables[0].Rows[0][5].ToString();
                txtMony.Text= ds.Tables[0].Rows[0][6].ToString();
                btnDelete.Enabled = true;
                ////   btnNew.Enabled = true;
                btnSave.Enabled = true;

                btnAdd.Enabled = false;
                // }
            }
            catch (Exception) { }
          
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string date2;
            string date1 = from.Value.ToString("yyyy-MM-dd");
            date2 = To.Value.ToString("yyyy-MM-dd");
            string ConString = System.Configuration.ConfigurationManager.ConnectionStrings["Database1ConnectionString"].ConnectionString;
            SqlConnection cnn = new SqlConnection(ConString);
            SqlCommand sc, insertStudent, scd, cscd3;
            cnn.Open();
            //   string datecurrent = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            //  string datecreatinAccount = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
            //     string sql = "INSERT INTO [dbo].[Tbl_eshtrackat]   ([ID]   ,[Student_id],[From]   ,[To]   ,[emp_id]     ,[class_name])  values ('" + txtID.Text + "','" + firstName.SelectedValue + "','" + date1 + "', '" + date2 + "','" + txtEmpname.SelectedValue + "','" + typecourse.Text + "')";
            string sql= "UPDATE [dbo].[Tbl_eshtrackat] set Student_id='" + firstName.SelectedValue+ "', [From]='" + date1+ "', [To]='" + date2+ "' , emp_id='"+txtEmpname.SelectedValue+ "',class_name='"+typecourse.Text+ "',mount='"+txtMony.Text+"' where Tbl_eshtrackat.[ID]='" + txtID.Text+"' ";
         //   string sql= "UPDATE [dbo].[Employees] SET [Employee_Name] =  ,[Phone_Number] =   ,[Account_Id] =   ,[Employee_Job] =    ,[Role] =  WHERE Employee_Name='"+txtEmpname.Text+"'"
            try
            {
                //cnn.Open();
                //  MessageBox.Show("Data Saved..");
                sc = new SqlCommand(sql, cnn);
                sc.ExecuteNonQuery();
                sc.Dispose();
                MessageBox.Show("تم التعديل  بنجاح");
               AutoNumber();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string ConString = System.Configuration.ConfigurationManager.ConnectionStrings["Database1ConnectionString"].ConnectionString;
            SqlConnection cnn = new SqlConnection(ConString);
            SqlCommand sc, insertStudent, scd, cscd3;
            cnn.Open();
            //   string datecurrent = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            //  string datecreatinAccount = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
            //     string sql = "INSERT INTO [dbo].[Tbl_eshtrackat]   ([ID]   ,[Student_id],[From]   ,[To]   ,[emp_id]     ,[class_name])  values ('" + txtID.Text + "','" + firstName.SelectedValue + "','" + date1 + "', '" + date2 + "','" + txtEmpname.SelectedValue + "','" + typecourse.Text + "')";
            string sql = "Delete  from  Tbl_eshtrackat where  [ID]='" + txtID.Text + "'";
            try
            {
                //cnn.Open();
                //  MessageBox.Show("Data Saved..");
                sc = new SqlCommand(sql, cnn);
                sc.ExecuteNonQuery();
                sc.Dispose();
                MessageBox.Show("تم المسح  بنجاح");
                AutoNumber();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    }
