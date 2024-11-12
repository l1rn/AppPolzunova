namespace Calculator1
{
    partial class Game
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Hardlvl = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.boxForGuess = new System.Windows.Forms.TextBox();
            this.AllAttempts = new System.Windows.Forms.Label();
            this.Enter = new System.Windows.Forms.Button();
            this.lblLose = new System.Windows.Forms.Label();
            this.Answer = new System.Windows.Forms.Label();
            this.Mediumlvl = new System.Windows.Forms.Button();
            this.Easylvl = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.lbl_Easy = new System.Windows.Forms.Label();
            this.lbl_Medium = new System.Windows.Forms.Label();
            this.lbl_Hard = new System.Windows.Forms.Label();
            this.SuccessAttempts = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(237, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Игра: Угадай число";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Calculator1.Properties.Resources.emblema;
            this.pictureBox1.Location = new System.Drawing.Point(275, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 145);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Hardlvl
            // 
            this.Hardlvl.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Hardlvl.Location = new System.Drawing.Point(443, 251);
            this.Hardlvl.Name = "Hardlvl";
            this.Hardlvl.Size = new System.Drawing.Size(158, 45);
            this.Hardlvl.TabIndex = 2;
            this.Hardlvl.Text = "Сложный";
            this.Hardlvl.UseVisualStyleBackColor = true;
            this.Hardlvl.Visible = false;
            this.Hardlvl.Click += new System.EventHandler(this.btn_Hardlvl);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(198, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "При нажатии вам дается 10 попыток и";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(180, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(340, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "  вам надо угадать число в диапазоне(0-100)";
            // 
            // boxForGuess
            // 
            this.boxForGuess.Location = new System.Drawing.Point(275, 352);
            this.boxForGuess.Name = "boxForGuess";
            this.boxForGuess.Size = new System.Drawing.Size(158, 23);
            this.boxForGuess.TabIndex = 5;
            this.boxForGuess.Visible = false;
            this.boxForGuess.TextChanged += new System.EventHandler(this.boxForGuess_TextChanged);
            // 
            // AllAttempts
            // 
            this.AllAttempts.AutoSize = true;
            this.AllAttempts.BackColor = System.Drawing.Color.Cornsilk;
            this.AllAttempts.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AllAttempts.ForeColor = System.Drawing.Color.Black;
            this.AllAttempts.Location = new System.Drawing.Point(275, 378);
            this.AllAttempts.Name = "AllAttempts";
            this.AllAttempts.Size = new System.Drawing.Size(144, 20);
            this.AllAttempts.TabIndex = 6;
            this.AllAttempts.Text = "Осталось попыток: ";
            this.AllAttempts.Visible = false;
            this.AllAttempts.Click += new System.EventHandler(this.AllAttempts_Click);
            // 
            // Enter
            // 
            this.Enter.BackColor = System.Drawing.Color.PaleGreen;
            this.Enter.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Enter.Location = new System.Drawing.Point(275, 401);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(158, 43);
            this.Enter.TabIndex = 7;
            this.Enter.Text = "Угадать!";
            this.Enter.UseVisualStyleBackColor = false;
            this.Enter.Visible = false;
            this.Enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // lblLose
            // 
            this.lblLose.AutoSize = true;
            this.lblLose.Location = new System.Drawing.Point(309, 319);
            this.lblLose.Name = "lblLose";
            this.lblLose.Size = new System.Drawing.Size(0, 15);
            this.lblLose.TabIndex = 8;
            // 
            // Answer
            // 
            this.Answer.AutoSize = true;
            this.Answer.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Answer.Location = new System.Drawing.Point(275, 448);
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(143, 20);
            this.Answer.TabIndex = 9;
            this.Answer.Text = "Правильный ответ:";
            this.Answer.Visible = false;
            this.Answer.Click += new System.EventHandler(this.Answer_Click);
            // 
            // Mediumlvl
            // 
            this.Mediumlvl.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Mediumlvl.Location = new System.Drawing.Point(279, 251);
            this.Mediumlvl.Name = "Mediumlvl";
            this.Mediumlvl.Size = new System.Drawing.Size(158, 45);
            this.Mediumlvl.TabIndex = 10;
            this.Mediumlvl.Text = "Средний";
            this.Mediumlvl.UseVisualStyleBackColor = true;
            this.Mediumlvl.Visible = false;
            this.Mediumlvl.Click += new System.EventHandler(this.btn_Mediumlvl);
            // 
            // Easylvl
            // 
            this.Easylvl.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Easylvl.Location = new System.Drawing.Point(115, 251);
            this.Easylvl.Name = "Easylvl";
            this.Easylvl.Size = new System.Drawing.Size(158, 45);
            this.Easylvl.TabIndex = 11;
            this.Easylvl.Text = "Легкий";
            this.Easylvl.UseVisualStyleBackColor = true;
            this.Easylvl.Visible = false;
            this.Easylvl.Click += new System.EventHandler(this.btn_Easylvl);
            // 
            // Start
            // 
            this.Start.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Start.Location = new System.Drawing.Point(279, 251);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(158, 45);
            this.Start.TabIndex = 12;
            this.Start.Text = "Загадать число";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.btn_Start);
            // 
            // lbl_Easy
            // 
            this.lbl_Easy.AutoSize = true;
            this.lbl_Easy.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Easy.Location = new System.Drawing.Point(115, 299);
            this.lbl_Easy.Name = "lbl_Easy";
            this.lbl_Easy.Size = new System.Drawing.Size(89, 20);
            this.lbl_Easy.TabIndex = 13;
            this.lbl_Easy.Text = "15 попыток";
            this.lbl_Easy.Visible = false;
            this.lbl_Easy.Click += new System.EventHandler(this.lbl_levels);
            // 
            // lbl_Medium
            // 
            this.lbl_Medium.AutoSize = true;
            this.lbl_Medium.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Medium.Location = new System.Drawing.Point(279, 299);
            this.lbl_Medium.Name = "lbl_Medium";
            this.lbl_Medium.Size = new System.Drawing.Size(89, 20);
            this.lbl_Medium.TabIndex = 14;
            this.lbl_Medium.Text = "10 попыток";
            this.lbl_Medium.Visible = false;
            this.lbl_Medium.Click += new System.EventHandler(this.lbl_levels);
            // 
            // lbl_Hard
            // 
            this.lbl_Hard.AutoSize = true;
            this.lbl_Hard.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Hard.Location = new System.Drawing.Point(443, 299);
            this.lbl_Hard.Name = "lbl_Hard";
            this.lbl_Hard.Size = new System.Drawing.Size(81, 20);
            this.lbl_Hard.TabIndex = 15;
            this.lbl_Hard.Text = "5 попыток";
            this.lbl_Hard.Visible = false;
            this.lbl_Hard.Click += new System.EventHandler(this.lbl_levels);
            // 
            // SuccessAttempts
            // 
            this.SuccessAttempts.AutoSize = true;
            this.SuccessAttempts.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SuccessAttempts.Location = new System.Drawing.Point(279, 477);
            this.SuccessAttempts.Name = "SuccessAttempts";
            this.SuccessAttempts.Size = new System.Drawing.Size(0, 20);
            this.SuccessAttempts.TabIndex = 16;
            this.SuccessAttempts.Visible = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(741, 513);
            this.Controls.Add(this.SuccessAttempts);
            this.Controls.Add(this.lbl_Hard);
            this.Controls.Add(this.lbl_Medium);
            this.Controls.Add(this.lbl_Easy);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Easylvl);
            this.Controls.Add(this.Mediumlvl);
            this.Controls.Add(this.Answer);
            this.Controls.Add(this.lblLose);
            this.Controls.Add(this.Enter);
            this.Controls.Add(this.AllAttempts);
            this.Controls.Add(this.boxForGuess);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Hardlvl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Game";
            this.Text = "Угадай число";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Button Hardlvl;
        private Label label2;
        private Label label3;
        private TextBox boxForGuess;
        private Label AllAttempts;
        private Button Enter;
        private Label lblLose;
        private Label Answer;
        private Button Mediumlvl;
        private Button Easylvl;
        private Button Start;
        private Label lbl_Easy;
        private Label lbl_Medium;
        private Label lbl_Hard;
        private Label SuccessAttempts;
    }
}