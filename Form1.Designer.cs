namespace StudentRegistrationApplication
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
            RegisterButton = new Button();
            label1 = new Label();
            MnameBox = new TextBox();
            FnameBox = new TextBox();
            LnameBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            MaleButton = new RadioButton();
            FemaleButton = new RadioButton();
            label6 = new Label();
            DayBox = new ComboBox();
            MonthBox = new ComboBox();
            YearBox = new ComboBox();
            label7 = new Label();
            ProgramBox = new ComboBox();
            pictureBox1 = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            BrowseButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // RegisterButton
            // 
            RegisterButton.BackColor = Color.Fuchsia;
            RegisterButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RegisterButton.ForeColor = SystemColors.Control;
            RegisterButton.Location = new Point(39, 376);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(275, 35);
            RegisterButton.TabIndex = 0;
            RegisterButton.Text = "Register student";
            RegisterButton.UseVisualStyleBackColor = false;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(39, 15);
            label1.Name = "label1";
            label1.Size = new Size(210, 21);
            label1.TabIndex = 1;
            label1.Text = "Student Registration Form";
            // 
            // MnameBox
            // 
            MnameBox.BorderStyle = BorderStyle.FixedSingle;
            MnameBox.Location = new Point(39, 192);
            MnameBox.Name = "MnameBox";
            MnameBox.Size = new Size(275, 23);
            MnameBox.TabIndex = 2;
            MnameBox.TextChanged += MnameBox_TextChanged;
            // 
            // FnameBox
            // 
            FnameBox.BorderStyle = BorderStyle.FixedSingle;
            FnameBox.Location = new Point(39, 128);
            FnameBox.Name = "FnameBox";
            FnameBox.Size = new Size(275, 23);
            FnameBox.TabIndex = 3;
            FnameBox.TextChanged += FnameBox_TextChanged;
            // 
            // LnameBox
            // 
            LnameBox.BorderStyle = BorderStyle.FixedSingle;
            LnameBox.Location = new Point(39, 71);
            LnameBox.Name = "LnameBox";
            LnameBox.Size = new Size(275, 23);
            LnameBox.TabIndex = 4;
            LnameBox.TextChanged += LnameBox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(39, 49);
            label2.Name = "label2";
            label2.Size = new Size(81, 17);
            label2.TabIndex = 5;
            label2.Text = "Last name *";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(39, 108);
            label3.Name = "label3";
            label3.Size = new Size(83, 17);
            label3.TabIndex = 6;
            label3.Text = "First name *";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(39, 172);
            label4.Name = "label4";
            label4.Size = new Size(95, 17);
            label4.TabIndex = 7;
            label4.Text = "Middle name*";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(41, 230);
            label5.Name = "label5";
            label5.Size = new Size(62, 17);
            label5.TabIndex = 8;
            label5.Text = "Gender *";
            // 
            // MaleButton
            // 
            MaleButton.AutoSize = true;
            MaleButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MaleButton.Location = new Point(111, 230);
            MaleButton.Name = "MaleButton";
            MaleButton.Size = new Size(52, 19);
            MaleButton.TabIndex = 9;
            MaleButton.TabStop = true;
            MaleButton.Text = "Male";
            MaleButton.UseVisualStyleBackColor = true;
            MaleButton.CheckedChanged += MaleButton_CheckedChanged;
            // 
            // FemaleButton
            // 
            FemaleButton.AutoSize = true;
            FemaleButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FemaleButton.Location = new Point(184, 230);
            FemaleButton.Name = "FemaleButton";
            FemaleButton.Size = new Size(65, 19);
            FemaleButton.TabIndex = 10;
            FemaleButton.TabStop = true;
            FemaleButton.Text = "Female";
            FemaleButton.UseVisualStyleBackColor = true;
            FemaleButton.CheckedChanged += FemaleButton_CheckedChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(39, 265);
            label6.Name = "label6";
            label6.Size = new Size(94, 17);
            label6.TabIndex = 11;
            label6.Text = "Date of birth*";
            // 
            // DayBox
            // 
            DayBox.FormattingEnabled = true;
            DayBox.Location = new Point(40, 285);
            DayBox.Name = "DayBox";
            DayBox.Size = new Size(80, 23);
            DayBox.TabIndex = 12;
            DayBox.Text = "    --Date-- ";
            DayBox.SelectedIndexChanged += DayBox_SelectedIndexChanged;
            // 
            // MonthBox
            // 
            MonthBox.FormattingEnabled = true;
            MonthBox.Location = new Point(126, 285);
            MonthBox.Name = "MonthBox";
            MonthBox.Size = new Size(96, 23);
            MonthBox.TabIndex = 13;
            MonthBox.Text = "    --Month--";
            MonthBox.SelectedIndexChanged += MonthBox_SelectedIndexChanged;
            // 
            // YearBox
            // 
            YearBox.FormattingEnabled = true;
            YearBox.Location = new Point(228, 285);
            YearBox.Name = "YearBox";
            YearBox.Size = new Size(86, 23);
            YearBox.TabIndex = 14;
            YearBox.Text = "      --Year--";
            YearBox.SelectedIndexChanged += YearBox_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(39, 318);
            label7.Name = "label7";
            label7.Size = new Size(126, 17);
            label7.TabIndex = 15;
            label7.Text = "Program to apply *";
            label7.Click += label7_Click;
            // 
            // ProgramBox
            // 
            ProgramBox.FormattingEnabled = true;
            ProgramBox.Location = new Point(41, 347);
            ProgramBox.Name = "ProgramBox";
            ProgramBox.Size = new Size(273, 23);
            ProgramBox.TabIndex = 16;
            ProgramBox.SelectedIndexChanged += ProgramBox_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(396, 71);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(275, 237);
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // BrowseButton
            // 
            BrowseButton.BackColor = Color.Fuchsia;
            BrowseButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BrowseButton.ForeColor = Color.White;
            BrowseButton.Location = new Point(396, 318);
            BrowseButton.Name = "BrowseButton";
            BrowseButton.Size = new Size(275, 35);
            BrowseButton.TabIndex = 18;
            BrowseButton.Text = "Browse";
            BrowseButton.UseVisualStyleBackColor = false;
            BrowseButton.Click += BrowseButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(708, 423);
            Controls.Add(BrowseButton);
            Controls.Add(pictureBox1);
            Controls.Add(ProgramBox);
            Controls.Add(label7);
            Controls.Add(YearBox);
            Controls.Add(MonthBox);
            Controls.Add(DayBox);
            Controls.Add(label6);
            Controls.Add(FemaleButton);
            Controls.Add(MaleButton);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(LnameBox);
            Controls.Add(FnameBox);
            Controls.Add(MnameBox);
            Controls.Add(label1);
            Controls.Add(RegisterButton);
            Name = "Form1";
            Text = "Student Registration";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button RegisterButton;
        private Label label1;
        private TextBox MnameBox;
        private TextBox FnameBox;
        private TextBox LnameBox;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private RadioButton MaleButton;
        private RadioButton FemaleButton;
        private Label label6;
        private ComboBox DayBox;
        private ComboBox MonthBox;
        private ComboBox YearBox;
        private Label label7;
        private ComboBox ProgramBox;
        private PictureBox pictureBox1;
        private OpenFileDialog openFileDialog1;
        private Button BrowseButton;
    }
}
