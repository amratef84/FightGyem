using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FighyGym2.Controler
{
    public class DAL
    {
        static string ConString = System.Configuration.ConfigurationManager.ConnectionStrings["Database1ConnectionString"].ConnectionString;

        static SqlConnection conn1 = new SqlConnection(ConString);
        public DAL()
        {
            // conn1 = Sql.Sqle();
        }

        static SqlCommand command = new SqlCommand();
        public DataTable SelectAll(string comand)
        {
            string tab = comand;
            DataTable tb = new DataTable();
            using (conn1)
            using (command)
            {
                command.Parameters.Clear();
                command.Connection = conn1;
                command.CommandText = tab;
                try
                {
                    if (conn1.State == ConnectionState.Closed) conn1.Open();
                    tb.Load(command.ExecuteReader());
                    // conn1.Close();
                    return tb;
                }
                catch (SqlException ex)
                {
                    // MessageBox.Show(ex.Message);
                    return null;
                }
            }

        }

        public string get_value(string coloum, string table, string coloum_condition, string row)
        {
            //SqlConnection conn1 = Sql.Sqle();
            Object returnValue;
            string tab = "SELECT " + coloum + " FROM " + table + " WHERE " + coloum_condition + " = " + row;
            using (conn1)
            using (command)
            {
                command.Parameters.Clear();
                command.Connection = conn1;
                command.CommandText = tab;
                try
                {
                    if (conn1.State == ConnectionState.Closed) conn1.Open();
                    returnValue = command.ExecuteScalar();
                    if (returnValue != null)
                    {
                        return returnValue.ToString();
                    }
                    else
                    {
                        return null;
                    }

                    // conn1.Close();               
                }
                catch (SqlException ex)
                {
                    return null;
                }
            }

        }
        public string get_value2(string selection)
        {
            Object returnValue;
            string tab = selection;
            using (conn1)
            using (command)
            {
                command.Parameters.Clear();
                command.Connection = conn1;
                command.CommandText = tab;
                try
                {
                    if (conn1.State == ConnectionState.Closed) conn1.Open();
                    returnValue = command.ExecuteScalar();
                    if (returnValue != null)
                    {
                        return returnValue.ToString();
                    }
                    else
                    {
                        return null;
                    }

                    // conn1.Close();               
                }
                catch (SqlException ex)
                {
                    return null;
                }
            }

        }
        //UPDATE `sma_settings` SET `default_warehouse` = "1" WHERE `setting_id`="1";
        public string Update_defualt_values(string table, string coloum, string value, string row, string row_condition)
        {
            string returnValue_2 = value;
            int returnValue = 0;
            string tab = @"UPDATE " + table + " set " + coloum + " = " + "'" + value + "'" + " WHERE " + row + " = " + row_condition;
            using (conn1)
            using (command)
            {
                command.Parameters.Clear();
                command.Connection = conn1;
                command.CommandText = tab;
                try
                {
                    if (conn1.State == ConnectionState.Closed) conn1.Open();
                    returnValue = command.ExecuteNonQuery();
                    if (returnValue != 0) return returnValue_2;
                    else return "0";

                    // conn1.Close();
                }
                catch (SqlException ex)
                {
                    return "0";
                }
            }

        }
        public string get_sum_coloum(string coloum, string table)
        {
            Object returnValue;
            using (conn1)
            using (command)
            {
                command.Parameters.Clear();

                string tab = "SELECT SUM(" + coloum + ") as total FROM " + table;
                command.Connection = conn1;
                command.CommandText = tab;
                try
                {
                    if (conn1.State == ConnectionState.Closed) conn1.Open();
                    returnValue = command.ExecuteScalar();
                    return returnValue.ToString();

                }
                catch (SqlException ex)
                {
                    return null;
                }
            }
        }
        //public double CheckInternetSpeed()
        //{
        //    try
        //    {
        //        bool beginValue = CrossConnectivity.Current.IsConnected;
        //        if (beginValue)
        //        {
        //            // Create Object Of WebClient
        //            System.Net.WebClient wc = new System.Net.WebClient();

        //            //DateTime Variable To Store Download Start Time.
        //            DateTime dt1 = DateTime.Now;

        //            //Number Of Bytes Downloaded Are Stored In ‘data’
        //            byte[] data = wc.DownloadData("http://google.com");

        //            //DateTime Variable To Store Download End Time.
        //            DateTime dt2 = DateTime.Now;

        //            //To Calculate Speed in Kb Divide Value Of data by 1024 And Then by End Time Subtract Start Time To Know Download Per Second.
        //            double InternetSpeed = Math.Round((data.Length / 1024) / (dt2 - dt1).TotalSeconds, 2);
        //            if (InternetSpeed > 0)
        //            {
        //                if (InternetSpeed < 100)
        //                {
        //                    if (InternetSpeed > 30)
        //                    {
        //                        Constant.checkInternetSpeed = "جودة لاباس بها ";
        //                        Constant.checkInternetMessage = "سرعة التحميل : " + InternetSpeed + " Kb / s  \n   هل تريد المتابعه ؟ ";
        //                    }
        //                    else
        //                    {
        //                        Constant.checkInternetSpeed = "  جودة ضعيفة ";
        //                        Constant.checkInternetMessage = "سرعة التحميل : " + InternetSpeed + " Kb / s  \n  قد تحدث مشاكل اثناء تحميل البيانات هل تريد المتابعه ؟ ";
        //                    }
        //                }
        //                else
        //                {
        //                    Constant.checkInternetSpeed = " جودة ممتازة ";
        //                    Constant.checkInternetMessage = "سرعة التحميل : " + InternetSpeed + " Kb / s   \n   هل تريد المتابعه ؟ ";
        //                }
        //            }
        //            return InternetSpeed;
        //        }
        //        else
        //        {
        //            Constant.checkInternetSpeed = "لا يوجد لديك انترنت حالياً";
        //            Constant.checkInternetMessage = "سرعة التحميل : " + 0 + " Kb / s  \n تم الغاء هذه العملية ";
        //            return 0;
        //        }
        //    }
        //    catch
        //    {
        //        Constant.checkInternetSpeed = "لا يوجد لديك انترنت حالياً";
        //        Constant.checkInternetMessage = "سرعة التحميل : " + 0 + " Kb / s   \n تم الغاء هذه العملية ";
        //        return 0;
        //    }
        //}
    }
}
