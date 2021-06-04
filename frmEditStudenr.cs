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

namespace FighyGym2
{
    public partial class frmEditStudenr : DevExpress.XtraEditors.XtraForm
    {
        string ConString = System.Configuration.ConfigurationManager.ConnectionStrings["Database1ConnectionString"].ConnectionString;
        DataTable dataTable;
        SqlCommand scd, comanstudent;
        SqlConnection cnn;
        int ColumnId, ColumnId2;
        int da;
        public frmEditStudenr()
        {
            InitializeComponent();
        }

        private void frmEditStudenr_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cnn = new SqlConnection(ConString);
            cnn.Open();
            SqlDataReader reader = null;
            string selectCmd = "SELECT   dbo.Student_Deitls.First_name, dbo.Student_Deitls.Father_Name, dbo.Student_Deitls.GrandFather_Name, dbo.Student_Deitls.Last_Name, dbo.Student_Deitls.Birth_Day, dbo.Student_Deitls.Nationalty,      dbo.Student_Deitls.Adress, dbo.Student_Deitls.Longth, dbo.Student_Deitls.Evalute, dbo.Student_Deitls.Health, dbo.Student_Deitls.Sport, dbo.Student_Deitls.type_student, dbo.Student_Deitls.Date   ,  dbo.Student_Deitls.Classroom_id, dbo.Student_Deitls.Wieght, dbo.Student_Deitls.phone_number, dbo.Students.Account_numb FROM       dbo.Student_Deitls INNER JOIN       dbo.Students ON dbo.Student_Deitls.Classroom_id = dbo.Students.Classroom_Id  where First_name='" + textBox1.Text + "'";

            comanstudent = new SqlCommand(selectCmd, cnn);
            SqlDataReader reader2 = comanstudent.ExecuteReader();
            dataTable = new DataTable();

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
            dataTable.Columns.Add("Classroom_id");
            dataTable.Columns.Add("Wieght");
            dataTable.Columns.Add("phone_number");
            dataTable.Columns.Add("Account_numb");
            while (reader2.Read())
            {
                DataRow row = dataTable.NewRow();
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
                row["Classroom_id"] = reader2["Classroom_id"];
                row["Wieght"] = reader2["Wieght"];
                row["phone_number"] = reader2["phone_number"];
                //  row["Account_numb"] = reader2["Account_numb"];


                dataTable.Rows.Add(row);
            }
            reader2.Close();
            dataGridView1.DataSource = dataTable;

            dataGridView1.Refresh();
            cnn.Close();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var button = (DataGridView)sender;
            //var cbx = (DataGridView)sender;
            //if (cbx.Columns[9] is DataGridViewColumn && e.RowIndex >= 0)
            //{
            //     da = Convert.ToInt16(typecoursed.ValueMember);
            //    //     string dat=Convert.ToString(     cbx.Rows.Cell[10].value);
            //    //   ((ComboBox)e.Control).SelectedIndexChanged += new System.EventHandler(this.onseleteddatagridomboboxevent);

            //}
            if (button.Columns[11] is DataGridViewColumn && e.RowIndex >= 0)
            {

                //cnn = new SqlConnection(ConString);
                //cnn.Open();
                //SqlDataReader reader = null;
                //string selectCmd = "SELECT   dbo.Student_Deitls.First_name, dbo.Student_Deitls.Father_Name, dbo.Student_Deitls.GrandFather_Name, dbo.Student_Deitls.Last_Name, dbo.Student_Deitls.Birth_Day, dbo.Student_Deitls.Nationalty,      dbo.Student_Deitls.Adress, dbo.Student_Deitls.Longth, dbo.Student_Deitls.Evalute, dbo.Student_Deitls.Health, dbo.Student_Deitls.Sport, dbo.Student_Deitls.type_student, dbo.Student_Deitls.Date   ,  dbo.Student_Deitls.Classroom_id, dbo.Student_Deitls.Wieght, dbo.Student_Deitls.phone_number, dbo.Students.Account_numb FROM       dbo.Student_Deitls INNER JOIN       dbo.Students ON dbo.Student_Deitls.Classroom_id = dbo.Students.Classroom_Id  where First_name='" + textBox1.Text + "'";

                //comanstudent = new SqlCommand(selectCmd, cnn);
                //SqlDataReader reader2 = comanstudent.ExecuteReader();

                if (e.ColumnIndex == 13)
                {
                    SqlConnection sqlcon = new SqlConnection(ConString);
                    sqlcon.Open();
                    foreach (DataGridViewRow dr in dataGridView1.Rows)
                    {
                        int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                        bool checkselected = Convert.ToBoolean(dr.Cells[0].Value);
                        if (checkselected == true)
                        {
                            string dateatt = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                            //     string sql = "Insert into Att_Student(Student_Id,Student_Name,Student_Class_Name,Student_Att,Date) values(@student_Id,@student_Name,@student_Class_Name,@student_Att,'"+ dateatt + "');";

                            string sql = "update  [dbo].[Student_Deitls]  set   [First_name]=@First_name  ,Father_Name=@Father_Name   ,GrandFather_Name=@GrandFather_Name ,Last_Name=@Last_Name      ,[Adress] =@Adress  ,[Longth]=@Longth ,[type_student]=@type_student ,[Date]='" + dateatt + "' ,[Classroom_id] ='" + typecoursed.Selected.ToString() + "' ,[Wieght]=@Wieght  ,[phone_number]=@phone_number where [Deitls_Id]='" + id + "'";
                            SqlCommand sqlcomm = new SqlCommand(sql, sqlcon);
                            sqlcomm.Parameters.AddWithValue("@First_name", dr.Cells[2].Value);
                            sqlcomm.Parameters.AddWithValue("@Father_Name", dr.Cells[3].Value);

                            if (dr.Cells[3].Value == "") { sqlcomm.Parameters.AddWithValue("@GrandFather_Name", dr.Cells[3].Value); }
                            else { sqlcomm.Parameters.AddWithValue("@GrandFather_Name", dr.Cells[4].Value); }
                            if (dr.Cells[4].Value == "") { sqlcomm.Parameters.AddWithValue("@Last_Name", dr.Cells[3].Value); }
                            else { sqlcomm.Parameters.AddWithValue("@Last_Name", dr.Cells[5].Value); }
                            //   sqlcomm.Parameters.AddWithValue("@Last_Name", dr.Cells[4].Value);
                            //sqlcomm.Parameters.AddWithValue("@Birth_Day", dr.Cells[5].Value);
                            sqlcomm.Parameters.AddWithValue("@phone_number", dr.Cells[6].Value);
                            sqlcomm.Parameters.AddWithValue("@Adress", dr.Cells[8].Value);
                            sqlcomm.Parameters.AddWithValue("@Longth", dr.Cells[12].Value);
                            sqlcomm.Parameters.AddWithValue("@Wieght", dr.Cells[11].Value);
                            //  sqlcomm.Parameters.AddWithValue("@Classroom_id", da);
                            sqlcomm.Parameters.AddWithValue("@type_student", dr.Cells[9].Value);


                            //     sqlcomm.Parameters.AddWithValue('"+ datecurrent2 +"', dr.Cells[4].Value);

                            sqlcomm.ExecuteNonQuery();
                            sqlcomm.Dispose();
                            sqlcon.Close();
                            MessageBox.Show("تم التعديل");

                        }
                    }
                }
            }
        }
    }
}