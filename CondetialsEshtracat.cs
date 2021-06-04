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
using System.Threading;
using System.IO;
using DevExpress.XtraReports.UI;

namespace FighyGym2
{
    public partial class CondetialsEshtracat : DevExpress.XtraEditors.XtraUserControl
    {
        string ConString = System.Configuration.ConfigurationManager.ConnectionStrings["Database1ConnectionString"].ConnectionString;
        int days;
        string date2;
        string DateToCompare;
        int prce;
        string date1;
        DateTime date11;
        Classalarm clss = new Classalarm();
        DataTable tbl = new DataTable();
        public CondetialsEshtracat()
        {
            InitializeComponent();
        }

        private static CondetialsEshtracat _instance;
        public static CondetialsEshtracat Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new CondetialsEshtracat();
                return _instance;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            //GmNm();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        Database db = new Database();


        private void CompFun()
        {
       
            if(dataGridView1.RowCount- 1 > 0)
            {

                DataTable tbl1 = new DataTable();
                for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                {
                    //////   tbl = db.readData("SELECT [Classrooms_Name] ,[Price] ,note FROM [fightGym].[dbo].[Classrooms] where note='"+dataGridView1.Rows[i].Cells[1].Value+"'", "");
                    string selected = this.typecourse.GetItemText(this.typecourse.SelectedItem);
                    tbl1.Clear();
                    //tbl = db.readData("SELECT  [ID],[Students].Student_Name,[From],[To],[class_name],[mount],[statys] FROM [fightGym].[dbo].[Tbl_eshtrackat]  INNER JOIN[dbo].[Students] ON Students.Deitls_Id = Tbl_eshtrackat.Student_id  where ID='"+dataGridView1.CurrentRow.Cells[0].Value+"' ", "");
                    tbl1 = db.readData("SELECT    dbo.Classrooms.note, dbo.Tbl_eshtrackat.class_name, dbo.Classrooms.Price, dbo.Tbl_eshtrackat.mount FROM       dbo.Classrooms INNER JOIN    dbo.Tbl_eshtrackat ON dbo.Classrooms.note = dbo.Tbl_eshtrackat.class_name where dbo.Classrooms.note='" + selected + "' GROUP BY dbo.Classrooms.note, dbo.Tbl_eshtrackat.class_name, dbo.Classrooms.Price, dbo.Tbl_eshtrackat.mount ", "");

                    if (tbl1.Rows.Count <= 0)
                    {
                    }
                    else { prce = Convert.ToInt32(tbl1.Rows[0][2].ToString()); }
                   
                        string c = dataGridView1.Rows[i].Cells[4].Value.ToString();
                        date11 = Convert.ToDateTime(dataGridView1.Rows[i].Cells[4].Value);
                    
                   
                 
                    DateTime sysdate = DateTime.Today;



                    double d = (sysdate - date11).TotalDays;
                    DateTime sysdate2 = DateTime.Today;
                    if (d >= 28)
                    {
                        dataGridView1.Rows[i].Cells[6].Value = "انتهى الاشتراك حديثا";
                        dataGridView1.Rows[i].Cells[6].Style.BackColor = Color.Red;
                    }


                    else if (d < 28)
                    {
                        if (Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value) < prce)
                        {
                            dataGridView1.Rows[i].Cells[6].Value = "يرجى تسديد الاشتراك ";
                            dataGridView1.Rows[i].Cells[6].Style.BackColor = Color.Yellow;
                        }
                        else
                        {
                            dataGridView1.Rows[i].Cells[6].Value = "  لازال الاشتراك جاري ";
                            dataGridView1.Rows[i].Cells[6].Style.BackColor = Color.LightGreen;
                        }
                    }



                }
            }
        }
     
        private void GmNm()
        {
            typecourse.BeginUpdate();
            typecourse.DataSource = db.readData("SELECT [Classrooms_Id] ,[Classrooms_Name],[Teacher_Id]  ,[fatarh],[faah],[senf] ,[User_id] ,[Entertime],[Price] ,[note] FROM [fightGym].[dbo].[Classrooms] ", "");
            typecourse.DisplayMember = "note";
            typecourse.ValueMember = "Classrooms_Id";
            typecourse.EndUpdate();
        }

        private void CondetialsEshtracat_Load(object sender, EventArgs e)
        {
           GmNm();
            
        }
      

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           try { 
            //get data to show it in detials form
            if (e.ColumnIndex == 8)
            {
                tbl = db.readData("SELECT    dbo.[Tbl_eshtrackat].[Student_id],dbo.Students.Student_Name, dbo.Tbl_eshtrackat.[From], dbo.Tbl_eshtrackat.[To], dbo.Tbl_eshtrackat.[mount],dbo.Students.Phone_Number, dbo.Tbl_eshtrackat.class_name,dbo.Tbl_eshtrackat.[TrainerName], dbo.Student_Deitls.pic FROM      dbo.Student_Deitls INNER JOIN dbo.Students ON dbo.Student_Deitls.Deitls_Id = dbo.Students.Deitls_Id INNER JOIN    dbo.Tbl_eshtrackat ON dbo.Students.Deitls_Id = dbo.Tbl_eshtrackat.Student_id where dbo.Tbl_eshtrackat.[Student_id]='" + dataGridView1.CurrentRow.Cells[0].Value+"'", "");
                    if (tbl.Rows.Count > 0)
                    {
                      try
                        {
                        Properties.Settings.Default.StuName = tbl.Rows[0][1].ToString();
                        Properties.Settings.Default.ClassName = tbl.Rows[0][4].ToString();
                        Properties.Settings.Default.DateBegin = tbl.Rows[0][1].ToString();
                        Properties.Settings.Default.phone = tbl.Rows[0][4].ToString();
                        Properties.Settings.Default.DateEnd = tbl.Rows[0][2].ToString();
                        Properties.Settings.Default.amount = tbl.Rows[0][3].ToString();
                        Properties.Settings.Default.Id = tbl.Rows[0][0].ToString();
                        Properties.Settings.Default.pic = tbl.Rows[0][8].ToString();
                        Properties.Settings.Default.typetrainer = tbl.Rows[0][7].ToString();
                        FRM_DatialsEshtrackat frm = new FRM_DatialsEshtrackat();
                        frm.Show();
                        }
                        catch (Exception ex) { MessageBox.Show(ex.Message); }
                    }
               
            }
            if (e.ColumnIndex == 7)
            {
               try {
                    tbl = db.readData("SELECT    dbo.[Tbl_eshtrackat].[Student_id],dbo.Students.Student_Name, dbo.Tbl_eshtrackat.[From], dbo.Tbl_eshtrackat.[To], dbo.Tbl_eshtrackat.[mount],dbo.Students.Phone_Number, dbo.Tbl_eshtrackat.class_name,dbo.Tbl_eshtrackat.[TrainerName], dbo.Student_Deitls.pic FROM      dbo.Student_Deitls INNER JOIN dbo.Students ON dbo.Student_Deitls.Deitls_Id = dbo.Students.Deitls_Id INNER JOIN    dbo.Tbl_eshtrackat ON dbo.Students.Deitls_Id = dbo.Tbl_eshtrackat.Student_id where dbo.Tbl_eshtrackat.ID='" + dataGridView1.CurrentRow.Cells[9].Value + "'", "");

                    Properties.Settings.Default.StuName= Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
                    Properties.Settings.Default.amount =Convert.ToString( dataGridView1.CurrentRow.Cells[3].Value);
                    Properties.Settings.Default.Id = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
                    Properties.Settings.Default.ClassName= Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
                    Properties.Settings.Default.DateBegin = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value);
                    Properties.Settings.Default.DateEnd = Convert.ToString(dataGridView1.CurrentRow.Cells[5].Value);
                    Properties.Settings.Default.typetrainer = Convert.ToString( tbl.Rows[0][7].ToString());
                    UpdateEshtrack frm = new UpdateEshtrack();
                    frm.Show();
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                }
            }
            catch (Exception) { }
        }


        public static Image ByteArrayToImage(byte[] byteArrayIn)
        {
            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                Image returnImage = Image.FromStream(ms);
                return returnImage;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
             date1 = Dtpfrom.Value.ToString("yyyy-MM-dd");
            date2 = DtpTo.Value.ToString("yyyy-MM-dd");
            Properties.Settings.Default.date1 = Convert.ToDateTime(date1);
            Properties.Settings.Default.date2 = Convert.ToDateTime(date2);
            SqlConnection conn = new SqlConnection(ConString);
       
            string da = "SELECT    dbo.Tbl_eshtrackat.Student_id ,dbo.Student_Deitls.First_name , dbo.Tbl_eshtrackat.class_name , dbo.Tbl_eshtrackat.mount , dbo.Tbl_eshtrackat.[From] , dbo.Tbl_eshtrackat.[To] , dbo.Tbl_eshtrackat.statys ,dbo.Tbl_eshtrackat.ID FROM   dbo.Student_Deitls INNER JOIN dbo.Students ON dbo.Student_Deitls.Deitls_Id = dbo.Students.Deitls_Id INNER JOIN  dbo.Tbl_eshtrackat ON dbo.Students.Deitls_Id = dbo.Tbl_eshtrackat.Student_id where  dbo.Tbl_eshtrackat.[From] between '" + date1 + "' and '" + date2 + "' and dbo.Tbl_eshtrackat.[statys]='1' group by dbo.Student_Deitls.First_name, dbo.Tbl_eshtrackat.[From], dbo.Tbl_eshtrackat.[To], dbo.Tbl_eshtrackat.class_name, dbo.Tbl_eshtrackat.mount, dbo.Tbl_eshtrackat.statys, dbo.Tbl_eshtrackat.Student_id ,dbo.Tbl_eshtrackat.ID   ORDER BY  dbo.Tbl_eshtrackat.[From] ASC ";
            SqlCommand comandReader = new SqlCommand(da, conn);
            conn.Open();
            comandReader.ExecuteNonQuery();
            //   conn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter(comandReader);

            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();

            CompFun();

        }

        private void typecourse_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //string selected = this.typecourse.GetItemText(this.typecourse.SelectedItem);
            //tbl.Clear();
            //// string da = "SELECT  Tbl_eshtrackat.[Student_id],[Students].Student_Name ,[From] ,[To]  ,[class_name] ,[mount]   ,[statys] FROM [fightGym].[dbo].[Tbl_eshtrackat]  INNER JOIN [dbo].[Students] ON Students.Deitls_Id = Tbl_eshtrackat.Student_id  where statys='1' and class_name='" + selected + "' ";

            //tbl = db.readData(" SELECT    dbo.Tbl_eshtrackat.Student_id ,dbo.Student_Deitls.First_name , dbo.Tbl_eshtrackat.class_name , dbo.Tbl_eshtrackat.mount , dbo.Tbl_eshtrackat.[From] , dbo.Tbl_eshtrackat.[To] , dbo.Tbl_eshtrackat.statys  FROM   dbo.Student_Deitls INNER JOIN dbo.Students ON dbo.Student_Deitls.Deitls_Id = dbo.Students.Deitls_Id INNER JOIN  dbo.Tbl_eshtrackat ON dbo.Students.Deitls_Id = dbo.Tbl_eshtrackat.Student_id where  dbo.Tbl_eshtrackat.class_name='" + selected + "' GROUP BY dbo.Student_Deitls.First_name, dbo.Tbl_eshtrackat.[From], dbo.Tbl_eshtrackat.[To], dbo.Tbl_eshtrackat.class_name, dbo.Tbl_eshtrackat.mount, dbo.Tbl_eshtrackat.statys, dbo.Tbl_eshtrackat.Student_id ", "");
            //dataGridView1.DataSource = tbl;


            //CompFun();

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
         //   dataGridView1.CurrentRow.
        }

        private void typecourse_SelectedValueChanged(object sender, EventArgs e)
        {
           
        }

        private void typecourse_SelectedIndexChanged(object sender, EventArgs e)
        {
          //GmNm();
        }

        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            // GmNm();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Print();
        }
        //print between date 
        public void Print()
        {
            DataTable tblrpt = new DataTable();
            date1 = Dtpfrom.Value.ToString("yyyy-MM-dd");
            date2 = DtpTo.Value.ToString("yyyy-MM-dd");
            //int.Parse(view.GetRowCellValue(e.RowHandle, "empid").ToString());
            tblrpt.Clear();


            ReportsEshtrak xtraReport1 = new ReportsEshtrak();
          
            tblrpt = db.readData("SELECT  [ID] ,[Students].Student_Name ,[From] ,[To]  ,[class_name] ,[mount]   ,[statys] FROM [fightGym].[dbo].[Tbl_eshtrackat]  INNER JOIN [dbo].[Students] ON Students.Deitls_Id = Tbl_eshtrackat.Student_id  where statys='1' and dbo.Tbl_eshtrackat.[From] between '" + date1 + "' and '" + date2 + "'   group by [ID] ,[Students].Student_Name ,[From] ,[To]  ,[class_name] ,[mount]   ,[statys] ", "");
            if (tblrpt.Rows.Count >= 1)
            {
                xtraReport1.DataMember = Convert.ToString(tblrpt);
                xtraReport1.DataSource = tblrpt;

            }

            else { MessageBox.Show("لاتوجد بيانات"); }

            ReportPrintTool reportsPrintTool = new ReportPrintTool(xtraReport1);
            reportsPrintTool.ShowRibbonPreview();

        }

        //print coures
        public void PrintCors()
        {
            DataTable tblrpt = new DataTable();

            //int.Parse(view.GetRowCellValue(e.RowHandle, "empid").ToString());
            tblrpt.Clear();

            date1 = Dtpfrom.Value.ToString("yyyy-MM-dd");
            date2 = DtpTo.Value.ToString("yyyy-MM-dd");

            ReportsEshtrak xtraReport1 = new ReportsEshtrak();

            tblrpt = db.readData("SELECT  [ID] ,[Students].Student_Name ,[From] ,[To]  ,[class_name] ,[mount]   ,[statys] FROM [fightGym].[dbo].[Tbl_eshtrackat]  INNER JOIN [dbo].[Students] ON Students.Deitls_Id = Tbl_eshtrackat.Student_id  where statys='1' and dbo.Tbl_eshtrackat.[From] between '" + date1 + "' and '" + date2 + "'  and dbo.Tbl_eshtrackat.class_name='" + typecourse.Text+"'  group by [ID] ,[Students].Student_Name ,[From] ,[To]  ,[class_name] ,[mount]   ,[statys] ", "");
            if (tblrpt.Rows.Count >= 1)
            {
                xtraReport1.DataMember = Convert.ToString(tblrpt);
                xtraReport1.DataSource = tblrpt;

            }

            else { MessageBox.Show("لاتوجد بيانات"); }

            ReportPrintTool reportsPrintTool = new ReportPrintTool(xtraReport1);
            reportsPrintTool.ShowRibbonPreview();

        }

        private void typecourse_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string selected = this.typecourse.GetItemText(this.typecourse.SelectedItem);
                tbl.Clear();
                // string da = "SELECT  Tbl_eshtrackat.[Student_id],[Students].Student_Name ,[From] ,[To]  ,[class_name] ,[mount]   ,[statys] FROM [fightGym].[dbo].[Tbl_eshtrackat]  INNER JOIN [dbo].[Students] ON Students.Deitls_Id = Tbl_eshtrackat.Student_id  where statys='1' and class_name='" + selected + "' ";
                
                tbl = db.readData(" SELECT   dbo.Tbl_eshtrackat.ID, dbo.Tbl_eshtrackat.Student_id ,dbo.Student_Deitls.First_name , dbo.Tbl_eshtrackat.class_name , dbo.Tbl_eshtrackat.mount , dbo.Tbl_eshtrackat.[From] , dbo.Tbl_eshtrackat.[To] , dbo.Tbl_eshtrackat.statys  FROM   dbo.Student_Deitls INNER JOIN dbo.Students ON dbo.Student_Deitls.Deitls_Id = dbo.Students.Deitls_Id INNER JOIN  dbo.Tbl_eshtrackat ON dbo.Students.Deitls_Id = dbo.Tbl_eshtrackat.Student_id where  dbo.Tbl_eshtrackat.class_name='" + selected + "' and dbo.Tbl_eshtrackat.[statys]='1' GROUP BY dbo.Student_Deitls.First_name, dbo.Tbl_eshtrackat.[From], dbo.Tbl_eshtrackat.[To], dbo.Tbl_eshtrackat.class_name, dbo.Tbl_eshtrackat.mount, dbo.Tbl_eshtrackat.statys, dbo.Tbl_eshtrackat.Student_id ,dbo.Tbl_eshtrackat.ID   ORDER BY  dbo.Tbl_eshtrackat.[From] ASC", "");
                dataGridView1.DataSource = tbl;

                
                CompFun();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PrintCors();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            GmNm();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {

                try
                {


                    string selected = this.typecourse.GetItemText(this.typecourse.SelectedItem);
                    tbl.Clear();
                    // string da = "SELECT  Tbl_eshtrackat.[Student_id],[Students].Student_Name ,[From] ,[To]  ,[class_name] ,[mount]   ,[statys] FROM [fightGym].[dbo].[Tbl_eshtrackat]  INNER JOIN [dbo].[Students] ON Students.Deitls_Id = Tbl_eshtrackat.Student_id  where statys='1' and class_name='" + selected + "' ";
                    // string da = "SELECT   dbo.Tbl_eshtrackat.ID, dbo.Tbl_eshtrackat.Student_id ,dbo.Student_Deitls.First_name , dbo.Tbl_eshtrackat.class_name , dbo.Tbl_eshtrackat.mount , dbo.Tbl_eshtrackat.[From] , dbo.Tbl_eshtrackat.[To] , dbo.Tbl_eshtrackat.statys  FROM   dbo.Student_Deitls INNER JOIN dbo.Students ON dbo.Student_Deitls.Deitls_Id = dbo.Students.Deitls_Id INNER JOIN  dbo.Tbl_eshtrackat ON dbo.Students.Deitls_Id = dbo.Tbl_eshtrackat.Student_id where  dbo.Tbl_eshtrackat.[From] between '" + date1 + "' and '" + date2 + "' and dbo.Tbl_eshtrackat.[statys]='1' group by dbo.Student_Deitls.First_name, dbo.Tbl_eshtrackat.[From], dbo.Tbl_eshtrackat.[To], dbo.Tbl_eshtrackat.class_name, dbo.Tbl_eshtrackat.mount, dbo.Tbl_eshtrackat.statys, dbo.Tbl_eshtrackat.Student_id ,dbo.Tbl_eshtrackat.ID   ORDER BY  dbo.Tbl_eshtrackat.[From] ASC ";
                //    tbl = db.readData(" SELECT   dbo.Tbl_eshtrackat.ID, dbo.Tbl_eshtrackat.Student_id ,dbo.Student_Deitls.First_name , dbo.Tbl_eshtrackat.class_name , dbo.Tbl_eshtrackat.mount , dbo.Tbl_eshtrackat.[From] , dbo.Tbl_eshtrackat.[To] , dbo.Tbl_eshtrackat.statys  FROM   dbo.Student_Deitls INNER JOIN dbo.Students ON dbo.Student_Deitls.Deitls_Id = dbo.Students.Deitls_Id INNER JOIN  dbo.Tbl_eshtrackat ON dbo.Students.Deitls_Id = dbo.Tbl_eshtrackat.Student_id where  dbo.Student_Deitls.First_name ='"+dataGridView1.CurrentRow.Cells[1].Value+"' and dbo.Tbl_eshtrackat.[statys]='1' GROUP BY dbo.Student_Deitls.First_name, dbo.Tbl_eshtrackat.[From], dbo.Tbl_eshtrackat.[To], dbo.Tbl_eshtrackat.class_name, dbo.Tbl_eshtrackat.mount, dbo.Tbl_eshtrackat.statys, dbo.Tbl_eshtrackat.Student_id ,dbo.Tbl_eshtrackat.ID   ORDER BY  dbo.Tbl_eshtrackat.[From] ASC", "");

                    tbl = db.readData("SELECT  dbo.Tbl_eshtrackat.ID, dbo.Tbl_eshtrackat.Student_id ,dbo.Student_Deitls.First_name , dbo.Tbl_eshtrackat.class_name , dbo.Tbl_eshtrackat.mount , dbo.Tbl_eshtrackat.[From] , dbo.Tbl_eshtrackat.[To] , dbo.Tbl_eshtrackat.statys  FROM   dbo.Student_Deitls INNER JOIN dbo.Students ON dbo.Student_Deitls.Deitls_Id = dbo.Students.Deitls_Id INNER JOIN  dbo.Tbl_eshtrackat ON dbo.Students.Deitls_Id = dbo.Tbl_eshtrackat.Student_id where  dbo.Student_Deitls.First_name ='"+dataGridView1.CurrentRow.Cells[1].Value+"' and dbo.Tbl_eshtrackat.[statys]='1' GROUP BY dbo.Student_Deitls.First_name, dbo.Tbl_eshtrackat.[From], dbo.Tbl_eshtrackat.[To], dbo.Tbl_eshtrackat.class_name, dbo.Tbl_eshtrackat.mount, dbo.Tbl_eshtrackat.statys, dbo.Tbl_eshtrackat.Student_id ,dbo.Tbl_eshtrackat.ID   ORDER BY  dbo.Tbl_eshtrackat.[From] ASC", "");
                    if (tbl.Rows.Count > 0)
                    {
                        dataGridView1.CurrentRow.Cells[9].Value = tbl.Rows[0][0].ToString();
                        dataGridView1.CurrentRow.Cells[0].Value = tbl.Rows[0][1].ToString();
                        dataGridView1.CurrentRow.Cells[1].Value = tbl.Rows[0][2].ToString();
                        dataGridView1.CurrentRow.Cells[2].Value = tbl.Rows[0][3].ToString();
                        dataGridView1.CurrentRow.Cells[3].Value = tbl.Rows[0][4].ToString();
                        dataGridView1.CurrentRow.Cells[4].Value = tbl.Rows[0][5].ToString();
                        dataGridView1.CurrentRow.Cells[5].Value = tbl.Rows[0][6].ToString();
                     
                        CompFun();
                    }
                
                    //    dataGridView1.DataSource = tbl;
                }
             
                  
                   // dataGridView1.Columns["First_name"].DefaultCellStyle.NullValue = null;
           

                  catch (Exception ex)
                {

                }
            }

            }
    }
}

