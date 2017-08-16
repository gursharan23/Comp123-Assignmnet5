﻿using System;
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
 * Version : 1.2 Added the private _scale method
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
                this.Bmi = Math.Floor((this.Weight * 703) / (this.Height * this.Height));
            }
            else if(MetricRadioButton.Checked)
            {
                this.Bmi = Math.Floor((this.Weight) / (this.Height * this.Height));
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
            }
            else if (this.Bmi > 18.5 && this.Bmi <= 24.9)
            {
                BMITextBox.Text += "Normal";
            }
            else if (this.Bmi >= 25 && this.Bmi <= 29.9)
            {
                BMITextBox.Text += "Overweight";
            }
            else
            {
                BMITextBox.Text += "Obese";
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
    }
}
