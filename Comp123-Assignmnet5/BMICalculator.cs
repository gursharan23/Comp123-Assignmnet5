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
 * Date : 10th August,2017
 * Description : This is the BMI calculator for calculating body mass index
 * Version : 1.8 Refactored the calculator
 */
namespace Comp123_Assignmnet5
{

    public partial class BMICalculator : Form
    {
        //Private Instance Variables
        private double _height;
        private double _weight;
        private double _bmi;
        //Public Properties

        public double Height
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
        public double Weight
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

        public double Bmi
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
                this.Bmi = Math.Round(((this.Weight * 703) / Math.Pow(this.Height, 2)), 1);
            }
            else if (MetricRadioButton.Checked)
            {
                this.Bmi = Math.Round(((this.Weight) / (this.Height * this.Height)), 1);
            }
            textBox.Text = Bmi.ToString();
            _scale();
        }
        private void _scale()
        {
            BMITextBox.Text = "You are : ";
            if (this.Bmi <= 18.5)
            {
                BMITextBox.Text += "Underweight";
                BMITextBox.BackColor = Color.Red;
            }
            else if (this.Bmi > 18.5 && this.Bmi <= 24.9)
            {
                BMITextBox.Text += "Normal";
                BMITextBox.BackColor = Color.Green;
            }
            else if (this.Bmi >= 25 && this.Bmi <= 29.9)
            {
                BMITextBox.Text += "Overweight";
                BMITextBox.BackColor = Color.Orange;
            }
            else
            {
                BMITextBox.Text += "Obese";
                BMITextBox.BackColor = Color.OrangeRed;
            }
        }

        /// <summary>
        /// This method converts input text of string datatype to decimal
        /// </summary>
        /// <param name="inputText"></param>
        /// <returns></returns>
        private double _convert(string inputText)
        {
            try
            {
                return Convert.ToDouble(inputText);
            }
            catch (Exception exception)
            {

                Debug.WriteLine("An Error Occurred");
                Debug.WriteLine(exception.Message);
            }
            return 0;

        }
        /// <summary>
        /// This is the event handler for closing the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BMICalculator_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// This is refrenced from stacxkoverflow
        /// It Handle the appropriate keyboard events to prevent anything
        /// but numeric input. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MyHeightTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void MyWeightTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// This is the reset button method that resets the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetButton_Click(object sender, EventArgs e)
        {
            MyWeightTextBox.Text = "";
            MyWeightTextBox.Text = "";
            textBox.Text = "";
            BMITextBox.Text = "";
            BMITextBox.BackColor = Color.White;
        }

        /// <summary>
        /// This method acts as a placeholder 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MyHeightTextBox_Enter(object sender, EventArgs e)
        {
            MyHeightTextBox.Text = "";
        }

        private void MyHeightTextBox_Leave(object sender, EventArgs e)
        {
            if (MyHeightTextBox.Text == "")
            {
                MyHeightTextBox.Text = "Inches";
            }
            else
            {
                return;
            }
        }

        private void MyWeightTextBox_Enter(object sender, EventArgs e)
        {
            MyWeightTextBox.Text = "";
        }

        private void MyWeightTextBox_Leave(object sender, EventArgs e)
        {
            if (MyWeightTextBox.Text == "")
            {
                MyWeightTextBox.Text = "Pounds";
            }
            else
            {
                return;
            }
        }

   
    }
}
