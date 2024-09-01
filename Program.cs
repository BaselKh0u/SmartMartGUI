using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartMart
{
    internal static class Program
    {
        public static Admin AdminInstance { get; set; }
        [STAThread]
        static void Main()
        {
            AdminInstance = new Admin("SmartMart E-Commerce Program");
            AdminInstance.FetchData();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
