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
    public partial class AddStudent : DevExpress.XtraEditors.XtraUserControl
    {
        private static AddStudent _instance;
        int IDnumber;
        Boolean healthisgood, sport;
        public string colfirstname, colsecondname, colthname, collastname, fullname, classcourse;
        public static SqlConnection connction;
        public static SqlCommand SelectAccountnumb;
        public string countNUMB, resultNUMBSTu;
        public int phonestu;
        string deptname, datecurrent;
        string nametypeservice;
        public static AddStudent Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AddStudent();
                return _instance;
            }
        }
        public AddStudent()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmEditStudenr frm = new frmEditStudenr();
            frm.Show();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void phonNm_TextChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //private void yes_CheckedChanged(object sender, EventArgs e)
        //{
        //     yes.Checked.
        //}



        private void fatherNm_TextChanged(object sender, EventArgs e)
        {

        }

        private void firstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        { }
        //    Boolean healthisgood, sport;
        //    if (yes.Checked == true)
        //    {
        //        healthisgood = true;
        //    }
        //    else
        //    {
        //        healthisgood = false;
        //    }
        //    if (Yeshealth.Checked == true)
        //    {
        //        sport = true;
        //    }
        //    else
        //    {
        //        sport = false;
        //    }
        //    //try
        //    //{

                ////    string ConString = System.Configuration.ConfigurationManager.ConnectionStrings["Database1ConnectionString"].ConnectionString;
                ////    SqlConnection cnn = new SqlConnection(ConString);
                ////    SqlCommand sc, insertStudent, scd, cscd3;
                ////    cnn.Open();
                ////    string datecurrent = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                ////    string datecreatinAccount = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
                ////    string sql = "Insert into Student_Deitls(First_name,Father_Name,GrandFather_Name,Last_Name,Birth_Day,Nationalty,Adress,Longth,Evalute,Health,Sport,type_student,Date,Classroom_id,Wieght,phone_number) values('" + firstName.Text + "','','', '" + lastname.Text + "','','" + nationalty.Text + "','" + adress.Text + "','" + longth.Text + "','" + cbxEvalute.Text + "','" + healthisgood + "','" + sport + "','" + cbxtype.Text + "','" + datecurrent + "','" + typecourse.Text + "','" + whigt.Text + "','" + phonNm.Text + "');";
                ////    try
                ////    {
                ////        //cnn.Open();
                ////        //  MessageBox.Show("Data Saved..");
                ////        sc = new SqlCommand(sql, cnn);
                ////        sc.ExecuteNonQuery();
                ////        sc.Dispose();
                ////        MessageBox.Show("تم تعبئة الاستمارة بنجاح");
                ////        SqlDataReader reader = null;
                ////        SqlDataReader reader1 = null;
                ////        SqlDataReader reader2 = null;
                ////        SqlDataReader reader3 = null;
                ////        SqlDataReader reader4 = null;
                ////        SqlDataReader reader5 = null;
                ////        string selectCmd = "SELECT First_name,Father_Name,GrandFather_Name ,Last_Name ,phone_number,Classroom_id  FROM  Student_Deitls    ";
                ////        scd = new SqlCommand(selectCmd, cnn);

                ////        reader = scd.ExecuteReader();
                ////        while (reader.Read())
                ////        {
                ////            colfirstname = (string)(reader["First_name"]);

                ////        }
                ////        reader.Close();
                ////        reader1 = scd.ExecuteReader();
                ////        while (reader1.Read())
                ////        {
                ////            colsecondname = (string)(reader1["Father_Name"]);
                ////        }
                ////        reader1.Close();
                ////        reader2 = scd.ExecuteReader();
                ////        while (reader2.Read())
                ////        {
                ////            colthname = (string)(reader2["GrandFather_Name"]);
                ////        }
                ////        reader2.Close();
                ////        reader3 = scd.ExecuteReader();
                ////        while (reader3.Read())
                ////        {
                ////            collastname = (string)(reader3["Last_Name"]);
                ////        }
                ////        reader3.Close();
                ////        reader4 = scd.ExecuteReader();
                ////        while (reader4.Read())
                ////        {
                ////            phonestu = (int)(reader4["phone_number"]);
                ////        }
                ////        reader4.Close();
                ////        reader5 = scd.ExecuteReader();
                ////        while (reader5.Read())
                ////        {
                ////            classcourse = (string)(reader5["Classroom_id"]);
                ////        }
                ////        reader5.Close();
                ////        fullname = colfirstname + " " + colsecondname + " " + colthname + " " + collastname;

                ////        try
                ////        {
                ////            SqlConnection connInsert = new SqlConnection(ConString);
                ////            connInsert.Open();
                ////            string sqltostudent = "Insert into Students(Student_Name,Phone_Number,Classroom_id,Account_numb) values('" + fullname + "','" + phonestu + "','" + classcourse + "','');";

                ////            //  MessageBox.Show("Data Saved..");
                ////            SqlCommand insertt = new SqlCommand(sqltostudent, connInsert);
                ////            insertt.ExecuteNonQuery();
                ////            insertt.Dispose();
                ////      //      MessageBox.Show("رقم حساب الطالب  " + "هو " + "" + acc.resultNUMBSTu);
                ////        }
                ////        catch (Exception ex)
                ////        {
                ////            MessageBox.Show(ex.ToString());
                ////        }

                ////    }
                ////    catch (Exception ex)
                ////    {
                ////        MessageBox.Show(ex.ToString());
                ////    }

                //////}
                //catch (Exception ex)
                //{

                //}
            
            

        private void r(object sender, EventArgs e)
        {
        
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {
           // string ConString = System.Configuration.ConfigurationManager.ConnectionStrings["Database1ConnectionString"].ConnectionString;

           // SqlConnection conn = new SqlConnection(ConString);
           // SqlDataAdapter da = new SqlDataAdapter("Select Classrooms_Name  FROM Classrooms", conn);
           // DataSet ds = new DataSet();
           // da.Fill(ds, "Classrooms");
           //typecourse.DisplayMember = Convert.ToString(ds.Tables[0].DefaultView);
           // //typecourse.DisplayMember = ds.Tables[0].Columns["Classrooms_Name"].ToString();
        }
    }
}
