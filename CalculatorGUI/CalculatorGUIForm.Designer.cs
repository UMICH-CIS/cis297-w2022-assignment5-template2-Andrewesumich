namespace CalculatorGUI
{
   partial class CalculatorGUIForm
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose( bool disposing )
      {
         if ( disposing && ( components != null ) )
         {
            components.Dispose();
         }
         base.Dispose( disposing );
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
            this.Equals = new System.Windows.Forms.Button();
            this.Decimal = new System.Windows.Forms.Button();
            this.NumZero = new System.Windows.Forms.Button();
            this.Addition = new System.Windows.Forms.Button();
            this.NumThree = new System.Windows.Forms.Button();
            this.NumTwo = new System.Windows.Forms.Button();
            this.NumOne = new System.Windows.Forms.Button();
            this.Multiply = new System.Windows.Forms.Button();
            this.NumSix = new System.Windows.Forms.Button();
            this.NumFive = new System.Windows.Forms.Button();
            this.NumFour = new System.Windows.Forms.Button();
            this.NumNine = new System.Windows.Forms.Button();
            this.NumEight = new System.Windows.Forms.Button();
            this.NumSeven = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ReverseString = new System.Windows.Forms.Button();
            this.QuotientRemainder = new System.Windows.Forms.Button();
            this.QuadraticRoots = new System.Windows.Forms.Button();
            this.MinMax = new System.Windows.Forms.Button();
            this.ToThePower = new System.Windows.Forms.Button();
            this.SquareRoot = new System.Windows.Forms.Button();
            this.RemoveSpaces = new System.Windows.Forms.Button();
            this.Log10 = new System.Windows.Forms.Button();
            this.LogX = new System.Windows.Forms.Button();
            this.Divide = new System.Windows.Forms.Button();
            this.Subtraction = new System.Windows.Forms.Button();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.Description = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Equals
            // 
            this.Equals.AccessibleName = "Equals";
            this.Equals.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Equals.Location = new System.Drawing.Point(126, 180);
            this.Equals.Margin = new System.Windows.Forms.Padding(0);
            this.Equals.Name = "Equals";
            this.Equals.Size = new System.Drawing.Size(63, 50);
            this.Equals.TabIndex = 32;
            this.Equals.Text = "=";
            this.Equals.Click += new System.EventHandler(this.Equals_Click);
            // 
            // Decimal
            // 
            this.Decimal.AccessibleName = "Decimal";
            this.Decimal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Decimal.Location = new System.Drawing.Point(63, 180);
            this.Decimal.Margin = new System.Windows.Forms.Padding(0);
            this.Decimal.Name = "Decimal";
            this.Decimal.Size = new System.Drawing.Size(63, 50);
            this.Decimal.TabIndex = 31;
            this.Decimal.Text = ".";
            this.Decimal.Click += new System.EventHandler(this.Decimal_Click);
            // 
            // NumZero
            // 
            this.NumZero.AccessibleName = "NumZero";
            this.NumZero.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NumZero.Location = new System.Drawing.Point(0, 180);
            this.NumZero.Margin = new System.Windows.Forms.Padding(0);
            this.NumZero.Name = "NumZero";
            this.NumZero.Size = new System.Drawing.Size(63, 50);
            this.NumZero.TabIndex = 30;
            this.NumZero.Text = "0";
            this.NumZero.Click += new System.EventHandler(this.NumZero_Click);
            // 
            // Addition
            // 
            this.Addition.AccessibleName = "Addition";
            this.Addition.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Addition.Location = new System.Drawing.Point(189, 130);
            this.Addition.Margin = new System.Windows.Forms.Padding(0);
            this.Addition.Name = "Addition";
            this.Addition.Size = new System.Drawing.Size(63, 50);
            this.Addition.TabIndex = 29;
            this.Addition.Text = "+";
            this.Addition.Click += new System.EventHandler(this.Addition_Click);
            // 
            // NumThree
            // 
            this.NumThree.AccessibleName = "NumThree";
            this.NumThree.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NumThree.Location = new System.Drawing.Point(126, 130);
            this.NumThree.Margin = new System.Windows.Forms.Padding(0);
            this.NumThree.Name = "NumThree";
            this.NumThree.Size = new System.Drawing.Size(63, 50);
            this.NumThree.TabIndex = 28;
            this.NumThree.Text = "3";
            this.NumThree.Click += new System.EventHandler(this.NumThree_Click);
            // 
            // NumTwo
            // 
            this.NumTwo.AccessibleName = "NumTwo";
            this.NumTwo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NumTwo.Location = new System.Drawing.Point(63, 130);
            this.NumTwo.Margin = new System.Windows.Forms.Padding(0);
            this.NumTwo.Name = "NumTwo";
            this.NumTwo.Size = new System.Drawing.Size(63, 50);
            this.NumTwo.TabIndex = 27;
            this.NumTwo.Text = "2";
            this.NumTwo.Click += new System.EventHandler(this.NumTwo_Click);
            // 
            // NumOne
            // 
            this.NumOne.AccessibleName = "NumOne";
            this.NumOne.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NumOne.Location = new System.Drawing.Point(0, 130);
            this.NumOne.Margin = new System.Windows.Forms.Padding(0);
            this.NumOne.Name = "NumOne";
            this.NumOne.Size = new System.Drawing.Size(63, 50);
            this.NumOne.TabIndex = 26;
            this.NumOne.Text = "1";
            this.NumOne.Click += new System.EventHandler(this.NumOne_Click);
            // 
            // Multiply
            // 
            this.Multiply.AccessibleName = "Multiply";
            this.Multiply.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Multiply.Location = new System.Drawing.Point(189, 80);
            this.Multiply.Margin = new System.Windows.Forms.Padding(0);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(63, 50);
            this.Multiply.TabIndex = 25;
            this.Multiply.Text = "*";
            this.Multiply.Click += new System.EventHandler(this.Multiply_Click);
            // 
            // NumSix
            // 
            this.NumSix.AccessibleName = "NumSix";
            this.NumSix.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NumSix.Location = new System.Drawing.Point(126, 80);
            this.NumSix.Margin = new System.Windows.Forms.Padding(0);
            this.NumSix.Name = "NumSix";
            this.NumSix.Size = new System.Drawing.Size(63, 50);
            this.NumSix.TabIndex = 24;
            this.NumSix.Text = "6";
            this.NumSix.Click += new System.EventHandler(this.NumSix_Click);
            // 
            // NumFive
            // 
            this.NumFive.AccessibleName = "NumFive";
            this.NumFive.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NumFive.Location = new System.Drawing.Point(63, 80);
            this.NumFive.Margin = new System.Windows.Forms.Padding(0);
            this.NumFive.Name = "NumFive";
            this.NumFive.Size = new System.Drawing.Size(63, 50);
            this.NumFive.TabIndex = 23;
            this.NumFive.Text = "5";
            this.NumFive.Click += new System.EventHandler(this.NumFive_Click);
            // 
            // NumFour
            // 
            this.NumFour.AccessibleName = "NumFour";
            this.NumFour.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NumFour.Location = new System.Drawing.Point(0, 80);
            this.NumFour.Margin = new System.Windows.Forms.Padding(0);
            this.NumFour.Name = "NumFour";
            this.NumFour.Size = new System.Drawing.Size(63, 50);
            this.NumFour.TabIndex = 22;
            this.NumFour.Text = "4";
            this.NumFour.Click += new System.EventHandler(this.NumFour_Click);
            // 
            // NumNine
            // 
            this.NumNine.AccessibleName = "NumNine";
            this.NumNine.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NumNine.Location = new System.Drawing.Point(126, 30);
            this.NumNine.Margin = new System.Windows.Forms.Padding(0);
            this.NumNine.Name = "NumNine";
            this.NumNine.Size = new System.Drawing.Size(63, 50);
            this.NumNine.TabIndex = 20;
            this.NumNine.Text = "9";
            this.NumNine.Click += new System.EventHandler(this.NumNine_Click);
            // 
            // NumEight
            // 
            this.NumEight.AccessibleName = "NumEight";
            this.NumEight.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NumEight.Location = new System.Drawing.Point(63, 30);
            this.NumEight.Margin = new System.Windows.Forms.Padding(0);
            this.NumEight.Name = "NumEight";
            this.NumEight.Size = new System.Drawing.Size(63, 50);
            this.NumEight.TabIndex = 19;
            this.NumEight.Text = "8";
            this.NumEight.Click += new System.EventHandler(this.NumEight_Click);
            // 
            // NumSeven
            // 
            this.NumSeven.AccessibleName = "NumSeven";
            this.NumSeven.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NumSeven.Location = new System.Drawing.Point(0, 30);
            this.NumSeven.Margin = new System.Windows.Forms.Padding(0);
            this.NumSeven.Name = "NumSeven";
            this.NumSeven.Size = new System.Drawing.Size(63, 50);
            this.NumSeven.TabIndex = 18;
            this.NumSeven.Text = "7";
            this.NumSeven.Click += new System.EventHandler(this.NumSeven_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 1);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(629, 26);
            this.textBox1.TabIndex = 17;
            // 
            // ReverseString
            // 
            this.ReverseString.AccessibleName = "ReverseString";
            this.ReverseString.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ReverseString.Location = new System.Drawing.Point(252, 80);
            this.ReverseString.Margin = new System.Windows.Forms.Padding(0);
            this.ReverseString.Name = "ReverseString";
            this.ReverseString.Size = new System.Drawing.Size(126, 50);
            this.ReverseString.TabIndex = 35;
            this.ReverseString.Text = "ReverseString";
            this.ReverseString.Click += new System.EventHandler(this.ReverseString_Click);
            // 
            // QuotientRemainder
            // 
            this.QuotientRemainder.AccessibleName = "QuotientRemainder";
            this.QuotientRemainder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.QuotientRemainder.Location = new System.Drawing.Point(252, 130);
            this.QuotientRemainder.Margin = new System.Windows.Forms.Padding(0);
            this.QuotientRemainder.Name = "QuotientRemainder";
            this.QuotientRemainder.Size = new System.Drawing.Size(126, 50);
            this.QuotientRemainder.TabIndex = 36;
            this.QuotientRemainder.Text = "QuotientRem";
            this.QuotientRemainder.Click += new System.EventHandler(this.QuotientRemainder_Click);
            // 
            // QuadraticRoots
            // 
            this.QuadraticRoots.AccessibleName = "QuadraticRoots";
            this.QuadraticRoots.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.QuadraticRoots.Location = new System.Drawing.Point(500, 30);
            this.QuadraticRoots.Margin = new System.Windows.Forms.Padding(0);
            this.QuadraticRoots.Name = "QuadraticRoots";
            this.QuadraticRoots.Size = new System.Drawing.Size(129, 50);
            this.QuadraticRoots.TabIndex = 39;
            this.QuadraticRoots.Text = "QRoot";
            this.QuadraticRoots.Click += new System.EventHandler(this.QuadraticRoots_Click);
            // 
            // MinMax
            // 
            this.MinMax.AccessibleName = "MinMax";
            this.MinMax.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MinMax.Location = new System.Drawing.Point(378, 80);
            this.MinMax.Margin = new System.Windows.Forms.Padding(0);
            this.MinMax.Name = "MinMax";
            this.MinMax.Size = new System.Drawing.Size(122, 50);
            this.MinMax.TabIndex = 39;
            this.MinMax.Text = "Min Max";
            this.MinMax.Click += new System.EventHandler(this.MinMax_Click);
            // 
            // ToThePower
            // 
            this.ToThePower.AccessibleName = "ToThePower";
            this.ToThePower.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ToThePower.Location = new System.Drawing.Point(378, 130);
            this.ToThePower.Margin = new System.Windows.Forms.Padding(0);
            this.ToThePower.Name = "ToThePower";
            this.ToThePower.Size = new System.Drawing.Size(122, 50);
            this.ToThePower.TabIndex = 40;
            this.ToThePower.Text = "To the Power";
            this.ToThePower.Click += new System.EventHandler(this.ToThePower_Click);
            // 
            // SquareRoot
            // 
            this.SquareRoot.AccessibleName = "SquareRoot";
            this.SquareRoot.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SquareRoot.Location = new System.Drawing.Point(378, 180);
            this.SquareRoot.Margin = new System.Windows.Forms.Padding(0);
            this.SquareRoot.Name = "SquareRoot";
            this.SquareRoot.Size = new System.Drawing.Size(122, 50);
            this.SquareRoot.TabIndex = 41;
            this.SquareRoot.Text = "SquareRoot";
            this.SquareRoot.Click += new System.EventHandler(this.SquareRoot_Click);
            // 
            // RemoveSpaces
            // 
            this.RemoveSpaces.AccessibleName = "RemoveSpaces";
            this.RemoveSpaces.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RemoveSpaces.Location = new System.Drawing.Point(252, 30);
            this.RemoveSpaces.Margin = new System.Windows.Forms.Padding(0);
            this.RemoveSpaces.Name = "RemoveSpaces";
            this.RemoveSpaces.Size = new System.Drawing.Size(126, 50);
            this.RemoveSpaces.TabIndex = 43;
            this.RemoveSpaces.Text = "Whitespace";
            this.RemoveSpaces.Click += new System.EventHandler(this.RemoveSpaces_Click);
            // 
            // Log10
            // 
            this.Log10.AccessibleName = "Log10";
            this.Log10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Log10.Location = new System.Drawing.Point(252, 180);
            this.Log10.Margin = new System.Windows.Forms.Padding(0);
            this.Log10.Name = "Log10";
            this.Log10.Size = new System.Drawing.Size(126, 50);
            this.Log10.TabIndex = 44;
            this.Log10.Text = "Log10";
            this.Log10.Click += new System.EventHandler(this.Log10_Click);
            // 
            // LogX
            // 
            this.LogX.AccessibleName = "LogX";
            this.LogX.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LogX.Location = new System.Drawing.Point(378, 30);
            this.LogX.Margin = new System.Windows.Forms.Padding(0);
            this.LogX.Name = "LogX";
            this.LogX.Size = new System.Drawing.Size(122, 50);
            this.LogX.TabIndex = 45;
            this.LogX.Text = "LogSpecified";
            this.LogX.Click += new System.EventHandler(this.LogX_Click);
            // 
            // Divide
            // 
            this.Divide.AccessibleName = "Divide";
            this.Divide.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Divide.Location = new System.Drawing.Point(189, 30);
            this.Divide.Margin = new System.Windows.Forms.Padding(0);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(63, 50);
            this.Divide.TabIndex = 46;
            this.Divide.Text = "/";
            this.Divide.Click += new System.EventHandler(this.Divide_Click);
            // 
            // Subtraction
            // 
            this.Subtraction.AccessibleName = "Subtraction";
            this.Subtraction.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Subtraction.Location = new System.Drawing.Point(189, 180);
            this.Subtraction.Margin = new System.Windows.Forms.Padding(0);
            this.Subtraction.Name = "Subtraction";
            this.Subtraction.Size = new System.Drawing.Size(63, 50);
            this.Subtraction.TabIndex = 47;
            this.Subtraction.Text = "-";
            this.Subtraction.Click += new System.EventHandler(this.Subtraction_Click);
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(566, 80);
            this.textBoxA.Multiline = true;
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(63, 38);
            this.textBoxA.TabIndex = 48;
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(566, 130);
            this.textBoxB.Multiline = true;
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(63, 36);
            this.textBoxB.TabIndex = 49;
            // 
            // textBoxC
            // 
            this.textBoxC.Location = new System.Drawing.Point(566, 180);
            this.textBoxC.Multiline = true;
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(63, 36);
            this.textBoxC.TabIndex = 50;
            // 
            // Description
            // 
            this.Description.AccessibleName = "Description";
            this.Description.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Description.Location = new System.Drawing.Point(500, 80);
            this.Description.Margin = new System.Windows.Forms.Padding(0);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(63, 150);
            this.Description.TabIndex = 51;
            this.Description.Text = "a\r\nb\r\nc";
            // 
            // CalculatorGUIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 230);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.textBoxC);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.Subtraction);
            this.Controls.Add(this.Divide);
            this.Controls.Add(this.LogX);
            this.Controls.Add(this.Log10);
            this.Controls.Add(this.RemoveSpaces);
            this.Controls.Add(this.SquareRoot);
            this.Controls.Add(this.ToThePower);
            this.Controls.Add(this.MinMax);
            this.Controls.Add(this.QuadraticRoots);
            this.Controls.Add(this.QuotientRemainder);
            this.Controls.Add(this.ReverseString);
            this.Controls.Add(this.Equals);
            this.Controls.Add(this.Decimal);
            this.Controls.Add(this.NumZero);
            this.Controls.Add(this.Addition);
            this.Controls.Add(this.NumThree);
            this.Controls.Add(this.NumTwo);
            this.Controls.Add(this.NumOne);
            this.Controls.Add(this.Multiply);
            this.Controls.Add(this.NumSix);
            this.Controls.Add(this.NumFive);
            this.Controls.Add(this.NumFour);
            this.Controls.Add(this.NumNine);
            this.Controls.Add(this.NumEight);
            this.Controls.Add(this.NumSeven);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CalculatorGUIForm";
            this.Text = "Calculator GUI";
            this.Load += new System.EventHandler(this.CalculatorGUIForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

      }

      #endregion
      private System.Windows.Forms.Button Equals;
      private System.Windows.Forms.Button Decimal;
      private System.Windows.Forms.Button NumZero;
      private System.Windows.Forms.Button Addition;
      private System.Windows.Forms.Button NumThree;
      private System.Windows.Forms.Button NumTwo;
      private System.Windows.Forms.Button NumOne;
      private System.Windows.Forms.Button Multiply;
      private System.Windows.Forms.Button NumSix;
      private System.Windows.Forms.Button NumFive;
      private System.Windows.Forms.Button NumFour;
      private System.Windows.Forms.Button NumNine;
      private System.Windows.Forms.Button NumEight;
      private System.Windows.Forms.Button NumSeven;
      private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button ReverseString;
        private System.Windows.Forms.Button QuotientRemainder;
        private System.Windows.Forms.Button QuadraticRoots;
        private System.Windows.Forms.Button MinMax;
        private System.Windows.Forms.Button ToThePower;
        private System.Windows.Forms.Button SquareRoot;
        private System.Windows.Forms.Button RemoveSpaces;
        private System.Windows.Forms.Button Log10;
        private System.Windows.Forms.Button LogX;
        private System.Windows.Forms.Button Divide;
        private System.Windows.Forms.Button Subtraction;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.TextBox textBoxC;
        private System.Windows.Forms.Button Description;
    }
}

