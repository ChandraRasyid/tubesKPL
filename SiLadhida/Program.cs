using SiLadhida.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SiLadhida.Model;
using SiLadhida.Controller;
using SiLadhida.Services;
using SiLadhida.View;

namespace SiLadhida
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new View1());
        }
    }
}