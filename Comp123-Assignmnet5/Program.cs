using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/*Name : Gursharan Singh
 *Student Id : 300931676
 * Date : 3rd August,2017
 * Description : This is the BMI calculator 
 * Version : 1.1 Created the draft user interface
 */ 
namespace Comp123_Assignmnet5
{
    public static class Program
    {
        public static BMICalculator bmiCalculator;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            bmiCalculator = new BMICalculator();
            Application.Run(new SplashForm());
        }
    }
}
