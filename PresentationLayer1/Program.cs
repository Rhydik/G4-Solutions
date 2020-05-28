using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer.Testdata;

namespace PresentationLayer1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var testdata = new Testdata();

            Console.WriteLine(testdata.Konto5021);
            Console.WriteLine(testdata.SchablonKostnad);



            testdata.ResultatAvdelning();
            testdata.ResultatProduktX();
            testdata.ResultatProduktY();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLoggaIn());
        }
    }
}
