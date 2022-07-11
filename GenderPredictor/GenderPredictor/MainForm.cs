using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GenderPredictor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_1_Click_1(object sender, EventArgs e)
        {
            GenderPredictor predict = new GenderPredictor();
            predict.ShowDialog();
        }

        private void btn_2_Click_1(object sender, EventArgs e)
        {
            DueDate estimate = new DueDate();
            estimate.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BMI bmi = new BMI();
            bmi.ShowDialog();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            What_to_Expect progress = new What_to_Expect();
            progress.ShowDialog();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Tips info = new Tips();
            info.ShowDialog();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Feedback help = new Feedback();
            help.ShowDialog();
        }

        private void btn_close_Click_1(object sender, EventArgs e)
        {
            MainForm cl = new MainForm();
            this.Close();
        }
        
    }
}
