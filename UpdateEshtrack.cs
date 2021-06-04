using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using DevExpress.XtraReports.UI;

namespace FighyGym2
{
    public partial class UpdateEshtrack : DevExpress.XtraEditors.XtraForm
    {
        DateTimePicker dtp = new DateTimePicker();
        public UpdateEshtrack()
        {
            InitializeComponent();
            eshtrakData.Controls.Add(dtp);
            dtp.Visible = false;
            dtp.Format = DateTimePickerFormat.Custom;
            dtp.TextChanged += new EventHandler(dtp_TextChange);
        }

        private void dtp_TextChange(object sender, EventArgs e)
        {
            eshtrakData.CurrentCell.Value = dtp.Text.ToString();
        }

        string date2;
        string date1;
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

            if (ds.Tables[0].Rows[0][0].ToString() == "")
            {
                txtID.Text = "1";
            }
            else
            {
                txtID.Text = (Convert.ToInt16(ds.Tables[0].Rows[0][0]) ).ToString();
                //(Convert.ToInt32(tbl.Rows[0][0]) + 1).ToString();
            }

          ////  btnSave.Enabled = false;

            btnAdd.Enabled = true;
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
        private void GmNm()
        {

            typecourse.DataSource = db.readData("SELECT [Classrooms_Id] ,[Classrooms_Name],[Teacher_Id]  ,[fatarh],[faah],[senf] ,[User_id] ,[Entertime],[Price] ,[note] FROM [fightGym].[dbo].[Classrooms] ", "");
            typecourse.DisplayMember = "note";
            typecourse.ValueMember = "Classrooms_Id";

        }
        private void UpdateEshtrack_Load(object sender, EventArgs e)
        {
        try {
                getStuName();
                getEmpName();
                GmNm();
                firstName.Text   = Properties.Settings.Default.StuName;
            txtID.Text       =Convert.ToString(Properties.Settings.Default.Id);
            txtMony.Text     = Properties.Settings.Default.amount;
            from.Text        = Properties.Settings.Default.DateBegin;
            To.Text          = Properties.Settings.Default.DateEnd;
            typecourse.Text  = Properties.Settings.Default.ClassName;
            txtEmpname.Text  = Properties.Settings.Default.typetrainer;
            

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void searchStu()
        {

            string ConString = System.Configuration.ConfigurationManager.ConnectionStrings["Database1ConnectionString"].ConnectionString;
            // ds.Clear();
            SqlConnection conn = new SqlConnection(ConString);
            SqlDataAdapter da = new SqlDataAdapter("SELECT     dbo.Students.Deitls_Id, dbo.Tbl_eshtrackat.ID,    dbo.Students.Student_Name, dbo.Tbl_eshtrackat.[From], dbo.Tbl_eshtrackat.[To], dbo.Tbl_eshtrackat.class_name, dbo.Tbl_eshtrackat.mount, dbo.Tbl_eshtrackat.statys, dbo.Students.Deitls_Id FROM     dbo.Students INNER JOIN  dbo.Tbl_eshtrackat ON dbo.Students.Deitls_Id = dbo.Tbl_eshtrackat.Student_id where Students.Student_Name like N'%"+firstName.Text+ "%'   and [statys]='1' ", conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Tbl_eshtrackat");

            try
            {
                from.Text = ds.Tables[0].Rows[0][3].ToString();

                txtID.Text = ds.Tables[0].Rows[0][0].ToString();
                firstName.Text = ds.Tables[0].Rows[0][2].ToString();
                To.Text = ds.Tables[0].Rows[0][4].ToString();

                txtMony.Text = ds.Tables[0].Rows[0][6].ToString();

                btnSave.Enabled = true;


            }
            catch (Exception) { }

        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable tbl = new DataTable();
            string ConString = System.Configuration.ConfigurationManager.ConnectionStrings["Database1ConnectionString"].ConnectionString;
            //tbl = db.readData("SELECT  [Student_Id],[Student_Name],[Deitls_Id] FROM [fightGym].[dbo].[Students] where  [Student_Id]='" + firstName.SelectedValue + "'", "");
            //if (tbl.Rows.Count <= 0) { }
            //else
            //{
            //    StuId = tbl.Rows[0][2].ToString();

            //    db.executeData("update  [dbo].[Tbl_eshtrackat] set [statys] ='0'   where Student_id='" + StuId + "' ", " ");
            //    db.executeData("update  [dbo].[Student_Deitls] set   [status] ='0'   where [Deitls_Id]='" + StuId + "' ", "  تم التحديث بنجاح  ");
            //}

            //  SqlCommand cmd = new SqlCommand();
            //update  [Student_Deitls] set   [status]=

            SqlConnection conn = new SqlConnection(ConString);
           SqlDataAdapter da = new SqlDataAdapter("SELECT     dbo.Students.Deitls_Id, dbo.Tbl_eshtrackat.ID,dbo.Tbl_eshtrackat.[TrainerName] ,    dbo.Students.Student_Name, dbo.Tbl_eshtrackat.[From], dbo.Tbl_eshtrackat.[To], dbo.Tbl_eshtrackat.class_name, dbo.Tbl_eshtrackat.mount, dbo.Tbl_eshtrackat.statys, dbo.Students.Deitls_Id FROM     dbo.Students INNER JOIN  dbo.Tbl_eshtrackat ON dbo.Students.Deitls_Id = dbo.Tbl_eshtrackat.Student_id where  Students.Student_Name = N'" + txtSearch2.Text+ "' and [statys]='1' ", conn);
            //cmd.Connection = conn;
            //cmd.CommandText = "SELECT     dbo.Students.Deitls_Id, dbo.Tbl_eshtrackat.ID,dbo.Tbl_eshtrackat.[TrainerName] ,    dbo.Students.Student_Name, dbo.Tbl_eshtrackat.[From], dbo.Tbl_eshtrackat.[To], dbo.Tbl_eshtrackat.class_name, dbo.Tbl_eshtrackat.mount, dbo.Tbl_eshtrackat.statys, dbo.Students.Deitls_Id FROM     dbo.Students INNER JOIN dbo.Tbl_eshtrackat ON dbo.Students.Deitls_Id = dbo.Tbl_eshtrackat.Student_id where Students.Student_Name = N'" + txtSearch2.Text + "'";
            //conn.Open();
            //tbl.Load( cmd.ExecuteReader());
            //conn.Close();

            DataSet ds = new DataSet();
            da.Fill(ds, "Tbl_eshtrackat");


            //if(tbl.Rows.Count > 0)
            //{
            //    for (int i = 0; i < tbl.Rows.Count ; i++)
            //    {

            //        int rowindex = eshtrakData.Rows.Count - 1;
            //        eshtrakData.Rows.Add(1);
            //        eshtrakData.Rows[rowindex].Cells[0].Value = tbl.Rows[i][1].ToString();
            //        eshtrakData.Rows[rowindex].Cells[1].Value = tbl.Rows[i][0].ToString();
            //        eshtrakData.Rows[rowindex].Cells[2].Value = tbl.Rows[i][3].ToString();
            //        eshtrakData.Rows[rowindex].Cells[3].Value = tbl.Rows[i][2].ToString();
            //        eshtrakData.Rows[rowindex].Cells[4].Value = tbl.Rows[i][6].ToString();
            //        eshtrakData.Rows[rowindex].Cells[5].Value = tbl.Rows[i][7].ToString();
            //        string date1=Convert.ToDateTime( tbl.Rows[i][4].ToString()).ToString("yyyy-MM-dd");
            //        string date2 = Convert.ToDateTime(tbl.Rows[i][5].ToString()).ToString("yyyy-MM-dd");
            //        eshtrakData.Rows[rowindex].Cells[6].Value = date1;
            //        eshtrakData.Rows[rowindex].Cells[7].Value = date2;
            //        eshtrakData.Rows[rowindex].Cells[8].Value = tbl.Rows[i][8].ToString();

            //    }
            //}


            //eshtrakData.DataSource = da;

            try
            {
              
                from.Text = ds.Tables[0].Rows[0][4].ToString();
                txtID.Text = ds.Tables[0].Rows[0][0].ToString();
                firstName.Text = ds.Tables[0].Rows[0][3].ToString();
                To.Text = ds.Tables[0].Rows[0][5].ToString();
                txtMony.Text = ds.Tables[0].Rows[0][7].ToString();
                typecourse.Text = ds.Tables[0].Rows[0][6].ToString();
                txtEmpname.Text= ds.Tables[0].Rows[0][2].ToString();
                btnSave.Enabled = true;
            }
            catch (Exception ex) {  }
        }
        int User_id;
        string ConString = System.Configuration.ConfigurationManager.ConnectionStrings["Database1ConnectionString"].ConnectionString;

        public string datecurrent;
        public void getuserid()
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
 
        }
        Database db = new Database();
        DataTable tbl = new DataTable();
        string StuId;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                getuserid();
                AutoNumber();
           
                 date1 = from.Value.ToString("yyyy-MM-dd");
                 date2 = To.Value.ToString("yyyy-MM-dd");
           
                tbl = db.readData("SELECT  [Student_Id],[Student_Name],[Deitls_Id] FROM [fightGym].[dbo].[Students] where  [Student_Name]='"+firstName.Text+"' ", "");
                if(tbl.Rows.Count <= 0 ) { } else
                {
                    StuId = tbl.Rows[0][2].ToString();

                    db.executeData(" UPDATE  [fightGym].[dbo].[Tbl_eshtrackat] set [statys]='0'  where [Student_id]='" + StuId + "'  ", "");
                    db.executeData("update  [dbo].[Student_Deitls] set   [status] ='0'   where [Deitls_Id]='" + StuId + "' ", "");
                    db.executeData("INSERT INTO [dbo].[Tbl_eshtrackat]([Student_id] ,[From] ,[To]      ,[emp_id]  ,[class_name]  ,[mount],Entertime,statys,[TrainerName]) VALUES('" + StuId + "','" + date1 + "','" + date2 + "','" + User_id + "','" + typecourse.Text + "','" + txtMony.Text + "','" + datecurrent + "','true','" + txtEmpname.Text + "')", "تم الحفظ  بنجاح");

                }
                //return inserted data
                searchStu();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                getuserid();
                date1 = from.Value.ToString("yyyy-MM-dd");
                date2 = To.Value.ToString("yyyy-MM-dd");
                //  ntertime,statys) '" + StuId + "','" + date1 + "','" + date2 + "','" + User_id + "','" + typecourse.Text + "','" + txtMony.Text + "','" + datecurrent + "','true')", "");
                tbl = db.readData("SELECT  [Deitls_Id],[Student_Name],[Deitls_Id] FROM [fightGym].[dbo].[Students] where  [Deitls_Id]='" + txtID.Text + "'", "");
                if (tbl.Rows.Count <= 0) { }
                else
                {
                    StuId = tbl.Rows[0][2].ToString();
                    db.executeData("update  [dbo].[Tbl_eshtrackat] set [Student_id] ='" + StuId + "' ,[TrainerName]='" + txtEmpname.Text + "',[From] ='" + date1 + "',[To]='" + date2 + "'      ,[emp_id] ='" + User_id + "' ,[class_name] ='" + typecourse.Text + "' ,[mount]='" + txtMony.Text + "',Entertime='" + datecurrent + "',statys='true'  where Student_id='" + StuId + "' ", "  تم التحديث بنجاح  ");

                }
            // searchStu();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Print();

        }
        public void Print()
        {
            try
            {
                DataTable tblrpt = new DataTable();
                //int idinvoce = Convert.ToInt16(txtidsheet.Text);

                //int numbEmp = Convert.ToInt16(Properties.Settings.Default.EmpiD);
                //int.Parse(view.GetRowCellValue(e.RowHandle, "empid").ToString());
               // tblrpt.Clear();


                ReportsMony xtraReport1 = new ReportsMony();
                tblrpt = db.readData("SELECT  [ID] ,[Students].Student_Name ,[Students].pic,[From],[To] ,Roles.Employee_Name,[class_name] ,[mount] ,[Entertime] FROM [fightGym].[dbo].[Tbl_eshtrackat]  INNER Join Roles  ON Tbl_eshtrackat.emp_id = Roles.role_Id  INNER Join [Students] ON Tbl_eshtrackat.Student_id = [Students].Deitls_Id  where Tbl_eshtrackat. Student_id ='"+txtID.Text+ "' and  Tbl_eshtrackat.[statys]='1'", "");

                 if (tblrpt.Rows.Count >= 1)
                {
                    xtraReport1.DataMember = Convert.ToString(tblrpt);
                    xtraReport1.DataSource = tblrpt;
                }
                else
                {
                    MessageBox.Show("لاتوجد بيانات");
                }
                ReportPrintTool reportsPrintTool = new ReportPrintTool(xtraReport1);
                reportsPrintTool.ShowRibbonPreview();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

        }

        private void txtSearch2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void eshtrakData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Rectangle _Rectangle;
            if (e.ColumnIndex == 10)
            {
               
                switch (eshtrakData.Columns[e.ColumnIndex].Name)
                {
                    case "Column10":
                        _Rectangle = eshtrakData.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true); //  
                        dtp.Size = new Size(_Rectangle.Width, _Rectangle.Height); //  
                        dtp.Location = new Point(_Rectangle.X, _Rectangle.Y); //  
                        dtp.CustomFormat = "yyyy-MM-dd";
                        dtp.Visible = true;

                        break;

                    case "Column11":

                        _Rectangle = eshtrakData.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true); //  
                        dtp.Size = new Size(_Rectangle.Width, _Rectangle.Height); //  
                        dtp.Location = new Point(_Rectangle.X, _Rectangle.Y); //  
                        dtp.CustomFormat = "yyyy-MM-dd";
                        dtp.Visible = true;

                        break;
                }
                getuserid();
                date1 = eshtrakData.CurrentRow.Cells[6].Value.ToString();
                date2 = eshtrakData.CurrentRow.Cells[7].Value.ToString();

                db.executeData("update  [dbo].[Tbl_eshtrackat] set [Student_id] ='" + eshtrakData.CurrentRow.Cells[0].Value + "' ,[From] ='" + date1 + "',[To]='" + date2 + "'      ,[emp_id] ='" + User_id + "' ,[class_name] ='" + eshtrakData.CurrentRow.Cells[4].Value + "' ,[mount]='" + eshtrakData.CurrentRow.Cells[5].Value + "',Entertime='" + datecurrent + "',statys='"+ eshtrakData.CurrentRow.Cells[8].Value + "',[TrainerName]='"+ eshtrakData.CurrentRow.Cells[3].Value + "'  where [ID]='" + eshtrakData.CurrentRow.Cells[0].Value + "' ", "  تم التحديث بنجاح  ");
            //    searchStu();

            }
                /*   getuserid();
                date1 = from.Value.ToString("yyyy-MM-dd");
                date2 = To.Value.ToString("yyyy-MM-dd");
                //  ntertime,statys) '" + StuId + "','" + date1 + "','" + date2 + "','" + User_id + "','" + typecourse.Text + "','" + txtMony.Text + "','" + datecurrent + "','true')", "");
                tbl = db.readData("SELECT  [Deitls_Id],[Student_Name],[Deitls_Id] FROM [fightGym].[dbo].[Students] where  [Deitls_Id]='" + txtID.Text + "'", "");
                if (tbl.Rows.Count <= 0) { }
                else
                {
                    StuId = tbl.Rows[0][2].ToString();
                }
                db.executeData("update  [dbo].[Tbl_eshtrackat] set [Student_id] ='"+ StuId + "' ,[From] ='"+ date1 + "',[To]='"+ date2+ "'      ,[emp_id] ='"+User_id+ "' ,[class_name] ='"+ typecourse.Text + "' ,[mount]='"+ txtMony.Text + "',Entertime='"+ datecurrent + "',statys='true'  where Student_id='"+StuId+"' ", "  تم التحديث بنجاح  ");
                searchStu();*/
          
            if (e.ColumnIndex == 9)
            {

             
                switch (eshtrakData.Columns[e.ColumnIndex].Name)
                {
                    case "Column10":

                        _Rectangle = eshtrakData.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true); //  
                        dtp.Size = new Size(_Rectangle.Width, _Rectangle.Height); //  
                        dtp.Location = new Point(_Rectangle.X, _Rectangle.Y); //  
                        dtp.CustomFormat = "yyyy-MM-dd";
                        dtp.Visible = true;

                        break;

                    case "Column11":

                        _Rectangle = eshtrakData.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true); //  
                        dtp.Size = new Size(_Rectangle.Width, _Rectangle.Height); //  
                        dtp.Location = new Point(_Rectangle.X, _Rectangle.Y); //  
                        dtp.CustomFormat = "yyyy-MM-dd";
                        dtp.Visible = true;

                        break;
                }
                date1 = eshtrakData.CurrentRow.Cells[6].Value.ToString();
                date2 = eshtrakData.CurrentRow.Cells[7].Value.ToString();
                try
                {
                    db.executeData("INSERT INTO [dbo].[Tbl_eshtrackat]([Student_id] ,[From] ,[To]      ,[emp_id]  ,[class_name]  ,[mount],Entertime,statys) VALUES('" + eshtrakData.CurrentRow.Cells[1].Value + "','" + date1 + "','" + date2 + "','" + User_id + "','" + eshtrakData.CurrentRow.Cells[4].Value + "','" + eshtrakData.CurrentRow.Cells[5].Value + "','" + datecurrent + "','" + eshtrakData.CurrentRow.Cells[5].Value + "')", "");
                    MessageBox.Show("تم الحفظ  بنجاح");
                   // searchStu();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            switch (eshtrakData.Columns[e.ColumnIndex].Name)
            {
                case "Column10":
           
                    _Rectangle = eshtrakData.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true); //  
                    dtp.Size = new Size(_Rectangle.Width, _Rectangle.Height); //  
                    dtp.Location = new Point(_Rectangle.X, _Rectangle.Y); //  
                    dtp.CustomFormat = "yyyy-MM-dd";
                    dtp.Visible = true;

                    break;

                case "Column11":
                
                    _Rectangle = eshtrakData.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true); //  
                    dtp.Size = new Size(_Rectangle.Width, _Rectangle.Height); //  
                    dtp.Location = new Point(_Rectangle.X, _Rectangle.Y); //  
                    dtp.CustomFormat="yyyy-MM-dd";
                    dtp.Visible = true;

                    break;


            }
        }

        private void eshtrakData_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Rectangle _Rectangle;
                switch (eshtrakData.Columns[e.ColumnIndex].Name)
                {
                    case "Column10":

                        _Rectangle = eshtrakData.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true); //  
                        dtp.Size = new Size(_Rectangle.Width, _Rectangle.Height); //  
                        dtp.Location = new Point(_Rectangle.X, _Rectangle.Y); //  
                        dtp.CustomFormat = "yyyy-MM-dd";
                        dtp.Visible = true;

                        break;

                    case "Column11":

                        _Rectangle = eshtrakData.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true); //  
                        dtp.Size = new Size(_Rectangle.Width, _Rectangle.Height); //  
                        dtp.Location = new Point(_Rectangle.X, _Rectangle.Y); //  
                        dtp.CustomFormat = "yyyy-MM-dd";
                        dtp.Visible = true;

                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

        }

        private void eshtrakData_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Rectangle _Rectangle;
                switch (eshtrakData.Columns[e.ColumnIndex].Name)
                {
                    case "Column10":

                        _Rectangle = eshtrakData.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true); //  
                        dtp.Size = new Size(_Rectangle.Width, _Rectangle.Height); //  
                        dtp.Location = new Point(_Rectangle.X, _Rectangle.Y); //  
                        dtp.CustomFormat = "yyyy-MM-dd";
                        dtp.Visible = true;

                        break;

                    case "Column11":

                        _Rectangle = eshtrakData.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true); //  
                        dtp.Size = new Size(_Rectangle.Width, _Rectangle.Height); //  
                        dtp.Location = new Point(_Rectangle.X, _Rectangle.Y); //  
                        dtp.CustomFormat = "yyyy-MM-dd";
                        dtp.Visible = true;

                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}