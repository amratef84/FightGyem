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
using System.IO;
using FighyGym2.Controler;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections;

namespace FighyGym2
{
    public partial class ConEditStudents : DevExpress.XtraEditors.XtraUserControl
    {
        string ConString = System.Configuration.ConfigurationManager.ConnectionStrings["Database1ConnectionString"].ConnectionString;
        DAL dal = new DAL();
        public ConEditStudents()
        {
            InitializeComponent();
        }
        private static ConEditStudents _instance;
        Database db = new Database();
        DataTable tbl = new DataTable();

        public static ConEditStudents Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ConEditStudents();
                return _instance;
            }
        }
        private void GetDate()
        {
            try
            {

                string selectCmd = "SELECT  dbo.Student_Deitls.Deitls_Id, dbo.Student_Deitls.First_name, dbo.Student_Deitls.Father_Name, dbo.Student_Deitls.GrandFather_Name, dbo.Student_Deitls.Last_Name, dbo.Student_Deitls.Birth_Day, dbo.Student_Deitls.Nationalty,      dbo.Student_Deitls.Adress, dbo.Student_Deitls.Longth, dbo.Student_Deitls.Evalute, dbo.Student_Deitls.Health, dbo.Student_Deitls.Sport, dbo.Student_Deitls.type_student, dbo.Student_Deitls.Date   ,  dbo.Student_Deitls.Classroom_id, dbo.Student_Deitls.Wieght, dbo.Student_Deitls.phone_number,dbo.Student_Deitls.status ,dbo.Student_Deitls.pic FROM       dbo.Student_Deitls ";
                gridControl1.DataSource = dal.SelectAll(selectCmd);

            }
            catch (Exception)
            {

                throw;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try { 
            SqlConnection cnn = new SqlConnection(ConString);
            cnn.Open();
            SqlDataReader reader1 = null;
            string selectCmd = "SELECT  dbo.Student_Deitls.Deitls_Id, dbo.Student_Deitls.First_name, dbo.Student_Deitls.Father_Name, dbo.Student_Deitls.GrandFather_Name, dbo.Student_Deitls.Last_Name, dbo.Student_Deitls.Birth_Day, dbo.Student_Deitls.Nationalty,      dbo.Student_Deitls.Adress, dbo.Student_Deitls.Longth, dbo.Student_Deitls.Evalute, dbo.Student_Deitls.Health, dbo.Student_Deitls.Sport, dbo.Student_Deitls.type_student, dbo.Student_Deitls.Date   ,  dbo.Student_Deitls.Classroom_id, dbo.Student_Deitls.Wieght, dbo.Student_Deitls.phone_number,dbo.Student_Deitls.status ,dbo.Student_Deitls.pic FROM       dbo.Student_Deitls         where  dbo.Student_Deitls.First_name like '%"+txtName.Text+"%' ";

            SqlCommand comanstudent = new SqlCommand(selectCmd, cnn);
            SqlDataReader reader2 = comanstudent.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Deitls_Id");
            dataTable.Columns.Add("First_name");
            dataTable.Columns.Add("Father_Name");
            dataTable.Columns.Add("GrandFather_Name");
            dataTable.Columns.Add("Last_Name");
            dataTable.Columns.Add("Birth_Day");
            dataTable.Columns.Add("Nationalty");
            dataTable.Columns.Add("Adress");
            dataTable.Columns.Add("Longth");
            dataTable.Columns.Add("Evalute");
            dataTable.Columns.Add("Health");
            dataTable.Columns.Add("Sport");
            dataTable.Columns.Add("type_student");
            dataTable.Columns.Add("Date");
          
            dataTable.Columns.Add("Wieght");
            dataTable.Columns.Add("phone_number");
            dataTable.Columns.Add("pic",Type.GetType("System.Byte[]"));          
            dataTable.Columns.Add("status");
            while (reader2.Read())
            {
              
                DataRow row = dataTable.NewRow();
                row["Deitls_Id"] = reader2["Deitls_Id"];
                //         row["pic"] = Image.FromFile("pic");
                string picture=Convert.ToString( reader2["pic"]);
            

                    if (picture == "")
                    {
                        // row["pic"] = "";


                    }
                    else
                    {
                        row["pic"] = File.ReadAllBytes(reader2["pic"].ToString());
                    }
             





                row["First_name"] = reader2["First_name"];
                row["Father_Name"] = reader2["Father_Name"];
                row["GrandFather_Name"] = reader2["GrandFather_Name"];
                row["Last_Name"] = reader2["Last_Name"];
                row["Birth_Day"] = reader2["Birth_Day"];
                row["Adress"] = reader2["Adress"];
                row["Longth"] = reader2["Longth"];
                row["Evalute"] = reader2["Evalute"];
                //row["Health"] = reader2["Health"];
                //row["Sport"] = reader2["Sport"];
                row["type_student"] = reader2["type_student"];
                //row["Date"] = reader2["Date"];

                row["Wieght"] = reader2["Wieght"];
                row["phone_number"] = reader2["phone_number"];
                //  row["Account_numb"] = reader2["Account_numb"];
                row["status"] = reader2["status"];
                row["Nationalty"] = reader2["Nationalty"];
                dataTable.Rows.Add(row);
            }
            reader2.Close();
            dataGridView1.DataSource = dataTable;

         dataGridView1.Refresh();
            cnn.Close();
            }
            catch ( Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void button3_Click(object sender, EventArgs e)
        {
           Properties.Settings.Default.phone="";
           Properties.Settings.Default.phoneW="";
           Properties.Settings.Default.ClassName="";
           // pictureBox1
        
           Properties.Settings.Default.DateBegin="";
           Properties.Settings.Default.DateEnd="";
        
              
        
           Properties.Settings.Default.DirthDate="";
           Properties.Settings.Default.adress="";
           Properties.Settings.Default.Nationality="";
             Properties.Settings.Default.StuName="";
            Properties.Settings.Default.pic = "";
            Properties.Settings.Default.amount="";
            //  Properties.Settings.Default.pic=
            //Properties.Settings.Default.Id =Convert.ToInt32( dataGridView1.CurrentRow.Cells[2].Value);
            Properties.Settings.Default.Id = "";
            Frm_AddStudents frm = new Frm_AddStudents();
            frm.ShowDialog();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var button = (DataGridView)sender;
            if (e.ColumnIndex == 11)
            {
              
                tbl.Clear();

                //dataGridView2.Visible = true;
                tbl = db.readData("SELECT  [ID] ,[Student_id] ,[From] ,[To] ,[emp_id] ,[class_name] ,[mount] FROM [fightGym].[dbo].[Tbl_eshtrackat]  where Student_id ='" + dataGridView1.CurrentRow.Cells[1].Value + "'", "");

                if (tbl.Rows.Count > 0)
                {
                    for (int i = 0; i < tbl.Rows.Count; i++)
                    {
                        try
                        {


                            string className = tbl.Rows[0][5].ToString();
                            string from = tbl.Rows[0][2].ToString();
                            string to = tbl.Rows[0][3].ToString();

                            int id = int.Parse(tbl.Rows[0][0].ToString());
                            //int rowIndex = dataGridView2.Rows.Count - 1;
                            //dataGridView2.Rows.Add(1);
                            //dataGridView2.Rows[rowIndex].Cells[0].Value = id;
                            //dataGridView2.Rows[rowIndex].Cells[1].Value = className;
                            //dataGridView2.Rows[rowIndex].Cells[2].Value = from;
                            //dataGridView2.Rows[rowIndex].Cells[3].Value = to;

                        }
                        catch (Exception ex) { MessageBox.Show(ex.Message); }
                    }
                }

            }
            if (e.ColumnIndex == 10)
            {
                if (MessageBox.Show("هل انت متاكد من الحذف ", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        db.executeData("delete  from Student_Deitls where  Deitls_Id='" + dataGridView1.CurrentRow.Cells[2].Value + "'", "");
                        db.executeData("delete  from Students where  [Deitls_Id]='" + dataGridView1.CurrentRow.Cells[2].Value + "'", "");
                        db.executeData("delete  from Tbl_eshtrackat where  Student_id='" + dataGridView1.CurrentRow.Cells[2].Value + "'", "تم الحذف بنجاح");
                        dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                    }
                    catch (Exception ex)
                    {

                    }
                }

            }
            if (e.ColumnIndex == 9)
            {
                cleardata();
                DataTable tbls = new DataTable();
                tbls.Clear();
                tbls = db.readData("SELECT dbo.Student_Deitls.Deitls_Id,dbo.Student_Deitls.First_name, dbo.Student_Deitls.Birth_Day, dbo.Student_Deitls.Nationalty, dbo.Student_Deitls.Adress, dbo.Student_Deitls.type_student, dbo.Student_Deitls.Wieght, dbo.Student_Deitls.phone_number, dbo.Student_Deitls.phwats, dbo.Student_Deitls.status, dbo.Student_Deitls.pic, dbo.Tbl_eshtrackat.[From],dbo.Tbl_eshtrackat.[To], dbo.Tbl_eshtrackat.mount, dbo.Student_Deitls.Classroom_id ,dbo.Tbl_eshtrackat.TrainerName  FROM   dbo.Student_Deitls CROSS JOIN   dbo.Tbl_eshtrackat   where  dbo.Student_Deitls.Deitls_Id = '" + dataGridView1.CurrentRow.Cells[2].Value+ "'  and  dbo.Tbl_eshtrackat.[Student_id]='"+ dataGridView1.CurrentRow.Cells[2].Value + "' group by dbo.Student_Deitls.Deitls_Id,dbo.Student_Deitls.First_name, dbo.Student_Deitls.Birth_Day, dbo.Student_Deitls.Nationalty, dbo.Student_Deitls.Adress, dbo.Student_Deitls.type_student, dbo.Student_Deitls.Wieght, dbo.Student_Deitls.phone_number, dbo.Student_Deitls.phwats, dbo.Student_Deitls.status, dbo.Student_Deitls.pic, dbo.Tbl_eshtrackat.[From], dbo.Tbl_eshtrackat.[To], dbo.Tbl_eshtrackat.mount, dbo.Student_Deitls.Classroom_id,dbo.Tbl_eshtrackat.TrainerName", "");
                if(tbls.Rows.Count > 0) {
                  
              
                    Properties.Settings.Default.Id = tbls.Rows[0][0].ToString();
                    Properties.Settings.Default.StuName = tbls.Rows[0][1].ToString();
                    Properties.Settings.Default.ClassName = tbls.Rows[0][14].ToString();
                    Properties.Settings.Default.DateBegin = tbls.Rows[0][11].ToString();
                    Properties.Settings.Default.phone = tbls.Rows[0][7].ToString();
                    Properties.Settings.Default.phoneW = tbls.Rows[0][8].ToString();
                    Properties.Settings.Default.DateEnd = tbls.Rows[0][12].ToString();
                    Properties.Settings.Default.DirthDate = tbls.Rows[0][2].ToString();
                    Properties.Settings.Default.adress = tbls.Rows[0][4].ToString();
                    Properties.Settings.Default.pic = tbls.Rows[0][10].ToString();
                    Properties.Settings.Default.typetrainer = tbls.Rows[0][15].ToString();
                    string sd= tbls.Rows[0][13].ToString();
                    Properties.Settings.Default.amount = sd;
                    if (tbls.Rows[0][9].ToString() == "True") {
                        Properties.Settings.Default.stats = "1";
                    } else
                    {
                        Properties.Settings.Default.stats = "0";
                    }
    
                    Properties.Settings.Default.Nationality = tbls.Rows[0][3].ToString();
                    Properties.Settings.Default.Id =Convert.ToString( dataGridView1.CurrentRow.Cells[2].Value);

                    Frm_AddStudents frm = new Frm_AddStudents();
                    frm.ShowDialog();
                } else { }
               
 
            }
        }

        private void cleardata()
        {
            Properties.Settings.Default.phone = "";
            Properties.Settings.Default.phoneW = "";
            Properties.Settings.Default.ClassName = "";
            // pictureBox1

            Properties.Settings.Default.DateBegin = "";
            Properties.Settings.Default.DateEnd = "";



            Properties.Settings.Default.DirthDate = "";
            Properties.Settings.Default.adress = "";
            Properties.Settings.Default.Nationality = "";
            Properties.Settings.Default.StuName = "";
            Properties.Settings.Default.pic = "";
            Properties.Settings.Default.amount = "";
        }

        private void ConEditStudents_Load(object sender, EventArgs e)
        {
            GetDate();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                if (MessageBox.Show("هل انت متاكد من المسح ", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void repositoryItemButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                cleardata();
                DataTable tbls = new DataTable();
                tbls.Clear();
                int id =Convert.ToInt32( gridView1.GetFocusedRowCellDisplayText(colDeitls_Id));//dataGridView1.CurrentRow.Cells[2].Value;
                tbls = db.readData("SELECT dbo.Student_Deitls.Deitls_Id,dbo.Student_Deitls.First_name, dbo.Student_Deitls.Birth_Day, dbo.Student_Deitls.Nationalty, dbo.Student_Deitls.Adress, dbo.Student_Deitls.type_student, dbo.Student_Deitls.Wieght, dbo.Student_Deitls.phone_number, dbo.Student_Deitls.phwats, dbo.Student_Deitls.status, dbo.Student_Deitls.pic, dbo.Tbl_eshtrackat.[From],dbo.Tbl_eshtrackat.[To], dbo.Tbl_eshtrackat.mount, dbo.Student_Deitls.Classroom_id ,dbo.Tbl_eshtrackat.TrainerName  FROM   dbo.Student_Deitls CROSS JOIN   dbo.Tbl_eshtrackat   where  dbo.Student_Deitls.Deitls_Id = '" + id + "'  and  dbo.Tbl_eshtrackat.[Student_id]='" + id + "' group by dbo.Student_Deitls.Deitls_Id,dbo.Student_Deitls.First_name, dbo.Student_Deitls.Birth_Day, dbo.Student_Deitls.Nationalty, dbo.Student_Deitls.Adress, dbo.Student_Deitls.type_student, dbo.Student_Deitls.Wieght, dbo.Student_Deitls.phone_number, dbo.Student_Deitls.phwats, dbo.Student_Deitls.status, dbo.Student_Deitls.pic, dbo.Tbl_eshtrackat.[From], dbo.Tbl_eshtrackat.[To], dbo.Tbl_eshtrackat.mount, dbo.Student_Deitls.Classroom_id,dbo.Tbl_eshtrackat.TrainerName", "");
                if (tbls.Rows.Count > 0)
                {


                    Properties.Settings.Default.Id = tbls.Rows[0][0].ToString();
                    Properties.Settings.Default.StuName = tbls.Rows[0][1].ToString();
                    Properties.Settings.Default.ClassName = tbls.Rows[0][14].ToString();
                    Properties.Settings.Default.DateBegin = tbls.Rows[0][11].ToString();
                    Properties.Settings.Default.phone = tbls.Rows[0][7].ToString();
                    Properties.Settings.Default.phoneW = tbls.Rows[0][8].ToString();
                    Properties.Settings.Default.DateEnd = tbls.Rows[0][12].ToString();
                    Properties.Settings.Default.DirthDate = tbls.Rows[0][2].ToString();
                    Properties.Settings.Default.adress = tbls.Rows[0][4].ToString();
                    Properties.Settings.Default.pic = tbls.Rows[0][10].ToString();
                    Properties.Settings.Default.typetrainer = tbls.Rows[0][15].ToString();
                    string sd = tbls.Rows[0][13].ToString();
                    Properties.Settings.Default.amount = sd;
                    if (tbls.Rows[0][9].ToString() == "True")
                    {
                        Properties.Settings.Default.stats = "1";
                    }
                    else
                    {
                        Properties.Settings.Default.stats = "0";
                    }

                    Properties.Settings.Default.Nationality = tbls.Rows[0][3].ToString();
                    Properties.Settings.Default.Id = id.ToString();

                    Frm_AddStudents frm = new Frm_AddStudents();
                    frm.ShowDialog();
                }
                else { }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void repositoryItemButtonDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("هل انت متاكد من الحذف ", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    db.executeData("delete  from Student_Deitls where  Deitls_Id='" + gridView1.GetFocusedRowCellDisplayText(colDeitls_Id) + "'", "");
                    db.executeData("delete  from Students where  [Deitls_Id]='" + gridView1.GetFocusedRowCellDisplayText(colDeitls_Id) + "'", "");
                    db.executeData("delete  from Tbl_eshtrackat where  Student_id='" + gridView1.GetFocusedRowCellDisplayText(colDeitls_Id) + "'", "تم الحذف بنجاح");
                    gridView1.DeleteRow(gridView1.GetFocusedDataSourceRowIndex());


                }
                catch (Exception ex)
                {

                }
            }
        }
        string ImageDir = @"Images\";
        Hashtable Images = new Hashtable();

        string GetFileName(string color)
        {
            if (color == null || color == string.Empty)
                return string.Empty;
            return color + ".jpg";
        }
        private void gridView1_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {

            if (e.Column.FieldName == "photo" && e.IsGetData)
            {
                GridView view = sender as GridView;

                string colorName = (string)view.GetRowCellValue(e.ListSourceRowIndex, "pic");
                string colorName2 = (string)view.GetRowCellValue(e.ListSourceRowIndex, "First_name");

                string fileName = GetFileName(colorName2).ToLower();
                if (!Images.ContainsKey(fileName))
                {
                    Image img = null;
                    try
                    {
                        string filePath = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, ImageDir + fileName, false);
                         //img = Image.FromFile(filePath);
                         img = Image.FromFile(colorName);
                    }
                    catch (Exception ex)
                    {
                    }
                    Images.Add(fileName, img);
                }
                e.Value = Images[fileName];
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Update();

        }

        private void repositoryItemButtonEdit_Click(object sender, EventArgs e)
        {
          //  repositoryItemButtonEdit_ButtonClick(sender, e as DevExpress.XtraEditors.Controls.ButtonPressedEventArgs);
        }

        private void repositoryItemButtonDelete_Click(object sender, EventArgs e)
        {
           // repositoryItemButtonDelete_ButtonClick(sender, e as DevExpress.XtraEditors.Controls.ButtonPressedEventArgs);
        }
    }
}
