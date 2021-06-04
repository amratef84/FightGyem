using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FighyGym2
{
    static class Program
    {
    
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
           
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm2());
            //Application.Idle += delegate {
            //    Classalarm classalarm = new Classalarm();
            //    classalarm.fun();
            //};

            // Output: true 
          //  Application.Run();



            //  if(MainPage().)

        }
    }
}
