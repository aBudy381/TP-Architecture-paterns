
namespace WinFormCalculatrice
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
            this.number = new System.Windows.Forms.TextBox();
            this.number2 = new System.Windows.Forms.TextBox();
            this.number1 = new System.Windows.Forms.Label();
            this.lblNumber2 = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // number
            // 
            this.number.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.number.Location = new System.Drawing.Point(248, 59);
            this.number.Name = "number";
            this.number.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.number.Size = new System.Drawing.Size(100, 22);
            this.number.TabIndex = 0;
            this.number.TextChanged += new System.EventHandler(this.number_TextChanged);
            // 
            // number2
            // 
            this.number2.Location = new System.Drawing.Point(248, 131);
            this.number2.Name = "number2";
            this.number2.Size = new System.Drawing.Size(100, 22);
            this.number2.TabIndex = 1;
            // 
            // number1
            // 
            this.number1.AutoSize = true;
            this.number1.Location = new System.Drawing.Point(119, 58);
            this.number1.Name = "number1";
            this.number1.Size = new System.Drawing.Size(70, 17);
            this.number1.TabIndex = 2;
            this.number1.Text = "Number 1";
            // 
            // lblNumber2
            // 
            this.lblNumber2.AutoSize = true;
            this.lblNumber2.Location = new System.Drawing.Point(119, 136);
            this.lblNumber2.Name = "lblNumber2";
            this.lblNumber2.Size = new System.Drawing.Size(70, 17);
            this.lblNumber2.TabIndex = 2;
            this.lblNumber2.Text = "Number 2";
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(122, 229);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 3;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(234, 229);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Sabstract";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(365, 229);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Multiply";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(263, 317);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(46, 17);
            this.result.TabIndex = 4;
            this.result.Text = "label1";
            this.result.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.result);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.lblNumber2);
            this.Controls.Add(this.number1);
            this.Controls.Add(this.number2);
            this.Controls.Add(this.number);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.TextBox number2;
        private System.Windows.Forms.Label number1;
        private System.Windows.Forms.Label lblNumber2;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label result;
    }
}

