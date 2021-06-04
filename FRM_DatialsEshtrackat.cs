using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;


namespace FighyGym2
{
    public partial class FRM_DatialsEshtrackat : DevExpress.XtraEditors.XtraForm
    {
        public FRM_DatialsEshtrackat()
        {
            InitializeComponent();
        }
        public string sms, phon;
      
   

        void load()
        {
            string[] ports = SerialPort.GetPortNames();

            foreach (string item in ports)
            {
               // comboBox1.Items.Add(item);
            }
        }
        private void FRM_DatialsEshtrackat_Load(object sender, EventArgs e)
        {
            firstName.Text = Properties.Settings.Default.StuName;
            txtclass.Text = Properties.Settings.Default.ClassName;
            txtphone.Text = Properties.Settings.Default.phone;
            
            //byte img =Convert.ToByte( Properties.Settings.Default.pic);
          
            txtImage.SizeMode = PictureBoxSizeMode.StretchImage;
            if (Properties.Settings.Default.pic == "")
            {
                MessageBox.Show("لاتوجد صورة للمشترك!");
            }
            else
            {
                txtImage.Load(Properties.Settings.Default.pic);
            }
        }

        private void txtImage_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
        //    //send 
        //    try{ 
        //    string from = "+967774941928";
        //    string to = txtphone.Text;
        //    string msg = textBox1.Text;
        //    WhatsApp wa = new WhatsApp(from,"1995", "samiah",true);
        //    wa.OnConnectSuccess += () =>
        //    {
        //        MessageBox.Show("connect to whatsapp..");

        //        wa.OnLoginSuccess += (phonrnumb, data) =>
        //        {
        //            wa.SendMessage(to, msg);
        //            MessageBox.Show("message sent...");
        //        };
        //        wa.OnLoginFailed += (data) =>
        //         {
        //             MessageBox.Show("login Faild : {0}", data);
        //         };
        //        wa.Login();

        //    };
        //    wa.OnConnectFailed += (ex) =>
        //     {
        //         MessageBox.Show("connection faild...");
        //     };
        //    wa.Connect();
        //    }
        //    catch(Exception ex) { MessageBox.Show(ex.Message); }
        //    //try
            //{
            //    load();
            //    for (int i = 0; i <= comboBox1.Items.Count - 1; i++)
            //    {
            //        comboBox1.SelectedIndex = i;
            //        port = cls.OpenPort(comboBox1.Text, Convert.ToInt32(9600), Convert.ToInt32(8), Convert.ToInt32(300), Convert.ToInt32(300));

            //        phon = txtphone.Text;
            //        sms = textBox1.Text;

            //        try
            //        {
            //            if (cls.sendMsg(port, phon, sms))
            //            {
            //                cls.ClosePort(port);
            //            }
            //        }
            //        catch (Exception)
            //        {


            //        }

            //    }

            //}
            //catch (Exception)
            //{


            //}

        }
    }
}