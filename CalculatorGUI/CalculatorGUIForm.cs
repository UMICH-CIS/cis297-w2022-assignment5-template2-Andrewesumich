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
        int intInput1;
        int intInput2;
        private void CalculatorGUIForm_Load(object sender, EventArgs e)
        {
            textBoxA.Enabled = false;
            textBoxB.Enabled = false;
            textBoxC.Enabled = false;
            Description.Enabled = false;
        }
        private void Equals_Click(object sender, EventArgs e)
        {
            double Placeholder;//used to hold the value that will be put back into the calulator display
            int a;//used for the quadradic formula
            int b;
            int c;
            double determinent;
            try
            {
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
                        Placeholder = Input1 - Input2;
                        textBox1.Text = Placeholder.ToString();
                        break;
                    case (3): //division
                        Input2 = double.Parse(textBox1.Text);
                        Placeholder = Input1 / Input2;
                        textBox1.Text = Placeholder.ToString();
                        break;
                    case (4): //multiplication
                        Input2 = double.Parse(textBox1.Text);
                        Placeholder = Input1 * Input2;
                        textBox1.Text = Placeholder.ToString();
                        break;
                    //don't need to have a case for removing white spaces or reversing as they only use one input
                    case (5): //quotientRemainder
                        intInput2 = int.Parse(textBox1.Text);
                        int remainder = 0;
                        Math.DivRem(intInput1, intInput2, out remainder);
                        MessageBox.Show($"The quotient of the numbers is: {intInput1 / intInput2}\nThe remainder is: {remainder}");
                        textBox1.Clear();
                        break;
                    case (6): //logX
                        Input2 = double.Parse(textBox1.Text);
                        Placeholder = Math.Log(Input1, Input2);
                        textBox1.Text = Placeholder.ToString();
                        break;
                    case (7): //MinMax
                        Input2 = double.Parse(textBox1.Text);
                        MessageBox.Show($"The smaller number is: {Math.Min(Input1, Input2)}\nThe larger number is: {Math.Max(Input1, Input2)}");
                        textBox1.Clear();
                        break;
                    case (8): //toThePower
                        Input2 = double.Parse(textBox1.Text);
                        Placeholder = Math.Pow(Input1, Input2);
                        textBox1.Text = Placeholder.ToString();
                        break;
                    case (9)://quadratic
                        a = int.Parse(textBoxA.Text);
                        b = int.Parse(textBoxB.Text);
                        c = int.Parse(textBoxC.Text);
                        determinent = Math.Pow(b, 2) - (4 * a * c);
                        if(determinent > 0)
                        {
                            MessageBox.Show($"Equation has two roots\nRoot 1: {(-b + Math.Sqrt(determinent))/(2 * a)}\nRoot 2: {(-b - Math.Sqrt(determinent)) / (2 * a)}");
                        }
                        else if (determinent == 0)
                        {
                            MessageBox.Show($"Equation has one root: {-b / (2 * a)}");
                        }
                        else
                        {
                            MessageBox.Show("Equation given has no roots");
                        }
                        textBoxA.Clear();
                        textBoxB.Clear();
                        textBoxC.Clear();
                        break;
                }
            }
            catch (FormatException invalidInput)
            {
                MessageBox.Show("Invalid input!");
            }
            finally//always reset the value in the calculator after an invalid input is detected
            {
                Input1 = 0;
                Input2 = 0;
                intInput1 = 0;
                intInput2 = 0;
                functionType = 0;
                Placeholder = 0;
                Addition.Enabled = true;
                Subtraction.Enabled = true;
                Divide.Enabled = true;
                Multiply.Enabled = true;
                RemoveSpaces.Enabled = true;
                ReverseString.Enabled = true;
                QuotientRemainder.Enabled = true;
                Log10.Enabled = true;
                LogX.Enabled = true;
                MinMax.Enabled = true;
                ToThePower.Enabled = true;
                QuadraticRoots.Enabled = true;
                SquareRoot.Enabled = true;
                textBoxA.Enabled = false;
                textBoxB.Enabled = false;
                textBoxC.Enabled = false;
            }
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
                Addition.Enabled = false;//disable other button presses until the first function is finished
                Subtraction.Enabled = false;
                Divide.Enabled = false;
                Multiply.Enabled = false;
                RemoveSpaces.Enabled = false;
                ReverseString.Enabled = false;
                QuotientRemainder.Enabled = false;
                Log10.Enabled = false;
                LogX.Enabled = false;
                MinMax.Enabled = false;
                ToThePower.Enabled = false;
                QuadraticRoots.Enabled = false;
                SquareRoot.Enabled = false;
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
                functionType = 2;
                Input1 = double.Parse(textBox1.Text);
                textBox1.Clear();
                Addition.Enabled = false;
                Subtraction.Enabled = false;
                Divide.Enabled = false;
                Multiply.Enabled = false;
                RemoveSpaces.Enabled = false;
                ReverseString.Enabled = false;
                QuotientRemainder.Enabled = false;
                Log10.Enabled = false;
                LogX.Enabled = false;
                MinMax.Enabled = false;
                ToThePower.Enabled = false;
                QuadraticRoots.Enabled = false;
                SquareRoot.Enabled = false;
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
                functionType = 3;
                Input1 = double.Parse(textBox1.Text);
                textBox1.Clear();
                Addition.Enabled = false;
                Subtraction.Enabled = false;
                Divide.Enabled = false;
                Multiply.Enabled = false;
                RemoveSpaces.Enabled = false;
                ReverseString.Enabled = false;
                QuotientRemainder.Enabled = false;
                Log10.Enabled = false;
                LogX.Enabled = false;
                MinMax.Enabled = false;
                ToThePower.Enabled = false;
                QuadraticRoots.Enabled = false;
                SquareRoot.Enabled = false;
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
                functionType = 4;
                Input1 = double.Parse(textBox1.Text);
                textBox1.Clear();
                Addition.Enabled = false;
                Subtraction.Enabled = false;
                Divide.Enabled = false;
                Multiply.Enabled = false;
                RemoveSpaces.Enabled = false;
                ReverseString.Enabled = false;
                QuotientRemainder.Enabled = false;
                Log10.Enabled = false;
                LogX.Enabled = false;
                MinMax.Enabled = false;
                ToThePower.Enabled = false;
                QuadraticRoots.Enabled = false;
                SquareRoot.Enabled = false;
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
            textBox1.Text = placeholder;
        }

        private void ReverseString_Click(object sender, EventArgs e)
        {
            string placeholder = textBox1.Text;
            char[] charArray = placeholder.ToCharArray();
            Array.Reverse(charArray);
            placeholder = String.Concat(charArray);
            textBox1.Text = placeholder;
        }

        private void QuotientRemainder_Click(object sender, EventArgs e)
        {
            try
            {
                functionType = 5;
                intInput1 = int.Parse(textBox1.Text);
                textBox1.Clear();
                Addition.Enabled = false;
                Subtraction.Enabled = false;
                Divide.Enabled = false;
                Multiply.Enabled = false;
                RemoveSpaces.Enabled = false;
                ReverseString.Enabled = false;
                QuotientRemainder.Enabled = false;
                Log10.Enabled = false;
                LogX.Enabled = false;
                MinMax.Enabled = false;
                ToThePower.Enabled = false;
                QuadraticRoots.Enabled = false;
                SquareRoot.Enabled = false;
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
                double placeholder = double.Parse(textBox1.Text);
                placeholder = Math.Log10(placeholder);
                textBox1.Text = placeholder.ToString();
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
                functionType = 6;
                Input1 = double.Parse(textBox1.Text);
                textBox1.Clear();
                Addition.Enabled = false;
                Subtraction.Enabled = false;
                Divide.Enabled = false;
                Multiply.Enabled = false;
                RemoveSpaces.Enabled = false;
                ReverseString.Enabled = false;
                QuotientRemainder.Enabled = false;
                Log10.Enabled = false;
                LogX.Enabled = false;
                MinMax.Enabled = false;
                ToThePower.Enabled = false;
                QuadraticRoots.Enabled = false;
                SquareRoot.Enabled = false;
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
                functionType = 7;
                Input1 = double.Parse(textBox1.Text);
                textBox1.Clear();
                Addition.Enabled = false;
                Subtraction.Enabled = false;
                Divide.Enabled = false;
                Multiply.Enabled = false;
                RemoveSpaces.Enabled = false;
                ReverseString.Enabled = false;
                QuotientRemainder.Enabled = false;
                Log10.Enabled = false;
                LogX.Enabled = false;
                MinMax.Enabled = false;
                ToThePower.Enabled = false;
                QuadraticRoots.Enabled = false;
                SquareRoot.Enabled = false;
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
                functionType = 8;
                Input1 = double.Parse(textBox1.Text);
                textBox1.Clear();
                Addition.Enabled = false;
                Subtraction.Enabled = false;
                Divide.Enabled = false;
                Multiply.Enabled = false;
                RemoveSpaces.Enabled = false;
                ReverseString.Enabled = false;
                QuotientRemainder.Enabled = false;
                Log10.Enabled = false;
                LogX.Enabled = false;
                MinMax.Enabled = false;
                ToThePower.Enabled = false;
                QuadraticRoots.Enabled = false;
                SquareRoot.Enabled = false;
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
                functionType = 9;
                textBoxA.Enabled = true;
                textBoxB.Enabled = true;
                textBoxC.Enabled = true;
                Addition.Enabled = false;
                Subtraction.Enabled = false;
                Divide.Enabled = false;
                Multiply.Enabled = false;
                RemoveSpaces.Enabled = false;
                ReverseString.Enabled = false;
                QuotientRemainder.Enabled = false;
                Log10.Enabled = false;
                LogX.Enabled = false;
                MinMax.Enabled = false;
                ToThePower.Enabled = false;
                QuadraticRoots.Enabled = false;
                SquareRoot.Enabled = false;

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
                double placeholder = double.Parse(textBox1.Text);
                placeholder = Math.Sqrt(placeholder);
                textBox1.Text = placeholder.ToString();
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