﻿namespace Calculator1
{
    partial class CalculatorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculatorForm));
            this.button18 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblExpression = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.button19 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button18.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button18.ForeColor = System.Drawing.Color.White;
            this.button18.Location = new System.Drawing.Point(256, 8);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(78, 40);
            this.button18.TabIndex = 54;
            this.button18.Text = "Выйти";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.exit_Click);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.LightGreen;
            this.button17.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button17.Location = new System.Drawing.Point(256, 306);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(75, 57);
            this.button17.TabIndex = 53;
            this.button17.Text = "=";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button13.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button13.Location = new System.Drawing.Point(256, 243);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 57);
            this.button13.TabIndex = 52;
            this.button13.Text = "/";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.btnOperator_Click);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button14.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button14.Location = new System.Drawing.Point(256, 180);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(75, 57);
            this.button14.TabIndex = 51;
            this.button14.Text = "*";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.btnOperator_Click);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button15.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button15.Location = new System.Drawing.Point(256, 117);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(75, 57);
            this.button15.TabIndex = 50;
            this.button15.Text = "-";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.btnOperator_Click);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button16.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button16.Location = new System.Drawing.Point(256, 54);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(75, 57);
            this.button16.TabIndex = 49;
            this.button16.Text = "+";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.btnOperator_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Salmon;
            this.button12.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button12.ForeColor = System.Drawing.Color.White;
            this.button12.Location = new System.Drawing.Point(172, 306);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 57);
            this.button12.TabIndex = 48;
            this.button12.Text = "C";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button11.Location = new System.Drawing.Point(11, 306);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 57);
            this.button11.TabIndex = 47;
            this.button11.Text = ",";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.btnComma_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.White;
            this.button10.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button10.Location = new System.Drawing.Point(91, 306);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 57);
            this.button10.TabIndex = 46;
            this.button10.Text = "0";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button7.Location = new System.Drawing.Point(10, 243);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 57);
            this.button7.TabIndex = 45;
            this.button7.Text = "1";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.White;
            this.button8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button8.Location = new System.Drawing.Point(91, 243);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 57);
            this.button8.TabIndex = 44;
            this.button8.Text = "2";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.White;
            this.button9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button9.Location = new System.Drawing.Point(172, 243);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 57);
            this.button9.TabIndex = 43;
            this.button9.Text = "3";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button6.Location = new System.Drawing.Point(10, 180);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 57);
            this.button6.TabIndex = 42;
            this.button6.Text = "4";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button5.Location = new System.Drawing.Point(91, 180);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 57);
            this.button5.TabIndex = 41;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button4.Location = new System.Drawing.Point(172, 180);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 57);
            this.button4.TabIndex = 40;
            this.button4.Text = "6";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(172, 117);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 57);
            this.button3.TabIndex = 39;
            this.button3.Text = "9";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(91, 117);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 57);
            this.button2.TabIndex = 38;
            this.button2.Text = "8";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(10, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 57);
            this.button1.TabIndex = 37;
            this.button1.Text = "7";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // lblExpression
            // 
            this.lblExpression.AutoSize = true;
            this.lblExpression.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblExpression.ForeColor = System.Drawing.Color.Gray;
            this.lblExpression.Location = new System.Drawing.Point(27, 16);
            this.lblExpression.Name = "lblExpression";
            this.lblExpression.Size = new System.Drawing.Size(0, 19);
            this.lblExpression.TabIndex = 55;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResult.Location = new System.Drawing.Point(27, 67);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 25);
            this.lblResult.TabIndex = 58;
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button19.Enabled = false;
            this.button19.Location = new System.Drawing.Point(10, 8);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(237, 103);
            this.button19.TabIndex = 59;
            this.button19.UseVisualStyleBackColor = false;
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 379);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblExpression);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CalculatorForm";
            this.Text = "Калькулятор";
            this.Load += new System.EventHandler(this.CalculatorForm_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button18;
        private Button button17;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button12;
        private Button button11;
        private Button button10;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label lblExpression;
        private Label lblResult;
        private Button button19;
    }
}