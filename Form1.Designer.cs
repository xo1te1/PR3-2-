using System;
using System.Windows.Forms;

namespace pr._1._2
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
        private TextBox emailTextBox;
        private Button submitButton;
        private Label confirmationLabel;
        private CheckBox newsletterCheckBox;
        private NumericUpDown ageNumericUpDown;
        private DateTimePicker birthDatePicker;
        private ComboBox colorComboBox;
        private ProgressBar progressBar;
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.confirmationLabel = new System.Windows.Forms.Label();
            this.newsletterCheckBox = new System.Windows.Forms.CheckBox();
            this.ageNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.birthDatePicker = new System.Windows.Forms.DateTimePicker();
            this.colorComboBox = new System.Windows.Forms.ComboBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ageNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(20, 214);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(260, 20);
            this.emailTextBox.TabIndex = 0;
            this.emailTextBox.Text = "Введіть вашу електронну пошту";
            this.emailTextBox.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(20, 289);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(260, 30);
            this.submitButton.TabIndex = 1;
            this.submitButton.Text = "Надіслати";
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // confirmationLabel
            // 
            this.confirmationLabel.Location = new System.Drawing.Point(17, 253);
            this.confirmationLabel.Name = "confirmationLabel";
            this.confirmationLabel.Size = new System.Drawing.Size(260, 23);
            this.confirmationLabel.TabIndex = 2;
            this.confirmationLabel.Text = "Підтвердження буде тут";
            // 
            // newsletterCheckBox
            // 
            this.newsletterCheckBox.Location = new System.Drawing.Point(20, 172);
            this.newsletterCheckBox.Name = "newsletterCheckBox";
            this.newsletterCheckBox.Size = new System.Drawing.Size(200, 24);
            this.newsletterCheckBox.TabIndex = 3;
            this.newsletterCheckBox.Text = "Хочу отримувати новини";
            // 
            // ageNumericUpDown
            // 
            this.ageNumericUpDown.Location = new System.Drawing.Point(20, 83);
            this.ageNumericUpDown.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.ageNumericUpDown.Name = "ageNumericUpDown";
            this.ageNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.ageNumericUpDown.TabIndex = 4;
            this.ageNumericUpDown.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // birthDatePicker
            // 
            this.birthDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthDatePicker.Location = new System.Drawing.Point(20, 146);
            this.birthDatePicker.Name = "birthDatePicker";
            this.birthDatePicker.Size = new System.Drawing.Size(260, 20);
            this.birthDatePicker.TabIndex = 5;
            // 
            // colorComboBox
            // 
            this.colorComboBox.Items.AddRange(new object[] {
            "Новини спорту",
            "Новини політики",
            "Новини України і світу",
            "Новини рівного"});
            this.colorComboBox.Location = new System.Drawing.Point(20, 22);
            this.colorComboBox.Name = "colorComboBox";
            this.colorComboBox.Size = new System.Drawing.Size(260, 21);
            this.colorComboBox.TabIndex = 6;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(20, 325);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(260, 23);
            this.progressBar.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Оберіть свій вік:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Оберіть дату, за яку ви хочете переглянути новини";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(300, 360);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.confirmationLabel);
            this.Controls.Add(this.newsletterCheckBox);
            this.Controls.Add(this.ageNumericUpDown);
            this.Controls.Add(this.birthDatePicker);
            this.Controls.Add(this.colorComboBox);
            this.Controls.Add(this.progressBar);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Новини";
            ((System.ComponentModel.ISupportInitialize)(this.ageNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Label label1;
        private Label label2;
    }
}

        #endregion
    
