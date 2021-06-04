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
using System.Security.Cryptography;
using System.IO;
using System.Data.SqlClient;

namespace FighyGym2
{
    public partial class LoginForm2 : DevExpress.XtraEditors.XtraForm
    {
     //  Database db = new Database();
       // DataTable tbl = 
        DataTable dataTable =new DataTable();
        public LoginForm2()
        {
            InitializeComponent();
        }
        string ConString = System.Configuration.ConfigurationManager.ConnectionStrings["Database1ConnectionString"].ConnectionString;

        public static string Encrypt(string encryptString)
        {
            try
            {
                string EncryptionKey = "0ram@1234xxxxxxxxxxtttttuuuuuiiiiio";  //we can change the code converstion key as per our requirement    
                byte[] clearBytes = Encoding.Unicode.GetBytes(encryptString);
                using (Aes encryptor = Aes.Create())
                {
                    Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] {
                       0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76
                         });
                    encryptor.Key = pdb.GetBytes(32);
                    encryptor.IV = pdb.GetBytes(16);
                    using (MemoryStream ms = new MemoryStream())
                    {
                        using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                        {
                            cs.Write(clearBytes, 0, clearBytes.Length);
                            cs.Close();
                        }
                        encryptString = Convert.ToBase64String(ms.ToArray());
                    }
                }
                return encryptString;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }



        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUserName.Text == "")
                {
                    MessageBox.Show("ادخل اسم المستخدم");

                }
                else if (txtpassword.Text == "")
                {
                    MessageBox.Show("ادخل كلمة المرور ");
                }
                else
                {


                    SqlConnection cnn = new SqlConnection(ConString);
                    cnn.Open();
                    SqlDataReader reader = null;
                    // MessageBox.Show(Database.Get());
                    string passHash = Encrypt(txtpassword.Text);
                    dataTable.Clear();
                    if (chekAdmin1.Checked == true)
                    {
                        string selectCmd = " SELECT  [role_Id] ,[Employee_Name],[Status] ,[Password] FROM [fightGym].[dbo].[Roles] where Employee_Name='"+ txtUserName.Text + "' and Password='"+ txtpassword.Text + "' and [Status]='مدير'";

                    
                        SqlDataAdapter sqladapter = new SqlDataAdapter(selectCmd, cnn);
                       // SqlDataReader reader2 = comanstudent.ExecuteReader();
                   
                         dataTable = new DataTable();
                        sqladapter.Fill(dataTable);
               

                    }
                    if (chekEmp.Checked == true)
                    {
                        string selectCmd = " SELECT  [role_Id] ,[Employee_Name]  ,Status,[Password] FROM [fightGym].[dbo].[Roles] where Employee_Name='" + txtUserName.Text + "' and Password='" + txtpassword.Text + "' and [Status]='مستخدم عادي'";
                        SqlDataAdapter sqladapter = new SqlDataAdapter(selectCmd, cnn);
                        // SqlDataReader reader2 = comanstudent.ExecuteReader();
                         dataTable.Clear();
                         dataTable = new DataTable();
                        sqladapter.Fill(dataTable);

                    }
             //       tbl = db.readData("select * from Users where User_Name=N'" + txtUserName.Text + "' and User_Password=N'" + passHash + "'  and type=N'مستخدم عادي'", "");

                    if (dataTable.Rows.Count >= 1)
                    {
                        Properties.Settings.Default.USER_NAME = txtUserName.Text;
                        Properties.Settings.Default.Save();
                        this.Hide();
                        RibbonForm1 frm = new RibbonForm1();
                        frm.ShowDialog();
                    }
                    else
                    {

                        MessageBox.Show("كلمة السر او اسم المستخدم خطأ", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

        }

        private void txtpassword_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
               if (e.KeyCode == Keys.Enter)
                {
                    if (txtUserName.Text == "")
                    {
                        MessageBox.Show("ادخل اسم المستخدم");

                    }
                    else if (txtpassword.Text == "")
                    {
                        MessageBox.Show("ادخل كلمة المرور ");
                    }
                    else
                    {


                        SqlConnection cnn = new SqlConnection(ConString);
                        cnn.Open();
                        SqlDataReader reader = null;
                        // MessageBox.Show(Database.Get());
                        string passHash = Encrypt(txtpassword.Text);
                        dataTable.Clear();
                        if (chekAdmin1.Checked == true)
                        {
                            string selectCmd = " SELECT  [role_Id] ,[Employee_Name],[Status] ,[Password] FROM [fightGym].[dbo].[Roles] where Employee_Name='" + txtUserName.Text + "' and Password='" + txtpassword.Text + "' and [Status]='مدير'";


                            SqlDataAdapter sqladapter = new SqlDataAdapter(selectCmd, cnn);
                            // SqlDataReader reader2 = comanstudent.ExecuteReader();

                            dataTable = new DataTable();
                            sqladapter.Fill(dataTable);


                        }
                        if (chekEmp.Checked == true)
                        {
                            string selectCmd = " SELECT  [role_Id] ,[Employee_Name]  ,Status,[Password] FROM [fightGym].[dbo].[Roles] where Employee_Name='" + txtUserName.Text + "' and Password='" + txtpassword.Text + "' and [Status]='مستخدم عادي'";
                            SqlDataAdapter sqladapter = new SqlDataAdapter(selectCmd, cnn);
                            // SqlDataReader reader2 = comanstudent.ExecuteReader();
                            dataTable.Clear();
                            dataTable = new DataTable();
                            sqladapter.Fill(dataTable);

                        }
                        //       tbl = db.readData("select * from Users where User_Name=N'" + txtUserName.Text + "' and User_Password=N'" + passHash + "'  and type=N'مستخدم عادي'", "");

                        if (dataTable.Rows.Count >= 1)
                        {
                            Properties.Settings.Default.USER_NAME = txtUserName.Text;
                            Properties.Settings.Default.Save();
                            this.Hide();
                            RibbonForm1 frm = new RibbonForm1();
                            frm.ShowDialog();
                        }
                        else
                        {

                            MessageBox.Show("كلمة السر او اسم المستخدم خطأ", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
 
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}