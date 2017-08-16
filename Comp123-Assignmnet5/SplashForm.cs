using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*Name : Gursharan Singh
 *Student Id : 300931676
 * Date : 15th August,2017
 * Description : This is the BMI calculator 
 * Version : 1.2 Added the tick event
 */
namespace Comp123_Assignmnet5
{
    public partial class SplashForm : Form
    {
        public BMICalculator BMICalculatorForm
        {

            get
            {
                return Program.bmiCalculator;
            }

        }
        public SplashForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is the event handler for the "tick" event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            BMICalculator bmiCalculator = new BMICalculator();
            bmiCalculator.Show();
            this.Hide();
            SplashTimer.Enabled = false;
        }
    }
}
