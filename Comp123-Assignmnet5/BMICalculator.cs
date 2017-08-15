using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*Name : Gursharan Singh
 *Student Id : 300931676
 * Date : 3rd August,2017
 * Description : This is the BMI calculator 
 * Version : 1.1 Added the private _convert method
 */
namespace Comp123_Assignmnet5
{
    
    public partial class BMICalculator : Form
    {
        //Private Instance Variables
        private decimal _height;
        private decimal _weight;
        private decimal _bmi;
        //Public Properties

        public decimal Height
        {
            get
            {
                return this._height;
            }
            set
            {
                this._height = value;
            }
        }
        public decimal Weight
        {
            get
            {
                return this._weight;
            }
            set
            {
                this._weight = value;
            }
        }

        public decimal Bmi
        {
            get
            {
                return this._bmi;
            }
            set
            {
                this._bmi = value;
            }
        }
        public BMICalculator()
        {
            InitializeComponent();
        }

       private void ImperialRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton imperialButton = sender as RadioButton;
            if (imperialButton.Checked)
            {
                MyHeightTextBox.Text = "Inches";
                MyWeightTextBox.Text = "Pounds";
            }
            else
            {
                MyHeightTextBox.Text = "Metres";
                MyWeightTextBox.Text = "kilograms";
            }

        }

        private void BMIButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            this.Height = _convert(MyHeightTextBox.Text);
            this.Weight = _convert(MyHeightTextBox.Text);
            if (ImperialRadioButton.Checked)
            {
                this.Bmi=
            }
        }

        /// <summary>
        /// This method converts input text of string datatype to decimal
        /// </summary>
        /// <param name="inputText"></param>
        /// <returns></returns>
        private decimal _convert(string inputText)
        {
            try
            {
                return Convert.ToDecimal(inputText);
            }
            catch (Exception exception)
            {

                Debug.WriteLine("An Error Occurred");
                Debug.WriteLine(exception.Message);
            }
            return 0;

        }
    }
}
