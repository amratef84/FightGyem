using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace FighyGym2
{
    public partial class MainPage : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public MainPage()
        {
            InitializeComponent();
            this.EnableAcrylicAccent = true;
            
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinMaskColors(Color.DarkBlue, Color.LightBlue);
        }

        private void accordionControlElement3_Click(object sender, EventArgs e)
        {
            
        }

        private void tileControl1_Click(object sender, EventArgs e)
        {

        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            //Classalarm cd = new Classalarm();
            //var thread =new Thread( new ThreadStart(cd.fun));
            //thread.Start();
           // thread.BeginInvoke(100, "", null, null);
        }

        private void accordionControl1_Click(object sender, EventArgs e)
        {

        }

        private void tileControl1_Click_1(object sender, EventArgs e)
        {

        }

        private void accordionControlElement10_Click(object sender, EventArgs e)
        {
            if (!containers.Controls.Contains(ConEditStudents.Instance))
            {

                containers.Controls.Add(ConEditStudents.Instance);
                ConEditStudents.Instance.Dock = DockStyle.Fill;
                ConEditStudents.Instance.BringToFront();

            }
            ConEditStudents.Instance.BringToFront();

        }

        private void tileItem1_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
          
        }

        private void accordionControlElement11_Click(object sender, EventArgs e)
        {
            if (!containers.Controls.Contains(Con_Eshtracat.Instance))
            {

                containers.Controls.Add(Con_Eshtracat.Instance);
                Con_Eshtracat.Instance.Dock = DockStyle.Fill;
                Con_Eshtracat.Instance.BringToFront();

            }
            Con_Eshtracat.Instance.BringToFront();
        }

        private void accordionControlElement12_Click(object sender, EventArgs e)
        {
            if (!containers.Controls.Contains(CondetialsEshtracat.Instance))
            {

                containers.Controls.Add(CondetialsEshtracat.Instance);
                CondetialsEshtracat.Instance.Dock = DockStyle.Fill;
                CondetialsEshtracat.Instance.BringToFront();

            }
            CondetialsEshtracat.Instance.BringToFront();
        }

        private void accordionControlElement9_Click(object sender, EventArgs e)
        {
         
            if (!containers.Controls.Contains(Con_Homecs.Instance))
            {

                containers.Controls.Add(Con_Homecs.Instance);
                Con_Homecs.Instance.Dock = DockStyle.Fill;
                Con_Homecs.Instance.BringToFront();

            }else
            {
                if(containers.Controls.Contains(Con_Homecs.Instance))
            {

                    containers.Controls.Add(Con_Homecs.Instance);
                    Con_Homecs.Instance.Dock = DockStyle.Fill;
                    Con_Homecs.Instance.BringToFront();

           }
              //  Con_Homecs.Instance.BringToFront();
            }
            Con_Homecs.Instance.BringToFront();
        }

        private void tileItem3_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            if (!containers.Controls.Contains(ConEditStudents.Instance))
            {

                containers.Controls.Add(ConEditStudents.Instance);
                ConEditStudents.Instance.Dock = DockStyle.Fill;
                ConEditStudents.Instance.BringToFront();

            }
            ConEditStudents.Instance.BringToFront();
        }

        private void containers_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement13_Click(object sender, EventArgs e)
        {
            if (!containers.Controls.Contains(AddEmployee.Instance))
            {

                containers.Controls.Add(AddEmployee.Instance);
                AddEmployee.Instance.Dock = DockStyle.Fill;
                AddEmployee.Instance.BringToFront();

            }
            AddEmployee.Instance.BringToFront();
        }

        private void tileItem10_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            if (!containers.Controls.Contains(Con_Eshtracat.Instance))
            {

                containers.Controls.Add(Con_Eshtracat.Instance);
                Con_Eshtracat.Instance.Dock = DockStyle.Fill;
                Con_Eshtracat.Instance.BringToFront();

            }
            Con_Eshtracat.Instance.BringToFront();
        }

        private void tileItem4_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            if (!containers.Controls.Contains(AddEmployee.Instance))
            {

                containers.Controls.Add(AddEmployee.Instance);
                AddEmployee.Instance.Dock = DockStyle.Fill;
                AddEmployee.Instance.BringToFront();

            }
            AddEmployee.Instance.BringToFront();
        }

        private void tileItem9_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            if (!containers.Controls.Contains(CondetialsEshtracat.Instance))
            {

                containers.Controls.Add(CondetialsEshtracat.Instance);
                CondetialsEshtracat.Instance.Dock = DockStyle.Fill;
                CondetialsEshtracat.Instance.BringToFront();

            }
            CondetialsEshtracat.Instance.BringToFront();
        }
    }
}
