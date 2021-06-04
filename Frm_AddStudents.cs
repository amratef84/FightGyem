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
using System.IO;
using DevExpress.XtraReports.UI;

namespace FighyGym2
{
    public partial class Frm_AddStudents : DevExpress.XtraEditors.XtraForm
    {
       public string datecurrent;
        int User_id, StuId;
        string idStu;
        private static Frm_AddStudents _instance;
        string dateBirth;
        //Database db = new Database();
        DataTable tbl = new DataTable();
        Boolean healthisgood, sport, stst;
        public static Frm_AddStudents Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Frm_AddStudents();
                return _instance;
            }
        }
        int IDnumber;
       
        public string colfirstname, colsecondname, colthname, collastname, fullname, classcourse;
        public static SqlConnection connction;
        public static SqlCommand SelectAccountnumb;
        Database db = new Database();
        string Path;

        private void typecourse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void GmNm()
        {

            typecourse.DataSource = db.readData("SELECT [Classrooms_Id] ,[Classrooms_Name],[Teacher_Id]  ,[fatarh],[faah],[senf] ,[User_id] ,[Entertime],[Price] ,[note] FROM [fightGym].[dbo].[Classrooms] ", "");
            typecourse.DisplayMember = "note";
            typecourse.ValueMember = "Classrooms_Id";

            //cbxtypeplayer.DataSource = db.readData("SELECT  [ID],[Senf],[Ftrah],[Feaah]  ,[user_id],[Entertime],[Days] FROM [fightGym].[dbo].[Set_fatrat]", "");
            //cbxtypeplayer.DisplayMember = "Feaah";
            //cbxtypeplayer.ValueMember = "ID";

            txtEmpname.DataSource = db.readData("SELECT [Employee_Id],[Employee_Name] ,[Phone_Number] ,[Account_Id],[Employee_Job],[Role] FROM [fightGym].[dbo].[Employees]", "");
            txtEmpname.DisplayMember = "Employee_Name";
            txtEmpname.ValueMember = "Employee_Id";
        }
        private void GetData()
        {
           try {
                string ihprice = Properties.Settings.Default.amount;
                phonNm.Text= Properties.Settings.Default.phone;
            txtohWhats.Text = Properties.Settings.Default.phoneW;
            typecourse.Text= Properties.Settings.Default.ClassName;
                if (Properties.Settings.Default.pic == "")
                {
                } else
                {
                    pictureBox1.Load(Properties.Settings.Default.pic);
                }
                // typecourse.Text = Properties.Settings.Default.ClassName;
                txtEmpname.Text = Properties.Settings.Default.typetrainer;
            From.Text = Properties.Settings.Default.DateBegin;
            To.Text= Properties.Settings.Default.DateEnd;
                if (Properties.Settings.Default.stats == "1")
                {
                    chktrue.Checked = true;
                }else
                {
                    chktrue.Checked = false;
                }
                pirthdatepick.Text = Properties.Settings.Default.DirthDate;
                adress.Text = Properties.Settings.Default.adress;
                nationalty.Text = Properties.Settings.Default.Nationality;
                firstName.Text = Properties.Settings.Default.StuName;
                pudprice.Text = Properties.Settings.Default.amount;
                txtEmpname.Text = Properties.Settings.Default.typetrainer;
            }
            catch (Exception ex) {  }

        }
        private void Frm_AddStudents_Load(object sender, EventArgs e)
        {
           


            if (Properties.Settings.Default.Id == "")
            {
                GmNm();
            }
            else
            {
                GetData();
                
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
        string imagePath = "";
        private void pictureBox1_Click(object sender, EventArgs e)
        {
           

            //OpenFileDialog opFile = new OpenFileDialog();
            //opFile.Title = "Select a Image";
            //opFile.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";
            //string name = firstName + "" + phonNm;
            //string appPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\Resources\"; // <---
            //if (Directory.Exists(appPath) == false)                                              // <---
            //{                                                                                    // <---
            //    Directory.CreateDirectory(appPath);                                              // <---
            //}                                                                                    // <---

            //if (opFile.ShowDialog() == DialogResult.OK)
            //{
            //    try
            //    {
            //        string iName = opFile.SafeFileName;   // <---
            //        string filepath = opFile.FileName;
            //     //   File.WriteAllText(filepath, firstName +""+ phonNm);
            //        // <---
            //      File.Copy(filepath, appPath + iName); // <---
            //      //  File.Copy(iName, Path.Combine(@"\Resources\", Path.GetFileName(iName)));
            //        pictureBox1.Image = new Bitmap(opFile.OpenFile());
            //    }
            //    catch (Exception exp)
            //    {
            //        MessageBox.Show("Unable to open file " + exp.Message);
            //    }
            //}
            //else
            //{
            //    opFile.Dispose();
            //}
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            getuserid();
      
            if (chktrue.Checked == true)
            {
                stst = true;
            }
            else
            {
                stst = false;
            }
            try
            {

                pictureBox1.Tag= firstName.Text + "" + phonNm.Text;
                string ConString = System.Configuration.ConfigurationManager.ConnectionStrings["Database1ConnectionString"].ConnectionString;
                SqlConnection cnn = new SqlConnection(ConString);
                SqlCommand sc, insertStudent, scd, cscd3;
                cnn.Open();
                 datecurrent = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                string datecreatinAccount = DateTime.Now.ToString("yyyy-MM-dd");
                DataTable tbl1 = new DataTable();
                tbl1 = db.readData("SELECT  [Deitls_Id],[First_name],[Father_Name],[GrandFather_Name],[Last_Name],[Birth_Day] ,[Nationalty] ,[Adress],[Longth],[Evalute],[Health],[Sport],[type_student] ,[Date],[Classroom_id],[Wieght],[phone_number],[phwats] ,[status],[pic] FROM [fightGym].[dbo].[Student_Deitls] where First_name='"+firstName.Text+"' ", "");
                if(tbl1.Rows.Count> 0)
                {
                    MessageBox.Show("سابقاً" + "'" + firstName.Text + "'" +  "لقد قمت بحفظ " );

                }else
                {
                    string sql = "Insert into Student_Deitls(First_name,Father_Name,GrandFather_Name,Last_Name,Birth_Day,Nationalty,Adress,Longth,Evalute,Health,Sport,type_student,Date,Classroom_id,Wieght,phone_number,phwats,status,pic) values('" + firstName.Text + "','','', '','" + pirthdatepick.Text + "','" + nationalty.Text + "','" + adress.Text + "','','','" + healthisgood + "','" + sport + "','','" + datecurrent + "','" + typecourse.Text + "','','" + phonNm.Text + "','" + txtohWhats.Text + "','" + stst + "','" + imagePath + "');";
                    try
                    {
                        //cnn.Open();
                        //  MessageBox.Show("Data Saved..");
                        sc = new SqlCommand(sql, cnn);
                        sc.ExecuteNonQuery();
                        sc.Dispose();
                        MessageBox.Show("تم تعبئة الاستمارة بنجاح");
                        SqlDataReader reader = null;
                        SqlDataReader reader1 = null;
                        SqlDataReader reader2 = null;
                        SqlDataReader reader3 = null;
                        SqlDataReader reader4 = null;
                        SqlDataReader reader5 = null;
                        SqlDataReader reader6 = null;
                        string selectCmd = "SELECT Deitls_Id, First_name,Father_Name,GrandFather_Name ,Last_Name ,phone_number,Classroom_id,phwats  FROM  Student_Deitls   where First_name='" + firstName.Text + "'   ";
                        scd = new SqlCommand(selectCmd, cnn);

                        reader = scd.ExecuteReader();
                        while (reader.Read())
                        {
                            colfirstname = (string)(reader["First_name"]);

                        }
                        reader.Close();
                        reader1 = scd.ExecuteReader();
                        while (reader1.Read())
                        {
                            colsecondname = (string)(reader1["Father_Name"]);
                        }
                        reader1.Close();
                        reader2 = scd.ExecuteReader();
                        while (reader2.Read())
                        {
                            colthname = (string)(reader2["GrandFather_Name"]);
                        }
                        reader2.Close();
                        reader3 = scd.ExecuteReader();
                        while (reader3.Read())
                        {
                            collastname = (string)(reader3["Last_Name"]);
                        }
                        reader3.Close();
                        reader4 = scd.ExecuteReader();
                        while (reader4.Read())
                        {
                            phonestu = (int)(reader4["phone_number"]);
                        }
                        reader4.Close();
                        reader5 = scd.ExecuteReader();
                        while (reader5.Read())
                        {
                            classcourse = (string)(reader5["Classroom_id"]);
                        }
                        reader5.Close();
                        reader6 = scd.ExecuteReader();
                        while (reader6.Read())
                        {
                            StuId = (int)(reader6["Deitls_Id"]);

                        }
                        reader6.Close();

                        fullname = colfirstname + " " + colsecondname + " " + colthname + " " + collastname;

                        try
                        {

                            SqlConnection connInsert = new SqlConnection(ConString);
                            connInsert.Open();
                            string sqltostudent = "Insert into Students(Student_Name,Phone_Number,Classroom_id,Account_numb,[Deitls_Id],pic) values('" + fullname + "','" + phonestu + "','" + classcourse + "','','" + StuId + "','" + imagePath + "');";

                            SqlCommand insertt = new SqlCommand(sqltostudent, connInsert);
                            insertt.ExecuteNonQuery();
                            insertt.Dispose();

                            string date2;

                            string date1 = From.Value.ToString("yyyy-MM-dd");

                            date2 = To.Value.ToString("yyyy-MM-dd");
                            //    tbl.Clear();
                            // tbl= db.readData("SELECT  [Student_Id]  ,[Student_Name] ,[Phone_Number]    ,[Classroom_Id]  FROM [fightGym].[dbo].[Students] where Phone_Number='"+phonNm.Text+"' ", "");
                            // idStu = tbl.Rows[0][0].ToString();
                            db.executeData("INSERT INTO [dbo].[Tbl_eshtrackat]([Student_id] ,[From] ,[To]      ,[emp_id]  ,[class_name]  ,[mount],Entertime,statys,TrainerName) VALUES('" + StuId + "','" + date1 + "','" + date2 + "','" + User_id + "','" + typecourse.Text + "','" + pudprice.Text + "','" + datecurrent + "','" + stst + "','" + txtEmpname.Text + "')", "");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
           

            }
            catch (Exception ex)
            {

            }
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void pudprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != ',') && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

             //   MessageBox.Show("يجب أن يكون المدخل احرف");
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Print();
        }

        private void txtohWhats_TextChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void longth_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFalse.Checked == true)
            {
                chktrue.Checked = false;
            }
        }

       

      

        private void adress_TextChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            getuserid();

            if (chktrue.Checked == true)
            {
                stst = true;
            }
            else
            {
                stst = false;
            }
            try
            {
                DataTable tblgetpic = new DataTable();

                pictureBox1.Tag = firstName.Text + "" + phonNm.Text;
                string ConString = System.Configuration.ConfigurationManager.ConnectionStrings["Database1ConnectionString"].ConnectionString;
                SqlConnection cnn = new SqlConnection(ConString);
                SqlCommand sc, insertStudent, scd, cscd3;
                cnn.Open();
                datecurrent = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                 dateBirth = pirthdatepick.Value.ToString("dd-MM-yyyy");
                tblgetpic.Clear();
                tblgetpic = db.readData("SELECT [Deitls_Id] ,[pic] FROM [fightGym].[dbo].[Student_Deitls] where Deitls_Id='" + Properties.Settings.Default.Id + "'", "");
                if (tblgetpic.Rows[0][1].ToString() == "") { Path = imagePath; }
                else
                {
                    if (imagePath == "")
                    {
                        Path = tblgetpic.Rows[0][1].ToString();
                    }
                    else
                    {
                        Path = imagePath;
                    }
                
                }
                string datecreatinAccount = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
                string sql = "Update  Student_Deitls set First_name='"+ firstName.Text + "',Birth_Day='"+ pirthdatepick.Text + "',Nationalty='"+ nationalty.Text +"',Adress='" + adress.Text + "',Date='" + datecurrent + "',Classroom_id='" + typecourse.Text + "',phone_number='" + phonNm.Text +"',phwats='" + txtohWhats.Text + "',status='"+ stst + "',pic='"+ Path + "'  where [Deitls_Id]='" + Properties.Settings.Default.Id+"'";
                try
                {
                    //cnn.Open();
                    //  MessageBox.Show("Data Saved..");
                    sc = new SqlCommand(sql, cnn);
                    sc.ExecuteNonQuery();
                    sc.Dispose();
                    
                    SqlDataReader reader = null;
                    SqlDataReader reader1 = null;
                    SqlDataReader reader2 = null;
                    SqlDataReader reader3 = null;
                    SqlDataReader reader4 = null;
                    SqlDataReader reader5 = null;
                    SqlDataReader reader6 = null;
                    string hg = Properties.Settings.Default.Id;
                    string selectCmd = "SELECT Deitls_Id, First_name,Father_Name,GrandFather_Name ,Last_Name ,phone_number,Classroom_id,phwats  FROM  Student_Deitls where Deitls_Id='" + Properties.Settings.Default.Id+ "'   ";
                    scd = new SqlCommand(selectCmd, cnn);

                    reader = scd.ExecuteReader();
                    while (reader.Read())
                    {
                        colfirstname = (string)(reader["First_name"]);

                    }
                    reader.Close();
                    reader1 = scd.ExecuteReader();
                    while (reader1.Read())
                    {
                        colsecondname = (string)(reader1["Father_Name"]);
                    }
                    reader1.Close();
                    reader2 = scd.ExecuteReader();
                    while (reader2.Read())
                    {
                        colthname = (string)(reader2["GrandFather_Name"]);
                    }
                    reader2.Close();
                    reader3 = scd.ExecuteReader();
                    while (reader3.Read())
                    {
                        collastname = (string)(reader3["Last_Name"]);
                    }
                    reader3.Close();
                    reader4 = scd.ExecuteReader();
                    while (reader4.Read())
                    {
                        phonestu = (int)(reader4["phone_number"]);
                    }
                    reader4.Close();
                    reader5 = scd.ExecuteReader();
                    while (reader5.Read())
                    {
                        classcourse = (string)(reader5["Classroom_id"]);
                    }
                    reader5.Close();
                    reader6 = scd.ExecuteReader();
                    while (reader6.Read())
                    {
                        StuId = (int)(reader6["Deitls_Id"]);

                    }
                    reader6.Close();

                    fullname = colfirstname + " " + colsecondname + " " + colthname + " " + collastname;

                    try
                    {

                        SqlConnection connInsert = new SqlConnection(ConString);
                        connInsert.Open();
                        string sqltostudent = "update  Students set Student_Name='" + firstName.Text + "',Phone_Number='" + phonNm.Text + "',Classroom_id='" + typecourse.Text + "',[Deitls_Id] ='" + StuId + "',pic='"+Path+"' where Deitls_Id='" + StuId + "' ";

                        SqlCommand insertt = new SqlCommand(sqltostudent, connInsert);
                        insertt.ExecuteNonQuery();
                        insertt.Dispose();

                        string date2;
                        string date1 = From.Value.ToString("yyyy-MM-dd");
                        date2 = To.Value.ToString("yyyy-MM-dd");
                        //    tbl.Clear();
                        // tbl= db.readData("SELECT  [Student_Id]  ,[Student_Name] ,[Phone_Number]    ,[Classroom_Id]  FROM [fightGym].[dbo].[Students] where Phone_Number='"+phonNm.Text+"' ", "");
                        // idStu = tbl.Rows[0][0].ToString();
                        db.executeData("Update  [dbo].[Tbl_eshtrackat] set  [Student_id]='"+ StuId + "' ,[From]='"+date1+"' ,[To]='"+date2+"'      ,[emp_id] ='"+ User_id + "' ,[class_name]='"+typecourse.Text+"'  ,[mount]='"+pudprice.Text+"',Entertime='"+datecurrent+"',statys='"+stst+ "',TrainerName ='" + txtEmpname.Text + "' where Student_id='" + StuId + "'", "");
                        MessageBox.Show("تم تعديل الاستمارة بنجاح");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
            catch (Exception ex)
            {

            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            //here we declare mouse event handlers
            pictureBox1.MouseDown += new MouseEventHandler(pictureBox1_MouseDown_1);

            pictureBox1.MouseMove += new MouseEventHandler(pictureBox1_MouseMove);

            pictureBox1.MouseEnter += new EventHandler(pictureBox1_MouseEnter);
            Controls.Add(pictureBox1);
        }
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            Cursor = Cursors.Default;
        }
     

       
        //declare some variable for crop coordinates
        int crpX, crpY, rectW, rectH;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                pictureBox1.Refresh();
                //set width and height for crop rectangle.
                rectW = e.X - crpX;
                rectH = e.Y - crpY;
                Graphics g = pictureBox1.CreateGraphics();
                g.DrawRectangle(crpPen, crpX, crpY, rectW, rectH);
                g.Dispose();
            }
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            base.OnMouseEnter(e);
            Cursor = Cursors.Cross;
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "All Files (*.*) | *.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imagePath = openFileDialog.FileName.ToString();
                if (imagePath == "")
                {
                    tbl.Clear();
                   tbl= db.readData("SELECT [Deitls_Id] ,[pic] FROM [fightGym].[dbo].[Student_Deitls] where Deitls_Id='"+Properties.Settings.Default.Id +"'", "");
                     Path = tbl.Rows[0][1].ToString();
                }
                else
                {
                    pictureBox1.Image = null;
                    pictureBox1.ImageLocation = imagePath;
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
              

            }
        }

        private void phonNm_KeyPress(object sender, KeyPressEventArgs e)
        {
            // If you want, you can allow decimal (float) numbers
            if (!char.IsControl(e.KeyChar)  && !char.IsLetter(e.KeyChar))
            {
                e.Handled = false;

            //    MessageBox.Show("يجب أن يكون المدخل احرف");
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtohWhats_KeyPress(object sender, KeyPressEventArgs e)
        {
            // If you want, you can allow decimal (float) numbers
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = false;

                //    MessageBox.Show("يجب أن يكون المدخل احرف");
            }
            else
            {
                e.Handled = true;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            GmNm();
        }

        private void pictureBox1_MouseDown_1(object sender, MouseEventArgs e)
        {
            base.OnMouseDown(e);

            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                Cursor = Cursors.Cross;
                crpPen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
                // set initial x,y co ordinates for crop rectangle
                //this is where we firstly click on image
                crpX = e.X;
                crpY = e.Y;

            }
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            try { 
            label2.Text = "Dimensions :" + rectW + "," + rectH;
            Cursor = Cursors.Default;
            //Now we will draw the cropped image into pictureBox2
            Bitmap bmp2 = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.DrawToBitmap(bmp2, pictureBox1.ClientRectangle);

            Bitmap crpImg = new Bitmap(rectW, rectH);

            for (int i = 0; i < rectW; i++)
            {
                for (int y = 0; y < rectH; y++)
                {
                    Color pxlclr = bmp2.GetPixel(crpX + i, crpY + y);
                    crpImg.SetPixel(i, y, pxlclr);
                }
            }

            pictureBox2.Image = (Image)crpImg;
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            }
            catch (Exception) { }
        }

        // Declare crop pen for cropping image
        public Pen crpPen = new Pen(Color.White);
   

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (chktrue.Checked == true)
            {
                chkFalse.Checked = false;
            }
        }


        public void Print()
        {
            DataTable tblrpt = new DataTable();
            //int idinvoce = Convert.ToInt16(txtidsheet.Text);

            //int numbEmp = Convert.ToInt16(Properties.Settings.Default.EmpiD);
            //int.Parse(view.GetRowCellValue(e.RowHandle, "empid").ToString());
            tblrpt.Clear();


            ReportsMony xtraReport1 = new ReportsMony();
            StuId =Convert.ToInt32(Properties.Settings.Default.Id);
            tblrpt = db.readData("   SELECT  [ID]      ,[Students].Student_Name ,[Students].pic,[From],[To] ,Roles.Employee_Name,[class_name] ,[mount] ,[Entertime] FROM [fightGym].[dbo].[Tbl_eshtrackat]  INNER Join [fightGym].[dbo].Roles  ON Tbl_eshtrackat.emp_id = Roles.role_Id  INNER Join [fightGym].[dbo].[Students] ON Tbl_eshtrackat.Student_id = [Students].Deitls_Id  where Tbl_eshtrackat. Student_id ='" + StuId+"'", "");
        //    tblrpt = db.readData("SELECT emp_id,[Numb_HC],[Name],[Type],[mony] ,[Tax],[Cuttingmony],[ClearMony],[SideName] ,[note],[EnterTime],ID,sheetDetials,[typePen],[PentiaName],ShtNumb FROM [HC_YC].[dbo].[Tbl_SheetDrugsHalfYearDetiels] where ShtNumb='" + txtidsheet.Text + "'", "");
             if (tblrpt.Rows.Count >= 1) 

            {
                xtraReport1.DataMember = Convert.ToString(tblrpt);
                xtraReport1.DataSource = tblrpt;

            }

            else {
                MessageBox.Show("لاتوجد بيانات");
            }

            ReportPrintTool reportsPrintTool = new ReportPrintTool(xtraReport1);
            reportsPrintTool.ShowRibbonPreview();

        }

        public string countNUMB, resultNUMBSTu;
        public int phonestu;
        string deptname;
        string nametypeservice;
        public Frm_AddStudents()
        {
            InitializeComponent();

        }

   
    }
}