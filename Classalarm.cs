using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FighyGym2
{
  public  class Classalarm
    {

        string ConString = System.Configuration.ConfigurationManager.ConnectionStrings["Database1ConnectionString"].ConnectionString;
        int days;
        // Classalarm clss = new Classalarm();
        DateTime firstDate;
        DateTime SecounDate;
        string studentName;
        public void fun()
        {

            SqlDataReader readerdates1 = null;
            SqlDataReader readerdates3 = null;
            SqlDataReader readerdates2 = null;
            SqlConnection conn = new SqlConnection(ConString);
            string das = "SELECT     dbo.Tbl_eshtrackat.ID, dbo.Students.Student_Name, dbo.Tbl_eshtrackat.class_name, dbo.Tbl_eshtrackat.[From], dbo.Tbl_eshtrackat.[To], dbo.Tbl_eshtrackat.mount FROM       dbo.Students INNER JOIN   dbo.Tbl_eshtrackat ON dbo.Students.Student_Id = dbo.Tbl_eshtrackat.Student_id INNER JOIN     dbo.Employees ON dbo.Tbl_eshtrackat.emp_id = dbo.Employees.Employee_Id order by dbo.Tbl_eshtrackat.[To] ASC";
            SqlCommand comandReader = new SqlCommand(das, conn);
            conn.Open();
         
        
            //  SqlDataAdapter da = new SqlDataAdapter(das, conn);
            DataTable tbl = new DataTable();
           
            comandReader.Connection = conn;

            tbl.Load(comandReader.ExecuteReader());
            conn.Close();
            conn.Open();
            readerdates1 = comandReader.ExecuteReader();
            for (int i=0;i< tbl.Rows.Count;i++)
            {
                while (readerdates1.Read())
                {
                     firstDate = (DateTime)readerdates1["From"];
                    Properties.Settings.Default.date1 = Convert.ToDateTime( firstDate);
                }
                conn.Close();
                conn.Open();
                readerdates1.Close();
                
          //      SqlCommand comandReader2 = new SqlCommand(das, conn);
                readerdates2 = comandReader.ExecuteReader();
                while (readerdates2.Read())
                {
                     SecounDate = (DateTime)readerdates2["To"];
                    Properties.Settings.Default.date2 = Convert.ToDateTime(SecounDate);
                }
                conn.Close();
                conn.Open();
                readerdates2.Close();
                readerdates3 = comandReader.ExecuteReader();
                while (readerdates3.Read())
                {
                    studentName = (string)readerdates3["Student_Name"];
                 //   Properties.Settings.Default.date1 = Convert.ToDateTime(firstDate);
                }
                conn.Close();
                readerdates3.Close();
                CondetialsEshtracat detials = new CondetialsEshtracat();

                //DateTime d = Properties.Settings.Default.date1;
                //DateTime d2 = Properties.Settings.Default.date2;
                int days = Convert.ToInt16((Properties.Settings.Default.date1 - Properties.Settings.Default.date2).TotalDays);


                if (days == 30)
                {
                    while (true)
                    {
                        System.Threading.Thread.Sleep(60 * 1000);
                        MessageBox.Show("سينتهي الاشتراك قريبا" , studentName);
                        //detials. dataGridView1.Rows[i].Cells[6].Value = "انتهى الاشتراك";
                        //detials.dataGridView1.Rows[i].Cells[6].Style.BackColor = Color.Red;
                    }
                }
                if (days > 30)
                {
                    while (true)
                    {
                        System.Threading.Thread.Sleep(60 * 1000);
                        MessageBox.Show("انتهي الاشتراك !", studentName);
                        //detials. dataGridView1.Rows[i].Cells[6].Value = "انتهى الاشتراك";
                        //detials.dataGridView1.Rows[i].Cells[6].Style.BackColor = Color.Red;
                    }
                }
                else
                {

                    while (true)
                    {
                        string message = "انتهي الاشتراك للطالب"+ studentName ;
                        string title = "تنبية";
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        System.Threading.Thread.Sleep( 100);
                        DialogResult result = MessageBox.Show(message, title, buttons);
                        //   MessageBox.Show("انتهي الاشتراك !", studentName,MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                        //detials. dataGridView1.Rows[i].Cells[6].Value = "انتهى الاشتراك";
                        //detials.dataGridView1.Rows[i].Cells[6].Style.BackColor = Color.Red;
                        if (result == DialogResult.Yes)
                        {
                        //    Application.ExitThread();
                        }
                        else
                        {
                            // Do something  
                        }
                    }

                }

            }
            readerdates1.Close();
            readerdates2.Close();
            //DataSet ds = new DataSet();
            //da.Fill(ds, "Tbl_eshtrackat");
            //  dataGridView1.DataSource = ds.Tables[0].DefaultView;

           
        }

    //int i = 0; i<dataGridView1.RowCount - 1; i++)
    //            {
    //                date1 = Convert.ToDateTime(dataGridView1.Rows[i].Cells[3].Value);
    //                date2 = Convert.ToDateTime(dataGridView1.Rows[i].Cells[4].Value);
    //                if (days == 30)
    //                {

    //                    while (true)
    //                    {
    //                        System.Threading.Thread.Sleep(60 * 1000);
    //                        MessageBox.Show("سينتهي الاشتراك قريبا!");
    //                        dataGridView1.Rows[i].Cells[6].Value = "انتهى الاشتراك";
    //                        dataGridView1.Rows[i].Cells[6].Style.BackColor = Color.Red;
    //                    }
    //}
    //                else if (days == 28 || days == 27 || days == 25 || days == 26)
    //                {
    //                    while (true)
    //                    {
    //                        System.Threading.Thread.Sleep(60 * 1000);
    //                        MessageBox.Show("سينتهي الاشتراك قريبا!");
    //                        dataGridView1.Rows[i].Cells[6].Value = "سينتهي الاشتراك قريبا";
    //                        dataGridView1.Rows[i].Cells[6].Style.BackColor = Color.LightYellow;

    //                    }
    //                }
    //                else
    //                {

    //                    while (true)
    //                    {
    //                        System.Threading.Thread.Sleep(60 * 1000);
    //                        MessageBox.Show("سينتهي الاشتراك قريبا!");
    //                        dataGridView1.Rows[i].Cells[6].Value = "تم الدفع";
    //                        dataGridView1.Rows[i].Cells[6].Style.BackColor = Color.LightGreen;
    //                    }
    //                }


    //            }on
}
}
