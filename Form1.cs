using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr._1._2
{
    public partial class Form1 : Form
    {
        private const int ProgressBarMax = 100;
        private const int ProgressBarStep = 1;
        public Form1()
        {
            InitializeComponent();
        }


        private async void submitButton_Click(object sender, EventArgs e)
        {

            if (newsletterCheckBox.Checked)
            {
                MessageBox.Show("Ви підписані на новини.");
            }
            else
            {
                MessageBox.Show("Ви не підписані на новини.");
            }

            for (int i = 0; i <= 100; i++)
            {
                progressBar.Value = i;
                await Task.Delay(10); 
            }
            MessageBox.Show("Форма успішно відправлена!");
        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {
            confirmationLabel.Text = $"Ваша електронна пошта: {emailTextBox.Text}";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}