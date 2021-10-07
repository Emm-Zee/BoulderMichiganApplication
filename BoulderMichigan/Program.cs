using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

//
//________________________________________________________________________________________
//________________________________________________________________________________________
//
//Title: Boulder Michigan
//Application Type: .Net Framework
//Description: Have people view services and book visits, classes, and memberships at an 
//             indoor climbing()facility
//Author: Emily Crull
//Date Created: November 22, 2020
//Last Modified: December 5, 2020
//________________________________________________________________________________________
//________________________________________________________________________________________
//
//

namespace BoulderMichigan
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
            Application.Run(new frm_Welcome());
        }
    }
}
