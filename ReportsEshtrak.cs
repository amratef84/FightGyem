using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace FighyGym2
{
    public partial class ReportsEshtrak : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportsEshtrak()
        {
           
            InitializeComponent();
      
        }

        private void ReportsEshtrak_DesignerLoaded(object sender, DevExpress.XtraReports.UserDesigner.DesignerLoadedEventArgs e)
        {
            //from.Text = Properties.Settings.Default.date1.ToString();
            //To.Text = Properties.Settings.Default.date2.ToString();
        }
    }
}
