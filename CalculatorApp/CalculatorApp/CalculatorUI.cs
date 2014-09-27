using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class CalculatorUI : Form
    {
        Calculator aCalculator = new Calculator();
        private double fNumber;
        private double sNumber;

        public CalculatorUI()
        {
            InitializeComponent();
        }
       
        private void addButton_Click(object sender, EventArgs e)
        {
            InitializeFNumberandSNumber();

            double result = aCalculator.Add(fNumber, sNumber);

            resultBox.Text = result.ToString();
        }

        private void InitializeFNumberandSNumber()
        {
            fNumber = Convert.ToDouble(firstnumberBox.Text);
            sNumber = Convert.ToDouble(secondnumberBox.Text);
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            InitializeFNumberandSNumber();

            double result = aCalculator.subtract(fNumber, sNumber);

            resultBox.Text = result.ToString();
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            InitializeFNumberandSNumber();
            double result = aCalculator.multiply(fNumber, sNumber);

            resultBox.Text = result.ToString();
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            InitializeFNumberandSNumber();
            double result = aCalculator.divide(fNumber, sNumber);

            resultBox.Text = result.ToString();

        }
    }
}
