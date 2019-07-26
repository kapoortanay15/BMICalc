using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Author's Name: Tanay Kapoor
/// Student Number: 301044399
/// Date Modified: 26-07-2019
/// Description: This Program Calculates your BMI as per the Values entered 
/// </summary>


namespace BMICalc
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
            Application.Run(new CalculatorForm());
        }
    }
}
