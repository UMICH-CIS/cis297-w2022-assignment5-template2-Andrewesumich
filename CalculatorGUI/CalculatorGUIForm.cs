using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalculatorGUI
{
   public partial class CalculatorGUIForm : Form
   {
      public CalculatorGUIForm()
      {
         InitializeComponent();
      }
        int functionType;//the type of function that has been selected
        double Input1;
        double Input2;
        private void CalculatorGUIForm_Load(object sender, EventArgs e)
        {

        }
        private void Equals_Click(object sender, EventArgs e)
        {
            double Placeholder;
            switch (functionType)
            {
                case (0)://no function selected

                    break;
                case (1): //addition
                    Input2 = double.Parse(textBox1.Text);
                    Placeholder = Input1 + Input2;
                    textBox1.Text = Placeholder.ToString();
                    break;
                case (2): //subtraction
                    Input2 = double.Parse(textBox1.Text);
                    MessageBox.Show($"The numbers subtracted is: {Input1 - Input2}");
                    break;
            }
            Input1 = 0;
            Input2 = 0;
            functionType = 0;
        }

        private void NumZero_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void NumOne_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void NumTwo_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void NumThree_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void NumFour_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void NumFive_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void NumSix_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void NumSeven_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void NumEight_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void NumNine_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void Decimal_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }

        private void Addition_Click(object sender, EventArgs e)
        {
            try
            {
                functionType = 1;
                Input1 = double.Parse(textBox1.Text);
                textBox1.Clear();
            }
            catch (FormatException invalidInput)
            {
                MessageBox.Show("Invalid input!");
                return;
            }
        }

        private void Subtraction_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (FormatException invalidInput)
            {
                MessageBox.Show("Invalid input!");
                return;
            }
        }
        private void Divide_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (FormatException invalidInput)
            {
                MessageBox.Show("Invalid input!");
                return;
            }
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (FormatException invalidInput)
            {
                MessageBox.Show("Invalid input!");
                return;
            }
        }

        private void RemoveSpaces_Click(object sender, EventArgs e)
        {
            string placeholder = textBox1.Text;
            placeholder = placeholder.Replace(" ", "");
            MessageBox.Show($"The input without spaces is: {placeholder}");
        }

        private void ReverseString_Click(object sender, EventArgs e)
        {
            string placeholder = textBox1.Text;
            char[] charArray = placeholder.ToCharArray();
            Array.Reverse(charArray);
            placeholder = String.Concat(charArray);
            MessageBox.Show($"The input reversed is: {placeholder}");
        }

        private void QuotientRemainder_Click(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch(FormatException invalidInput)
            {
                MessageBox.Show("Invalid input!");
                return;
            }
            
        }

        private void Log10_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (FormatException invalidInput)
            {
                MessageBox.Show("Invalid input!");
                return;
            }
        }

        private void LogX_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (FormatException invalidInput)
            {
                MessageBox.Show("Invalid input!");
                return;
            }
        }

        private void MinMax_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (FormatException invalidInput)
            {
                MessageBox.Show("Invalid input!");
                return;
            }
        }

        private void ToThePower_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (FormatException invalidInput)
            {
                MessageBox.Show("Invalid input!");
                return;
            }
        }

        private void QuadraticRoots_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (FormatException invalidInput)
            {
                MessageBox.Show("Invalid input!");
                return;
            }
        }

        private void SquareRoot_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (FormatException invalidInput)
            {
                MessageBox.Show("Invalid input!");
                return;
            }
        }

    }
}

/**************************************************************************
 * (C) Copyright 1992-2017 by Deitel & Associates, Inc. and               *
 * Pearson Education, Inc. All Rights Reserved.                           *
 *                                                                        *
 * DISCLAIMER: The authors and publisher of this book have used their     *
 * best efforts in preparing the book. These efforts include the          *
 * development, research, and testing of the theories and programs        *
 * to determine their effectiveness. The authors and publisher make       *
 * no warranty of any kind, expressed or implied, with regard to these    *
 * programs or to the documentation contained in these books. The authors *
 * and publisher shall not be liable in any event for incidental or       *
 * consequential damages in connection with, or arising out of, the       *
 * furnishing, performance, or use of these programs.                     *
 *************************************************************************/