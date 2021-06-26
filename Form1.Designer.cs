
namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.percentage = new System.Windows.Forms.Button();
            this.clear_entry = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.backspace = new System.Windows.Forms.Button();
            this.reciprocal = new System.Windows.Forms.Button();
            this.squared = new System.Windows.Forms.Button();
            this.square_root = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.multiplication = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.subtraction = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.addition = new System.Windows.Forms.Button();
            this.plus_minus = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.point_decimal = new System.Windows.Forms.Button();
            this.equals = new System.Windows.Forms.Button();
            this.textBox_results = new System.Windows.Forms.TextBox();
            this.Calculator = new System.Windows.Forms.Label();
            this.OperationLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // percentage
            // 
            this.percentage.BackColor = System.Drawing.Color.Gainsboro;
            this.percentage.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percentage.Location = new System.Drawing.Point(10, 164);
            this.percentage.Name = "percentage";
            this.percentage.Size = new System.Drawing.Size(72, 54);
            this.percentage.TabIndex = 0;
            this.percentage.Text = "%";
            this.percentage.UseVisualStyleBackColor = false;
            // 
            // clear_entry
            // 
            this.clear_entry.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_entry.Location = new System.Drawing.Point(83, 164);
            this.clear_entry.Name = "clear_entry";
            this.clear_entry.Size = new System.Drawing.Size(72, 54);
            this.clear_entry.TabIndex = 1;
            this.clear_entry.Text = "CE";
            this.clear_entry.UseVisualStyleBackColor = true;
            this.clear_entry.Click += new System.EventHandler(this.clear_entry_Click);
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(156, 164);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(72, 54);
            this.clear.TabIndex = 2;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // backspace
            // 
            this.backspace.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backspace.Location = new System.Drawing.Point(229, 164);
            this.backspace.Name = "backspace";
            this.backspace.Size = new System.Drawing.Size(72, 54);
            this.backspace.TabIndex = 3;
            this.backspace.Text = "⌫";
            this.backspace.UseVisualStyleBackColor = true;
            this.backspace.Click += new System.EventHandler(this.backspace_Click);
            // 
            // reciprocal
            // 
            this.reciprocal.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reciprocal.Location = new System.Drawing.Point(10, 219);
            this.reciprocal.Name = "reciprocal";
            this.reciprocal.Size = new System.Drawing.Size(72, 54);
            this.reciprocal.TabIndex = 4;
            this.reciprocal.Text = "1/x";
            this.reciprocal.UseVisualStyleBackColor = true;
            // 
            // squared
            // 
            this.squared.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.squared.Location = new System.Drawing.Point(83, 219);
            this.squared.Name = "squared";
            this.squared.Size = new System.Drawing.Size(72, 54);
            this.squared.TabIndex = 5;
            this.squared.Text = "x²";
            this.squared.UseVisualStyleBackColor = true;
            // 
            // square_root
            // 
            this.square_root.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.square_root.Location = new System.Drawing.Point(156, 219);
            this.square_root.Name = "square_root";
            this.square_root.Size = new System.Drawing.Size(72, 54);
            this.square_root.TabIndex = 6;
            this.square_root.Text = "√x";
            this.square_root.UseVisualStyleBackColor = true;
            // 
            // division
            // 
            this.division.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.division.Location = new System.Drawing.Point(229, 219);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(72, 54);
            this.division.TabIndex = 7;
            this.division.Text = "/";
            this.division.UseVisualStyleBackColor = true;
            this.division.Click += new System.EventHandler(this.Operation_click);
            // 
            // seven
            // 
            this.seven.BackColor = System.Drawing.Color.White;
            this.seven.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seven.Location = new System.Drawing.Point(10, 274);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(72, 54);
            this.seven.TabIndex = 8;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = false;
            this.seven.Click += new System.EventHandler(this.button_click);
            // 
            // eight
            // 
            this.eight.BackColor = System.Drawing.Color.White;
            this.eight.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eight.Location = new System.Drawing.Point(83, 274);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(72, 54);
            this.eight.TabIndex = 9;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = false;
            this.eight.Click += new System.EventHandler(this.button_click);
            // 
            // nine
            // 
            this.nine.BackColor = System.Drawing.Color.White;
            this.nine.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nine.Location = new System.Drawing.Point(156, 274);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(72, 54);
            this.nine.TabIndex = 10;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = false;
            this.nine.Click += new System.EventHandler(this.button_click);
            // 
            // multiplication
            // 
            this.multiplication.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplication.Location = new System.Drawing.Point(229, 274);
            this.multiplication.Name = "multiplication";
            this.multiplication.Size = new System.Drawing.Size(72, 54);
            this.multiplication.TabIndex = 11;
            this.multiplication.Text = "*";
            this.multiplication.UseVisualStyleBackColor = true;
            this.multiplication.Click += new System.EventHandler(this.Operation_click);
            // 
            // four
            // 
            this.four.BackColor = System.Drawing.Color.White;
            this.four.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.four.Location = new System.Drawing.Point(10, 329);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(72, 54);
            this.four.TabIndex = 12;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = false;
            this.four.Click += new System.EventHandler(this.button_click);
            // 
            // five
            // 
            this.five.BackColor = System.Drawing.Color.White;
            this.five.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.five.Location = new System.Drawing.Point(83, 329);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(72, 54);
            this.five.TabIndex = 13;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = false;
            this.five.Click += new System.EventHandler(this.button_click);
            // 
            // six
            // 
            this.six.BackColor = System.Drawing.Color.White;
            this.six.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.six.Location = new System.Drawing.Point(156, 329);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(72, 54);
            this.six.TabIndex = 14;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = false;
            this.six.Click += new System.EventHandler(this.button_click);
            // 
            // subtraction
            // 
            this.subtraction.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtraction.Location = new System.Drawing.Point(229, 329);
            this.subtraction.Name = "subtraction";
            this.subtraction.Size = new System.Drawing.Size(72, 54);
            this.subtraction.TabIndex = 15;
            this.subtraction.Text = "-";
            this.subtraction.UseVisualStyleBackColor = true;
            this.subtraction.Click += new System.EventHandler(this.Operation_click);
            // 
            // one
            // 
            this.one.BackColor = System.Drawing.Color.White;
            this.one.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.one.Location = new System.Drawing.Point(10, 384);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(72, 54);
            this.one.TabIndex = 16;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = false;
            this.one.Click += new System.EventHandler(this.button_click);
            // 
            // two
            // 
            this.two.BackColor = System.Drawing.Color.White;
            this.two.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.two.Location = new System.Drawing.Point(83, 384);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(72, 54);
            this.two.TabIndex = 17;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = false;
            this.two.Click += new System.EventHandler(this.button_click);
            // 
            // three
            // 
            this.three.BackColor = System.Drawing.Color.White;
            this.three.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.three.Location = new System.Drawing.Point(156, 384);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(72, 54);
            this.three.TabIndex = 18;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = false;
            this.three.Click += new System.EventHandler(this.button_click);
            // 
            // addition
            // 
            this.addition.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addition.Location = new System.Drawing.Point(229, 384);
            this.addition.Name = "addition";
            this.addition.Size = new System.Drawing.Size(72, 54);
            this.addition.TabIndex = 19;
            this.addition.Text = "+";
            this.addition.UseVisualStyleBackColor = true;
            this.addition.Click += new System.EventHandler(this.Operation_click);
            // 
            // plus_minus
            // 
            this.plus_minus.BackColor = System.Drawing.Color.White;
            this.plus_minus.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus_minus.Location = new System.Drawing.Point(10, 439);
            this.plus_minus.Name = "plus_minus";
            this.plus_minus.Size = new System.Drawing.Size(72, 54);
            this.plus_minus.TabIndex = 20;
            this.plus_minus.Text = "+/-";
            this.plus_minus.UseVisualStyleBackColor = false;
            this.plus_minus.Click += new System.EventHandler(this.plus_minus_Click);
            // 
            // zero
            // 
            this.zero.BackColor = System.Drawing.Color.White;
            this.zero.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zero.Location = new System.Drawing.Point(83, 439);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(72, 54);
            this.zero.TabIndex = 21;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = false;
            this.zero.Click += new System.EventHandler(this.button_click);
            // 
            // point_decimal
            // 
            this.point_decimal.BackColor = System.Drawing.Color.White;
            this.point_decimal.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.point_decimal.Location = new System.Drawing.Point(156, 439);
            this.point_decimal.Name = "point_decimal";
            this.point_decimal.Size = new System.Drawing.Size(72, 54);
            this.point_decimal.TabIndex = 22;
            this.point_decimal.Text = ".";
            this.point_decimal.UseVisualStyleBackColor = false;
            this.point_decimal.Click += new System.EventHandler(this.button_click);
            // 
            // equals
            // 
            this.equals.BackColor = System.Drawing.Color.SteelBlue;
            this.equals.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equals.Location = new System.Drawing.Point(229, 439);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(72, 54);
            this.equals.TabIndex = 23;
            this.equals.Text = "=";
            this.equals.UseVisualStyleBackColor = false;
            this.equals.Click += new System.EventHandler(this.equals_Click);
            // 
            // textBox_results
            // 
            this.textBox_results.BackColor = System.Drawing.Color.Silver;
            this.textBox_results.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_results.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_results.Location = new System.Drawing.Point(10, 104);
            this.textBox_results.Name = "textBox_results";
            this.textBox_results.Size = new System.Drawing.Size(291, 42);
            this.textBox_results.TabIndex = 24;
            this.textBox_results.Text = "0";
            this.textBox_results.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Calculator
            // 
            this.Calculator.AutoSize = true;
            this.Calculator.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calculator.Location = new System.Drawing.Point(22, 20);
            this.Calculator.Name = "Calculator";
            this.Calculator.Size = new System.Drawing.Size(133, 28);
            this.Calculator.TabIndex = 25;
            this.Calculator.Text = "≡  Standard";
            // 
            // OperationLabel
            // 
            this.OperationLabel.AutoSize = true;
            this.OperationLabel.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OperationLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.OperationLabel.Location = new System.Drawing.Point(246, 71);
            this.OperationLabel.Name = "OperationLabel";
            this.OperationLabel.Size = new System.Drawing.Size(0, 20);
            this.OperationLabel.TabIndex = 26;
            this.OperationLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(309, 496);
            this.Controls.Add(this.OperationLabel);
            this.Controls.Add(this.Calculator);
            this.Controls.Add(this.textBox_results);
            this.Controls.Add(this.equals);
            this.Controls.Add(this.point_decimal);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.plus_minus);
            this.Controls.Add(this.addition);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.subtraction);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.multiplication);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.division);
            this.Controls.Add(this.square_root);
            this.Controls.Add(this.squared);
            this.Controls.Add(this.reciprocal);
            this.Controls.Add(this.backspace);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.clear_entry);
            this.Controls.Add(this.percentage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button percentage;
        private System.Windows.Forms.Button clear_entry;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button backspace;
        private System.Windows.Forms.Button reciprocal;
        private System.Windows.Forms.Button squared;
        private System.Windows.Forms.Button square_root;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button multiplication;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button subtraction;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button addition;
        private System.Windows.Forms.Button plus_minus;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button point_decimal;
        private System.Windows.Forms.Button equals;
        private System.Windows.Forms.TextBox textBox_results;
        private System.Windows.Forms.Label Calculator;
        private System.Windows.Forms.Label OperationLabel;
    }
}

