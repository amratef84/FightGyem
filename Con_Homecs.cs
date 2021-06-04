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

namespace FighyGym2
{
    public partial class Con_Homecs : DevExpress.XtraEditors.XtraUserControl
    {
        public Con_Homecs()
        {
            InitializeComponent();
        }
        private static Con_Homecs _instance;
        public static Con_Homecs Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Con_Homecs();
                return _instance;
            }
        }
        private void tileItem9_ItemClick(object sender, TileItemEventArgs e)
        {
            if (!tileControl2.Controls.Contains(CondetialsEshtracat.Instance))
            {

                tileControl2.Controls.Add(CondetialsEshtracat.Instance);
                CondetialsEshtracat.Instance.Dock = DockStyle.Fill;
                CondetialsEshtracat.Instance.BringToFront();

            }
            CondetialsEshtracat.Instance.BringToFront();
        }

        private void tileItem3_ItemClick(object sender, TileItemEventArgs e)
        {
            if (!tileControl2.Controls.Contains(ConEditStudents.Instance))
            {

                tileControl2.Controls.Add(ConEditStudents.Instance);
                ConEditStudents.Instance.Dock = DockStyle.Fill;
                ConEditStudents.Instance.BringToFront();

            }
            ConEditStudents.Instance.BringToFront();
        }

        private void tileItem4_ItemClick(object sender, TileItemEventArgs e)
        {
            if (!tileControl2.Controls.Contains(AddEmployee.Instance))
            {

                tileControl2.Controls.Add(AddEmployee.Instance);
                AddEmployee.Instance.Dock = DockStyle.Fill;
                AddEmployee.Instance.BringToFront();

            }
            AddEmployee.Instance.BringToFront();
        }

        private void tileItem10_ItemClick(object sender, TileItemEventArgs e)
        {
            if (!tileControl2.Controls.Contains(Con_Eshtracat.Instance))
            {

                tileControl2.Controls.Add(Con_Eshtracat.Instance);
                Con_Eshtracat.Instance.Dock = DockStyle.Fill;
                Con_Eshtracat.Instance.BringToFront();

            }
            Con_Eshtracat.Instance.BringToFront();
        }
    }
}
