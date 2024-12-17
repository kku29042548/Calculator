namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            number = new Label();
            number2 = new Label();
            lebel = new Label();
            num1 = new TextBox();
            num2 = new TextBox();
            result = new TextBox();
            button5 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(367, 69);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(367, 109);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 1;
            button2.Text = "-";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(367, 149);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 2;
            button3.Text = "x";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(367, 189);
            button4.Name = "button4";
            button4.Size = new Size(112, 34);
            button4.TabIndex = 3;
            button4.Text = "/";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // number
            // 
            number.AutoSize = true;
            number.Location = new Point(124, 74);
            number.Name = "number";
            number.Size = new Size(58, 25);
            number.TabIndex = 4;
            number.Text = "num1";
            // 
            // number2
            // 
            number2.AutoSize = true;
            number2.Location = new Point(124, 111);
            number2.Name = "number2";
            number2.Size = new Size(58, 25);
            number2.TabIndex = 5;
            number2.Text = "num2";
            number2.Click += label2_Click;
            // 
            // lebel
            // 
            lebel.AutoSize = true;
            lebel.Location = new Point(124, 152);
            lebel.Name = "lebel";
            lebel.Size = new Size(55, 25);
            lebel.TabIndex = 6;
            lebel.Text = "result";
            // 
            // num1
            // 
            num1.Location = new Point(211, 74);
            num1.Name = "num1";
            num1.Size = new Size(150, 31);
            num1.TabIndex = 7;
            // 
            // num2
            // 
            num2.Location = new Point(211, 111);
            num2.Name = "num2";
            num2.Size = new Size(150, 31);
            num2.TabIndex = 8;
            // 
            // result
            // 
            result.Location = new Point(211, 152);
            result.Name = "result";
            result.Size = new Size(150, 31);
            result.TabIndex = 9;
            // 
            // button5
            // 
            button5.Location = new Point(225, 189);
            button5.Name = "button5";
            button5.Size = new Size(112, 34);
            button5.TabIndex = 10;
            button5.Text = "clear";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(result);
            Controls.Add(num2);
            Controls.Add(num1);
            Controls.Add(lebel);
            Controls.Add(number2);
            Controls.Add(number);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label number;
        private Label number2;
        private Label lebel;
        private TextBox num1;
        private TextBox num2;
        private TextBox result;
        private Button button5;
    }
}
