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
    public partial class ConGameSett : DevExpress.XtraEditors.XtraUserControl
    {
        private static ConGameSett _instance;
        Database db = new Database();
        DataTable tbl = new DataTable();

        public static ConGameSett Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ConGameSett();
                return _instance;
            }
        }
        int User_id;
        string datecurrent;
        public ConGameSett()
        {
            InitializeComponent();
        }
       
        private void GetSet()
        {
            txtSenf.Items.Clear();
            tbl.Clear();
            tbl = db.readData("SELECT Distinct [Senf] FROM [fightGym].[dbo].[Set_fatrat] ", "");


            for (int i = 0; tbl.Rows.Count > i; i++)
            {
                //DataGridViewComboBoxColumn cbx = (DataGridViewComboBoxColumn)dataGridView1.Rows[0].Cells[4].OwningColumn;
                //cbx.Items.Add(tbl.Rows[i][0].ToString());
                txtSenf.Items.Add(tbl.Rows[i][0].ToString());

            }
            //tbl.Clear();
            //tbl = db.readData("SELECT Distinct [Ftrah] FROM [fightGym].[dbo].[Set_fatrat] ", "");

            //for (int i = 0; tbl.Rows.Count > i; i++)
            //{

            //    DataGridViewComboBoxColumn cbx1 = (DataGridViewComboBoxColumn)dataGridView1.Rows[0].Cells[3].OwningColumn;
            //    cbx1.Items.Add(tbl.Rows[i][0].ToString());



            //}
            //tbl.Clear();

            //tbl = db.readData("SELECT Distinct [Feaah] FROM [fightGym].[dbo].[Set_fatrat] ", "");
            //for (int i = 0; tbl.Rows.Count > i; i++)
            //{


            //    DataGridViewComboBoxColumn cbx2 = (DataGridViewComboBoxColumn)dataGridView1.Rows[0].Cells[2].OwningColumn;
            //    cbx2.Items.Add(tbl.Rows[i][0].ToString());

            //}
        }

        private void ConGameSett_Load(object sender, EventArgs e)
        {
            GetSet();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") { XtraMessageBox.Show("يجب تعبئة حقل البحث", "تنوية", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            else
            {
                //  tbl = db.readData("SELECT DISTINCT  Penf_ID,[Emp_ID] ,[Penf_Name] ,HC_ID,[TBL_Departments].Dpt_Name,TBL_penfType.NametypePenf FROM [HC_YC].[dbo].[TBL_penfdata] ,[TBL_Departments],TBL_penfType where Emp_ID='" + txtaddrow.Text + "' And Penf_ID ='" + txthealth.Text + "' ", "");
                tbl = db.readData("SELECT [ID]  ,[Senf]  ,[Ftrah]  ,[Feaah]  ,[user_id]  ,[Entertime],Days FROM [fightGym].[dbo].[Set_fatrat] where Senf like '%" + textBox1.Text + "%' ", "");
                dataGridView2.DataSource = tbl;


                //if (tbl.Rows.Count > 0)
                //{
                //    txtSenf.Text = tbl.Rows[0][1].ToString();
                //    txtfatrah.Text = tbl.Rows[0][2].ToString();
                //    txtfeaah.Text = tbl.Rows[0][3].ToString();
                //    txtid.Text = tbl.Rows[0][0].ToString();
                //    txtDays.Text= tbl.Rows[0][6].ToString();
                //}
            }
        }
        string ConString = System.Configuration.ConfigurationManager.ConnectionStrings["Database1ConnectionString"].ConnectionString;

        public void getuserid()
        {
            User_id = 0;
            try
            {
                SqlConnection conn = new SqlConnection(ConString);
                string selectCmd = " SELECT  [role_Id]  FROM [fightGym].[dbo].[Roles] where Employee_Name='" + Properties.Settings.Default.USER_NAME + "' ";
                //  string da = "SELECT   dbo.Tbl_eshtrackat.ID, dbo.Students.Student_Name, dbo.Tbl_eshtrackat.class_name, dbo.Tbl_eshtrackat.[From], dbo.Tbl_eshtrackat.[To], dbo.Tbl_eshtrackat.mount FROM       dbo.Students INNER JOIN   dbo.Tbl_eshtrackat ON dbo.Students.Student_Id = dbo.Tbl_eshtrackat.Student_id INNER JOIN     dbo.Employees ON dbo.Tbl_eshtrackat.emp_id = dbo.Employees.Employee_Id where   dbo.Tbl_eshtrackat.[From] between '" + date1 + "' and '" + date2 + "' ";
                SqlCommand comandReader = new SqlCommand(selectCmd, conn);
                conn.Open();
                comandReader.ExecuteNonQuery();
                //   conn.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter adapt = new SqlDataAdapter(comandReader);

                adapt.Fill(dt);
                User_id = Convert.ToInt16(dt.Rows[0][0].ToString());
                //  User_id = Convert.ToInt16(db.readData("select User_ID from Users where User_Name=N'" + Properties.Settings.Default.USER_NAME + "'", "").Rows[0][0]);
                datecurrent = DateTime.Now.ToString("yyyy-MM-dd ");
            }

            catch { }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            getuserid();
            db.executeData(" update  [dbo].[Set_fatrat] set [Senf] ='" + txtSenf.Text + "',[Ftrah] ='" + txtfatrah.Text + "' ,[Feaah]='" + txtfeaah.Text + "',user_id='" + User_id + "',Entertime ='" + datecurrent + "',Days ='" + txtDays.Text + "' where ID='" + txtid.Text + "')", "تم التعديل بنجاح");

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متاكد من المسح ", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (txtid.Text == "")
                {
                    MessageBox.Show("لاتوجد بيانات");
                }
                else
                {
                    getuserid();
                    db.executeData(" delete   [dbo].[Set_fatrat] where ID='" + txtid.Text + "'", "تم المسح بنجاح");
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            getuserid();
            db.executeData(" INSERT INTO [dbo].[Set_fatrat] ([Senf] ,[Ftrah]  ,[Feaah],user_id,Entertime,Days)  VALUES( '" + txtSenf.Text + "' ,'" + txtfatrah.Text + "'  ,'" + txtfeaah.Text + "','" + User_id + "','" + datecurrent + "','" + txtDays.Text + "')", "تم الحفظ بنجاح");
            GetSet();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 6)
            {
                getuserid();
                db.executeData(" update  [dbo].[Set_fatrat] set [Senf] ='" + dataGridView2.CurrentRow.Cells[4].Value + "',[Ftrah] ='" + dataGridView2.CurrentRow.Cells[3].Value + "' ,[Feaah]='" + dataGridView2.CurrentRow.Cells[2].Value + "',user_id='" + User_id + "',Entertime ='" + datecurrent + "',Days ='" + dataGridView2.CurrentRow.Cells[5].Value + "' where ID='" + dataGridView2.CurrentRow.Cells[1].Value + "'", "تم التعديل بنجاح");

            }
            if (e.ColumnIndex == 7)
            {
                if (MessageBox.Show("هل انت متاكد من المسح ", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (dataGridView2.Rows.Count <= 0) { }
                    else
                    {
                        db.executeData("DELETE FROM [dbo].[Set_fatrat]   WHERE [ID]='" + dataGridView2.CurrentRow.Cells[1].Value + "'", "تم الحذف بنجاح");

                        dataGridView2.Rows.RemoveAt(dataGridView2.CurrentRow.Index);
                        //GmNm();
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
