using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/*Name : Gursharan Singh
 *Student Id : 300931676
 * Date : 3rd August,2017
 * Description : This is the BMI calculator 
 * Version : 1.0 Created the program class
 */ 
namespace Comp123_Assignmnet5
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
            Application.Run(new BMICalculator());
        }
    }
}
