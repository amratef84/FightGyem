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
    class Database
    {
      static  string ConString = System.Configuration.ConfigurationManager.ConnectionStrings["Database1ConnectionString"].ConnectionString;

        SqlConnection conn = new SqlConnection(ConString);

        SqlCommand cmd = new SqlCommand();
        public DataTable readData(String stmt, string mssg)
        {
            DataTable tbl = new DataTable();
            try
            {

                cmd.Connection = conn;
                cmd.CommandText = stmt;
                if(conn.State== ConnectionState.Closed) 
                conn.Open();

                //Load data from databas to tbl

                tbl.Load(cmd.ExecuteReader());

                conn.Close();


                if (mssg != "")
                {
                    MessageBox.Show(mssg, "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return tbl;

        }

        //insert,update,delete
        public bool executeData(String stmt, string mssg)
        {


            try
            {
                cmd.Connection = conn;
                cmd.CommandText = stmt;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                if (mssg != "")
                {
                    MessageBox.Show(mssg, "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return true;
            }
            catch (Exception ex)
            {

                conn.Close();
                MessageBox.Show(ex.Message);
                return false;

                conn.Close();
            }
            finally
            {
                conn.Close();
            }
        }
    
}
}
