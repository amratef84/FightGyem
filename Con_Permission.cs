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
    public partial class Con_Permission : DevExpress.XtraEditors.XtraUserControl
    {


        private static Con_Permission _instance;
        string CountryName, EmpNameV, EmpNameType;
        public static Con_Permission Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Con_Permission();
                return _instance;
            }
        }

        public Con_Permission()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        string ConString = System.Configuration.ConfigurationManager.ConnectionStrings["Database1ConnectionString"].ConnectionString;
        DataTable dt;
        int User_id;
        public void getuserid()
        {
            User_id = 0;
            try
            {
                conn = new SqlConnection(ConString);
                string selectCmd = " SELECT  [role_Id]  FROM [fightGym].[dbo].[Roles] where Employee_Name='" + Properties.Settings.Default.USER_NAME + "' ";
                //  string da = "SELECT   dbo.Tbl_eshtrackat.ID, dbo.Students.Student_Name, dbo.Tbl_eshtrackat.class_name, dbo.Tbl_eshtrackat.[From], dbo.Tbl_eshtrackat.[To], dbo.Tbl_eshtrackat.mount FROM       dbo.Students INNER JOIN   dbo.Tbl_eshtrackat ON dbo.Students.Student_Id = dbo.Tbl_eshtrackat.Student_id INNER JOIN     dbo.Employees ON dbo.Tbl_eshtrackat.emp_id = dbo.Employees.Employee_Id where   dbo.Tbl_eshtrackat.[From] between '" + date1 + "' and '" + date2 + "' ";
                SqlCommand comandReader = new SqlCommand(selectCmd, conn);
                conn.Open();
                comandReader.ExecuteNonQuery();
                //   conn.Open();
                dt = new DataTable();
                SqlDataAdapter adapt = new SqlDataAdapter(comandReader);

                adapt.Fill(dt);
                User_id = Convert.ToInt16(dt.Rows[0][0].ToString());
                //  User_id = Convert.ToInt16(db.readData("select User_ID from Users where User_Name=N'" + Properties.Settings.Default.USER_NAME + "'", "").Rows[0][0]);
            }

            catch { }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }
        private void getUserName()
        {
            string ConString = System.Configuration.ConfigurationManager.ConnectionStrings["Database1ConnectionString"].ConnectionString;

            SqlConnection conn = new SqlConnection(ConString);
            string sqlcon = ("SELECT role_Id,[Employee_Name] ,[Status]  FROM [fightGym].[dbo].[Roles]");
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(sqlcon, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "[Roles]");
            cbxUsernameop.DataSource = ds.Tables[0].DefaultView;
            cbxUsernameop.ValueMember = ds.Tables[0].Columns["role_Id"].ToString();
            cbxUsernameop.DisplayMember = ds.Tables[0].Columns["Employee_Name"].ToString();
            conn.Close();
        }
        private void Con_Permission_Load(object sender, EventArgs e)
        {
            getUserName();
            Auto();
            //    cbxUsernameop.DataSource = db.readData("select * from Users", "");
            //    cbxUsernameop.DisplayMember = "User_Name";
            //    cbxUsernameop.ValueMember = "User_ID";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void xtraTabControl1_Click(object sender, EventArgs e)
        {

        }

        private void xtraTabPage2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            getuserid();
            try
            {
                int chkplayer = 0, chkparticption = 0, chkTeach = 0, chkuserd, chkCalcualte = 0, chkSetGames = 0;

                if (chkMangplayer.Checked == true)
                {
                    chkplayer = 1;
                }
                else
                    chkplayer = 0;

                if (chkMangParticption.Checked == true)
                {
                    chkparticption = 1;
                }
                else
                    chkparticption = 0;

                if (chkMangCalculation.Checked == true)
                {
                    chkCalcualte = 1;
                }
                else
                    chkCalcualte = 0;

                if (chkMangGames.Checked == true)
                {
                    chkSetGames = 1;
                }
                else
                    chkSetGames = 0;

                if (chkMangTcher.Checked == true)
                {
                    chkTeach = 1;
                }
                else
                    chkTeach = 0;

                if (chkUser.Checked == true)
                {
                    chkuserd = 1;
                }
                else
                    chkuserd = 0;

                string datecurrent = DateTime.Now.ToString("yyyy-MM-dd ");

                db.executeData("UPDATE [dbo].[PermisionSetting] SET  [Permisission_Player] = '" + chkplayer + "'   ,[Permisission_Particpiation] ='" + chkparticption + "'  ,[Permisission_TrainerTech] ='" + chkTeach + "'  ,[Permisission_calculation] ='" + chkCalcualte + "'  ,[Permisission_Users] ='" + chkuserd + "' ,[Permisission_Game] ='" + chkSetGames + "'  where [Role_id] ='" + cbxUsernameop.SelectedValue + "'  ", "");
                //  SqlCommand sqlcomm = new SqlCommand(sql, conn);
                //  db.executeData("UPDATE [dbo].[Search_Permissions] SET [Patiant_Screen] ='" + penf + "'   ,[Sheets] ='" + Sheets + "'   ,[Sumary] = '" + Summry + "'  ,[Side_Medicne] ='" + SideMedcn + "' ,UserId ='" + User_id + "'  ,Entertime= '" + datecurrent + "'  WHERE Shrch_id = " + cbxUserNameSRCH.SelectedValue + "", "تم الحفظ بنجاح");
                //sqlcomm.ExecuteNonQuery();
                //sqlcomm.Dispose();
                //conn.Close();
                MessageBox.Show("تم الحفظ بنجاح");
                cbxUsernameop.SelectedIndex = 0;
            }
            catch
            {

            }

        }

        private void xtraTabControl1_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (xtraTabControl1.SelectedTabPage == xtraTabPage3)
            {
                getUserName();
            }
        }

        private void xtraTabPage3_Paint(object sender, PaintEventArgs e)
        {

        }
        Database db = new Database();
        DataTable tbl = new DataTable();
        private void cbxUsernameop_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cbxUsernameop_SelectionChangeCommitted(object sender, EventArgs e)
        {
            tbl.Clear();
            tbl = db.readData(" SELECT  [ID_permission]   ,[Permisission_Player] ,[Permisission_Particpiation] ,[Permisission_TrainerTech] ,[Permisission_calculation]   ,[Permisission_Users]   ,[Permisission_Game] ,[Role_id] FROM [fightGym].[dbo].[PermisionSetting] where Role_id='" + cbxUsernameop.SelectedValue + "'   ", "");
            if (tbl.Rows.Count >= 1)
            {
                if (Convert.ToInt32(tbl.Rows[0][1].ToString()) == 1)
                {
                    chkMangplayer.Checked = true;


                }
                else if (Convert.ToInt32(tbl.Rows[0][1].ToString()) == 0)

                {

                    chkMangplayer.Checked = false;

                }

                if (Convert.ToInt32(tbl.Rows[0][2].ToString()) == 1)
                {
                    chkMangParticption.Checked = true;


                }
                else if (Convert.ToInt32(tbl.Rows[0][2].ToString()) == 0)

                {

                    chkMangParticption.Checked = false;

                }

                if (Convert.ToInt32(tbl.Rows[0][3].ToString()) == 1)
                {
                    chkMangTcher.Checked = true;


                }
                else if (Convert.ToInt32(tbl.Rows[0][3].ToString()) == 0)

                {

                    chkMangTcher.Checked = false;

                }

                if (Convert.ToInt32(tbl.Rows[0][4].ToString()) == 1)
                {
                    chkMangCalculation.Checked = true;


                }
                else if (Convert.ToInt32(tbl.Rows[0][4].ToString()) == 0)

                {

                    chkMangCalculation.Checked = false;

                }

                if (Convert.ToInt32(tbl.Rows[0][5].ToString()) == 1)
                {
                    chkUser.Checked = true;


                }
                else if (Convert.ToInt32(tbl.Rows[0][5].ToString()) == 0)

                {

                    chkUser.Checked = false;

                }


                if (Convert.ToInt32(tbl.Rows[0][5].ToString()) == 1)
                {
                    chkUser.Checked = true;


                }
                else if (Convert.ToInt32(tbl.Rows[0][5].ToString()) == 0)

                {

                    chkUser.Checked = false;

                }
                if (Convert.ToInt32(tbl.Rows[0][6].ToString()) == 1)
                {
                    chkMangGames.Checked = true;


                }
                else if (Convert.ToInt32(tbl.Rows[0][6].ToString()) == 0)

                {

                    chkMangGames.Checked = false;

                }

            }

        }

        private void cbxUsernameop_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            getuserid();
            db.executeData(" update [dbo].[Roles] set [Employee_Name] ='" + txtUserName.Text + "',[Status]='" + cbxtype.Text + "',[Password]='" + txtPassword.Text + "' where role_Id='" + txtID.Text + "' ", "تم التعديل بنجاح");

            // string EncrptPass = Encrypt(txtPassword.Text);
            // db.readData("update   Users set  User_Name =N'" + txtUserName.Text + "' ,User_Password=N'" + EncrptPass + "' , type='" + cbxtype.Text + "',UserId='" + User_id + "',EnterTime='" + datecurrent + "'  where User_ID='" + txtID.Text + "'", "تم تعديل البيانات بنجاح");
        }
        int row;
        private void Show()
        {
            tbl.Clear();
            tbl = db.readData("select * from Roles", "");

            if (tbl.Rows.Count <= 0)
            {
                MessageBox.Show("لايوجد بيانات في هذه الشاشة");
            }
            else
            {
                try
                {
                    txtID.Text = tbl.Rows[row][0].ToString();
                    txtUserName.Text = tbl.Rows[row][1].ToString();
                    txtPassword.Text = tbl.Rows[row][2].ToString();
                }
                catch { }


            }
            btnDelete.Enabled = true;
            btnNew.Enabled = true;
            btnSave.Enabled = true;
            btnAdd.Enabled = false;

        }
        private void Auto()
        {
   
            tbl.Clear();
            tbl = db.readData("select max (role_Id) from Roles", "");

            if (tbl.Rows[0][0].ToString() == DBNull.Value.ToString())
            {
                txtID.Text = "1";
            }
            else
            {
                txtID.Text = (Convert.ToInt32(tbl.Rows[0][0]) + 1).ToString();

            }
            txtPassword.Clear();
            txtUserName.Clear();


            btnDelete.Enabled = false;
            btnNew.Enabled = true;
            btnSave.Enabled = false;

            btnAdd.Enabled = true;
        
    
        }
        private void btnlast_Click(object sender, EventArgs e)
        {

            tbl.Clear();
            tbl = db.readData("select count(role_Id) from Roles", "");
            row = (Convert.ToInt32(tbl.Rows[0][0]) - 1);
            Show();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            if (row == 0)
            {
                tbl.Clear();
                tbl = db.readData("select count(role_Id) from Roles", "");
                row = Convert.ToInt32(tbl.Rows[0][0]) - 1;
                Show();
            }
            else
            {

                row--;
                Show();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tbl = db.readData("select count(role_Id) from Roles", "");
            if ((Convert.ToInt32(tbl.Rows[0][0]) - 1) == row)
            {
                row = 0;
                Show();
            }
            else
            {
                row++;
                Show();
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (row == 0)
            {
                tbl.Clear();
                tbl = db.readData("select count(role_Id) from Roles", "");
                row = Convert.ToInt32(tbl.Rows[0][0]) - 1;
                Show();
            }
            else
            {

                row--;
                Show();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متاكد من مسح البيانات", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                getuserid();
                db.readData("delete from    Roles    where role_Id='" + txtID.Text + "'", "تم مسح  المستخدم بنجاح");
                Auto();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            Auto();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string datecurrent = DateTime.Now.ToString("yyyy-MM-dd ");

            db.executeData("INSERT INTO [dbo].[Roles]([Employee_Name],[Status],[Password]) VALUES('"+txtUserName.Text+"', '"+cbxtype.Text+"', '"+txtPassword.Text+"') ", "");
    
            cbxUsernameop.SelectedIndex = 0;
            //insert to permissions
       //     tbl.Clear();
         //   tbl = db.readData("SELECT  [role_Id]  ,[Employee_Name] ,[Status] ,[Password]  FROM [fightGym].[dbo].[Roles] where role_Id='" + txtID.Text + "'", "");

            db.executeData("INSERT INTO [dbo].[PermisionSetting] ([Permisission_Player],[Permisission_Particpiation],[Permisission_TrainerTech],[Permisission_calculation],[Permisission_Users],[Permisission_Game],[Role_id]) VALUES(0, 0, 0, 0, 0, 0,'"+txtID.Text+"')", "");
           //show users in grid
            dt = new DataTable();
            dt.Clear();
            DGvusers.ClearSelection();
           string sqlcon = ("SELECT [Employee_Name] as 'اسم المستخدم',[Status] as 'نوعة' FROM [fightGym].[dbo].[Roles]");
            SqlConnection cnn = new SqlConnection(ConString);
            SqlCommand comandReader = new SqlCommand(sqlcon, cnn);
            cnn.Open();
            comandReader.ExecuteNonQuery();
            //   conn.Open();
            dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter(comandReader);

            adapt.Fill(dt);
            DGvusers.DataSource = dt;
            cnn.Close();
            Auto();
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
          
        }
    }
}
