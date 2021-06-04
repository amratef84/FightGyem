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
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;

namespace FighyGym2
{
    public partial class ConGames : DevExpress.XtraEditors.XtraUserControl
    {
        public ConGames()
        {
            InitializeComponent();

            //   gridControl.DataSource = GetDataSource();
        }



        private void labelControl_Click(object sender, EventArgs e)
        {

        }
        private static ConGames _instance;
        Database db = new Database();
        DataTable tbl = new DataTable();

        public static ConGames Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ConGames();
                return _instance;
            }
        }
        private void GmNm()
        {
           // cbxGames.Items.Clear();
            cbxGames.DataSource = db.readData("SELECT  [Classrooms_Id]   ,  [Classrooms_Name] FROM [fightGym].[dbo].[Classrooms] ", "");
            cbxGames.DisplayMember = "Classrooms_Name";
            cbxGames.ValueMember = "Classrooms_Id";
        }
        private void ConGames_Load(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        string ConString = System.Configuration.ConfigurationManager.ConnectionStrings["Database1ConnectionString"].ConnectionString;
        string datecurrent;
        int User_id;
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

        //private void btnAdd_Click(object sender, EventArgs e)
        //{
        //    getuserid();
        //    db.executeData(" INSERT INTO [dbo].[Set_fatrat] ([Senf] ,[Ftrah]  ,[Feaah],user_id,Entertime,Days)  VALUES( '" + txtSenf.Text + "' ,'" + txtfatrah.Text + "'  ,'" + txtfeaah.Text + "','" + User_id + "','" + datecurrent + "','" + txtDays.Text + "')", "تم الحفظ بنجاح");
        //   // GetSet();
        //}



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                db.executeData("UPDATE [dbo].[Classrooms] SET [Classrooms_Name] = '" + dataGridView1.CurrentRow.Cells[1].Value + "',[fatarh] = '" + dataGridView1.CurrentRow.Cells[3].Value + "'  ,[faah] ='" + dataGridView1.CurrentRow.Cells[2].Value + "'  ,[senf] ='" + dataGridView1.CurrentRow.Cells[4].Value + "'  ,[User_id] ='" + User_id + "'  ,[Entertime] ='" + datecurrent + "' ,[Price] ='" + dataGridView1.CurrentRow.Cells[5].Value + "'    ,[note] ='" + dataGridView1.CurrentRow.Cells[6].Value + "'  WHERE Classrooms_Id='" + Properties.Settings.Default.ClassId + "'", "تم الحفظ بنجاح");
                GmNm();
            }
            if (e.ColumnIndex == 8)
            {
                if (MessageBox.Show("هل انت متاكد من المسح ", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (dataGridView1.Rows.Count <= 0) { }
                    else
                    {
                        db.executeData("DELETE from   [dbo].[Classrooms]   WHERE Classrooms_Id='" + Properties.Settings.Default.ClassId + "'", "تم الحذف بنجاح");

                        dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                        GmNm();
                    }
                }
            }
            if (e.ColumnIndex == 9)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            { }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            getuserid();
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                db.executeData("INSERT INTO [dbo].[Classrooms] ([Classrooms_Name]  ,[Teacher_Id]  ,[fatarh]   ,[faah],[senf]  ,[User_id]  ,[Entertime],Price,note) VALUES ('" + dataGridView1.Rows[i].Cells[1].Value + "','','" + dataGridView1.Rows[i].Cells[3].Value + "','" + dataGridView1.Rows[i].Cells[2].Value + "','" + dataGridView1.Rows[i].Cells[4].Value + "','" + User_id + "','" + datecurrent + "','" + dataGridView1.Rows[i].Cells[5].Value + "','" + dataGridView1.Rows[i].Cells[6].Value + "')", "");

            }
            //     db.executeData("INSERT INTO [dbo].[SheetMIgrate]([sheetId],[Datemig] ,[SheetBian] ,[TotalFirst],[TotalAll],[TaxMony] ,[Currency] ,[CleareMony] ,[CountShees] ,[useriD] ,[EnterTime],[Empid]) Values('" + txtidsheet.Text + "','" + datecurrent + "','" + txtsheetDetials.Text + "','" + Mony.Text + "','" + txtCleare.Text + "','" + txttaxMony.Text + "','" + txtCutting.Text + "','" + txtCleare.Text + "','" + CountId.Text + "','" + User_id + "','" + datecurrent + "','" + empid + "')", "");
            GmNm();
            MessageBox.Show("تم الحفظ بنجاح");
            //  db.executeData("INSERT INTO [dbo].[SheetMIgrate]([sheetId],[Datemig] ,[SheetBian] ,[TotalFirst],[TotalAll],[TaxMony] ,[Currency] ,[CleareMony] ,[CountShees] ,[useriD] ,[EnterTime],Empid) Values('" + txtidsheet.Text + "','" + datecurrent + "','" + txtsheetDetials.Text + "','" + Mony.Text + "','" + txtCleare.Text + "','" + Mony.Text + "','" + txtCutting.Text + "','" + txtCleare.Text + "','" + CountId.Text + "','" + User_id + "','" + datecurrent + "','" + empid + "')", "");

        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                string da = dataGridView1.CurrentRow.Cells[1].Value + " " + dataGridView1.CurrentRow.Cells[2].Value + " " + dataGridView1.CurrentRow.Cells[3].Value + "  " + dataGridView1.CurrentRow.Cells[4].Value;
                dataGridView1.CurrentRow.Cells[6].Value = da;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

      
      

        private void cbxGames_SelectedValueChanged(object sender, EventArgs e)
        {


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cbxGames_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Properties.Settings.Default.ClassId = Convert.ToInt16(cbxGames.SelectedValue);
            tbl.Clear();
            tbl = db.readData("SELECT  [Classrooms_Id]  ,[Classrooms_Name]   ,[Teacher_Id],[fatarh] ,[faah] ,[senf]  ,[Price] ,[note] FROM [fightGym].[dbo].[Classrooms] where Classrooms_Id='" + cbxGames.SelectedValue + "'", "");
            if (tbl.Rows.Count >= 1)
            {
                try
                {


                    string className = tbl.Rows[0][1].ToString();
                    string fatrah = tbl.Rows[0][3].ToString();
                    string feaah = tbl.Rows[0][4].ToString();
                    string senf = tbl.Rows[0][5].ToString();
                    int id = int.Parse(tbl.Rows[0][0].ToString());
                    string note = tbl.Rows[0][7].ToString();
                    int price = int.Parse(tbl.Rows[0][6].ToString());

                    int rowIndex = dataGridView1.Rows.Count - 1;
                    dataGridView1.Rows.Add(1);
                    dataGridView1.Rows[rowIndex].Cells[1].Value = className;
                    //dataGridView1.Rows[rowIndex].Cells[2].Value = feaah;
                    //dataGridView1.Rows[rowIndex].Cells[3].Value = fatrah;
                    //dataGridView1.Rows[rowIndex].Cells[4].Value = senf;
                    dataGridView1.Rows[rowIndex].Cells[5].Value = price;
                    dataGridView1.Rows[rowIndex].Cells[6].Value = note;
                  
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }


            }



        }

        private void cbxGames_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GetSet()
        {
           // txtSenf.Items.Clear();
            tbl.Clear();
            tbl = db.readData("SELECT Distinct [Senf] FROM [fightGym].[dbo].[Set_fatrat] ", "");


            for (int i = 0; tbl.Rows.Count > i; i++)
            {
                DataGridViewComboBoxColumn cbx = (DataGridViewComboBoxColumn)dataGridView1.Rows[0].Cells[4].OwningColumn;
                cbx.Items.Add(tbl.Rows[i][0].ToString());
                //  txtSenf.Items.Add(tbl.Rows[i][0].ToString());

            }
            tbl.Clear();
            tbl = db.readData("SELECT Distinct [Ftrah] FROM [fightGym].[dbo].[Set_fatrat] ", "");

            for (int i = 0; tbl.Rows.Count > i; i++)
            {

                DataGridViewComboBoxColumn cbx1 = (DataGridViewComboBoxColumn)dataGridView1.Rows[0].Cells[3].OwningColumn;
                cbx1.Items.Add(tbl.Rows[i][0].ToString());



            }
            tbl.Clear();

            tbl = db.readData("SELECT Distinct [Feaah] FROM [fightGym].[dbo].[Set_fatrat] ", "");
            for (int i = 0; tbl.Rows.Count > i; i++)
            {


                DataGridViewComboBoxColumn cbx2 = (DataGridViewComboBoxColumn)dataGridView1.Rows[0].Cells[2].OwningColumn;
                cbx2.Items.Add(tbl.Rows[i][0].ToString());

            }
        }
        private void ConGames_Load_1(object sender, EventArgs e)
        {
            GmNm();
           GetSet();

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            GetSet();
        }
    }
}
