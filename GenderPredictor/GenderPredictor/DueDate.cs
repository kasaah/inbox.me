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
    public partial class DueDate : Form
    {
        public DueDate()
        {
            InitializeComponent();
        }

        private void DueDate_Load(object sender, EventArgs e)
        {

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            try
            {
//JANUARY 2018 AND 25-DAY CYCLE STARTS FROM HERE...
                if (cmb3.Text.ToString() == "1" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, October 05, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "2" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, October 06, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "3" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, October 07, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "4" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, October 08, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "5" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, October 09, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "6" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, October 10, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "7" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, October 11, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "8" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, October 12, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "9" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, October 13, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "10" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, October 14, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "11" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, October 15, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "12" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, October 16, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "13" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, October 17, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "14" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, October 18, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "15" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, October 19, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "16" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, October 20, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "17" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, October 21, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "18" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, October 22, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "19" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, October 23, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "20" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, October 24, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "21" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, October 25, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "22" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, October 26, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "23" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, October 27, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "24" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, October 28, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "25" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, October 29, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "26" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, October 30, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "27" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, October 31, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "28" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, November 01, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "29" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, November 02, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "30" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, November 03, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "31" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, November 04, 2018._________________");
                    return;
                }

    //FEBRUARY 2018 AND 25-DAY CYCLE STARTS FROM HERE...
                else if (cmb3.Text.ToString() == "1" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, November 05, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "2" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, November 06, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "3" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, November 07, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "4" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, November 08, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "5" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, November 09, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "6" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, November 10, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "7" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, November 11, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "8" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, November 12, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "9" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, November 13, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "10" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, November 14, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "11" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, November 15, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "12" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, November 16, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "13" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, November 17, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "14" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, November 18, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "15" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, November 19, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "16" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, November 20, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "17" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, November 21, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "18" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, November 22, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "19" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, November 23, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "20" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, November 24, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "21" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, November 25, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "22" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, November 26, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "23" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, November 27, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "24" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, November 28, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "25" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, November 29, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "26" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, November 30, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "27" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, December 01, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "28" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, December 02, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "29" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Please correct the following errors \n\n***Invalid date given.");
                    return;
                }
                else if (cmb3.Text.ToString() == "30" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Please correct the following errors \n\n***Invalid date given.");
                    return;
                }
                else if (cmb3.Text.ToString() == "31" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Please correct the following errors \n\n***Invalid date given.");
                    return;
                }

    //MARCH 2018 AND 20-DAY CYCLE STARTS FROM HERE...
                else if (cmb3.Text.ToString() == "1" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, December 03, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "2" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, December 04, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "3" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, December 05, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "4" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, December 06, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "5" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, December 07, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "6" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, December 08, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "7" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, December 09, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "8" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, December 10, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "9" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, December 11, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "10" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, December 12, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "11" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, December 13, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "12" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, December 14, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "13" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, December 15, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "14" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, December 16, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "15" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, December 17, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "16" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, December 18, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "17" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, December 19, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "18" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, December 20, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "19" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, December 21, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "20" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, December 22, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "21" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, December 23, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "22" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, December 24, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "23" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, December 25, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "24" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, December 26, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "25" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, December 27, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "26" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, December 28, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "27" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, December 29, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "28" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, December 30, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "29" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, December 31, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "30" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, January 01, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "31" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, January 02, 2019._________________");
                    return;
                }

    //APRIL 2018 AND 20-DAY CYCLE STARTS FROM HERE...
                else if (cmb3.Text.ToString() == "1" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, January 03, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "2" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, January 04, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "3" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, January 05, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "4" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, January 06, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "5" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, January 07, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "6" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, January 08, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "7" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, January 09, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "8" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, January 10, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "9" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, January 11, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "10" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, January 12, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "11" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, January 13, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "12" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, January 14, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "13" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, January 15, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "14" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, January 16, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "15" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, January 17, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "16" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, January 18, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "17" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, January 19, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "18" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, January 20, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "19" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, January 21, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "20" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, January 22, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "21" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, January 23, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "22" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, January 24, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "23" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, January 25, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "24" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, January 26, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "25" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, January 27, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "26" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, January 28, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "27" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, January 29, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "28" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, January 30, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "29" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, January 31, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "30" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, February 01, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "31" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Please correct the following errors \n\n***Invalid date given.");
                    return;
                }

    //MAY 2018 AND 25-DAY CYCLE STARTS FROM HERE...
                else if (cmb3.Text.ToString() == "1" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, February 02, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "2" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, February 03, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "3" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, February 04, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "4" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, February 05, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "5" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, February 06, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "6" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, February 07, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "7" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, February 08, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "8" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, February 09, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "9" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, February 10, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "10" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, February 11, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "11" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, February 12, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "12" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, February 13, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "13" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, February 14, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "14" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, February 15, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "15" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, February 16, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "16" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, February 17, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "17" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, February 18, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "18" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, February 19, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "19" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, February 20, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "20" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, February 21, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "21" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, February 22, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "22" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, February 23, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "23" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, February 24, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "24" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, February 25, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "25" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, February 26, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "26" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, February 27, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "27" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, February 28, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "28" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, March 01, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "29" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, March 02, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "30" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, March 03, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "31" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, March 04, 2019._________________");
                    return;
                }


    //JUNE 2018 AND 25-DAY CYCLE STARTS FROM HERE...
                else if (cmb3.Text.ToString() == "1" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, March 05, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "2" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, March 06, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "3" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, March 07, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "4" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, March 08, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "5" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, March 09, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "6" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, March 10, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "7" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, March 11, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "8" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, March 12, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "9" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, March 13, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "10" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, March 14, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "11" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, March 15, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "12" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, March 16, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "13" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, March 17, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "14" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, March 18, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "15" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, March 19, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "16" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, March 20, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "17" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, March 21, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "18" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, March 22, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "19" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, March 23, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "20" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, March 24, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "21" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, March 25, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "22" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, March 26, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "23" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, March 27, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "24" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, March 28, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "25" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, March 29, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "26" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, March 30, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "27" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, March 31, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "28" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, April 01, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "29" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, April 02, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "30" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, April 03, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "31" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Please correct the following errors \n\n***Invalid date given.");
                    return;
                }


    //JULY 2018 AND 25-DAY CYCLE STARTS FROM HERE...
                else if (cmb3.Text.ToString() == "1" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, April 04, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "2" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, April 05, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "3" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, April 06, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "4" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, April 07, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "5" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, April 08, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "6" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, April 09, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "7" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, April 10, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "8" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, April 11, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "9" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, April 12, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "10" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, April 13, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "11" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, April 14, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "12" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, April 15, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "13" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, April 16, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "14" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, April 17, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "15" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, April 18, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "16" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, April 19, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "17" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, April 20, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "18" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, April 21, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "19" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, April 22, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "20" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, April 23, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "21" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, April 24, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "22" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, April 25, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "23" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, April 26, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "24" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, April 27, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "25" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, April 28, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "26" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, April 29, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "27" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, April 30, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "28" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, May 01, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "29" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, May 02, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "30" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, May 03, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "31" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, May 04, 2019._________________");
                    return;
                }


    //AUGUST 2018 AND 25-DAY CYCLE STARTS FROM HERE...
                else if (cmb3.Text.ToString() == "1" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, May 05, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "2" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, May 06, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "3" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, May 07, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "4" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, May 08, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "5" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, May 09, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "6" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, May 10, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "7" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, May 11, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "8" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, May 12, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "9" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, May 13, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "10" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, May 14, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "11" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, May 15, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "12" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, May 16, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "13" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, May 17, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "14" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, May 18, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "15" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, May 19, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "16" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, May 20, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "17" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, May 21, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "18" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, May 22, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "19" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, May 23, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "20" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, May 24, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "21" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, May 25, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "22" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, May 26, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "23" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, May 27, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "24" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, May 28, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "25" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, May 29, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "26" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, May 30, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "27" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, May 31, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "28" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, June 01, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "29" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, June 02, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "30" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, June 03, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "31" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, June 04, 2019._________________");
                    return;
                }


    //SEPTEMBER 2018 AND 25-DAY CYCLE STARTS FROM HERE...
                else if (cmb3.Text.ToString() == "1" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wedneday, June 05, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "2" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, June 06, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "3" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, June 07, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "4" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, June 08, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "5" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, June 09, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "6" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, June 10, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "7" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, June 11, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "8" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, June 12, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "9" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, June 13, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "10" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, June 14, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "11" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, June 15, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "12" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, June 16, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "13" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, June 17, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "14" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, June 18, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "15" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, June 19, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "16" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, June 20, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "17" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, June 21, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "18" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, June 22, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "19" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, June 23, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "20" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, June 24, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "21" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, June 25, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "22" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, June 26, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "23" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, June 27, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "24" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, June 28, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "25" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, June 29, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "26" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, June 30, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "27" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, July 01, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "28" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, July 02, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "29" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, July 03, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "30" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, July 04, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "31" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Please correct the following errors \n\n***Invalid date given.");
                    return;
                }


    //OCTOBER 2018 AND 25-DAY CYCLE STARTS FROM HERE...
                else if (cmb3.Text.ToString() == "1" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, July 05, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "2" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, July 06, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "3" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, July 07, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "4" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, July 08, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "5" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, July 09, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "6" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, July 10, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "7" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, July 11, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "8" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, July 12, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "9" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, July 13, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "10" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, July 14, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "11" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, July 15, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "12" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, July 16, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "13" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, July 17, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "14" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, July 18, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "15" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, July 19, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "16" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, July 20, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "17" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, July 21, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "18" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, July 22, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "19" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, July 23, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "20" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, July 24, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "21" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, July 25, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "22" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, July 26, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "23" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, July 27, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "24" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, July 28, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "25" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, July 29, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "26" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, July 30, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "27" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, July 31, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "28" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, August 01, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "29" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, August 02, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "30" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, August 03, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "31" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, August 04, 2019._________________");
                    return;
                }


    //NOVEMBER 2018 AND 25-DAY CYCLE STARTS FROM HERE...
                else if (cmb3.Text.ToString() == "1" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, August 05, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "2" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, August 06, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "3" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, August 07, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "4" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, August 08, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "5" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, August 09, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "6" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, August 10, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "7" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, August 11, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "8" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, August 12, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "9" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, August 13, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "10" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, August 14, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "11" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, August 15, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "12" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, August 16, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "13" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, August 17, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "14" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, August 18, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "15" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, August 19, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "16" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, August 20, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "17" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, August 21, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "18" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, August 22, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "19" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, August 23, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "20" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, August 24, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "21" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, August 25, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "22" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, August 26, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "23" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, August 27, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "24" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, August 28, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "25" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, August 29, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "26" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, August 30, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "27" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, August 31, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "28" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, September 01, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "29" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, September 02, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "30" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, September 03, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "31" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Please correct the following errors \n\n***Invalid date given.");
                    return;
                }


    //DECEMBER 2018 AND 25-DAY CYCLE STARTS FROM HERE...
                else if (cmb3.Text.ToString() == "1" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, September 04, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "2" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, September 05, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "3" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, September 06, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "4" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, September 07, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "5" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, September 08, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "6" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, September 09, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "7" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, September 10, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "8" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, September 11, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "9" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, September 12, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "10" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, September 13, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "11" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, September 14, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "12" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, September 15, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "13" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, September 16, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "14" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, September 17, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "15" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, September 18, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "16" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, September 19, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "17" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, September 20, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "18" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, September 21, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "19" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, September 22, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "20" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, September 23, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "21" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, September 24, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "22" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, September 25, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "23" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, September 26, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "24" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, September 27, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "25" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, September 28, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "26" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, September 29, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "27" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, September 30, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "28" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, October 01, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "29" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, October 02, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "30" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, October 03, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "31" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, October 04, 2019._________________");
                    return;
                }





                //JANUARY 2018 AND 26-DAY CYCLE STARTS FROM HERE...
                if (cmb3.Text.ToString() == "1" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, October 06, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "2" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, October 07, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "3" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, October 08, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "4" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, October 09, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "5" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, October 10, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "6" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, October 11, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "7" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, October 12, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "8" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, October 13, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "9" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, October 14, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "10" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, October 15, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "11" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, October 16, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "12" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, October 17, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "13" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, October 18, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "14" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, October 19, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "15" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, October 20, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "16" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, October 21, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "17" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, October 22, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "18" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, October 23, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "19" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, October 24, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "20" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, October 25, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "21" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, October 26, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "22" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, October 27, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "23" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, October 28, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "24" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, October 29, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "25" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, October 30, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "26" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, October 31, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "27" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, November 01, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "28" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, November 02, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "29" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, November 03, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "30" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, November 04, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "31" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, November 05, 2018._________________");
                    return;
                }

    //FEBRUARY 2018 AND 26-DAY CYCLE STARTS FROM HERE...
                else if (cmb3.Text.ToString() == "1" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, November 06, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "2" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, November 07, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "3" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, November 08, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "4" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, November 09, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "5" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, November 10, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "6" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, November 11, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "7" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, November 12, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "8" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, November 13, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "9" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, November 14, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "10" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, November 15, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "11" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, November 16, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "12" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, November 17, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "13" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, November 18, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "14" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, November 19, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "15" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, November 20, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "16" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, November 21, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "17" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, November 22, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "18" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, November 23, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "19" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, November 24, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "20" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, November 25, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "21" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, November 26, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "22" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, November 27, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "23" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, November 28, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "24" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, November 29, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "25" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, November 30, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "26" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, December 01, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "27" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, December 02, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "28" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, December 03, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "29" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Please correct the following errors \n\n***Invalid date given.");
                    return;
                }
                else if (cmb3.Text.ToString() == "30" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Please correct the following errors \n\n***Invalid date given.");
                    return;
                }
                else if (cmb3.Text.ToString() == "31" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Please correct the following errors \n\n***Invalid date given.");
                    return;
                }

    //MARCH 2018 AND 26-DAY CYCLE STARTS FROM HERE...
                else if (cmb3.Text.ToString() == "1" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, December 04, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "2" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, December 05, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "3" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, December 06, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "4" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, December 07, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "5" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, December 08, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "6" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, December 09, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "7" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, December 10, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "8" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, December 11, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "9" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, December 12, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "10" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, December 13, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "11" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, December 14, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "12" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, December 15, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "13" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, December 16, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "14" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, December 17, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "15" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, December 18, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "16" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, December 19, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "17" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, December 20, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "18" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, December 21, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "19" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, December 22, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "20" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, December 23, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "21" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, December 24, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "22" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, December 25, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "23" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, December 26, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "24" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, December 27, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "25" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, December 28, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "26" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, December 29, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "27" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, December 30, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "28" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, December 31, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "29" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, January 01, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "30" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, January 02, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "31" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, January 03, 2019._________________");
                    return;
                }

    //APRIL 2018 AND 26-DAY CYCLE STARTS FROM HERE...
                else if (cmb3.Text.ToString() == "1" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, January 04, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "2" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, January 05, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "3" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, January 06, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "4" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, January 07, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "5" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, January 08, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "6" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, January 09, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "7" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, January 10, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "8" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, January 11, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "9" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, January 12, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "10" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, January 13, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "11" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, January 14, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "12" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, January 15, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "13" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, January 16, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "14" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, January 17, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "15" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, January 18, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "16" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, January 19, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "17" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, January 20, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "18" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, January 21, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "19" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, January 22, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "20" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, January 23, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "21" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, January 24, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "22" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, January 25, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "23" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, January 26, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "24" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, January 27, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "25" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, January 28, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "26" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, January 29, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "27" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, January 30, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "28" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, January 31, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "29" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, February 01, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "30" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, February 02, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "31" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Please correct the following errors \n\n***Invalid date given.");
                    return;
                }

    //MAY 2018 AND 26-DAY CYCLE STARTS FROM HERE...
                else if (cmb3.Text.ToString() == "1" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, February 03, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "2" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, February 04, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "3" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, February 05, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "4" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, February 06, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "5" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, February 07, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "6" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, February 08, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "7" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, February 09, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "8" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, February 10, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "9" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, February 11, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "10" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, February 12, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "11" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, February 13, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "12" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, February 14, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "13" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, February 15, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "14" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, February 16, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "15" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, February 17, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "16" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, February 18, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "17" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, February 19, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "18" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, February 20, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "19" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, February 21, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "20" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, February 22, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "21" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, February 23, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "22" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, February 24, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "23" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, February 25, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "24" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, February 26, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "25" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, February 27, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "26" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, February 28, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "27" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, March 01, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "28" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, March 02, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "29" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, March 03, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "30" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, March 04, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "31" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, March 05, 2019._________________");
                    return;
                }


    //JUNE 2018 AND 26-DAY CYCLE STARTS FROM HERE...
                else if (cmb3.Text.ToString() == "1" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, March 06, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "2" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, March 07, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "3" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, March 08, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "4" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, March 09, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "5" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, March 10, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "6" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, March 11, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "7" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, March 12, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "8" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, March 13, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "9" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, March 14, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "10" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, March 15, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "11" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, March 16, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "12" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, March 17, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "13" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, March 18, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "14" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, March 19, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "15" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, March 20, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "16" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, March 21, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "17" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, March 22, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "18" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, March 23, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "19" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, March 24, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "20" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, March 25, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "21" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, March 26, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "22" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, March 27, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "23" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, March 28, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "24" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, March 29, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "25" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, March 30, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "26" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, March 31, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "27" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, April 01, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "28" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, April 02, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "29" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, April 03, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "30" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, April 04, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "31" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Please correct the following errors \n\n***Invalid date given.");
                    return;
                }


    //JULY 2018 AND 26-DAY CYCLE STARTS FROM HERE...
                else if (cmb3.Text.ToString() == "1" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, April 05, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "2" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, April 06, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "3" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, April 07, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "4" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, April 08, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "5" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, April 09, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "6" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, April 10, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "7" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, April 11, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "8" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, April 12, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "9" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, April 13, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "10" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, April 14, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "11" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, April 15, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "12" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, May 16, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "13" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, April 17, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "14" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, April 18, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "15" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, April 19, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "16" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, April 20, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "17" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, April 21, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "18" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, April 22, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "19" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, April 23, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "20" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, April 24, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "21" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, April 25, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "22" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, April 26, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "23" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, April 27, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "24" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, April 28, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "25" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, April 29, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "26" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, April 30, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "27" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, May 01, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "28" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, May 02, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "29" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, May 03, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "30" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, May 04, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "31" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, May 05, 2019._________________");
                    return;
                }


    //AUGUST 2018 AND 26-DAY CYCLE STARTS FROM HERE...
                else if (cmb3.Text.ToString() == "1" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, May 06, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "2" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, May 07, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "3" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, May 08, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "4" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, May 09, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "5" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, May 10, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "6" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, May 11, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "7" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, May 12, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "8" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, May 13, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "9" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, May 14, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "10" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, May 15, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "11" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, May 16, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "12" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, May 17, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "13" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, May 18, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "14" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, May 19, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "15" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, May 20, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "16" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, May 21, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "17" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, May 22, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "18" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, May 23, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "19" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, May 24, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "20" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, May 25, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "21" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, May 26, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "22" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, May 27, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "23" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, May 28, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "24" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, May 29, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "25" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, May 30, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "26" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, May 31, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "27" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, June 01, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "28" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, June 02, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "29" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, June 03, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "30" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, June 04, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "31" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, June 05, 2019._________________");
                    return;
                }

    //SEPTEMBER 2018 AND 26-DAY CYCLE STARTS FROM HERE...
                else if (cmb3.Text.ToString() == "1" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, June 06, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "2" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, June 07, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "3" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, June 08, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "4" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, June 09, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "5" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, June 10, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "6" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, June 11, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "7" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, June 12, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "8" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, June 13, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "9" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, June 14, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "10" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, June 15, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "11" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, June 16, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "12" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, June 17, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "13" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, June 18, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "14" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, June 19, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "15" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, June 20, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "16" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, June 21, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "17" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, June 22, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "18" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, June 23, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "19" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, June 24, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "20" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, June 25, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "21" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, June 26, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "22" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, June 27, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "23" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, June 28, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "24" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, June 29, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "25" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, June 30, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "26" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, July 01, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "27" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, July 02, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "28" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, July 03, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "29" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, July 04, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "30" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, July 05, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "31" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "25")
                {
                    MessageBox.Show("Please correct the following errors \n\n***Invalid date given.");
                    return;
                }


    //OCTOBER 2018 AND 26-DAY CYCLE STARTS FROM HERE...
                else if (cmb3.Text.ToString() == "1" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, July 06, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "2" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, July 07, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "3" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, July 08, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "4" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, July 09, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "5" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, July 10, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "6" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, July 11, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "7" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, July 12, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "8" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, July 13, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "9" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, July 14, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "10" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, July 15, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "11" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, July 16, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "12" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, July 17, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "13" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, July 18, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "14" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, July 19, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "15" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, July 20, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "16" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, July 21, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "17" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, July 22, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "18" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, July 23, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "19" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, July 24, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "20" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, July 25, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "21" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, July 26, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "22" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, July 27, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "23" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, July 28, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "24" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, July 29, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "25" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, July 30, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "26" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, July 31, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "27" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, August 01, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "28" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, August 02, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "29" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, August 03, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "30" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, August 04, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "31" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, August 05, 2019._________________");
                    return;
                }


    //NOVEMBER 2018 AND 26-DAY CYCLE STARTS FROM HERE...
                else if (cmb3.Text.ToString() == "1" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, August 06, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "2" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, August 07, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "3" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, August 08, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "4" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, August 09, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "5" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, August 10, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "6" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, August 11, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "7" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, August 12, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "8" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, August 13, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "9" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, August 14, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "10" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, August 15, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "11" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, August 16, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "12" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, August 17, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "13" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, August 18, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "14" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, August 19, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "15" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, August 20, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "16" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, August 21, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "17" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, August 22, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "18" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, August 23, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "19" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, August 24, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "20" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, August 25, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "21" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, August 26, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "22" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, August 27, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "23" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, August 28, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "24" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, August 29, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "25" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, August 30, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "26" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, August 31, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "27" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, September 01, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "28" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, September 02, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "29" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, September 03, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "30" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, September 04, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "31" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Please correct the following errors \n\n***Invalid date given.");
                    return;
                }


    //DECEMBER 2018 AND 26-DAY CYCLE STARTS FROM HERE...
                else if (cmb3.Text.ToString() == "1" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, September 05, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "2" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, September 06, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "3" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, September 07, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "4" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, September 08, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "5" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, September 09, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "6" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, September 10, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "7" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, September 11, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "8" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, September 12, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "9" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, September 13, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "10" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, September 14, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "11" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, September 15, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "12" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, September 16, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "13" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, September 17, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "14" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, September 18, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "15" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, September 19, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "16" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, September 20, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "17" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, September 21, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "18" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, September 22, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "19" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, September 23, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "20" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, September 24, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "21" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, September 25, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "22" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, September 26, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "23" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, September 27, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "24" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, September 28, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "25" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, September 29, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "26" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, September 30, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "27" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, October 01, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "28" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, October 02, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "29" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, October 03, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "30" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, October 04, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "31" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "26")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, October 05, 2019._________________");
                    return;
                }





                //JANUARY 2018 AND 27-DAY CYCLE STARTS FROM HERE...
                if (cmb3.Text.ToString() == "1" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, October 07, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "2" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, October 08, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "3" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, October 09, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "4" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, October 10, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "5" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, October 11, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "6" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, October 12, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "7" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, October 13, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "8" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, October 14, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "9" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, October 15, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "10" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, October 16, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "11" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, October 17, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "12" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, October 18, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "13" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, October 19, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "14" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, October 20, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "15" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, October 21, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "16" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, October 22, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "17" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, October 23, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "18" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, October 24, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "19" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, October 25, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "20" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, October 26, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "21" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, October 27, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "22" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, October 28, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "23" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, October 29, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "24" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, October 30, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "25" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, October 31, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "26" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, November 01, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "27" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, November 02, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "28" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, November 03, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "29" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, November 04, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "30" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, November 05, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "31" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, November 06, 2018._________________");
                    return;
                }

    //FEBRUARY 2018 AND 27-DAY CYCLE STARTS FROM HERE...
                else if (cmb3.Text.ToString() == "1" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, November 07, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "2" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, November 08, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "3" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, November 09, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "4" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, November 10, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "5" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, November 11, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "6" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, November 12, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "7" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, November 13, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "8" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, November 14, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "9" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, November 15, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "10" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, November 16, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "11" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, November 17, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "12" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, November 18, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "13" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, November 19, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "14" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, November 20, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "15" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, November 21, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "16" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, November 22, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "17" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, November 23, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "18" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, November 24, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "19" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, November 25, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "20" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, November 26, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "21" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, November 27, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "22" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, November 28, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "23" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, November 29, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "24" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, November 30, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "25" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, December 01, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "26" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, December 02, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "27" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, December 03, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "28" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, December 04, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "29" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Please correct the following errors \n\n***Invalid date given.");
                    return;
                }
                else if (cmb3.Text.ToString() == "30" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Please correct the following errors \n\n***Invalid date given.");
                    return;
                }
                else if (cmb3.Text.ToString() == "31" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Please correct the following errors \n\n***Invalid date given.");
                    return;
                }

    //MARCH 2018 AND 27-DAY CYCLE STARTS FROM HERE...
                else if (cmb3.Text.ToString() == "1" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, December 05, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "2" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, December 06, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "3" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, December 07, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "4" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, December 08, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "5" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, December 09, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "6" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, December 10, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "7" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, December 11, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "8" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, December 12, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "9" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, December 13, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "10" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, December 14, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "11" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, December 15, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "12" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, December 16, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "13" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, December 17, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "14" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, December 18, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "15" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, December 19, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "16" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, December 20, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "17" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, December 21, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "18" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, December 22, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "19" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, December 23, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "20" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, December 24, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "21" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, December 25, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "22" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, December 26, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "23" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, December 27, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "24" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, December 28, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "25" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, December 29, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "26" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, December 30, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "27" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, December 31, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "28" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, January 01, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "29" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, January 02, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "30" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, January 03, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "31" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, January 04, 2019._________________");
                    return;
                }

    //APRIL 2018 AND 27-DAY CYCLE STARTS FROM HERE...
                else if (cmb3.Text.ToString() == "1" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wedesday, January 05, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "2" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, January 06, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "3" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, January 07, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "4" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, January 08, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "5" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, January 09, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "6" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, January 10, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "7" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, January 11, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "8" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wedesday, January 12, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "9" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, January 13, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "10" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, January 14, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "11" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, January 15, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "12" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, January 16, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "13" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, January 17, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "14" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, January 18, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "15" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, January 19, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "16" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, January 20, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "17" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, January 21, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "18" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, January 22, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "19" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, January 23, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "20" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, January 24, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "21" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, January 25, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "22" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wedesday, January 26, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "23" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, January 27, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "24" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, January 29, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "25" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, January 31, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "26" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, February 01, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "27" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, February 02, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "28" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, February 03, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "29" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, February 04, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "30" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, February 05, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "31" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Please correct the following errors \n\n***Invalid date given.");
                    return;
                }

    //MAY 2018 AND 27-DAY CYCLE STARTS FROM HERE...
                else if (cmb3.Text.ToString() == "1" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, February 06, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "2" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, February 07, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "3" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, February 08, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "4" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, February 09, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "5" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, February 10, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "6" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wedesday, February 11, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "7" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, February 12, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "8" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, February 13, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "9" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, February 14, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "10" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, February 15, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "11" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, February 16, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "12" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, February 17, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "13" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wedesday, February 18, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "14" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, February 19, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "15" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, February 20, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "16" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, February 21, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "17" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, February 22, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "18" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, February 23, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "19" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, February 24, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "20" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, February 25, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "21" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, February 26, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "22" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, February 27, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "23" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, February 28, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "24" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, February 29, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "25" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, March 01, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "26" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, February 02, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "27" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________wednesday, February 03, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "28" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, March 04, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "29" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, March 05, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "30" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, March 06, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "31" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, March 07, 2019._________________");
                    return;
                }


    //JUNE 2018 AND 27-DAY CYCLE STARTS FROM HERE...
                else if (cmb3.Text.ToString() == "1" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, March 08, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "2" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, March 09, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "3" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, March 10, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "4" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, March 11, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "5" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, March 12, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "6" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, March 13, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "7" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, March 14, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "8" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, March 15, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "9" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, March 16, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "10" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, March 17, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "11" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, March 18, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "12" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, March 19, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "13" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, March 20, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "14" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, March 21, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "15" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, March 22, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "16" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, March 23, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "17" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, March 24, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "18" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, March 25, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "19" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, March 26, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "20" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, March 27, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "21" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, March 28, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "22" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, March 29, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "23" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, March 30, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "24" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, March 31, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "25" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, April 01, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "26" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, April 02, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "27" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, April 03, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "28" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, April 04, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "29" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, April 05, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "30" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, April 06, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "31" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Please correct the following errors \n\n***Invalid date given.");
                    return;
                }


    //JULY 2018 AND 27-DAY CYCLE STARTS FROM HERE...
                else if (cmb3.Text.ToString() == "1" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, April 07, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "2" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, April 08, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "3" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, April 09, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "4" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, April 10, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "5" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, April 11, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "6" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, April 12, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "7" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, April 13, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "8" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, April 14, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "9" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, April 15, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "10" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, April 16, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "11" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, April 17, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "12" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, April 18, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "13" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, April 19, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "14" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, April 20, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "15" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, April 21, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "16" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, April 22, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "17" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, April 23, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "18" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, April 24, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "19" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, April 25, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "20" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, April 26, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "21" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, April 27, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "22" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, April 28, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "23" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, April 29, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "24" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, April 30, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "25" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, May 01, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "26" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, May 02, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "27" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, May 03, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "28" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, May 04, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "29" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, May 05, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "30" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, May 06, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "31" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, May 07, 2019._________________");
                    return;
                }


    //AUGUST 2018 AND 27-DAY CYCLE STARTS FROM HERE...
                else if (cmb3.Text.ToString() == "1" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, May 08, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "2" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, May 09, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "3" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, May 10, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "4" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, May 11, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "5" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, May 12, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "6" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, May 13, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "7" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, May 14, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "8" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, May 15, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "9" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, May 16, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "10" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, May 17, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "11" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, May 18, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "12" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, May 19, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "13" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, May 20, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "14" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, May 21, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "15" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, May 22, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "16" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, May 23, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "17" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, May 24, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "18" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, May 25, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "19" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, May 26, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "20" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, May 27, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "21" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, May 28, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "22" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, May 29, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "23" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, May 30, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "24" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, May 31, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "25" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, June 01, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "26" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, June 02, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "27" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, June 03, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "28" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, June 04, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "29" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, June 05, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "30" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, June 06, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "31" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, June 07, 2019._________________");
                    return;
                }


    //SEPTEMBER 2018 AND 27-DAY CYCLE STARTS FROM HERE...
                else if (cmb3.Text.ToString() == "1" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, June 08, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "2" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, June 09, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "3" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, June 10, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "4" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, June 11, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "5" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, June 12, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "6" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, June 13, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "7" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, June 14, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "8" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, June 15, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "9" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, June 16, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "10" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, June 17, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "11" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, June 18, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "12" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, June 19, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "13" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, June 20, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "14" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, June 21, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "15" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, June 22, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "16" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, June 23, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "17" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, June 24, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "18" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, June 25, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "19" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, June 26, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "20" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, June 27, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "21" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, June 28, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "22" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, June 29, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "23" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, June 30, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "24" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, Jully 01, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "25" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, Jully 02, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "26" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, June 03, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "27" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, July 04, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "28" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, July 05, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "29" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, July 06, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "30" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, July 07, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "31" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Please correct the following errors \n\n***Invalid date given.");
                    return;
                }


    //OCTOBER 2018 AND 27-DAY CYCLE STARTS FROM HERE...
                else if (cmb3.Text.ToString() == "1" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, July 08, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "2" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, July 09, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "3" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, July 10, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "4" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, July 11, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "5" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, July 12, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "6" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, July 13, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "7" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, July 14, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "8" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, July 15, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "9" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, July 16, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "10" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, July 17, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "11" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, July 18, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "12" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, July 19, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "13" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, July 20, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "14" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, July 21, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "15" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, July 22, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "16" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, July 23, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "17" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, July 24, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "18" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, July 25, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "19" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, July 26, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "20" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, July 27, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "21" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, July 28, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "22" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, July 29, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "23" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, July 30, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "24" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, July 31, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "25" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, August 01, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "26" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, August 02, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "27" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, August 03, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "28" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, August 04, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "29" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, August 05, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "30" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, August 06, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "31" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, August 07, 2019._________________");
                    return;
                }


    //NOVEMBER 2018 AND 27-DAY CYCLE STARTS FROM HERE...
                else if (cmb3.Text.ToString() == "1" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, August 08, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "2" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, August 09, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "3" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, August 10, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "4" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, August 11, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "5" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, August 12, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "6" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, August 13, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "7" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, August 14, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "8" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, August 15, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "9" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, August 16, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "10" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, August 17, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "11" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, August 18, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "12" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, August 19, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "13" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, August 20, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "14" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, August 21, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "15" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, August 22, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "16" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, August 23, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "17" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, August 24, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "18" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, August 25, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "19" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, August 26, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "20" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, August 27, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "21" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, August 28, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "22" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, August 29, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "23" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, August 30, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "24" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, August 31, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "25" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, September 01, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "26" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, September 02, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "27" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, September 03, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "28" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, September 04, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "29" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, September 05, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "30" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, September 06, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "31" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Please correct the following errors \n\n***Invalid date given.");
                    return;
                }


    //DECEMBER 2018 AND 27-DAY CYCLE STARTS FROM HERE...
                else if (cmb3.Text.ToString() == "1" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, September 07, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "2" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, September 08, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "3" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, September 09, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "4" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, September 10, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "5" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, September 11, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "6" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, September 12, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "7" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, September 13, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "8" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, September 14, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "9" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, September 15, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "10" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, September 16, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "11" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, September 17, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "12" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, September 18, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "13" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, September 19, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "14" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, September 20, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "15" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, September 21, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "16" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, September 22, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "17" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, September 23, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "18" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, September 24, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "19" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, September 25, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "20" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, September 26, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "21" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, September 27, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "22" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, September 28, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "23" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, September 29, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "24" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, September 30, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "25" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, October 01, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "26" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, October 02, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "27" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, September 03, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "28" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, October 04, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "29" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, October 05, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "30" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, October 06, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "31" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "27")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, October 07, 2019._________________");
                    return;
                }




                //JANUARY 2018 AND 28-DAY CYCLE STARTS FROM HERE...
                if (cmb3.Text.ToString() == "1" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, October 08, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "2" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, October 09, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "3" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, October 10, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "4" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, October 11, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "5" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, October 12, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "6" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, October 13, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "7" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, October 14, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "8" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, October 15, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "9" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, October 16, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "10" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, October 17, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "11" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, October 18, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "12" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, October 19, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "13" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, October 20, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "14" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, October 21, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "15" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, October 22, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "16" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, October 23, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "17" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, October 24, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "18" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, October 25, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "19" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, October 26, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "20" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, October 27, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "21" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, October 28, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "22" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, October 29, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "23" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, October 30, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "24" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, October 31, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "25" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, November 01, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "26" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, November 02, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "27" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, November 03, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "28" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, November 04, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "29" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, November 05, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "30" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, November 06, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "31" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, November 07, 2018._________________");
                    return;
                }

    //FEBRUARY 2018 AND 28-DAY CYCLE STARTS FROM HERE...
                else if (cmb3.Text.ToString() == "1" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, November 08, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "2" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, November 09, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "3" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, November 10, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "4" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, November 11, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "5" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, November 12, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "6" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, November 13, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "7" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, November 14, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "8" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, November 15, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "9" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, November 16, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "10" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, November 17, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "11" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, November 18, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "12" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, November 19, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "13" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, November 20, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "14" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, November 21, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "15" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, November 22, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "16" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, November 23, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "17" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, November 24, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "18" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, November 25, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "19" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, November 26, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "20" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, November 27, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "21" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, November 28, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "22" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, November 29, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "23" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, November 30, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "24" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, December 01, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "25" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, December 02, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "26" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, December 03, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "27" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, December 04, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "28" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, December 05, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "29" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Please correct the following errors \n\n***Invalid date given.");
                    return;
                }
                else if (cmb3.Text.ToString() == "30" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Please correct the following errors \n\n***Invalid date given.");
                    return;
                }
                else if (cmb3.Text.ToString() == "31" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Please correct the following errors \n\n***Invalid date given.");
                    return;
                }

    //MARCH 2018 AND 28-DAY CYCLE STARTS FROM HERE...
                else if (cmb3.Text.ToString() == "1" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, December 06, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "2" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, December 07, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "3" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, December 08, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "4" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, December 09, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "5" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, December 10, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "6" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, December 11, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "7" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, December 12, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "8" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, December 13, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "9" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, December 14, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "10" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, December 15, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "11" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, December 16, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "12" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, December 17, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "13" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, December 18, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "14" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, December 19, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "15" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, December 20, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "16" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, December 21, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "17" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, December 22, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "18" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, December 23, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "19" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, December 24, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "20" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, December 25, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "21" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, December 26, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "22" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, December 27, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "23" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, December 28, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "24" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, December 29, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "25" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, December 30, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "26" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, December 31, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "27" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, January 01, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "28" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, January 02, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "29" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, January 03, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "30" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, January 04, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "31" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, January 06, 2019._________________");
                    return;
                }

    //APRIL 2018 AND 28-DAY CYCLE STARTS FROM HERE...
                else if (cmb3.Text.ToString() == "1" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, January 07, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "2" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, January 08, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "3" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, January 09, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "4" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, January 10, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "5" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, January 11, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "6" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, January 12, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "7" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, January 13, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "8" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, January 14, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "9" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, January 15, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "10" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, January 16, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "11" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, January 17, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "12" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, January 18, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "13" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, January 19, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "14" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, January 20, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "15" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, January 21, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "16" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, January 22, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "17" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, January 23, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "18" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, January 24, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "19" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, January 25, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "20" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, January 26, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "21" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, January 27, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "22" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, January 28, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "23" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, January 29, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "24" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, January 30, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "25" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, January 31, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "26" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, February 01, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "27" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, February 02, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "28" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, February 03, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "29" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, February 04, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "30" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, February 05, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "31" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Please correct the following errors \n\n***Invalid date given.");
                    return;
                }

    //MAY 2018 AND 28-DAY CYCLE STARTS FROM HERE...
                else if (cmb3.Text.ToString() == "1" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, February 06, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "2" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, February 07, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "3" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, February 08, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "4" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, February 09, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "5" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, February 10, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "6" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, February 11, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "7" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, February 12, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "8" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, February 13, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "9" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, February 14, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "10" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, February 15, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "11" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, February 16, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "12" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, February 17, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "13" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, February 18, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "14" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, February 19, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "15" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, February 20, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "16" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, February 21, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "17" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, February 22, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "18" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, February 23, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "19" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, February 24, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "20" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, February 25, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "21" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, February 26, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "22" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, February 27, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "23" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, February 28, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "24" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, March 01, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "25" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, March 02, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "26" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, March 03, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "27" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, March 04, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "28" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, March 05, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "29" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, March 06, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "30" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, March 07, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "31" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, March 08, 2019._________________");
                    return;
                }


    //JUNE 2018 AND 28-DAY CYCLE STARTS FROM HERE...
                else if (cmb3.Text.ToString() == "1" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, March 09, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "2" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, March 10, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "3" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, March 11, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "4" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, March 12, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "5" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, March 13, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "6" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, March 14, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "7" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, March 15, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "8" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, March 16, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "9" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, March 17, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "10" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, March 18, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "11" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, March 19, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "12" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, March 20, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "13" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, March 21, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "14" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, March 22, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "15" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, March 23, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "16" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, March 24, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "17" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, March 25, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "18" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, March 26, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "19" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, March 27, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "20" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, March 28, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "21" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, March 29, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "22" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, March 30, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "23" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, March 31, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "24" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, April 01, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "25" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, April 02, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "26" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, April 03, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "27" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, April 04, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "28" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, April 05, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "29" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, April 06, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "30" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, April 07, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "31" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Please correct the following errors \n\n***Invalid date given.");
                    return;
                }


    //JULY 2018 AND 28-DAY CYCLE STARTS FROM HERE...
                else if (cmb3.Text.ToString() == "1" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, April 08, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "2" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, April 09, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "3" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, April 10, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "4" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, April 11, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "5" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, April 12, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "6" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, April 13, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "7" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, April 14, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "8" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, April 15, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "9" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, April 16, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "10" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, April 17, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "11" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, April 18, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "12" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, April 19, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "13" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, April 20, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "14" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, April 21, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "15" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, April 22, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "16" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, April 23, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "17" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, April 24, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "18" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, April 25, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "19" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, April 26, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "20" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, April 27, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "21" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, April 28, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "22" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, April 29, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "23" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, April 30, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "24" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, May 01, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "25" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, May 02, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "26" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, May 03, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "27" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, May 04, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "28" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, May 05, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "29" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, May 06, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "30" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, May 07, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "31" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, May 08, 2019._________________");
                    return;
                }


    //AUGUST 2018 AND 28-DAY CYCLE STARTS FROM HERE...
                else if (cmb3.Text.ToString() == "1" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, May 09, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "2" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, May 10, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "3" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, May 11, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "4" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, May 12, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "5" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, May 13, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "6" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, May 14, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "7" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, May 15, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "8" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, May 16, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "9" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, May 17, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "10" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, May 18, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "11" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, May 19, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "12" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, May 20, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "13" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, May 21, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "14" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, May 22, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "15" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, May 23, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "16" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, May 24, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "17" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, May 25, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "18" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, May 26, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "19" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, May 27, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "20" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, May 28, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "21" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, May 29, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "22" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, May 30, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "23" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, May 31, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "24" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, June 01, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "25" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, June 02, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "26" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, June 03, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "27" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, June 04, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "28" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, June 05, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "29" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, June 06, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "30" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, June 07, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "31" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, June 08, 2019._________________");
                    return;
                }


    //SEPTEMBER 2018 AND 28-DAY CYCLE STARTS FROM HERE...
                else if (cmb3.Text.ToString() == "1" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, June 09, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "2" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, June 10, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "3" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, June 11, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "4" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, June 12, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "5" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, June 13, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "6" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, June 14, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "7" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, June 15, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "8" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, June 16, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "9" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, June 17, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "10" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, June 18, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "11" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, June 19, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "12" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, June 20, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "13" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, June 21, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "14" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, June 22, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "15" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, June 23, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "16" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, June 24, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "17" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, June 25, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "18" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, June 26, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "19" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, June 27, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "20" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, June 28, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "21" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, June 29, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "22" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, June 30, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "23" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, July 01, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "24" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, July 02, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "25" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, July 03, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "26" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, July 04, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "27" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, July 05, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "28" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, July 06, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "29" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, July 07, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "30" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, July 08, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "31" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Please correct the following errors \n\n***Invalid date given.");
                    return;
                }


    //OCTOBER 2018 AND 28-DAY CYCLE STARTS FROM HERE...
                else if (cmb3.Text.ToString() == "1" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, July 09, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "2" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, July 10, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "3" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, July 11, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "4" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, July 12, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "5" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, July 13, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "6" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, July 14, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "7" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, July 15, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "8" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, July 16, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "9" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, July 17, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "10" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, July 18, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "11" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, July 19, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "12" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, July 20, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "13" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, July 21, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "14" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, July 22, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "15" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, July 23, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "16" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, July 24, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "17" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, July 25, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "18" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, July 26, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "19" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, July 27, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "20" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, July 28, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "21" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, July 29, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "22" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, July 30, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "23" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, July 31, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "24" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, August 01, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "25" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, August 02, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "26" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, August 03, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "27" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, August 04, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "28" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, August 05, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "29" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, August 06, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "30" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, August 07, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "31" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, August 08, 2019._________________");
                    return;
                }


    //NOVEMBER 2018 AND 28-DAY CYCLE STARTS FROM HERE...
                else if (cmb3.Text.ToString() == "1" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, August 09, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "2" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, August 10, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "3" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, August 11, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "4" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, August 12, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "5" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, August 13, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "6" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, August 14, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "7" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, August 15, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "8" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, August 16, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "9" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, August 17, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "10" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, August 18, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "11" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, August 19, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "12" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, August 20, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "13" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, August 21, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "14" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, August 22, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "15" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, August 23, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "16" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, August 24, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "17" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, August 25, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "18" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, August 26, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "19" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, August 27, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "20" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, August 28, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "21" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, August 29, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "22" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, August 30, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "23" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, August 31, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "24" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, September 01, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "25" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, September 02, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "26" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, September 03, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "27" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, September 04, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "28" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, September 05, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "29" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, September 06, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "30" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, September 07, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "31" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Please correct the following errors \n\n***Invalid date given.");
                    return;
                }


    //DECEMBER 2018 AND 27-DAY CYCLE STARTS FROM HERE...
                else if (cmb3.Text.ToString() == "1" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, September 08, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "2" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, September 09, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "3" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, September 10, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "4" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, September 11, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "5" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, September 12, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "6" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, September 13, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "7" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, September 14, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "8" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, September 15, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "9" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, September 16, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "10" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, September 17, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "11" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, September 18, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "12" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, September 19, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "13" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, September 20, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "14" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, September 21, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "15" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, September 22, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "16" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, September 23, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "17" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, September 24, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "18" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, September 25, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "19" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, September 26, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "20" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, September 27, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "21" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, September 28, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "22" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, September 29, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "23" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, September 30, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "24" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, October 01, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "25" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, October 02, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "26" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, October 03, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "27" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, October 04, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "28" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, October 05, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "29" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, October 06, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "30" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, October 07, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "31" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "28")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, October 08, 2019._________________");
                    return;
                }


                //JANUARY 2018 AND 29-DAY CYCLE STARTS FROM HERE...
                if (cmb3.Text.ToString() == "1" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, October 09, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "2" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, October 10, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "3" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, October 11, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "4" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, October 12, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "5" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, October 13, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "6" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, October 14, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "7" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, October 15, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "8" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, October 16, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "9" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, October 17, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "10" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, October 18, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "11" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, October 19, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "12" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, October 20, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "13" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, October 21, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "14" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, October 22, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "15" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, October 23, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "16" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, October 24, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "17" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, October 25, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "18" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, October 26, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "19" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, October 27, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "20" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, October 28, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "21" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, October 29, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "22" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, October 30, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "23" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, October 31, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "24" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, November 01, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "25" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, November 02, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "26" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, November 03, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "27" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, November 04, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "28" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, November 05, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "29" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, November 06, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "30" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, November 07, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "31" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, November 08, 2018._________________");
                    return;
                }

    //FEBRUARY 2018 AND 29-DAY CYCLE STARTS FROM HERE...
                else if (cmb3.Text.ToString() == "1" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, November 09, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "2" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, November 10, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "3" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, November 11, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "4" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, November 12, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "5" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, November 13, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "6" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, November 14, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "7" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, November 15, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "8" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, November 16, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "9" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, November 17, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "10" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, November 18, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "11" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, November 19, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "12" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, November 20, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "13" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, November 21, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "14" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, November 22, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "15" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, November 23, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "16" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, November 24, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "17" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, November 25, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "18" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, November 26, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "19" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, November 27, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "20" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, November 28, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "21" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, November 29, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "22" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, November 30, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "23" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, December 01, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "24" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, December 02, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "25" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, December 03, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "26" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, December 04, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "27" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, December 05, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "28" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, December 06, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "29" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Please correct the following errors \n\n***Invalid date given.");
                    return;
                }
                else if (cmb3.Text.ToString() == "30" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Please correct the following errors \n\n***Invalid date given.");
                    return;
                }
                else if (cmb3.Text.ToString() == "31" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Please correct the following errors \n\n***Invalid date given.");
                    return;
                }

    //MARCH 2018 AND 28-DAY CYCLE STARTS FROM HERE...
                else if (cmb3.Text.ToString() == "1" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, December 07, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "2" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, December 08, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "3" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, December 09, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "4" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, December 10, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "5" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, December 11, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "6" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, December 12, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "7" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, December 13, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "8" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, December 14, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "9" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, December 15, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "10" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, December 16, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "11" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, December 17, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "12" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, December 18, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "13" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, December 19, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "14" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, December 20, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "15" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, December 21, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "16" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, December 22, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "17" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, December 23, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "18" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, December 24, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "19" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, December 25, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "20" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, December 26, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "21" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, December 27, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "22" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, December 28, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "23" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, December 29, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "24" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, December 30, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "25" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, December 31, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "26" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, January 01, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "27" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, January 02, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "28" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, January 03, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "29" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, January 04, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "30" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, January 05, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "31" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, January 06, 2019._________________");
                    return;
                }

    //APRIL 2018 AND 29-DAY CYCLE STARTS FROM HERE...
                else if (cmb3.Text.ToString() == "1" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, January 07, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "2" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, January 08, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "3" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, January 09, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "4" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, January 10, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "5" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, January 11, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "6" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, January 12, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "7" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, January 13, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "8" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, January 14, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "9" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, January 15, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "10" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, January 16, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "11" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, January 17, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "12" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, January 18, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "13" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, January 19, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "14" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, January 20, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "15" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, January 21, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "16" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, January 22, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "17" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, January 23, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "18" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, January 24, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "19" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, January 25, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "20" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, January 26, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "21" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, January 27, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "22" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, January 28, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "23" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, January 29, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "24" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, January 30, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "25" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, January 31, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "26" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, February 01, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "27" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, February 02, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "28" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, February 03, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "29" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, February 04, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "30" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, February 05, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "31" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Please correct the following errors \n\n***Invalid date given.");
                    return;
                }

    //MAY 2018 AND 29-DAY CYCLE STARTS FROM HERE...
                else if (cmb3.Text.ToString() == "1" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, February 06, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "2" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, February 07, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "3" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, February 08, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "4" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, February 09, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "5" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, February 10, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "6" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, February 11, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "7" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, February 12, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "8" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, February 13, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "9" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, February 14, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "10" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, February 15, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "11" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, February 16, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "12" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, February 17, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "13" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, February 18, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "14" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, February 19, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "15" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, February 20, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "16" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, February 21, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "17" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, February 22, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "18" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, February 23, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "19" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, February 24, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "20" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, February 25, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "21" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, February 26, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "22" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, February 27, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "23" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, February 28, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "24" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, March 01, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "25" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, March 02, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "26" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, March 03, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "27" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, March 04, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "28" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, March 05, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "29" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, March 06, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "30" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, March 07, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "31" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, March 08, 2019._________________");
                    return;
                }


    //JUNE 2018 AND 28-DAY CYCLE STARTS FROM HERE...
                else if (cmb3.Text.ToString() == "1" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, March 09, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "2" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, March 10, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "3" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, March 11, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "4" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, March 12, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "5" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, March 13, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "6" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, March 14, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "7" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, March 15, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "8" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, March 16, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "9" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, March 17, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "10" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, March 18, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "11" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, March 19, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "12" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, March 20, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "13" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, March 21, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "14" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, March 22, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "15" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, March 23, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "16" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, March 24, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "17" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, March 25, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "18" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, March 26, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "19" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, March 27, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "20" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, March 28, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "21" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, March 29, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "22" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, March 30, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "23" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, March 31, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "24" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, April 01, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "25" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, April 02, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "26" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, April 03, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "27" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, April 04, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "28" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, April 05, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "29" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, April 06, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "30" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, April 07, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "31" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Please correct the following errors \n\n***Invalid date given.");
                    return;
                }


    //JULY 2018 AND 28-DAY CYCLE STARTS FROM HERE...
                else if (cmb3.Text.ToString() == "1" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, April 08, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "2" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, April 09, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "3" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, April 10, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "4" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, April 11, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "5" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, April 12, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "6" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, April 13, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "7" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, April 14, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "8" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, April 15, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "9" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, April 16, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "10" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, April 17, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "11" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, April 18, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "12" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, April 19, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "13" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, April 20, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "14" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, April 21, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "15" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, April 22, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "16" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, April 23, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "17" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, April 24, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "18" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, April 25, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "19" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, April 26, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "20" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, April 27, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "21" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, April 28, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "22" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, April 29, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "23" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, April 30, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "24" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, May 01, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "25" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, May 02, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "26" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, May 03, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "27" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, May 04, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "28" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, May 05, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "29" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, May 06, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "30" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, May 07, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "31" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, May 08, 2019._________________");
                    return;
                }


    //AUGUST 2018 AND 29-DAY CYCLE STARTS FROM HERE...
                else if (cmb3.Text.ToString() == "1" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, May 09, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "2" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, May 10, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "3" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, May 11, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "4" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, May 12, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "5" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, May 13, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "6" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, May 14, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "7" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, May 15, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "8" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, May 16, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "9" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, May 17, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "10" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, May 18, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "11" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, May 19, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "12" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, May 20, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "13" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, May 21, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "14" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, May 22, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "15" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, May 23, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "16" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, May 24, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "17" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, May 25, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "18" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, May 26, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "19" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, May 27, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "20" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, May 28, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "21" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, May 29, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "22" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, May 30, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "23" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, May 31, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "24" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, June 01, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "25" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, June 02, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "26" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, June 03, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "27" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, June 04, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "28" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, June 05, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "29" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, June 06, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "30" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, June 07, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "31" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, June 08, 2019._________________");
                    return;
                }


    //SEPTEMBER 2018 AND 28-DAY CYCLE STARTS FROM HERE...
                else if (cmb3.Text.ToString() == "1" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, June 09, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "2" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, June 10, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "3" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, June 11, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "4" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, June 12, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "5" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, June 13, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "6" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, June 14, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "7" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, June 15, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "8" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, June 16, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "9" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, June 17, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "10" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, June 18, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "11" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, June 19, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "12" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, June 20, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "13" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, June 21, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "14" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, June 22, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "15" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, June 23, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "16" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, June 24, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "17" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, June 25, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "18" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, June 26, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "19" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, June 27, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "20" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, June 28, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "21" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, June 29, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "22" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, June 30, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "23" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, July 01, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "24" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, July 02, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "25" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, July 03, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "26" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, July 04, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "27" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, July 05, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "28" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, July 06, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "29" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, July 07, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "30" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, July 08, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "31" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Please correct the following errors \n\n***Invalid date given.");
                    return;
                }


    //OCTOBER 2018 AND 27-DAY CYCLE STARTS FROM HERE...
                else if (cmb3.Text.ToString() == "1" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, July 09, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "2" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, July 10, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "3" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, July 11, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "4" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, July 12, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "5" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, July 13, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "6" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, July 14, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "7" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, July 15, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "8" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, July 16, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "9" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, July 17, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "10" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, July 18, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "11" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, July 19, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "12" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, July 20, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "13" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, July 21, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "14" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, July 22, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "15" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, July 23, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "16" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, July 24, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "17" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, July 25, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "18" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, July 26, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "19" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, July 27, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "20" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, July 28, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "21" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, July 29, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "22" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, July 30, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "23" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, July 31, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "24" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, August 01, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "25" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, August 02, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "26" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, August 03, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "27" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, August 04, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "28" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, August 05, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "29" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, August 06, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "30" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, August 07, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "31" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, August 08, 2019._________________");
                    return;
                }


    //NOVEMBER 2018 AND 28-DAY CYCLE STARTS FROM HERE...
                else if (cmb3.Text.ToString() == "1" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, August 09, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "2" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, August 10, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "3" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, August 11, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "4" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, August 12, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "5" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, August 13, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "6" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, August 14, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "7" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, August 15, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "8" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, August 16, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "9" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n________________Saturday, August 17, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "10" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, August 18, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "11" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, August 19, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "12" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, August 20, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "13" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, August 21, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "14" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, August 22, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "15" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, August 23, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "16" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, August 24, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "17" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, August 25, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "18" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, August 26, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "19" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, August 27, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "20" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, August 28, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "21" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, August 29, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "22" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, August 30, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "23" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, August 31, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "24" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, September 01, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "25" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, September 02, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "26" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, September 03, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "27" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, September 04, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "28" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, September 05, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "29" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, September 06, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "30" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, September 07, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "31" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Please correct the following errors \n\n***Invalid date given.");
                    return;
                }


    //DECEMBER 2018 AND 27-DAY CYCLE STARTS FROM HERE...
                else if (cmb3.Text.ToString() == "1" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, September 08, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "2" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, September 09, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "3" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, September 10, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "4" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, September 11, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "5" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, September 12, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "6" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, September 13, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "7" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, September 14, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "8" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, September 15, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "9" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, September 16, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "10" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, September 17, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "11" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, September 18, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "12" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, September 19, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "13" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, September 20, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "14" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, September 21, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "15" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, September 22, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "16" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, September 23, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "17" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, September 24, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "18" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, September 25, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "19" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, September 26, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "20" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, September 27, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "21" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, September 28, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "22" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, September 29, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "23" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, September 30, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "24" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, October 01, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "25" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, October 02, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "26" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, October 03, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "27" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, October 04, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "28" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, October 05, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "29" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, October 06, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "30" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, October 07, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "31" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "29")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, October 08, 2019._________________");
                    return;
                }




                //JANUARY 2018 AND 30-DAY CYCLE STARTS FROM HERE...
                if (cmb3.Text.ToString() == "1" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, October 10, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "2" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, October 11, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "3" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, October 12, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "4" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, October 13, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "5" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, October 14, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "6" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, October 15, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "7" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, October 16, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "8" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, October 17, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "9" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, October 18, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "10" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, October 19, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "11" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, October 20, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "12" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, October 21, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "13" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, October 22, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "14" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, October 23, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "15" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, October 24, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "16" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, October 25, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "17" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, October 26, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "18" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, October 27, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "19" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, October 28, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "20" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, October 29, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "21" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, October 30, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "22" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, October 31, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "23" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, November 01, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "24" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, November 02, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "25" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, November 03, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "26" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, November 04, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "27" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, November 05, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "28" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, November 06, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "29" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, November 07, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "30" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, November 08, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "31" && cmb4.Text.ToString() == "January" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, November 09, 2018._________________");
                    return;
                }

    //FEBRUARY 2018 AND 30-DAY CYCLE STARTS FROM HERE...
                else if (cmb3.Text.ToString() == "1" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, November 10, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "2" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, November 11, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "3" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, November 12, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "4" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, November 13, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "5" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, November 14, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "6" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, November 15, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "7" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, November 16, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "8" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, November 17, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "9" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, November 18, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "10" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, November 19, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "11" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, November 20, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "12" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, November 21, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "13" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, November 22, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "14" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, November 23, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "15" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, November 24, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "16" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, November 25, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "17" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, November 26, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "18" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, November 27, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "19" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, November 28, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "20" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, November 29, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "21" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, November 30, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "22" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, December 01, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "23" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, December 02, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "24" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, December 03, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "25" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, December 04, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "26" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, December 05, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "27" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, December 06, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "28" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, December 07, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "29" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Please correct the following errors \n\n***Invalid date given.");
                    return;
                }
                else if (cmb3.Text.ToString() == "30" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Please correct the following errors \n\n***Invalid date given.");
                    return;
                }
                else if (cmb3.Text.ToString() == "31" && cmb4.Text.ToString() == "February" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Please correct the following errors \n\n***Invalid date given.");
                    return;
                }

    //MARCH 2018 AND 30-DAY CYCLE STARTS FROM HERE...
                else if (cmb3.Text.ToString() == "1" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, December 08, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "2" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, December 09, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "3" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, December 10, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "4" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, December 11, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "5" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, December 12, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "6" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, December 13, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "7" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, December 14, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "8" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, December 15, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "9" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, December 16, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "10" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, December 17, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "11" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, December 18, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "12" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, December 19, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "13" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, December 20, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "14" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, December 21, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "15" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, December 22, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "16" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, December 23, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "17" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, December 24, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "18" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, December 25, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "19" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, December 26, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "20" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, December 27, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "21" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, December 28, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "22" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, December 29, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "23" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, December 30, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "24" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, December 31, 2018._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "25" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, January 01, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "26" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, January 02, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "27" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, January 03, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "28" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, January 04, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "29" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, January 05, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "30" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, January 06, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "31" && cmb4.Text.ToString() == "March" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, January 07, 2019._________________");
                    return;
                }

    //APRIL 2018 AND 30-DAY CYCLE STARTS FROM HERE...
                else if (cmb3.Text.ToString() == "1" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, January 08, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "2" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, January 09, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "3" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, January 10, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "4" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, January 11, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "5" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, January 12, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "6" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, January 13, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "7" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, January 14, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "8" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, January 15, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "9" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, January 16, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "10" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, January 17, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "11" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, January 18, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "12" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, January 19, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "13" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, January 20, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "14" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, January 21, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "15" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, January 22, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "16" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, January 23, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "17" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, January 24, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "18" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, January 25, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "19" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, January 26, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "20" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, January 27, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "21" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, January 28, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "22" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, January 29, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "23" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, January 30, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "24" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, January 31, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "25" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, February 01, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "26" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, February 02, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "27" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, February 03, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "28" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, February 04, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "29" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, February 05, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "30" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, February 06, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "31" && cmb4.Text.ToString() == "April" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Please correct the following errors \n\n***Invalid date given.");
                    return;
                }

    //MAY 2018 AND 30-DAY CYCLE STARTS FROM HERE...
                else if (cmb3.Text.ToString() == "1" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, February 07, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "2" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, February 08, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "3" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, February 09, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "4" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, February 10, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "5" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, February 11, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "6" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, February 12, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "7" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, February 13, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "8" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, February 14, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "9" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, February 15, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "10" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, February 16, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "11" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, February 17, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "12" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, February 18, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "13" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, February 19, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "14" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, February 20, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "15" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, February 21, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "16" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, February 22, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "17" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, February 23, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "18" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, February 24, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "19" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, February 25, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "20" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, February 26, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "21" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, February 27, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "22" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, February 28, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "23" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, March 01, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "24" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, March 02, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "25" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, March 03, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "26" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, March 04, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "27" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, March 05, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "28" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, March 06, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "29" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, March 07, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "30" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, March 08, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "31" && cmb4.Text.ToString() == "May" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, March 09, 2019._________________");
                    return;
                }


    //JUNE 2018 AND 30-DAY CYCLE STARTS FROM HERE...
                else if (cmb3.Text.ToString() == "1" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, March 10, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "2" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, March 11, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "3" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, March 12, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "4" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, March 13, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "5" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, March 14, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "6" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, March 15, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "7" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, March 16, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "8" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, March 17, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "9" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, March 18, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "10" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, March 19, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "11" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, March 20, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "12" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, March 21, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "13" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, March 22, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "14" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, March 23, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "15" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, March 24, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "16" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, March 25, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "17" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, March 26, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "18" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, March 27, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "19" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, March 28, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "20" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, March 29, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "21" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, March 30, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "22" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, March 31, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "23" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, April 01, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "24" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Tuesday, April 02, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "25" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Wednesday, April 03, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "26" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Thursday, April 04, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "27" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Friday, April 05, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "28" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Saturday, April 06, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "29" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Sunday, April 07, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "30" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Congratulations! Your baby's birth date was on or around... \n\n_________________Monday, April 08, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "31" && cmb4.Text.ToString() == "June" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Please correct the following errors \n\n***Invalid date given.");
                    return;
                }


    //JULY 2018 AND 30-DAY CYCLE STARTS FROM HERE...
                else if (cmb3.Text.ToString() == "1" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, April 09, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "2" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, April 10, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "3" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, April 11, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "4" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, April 12, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "5" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, April 13, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "6" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, April 14, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "7" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, April 15, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "8" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, April 16, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "9" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, April 17, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "10" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, April 18, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "11" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, April 19, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "12" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, April 20, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "13" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, April 21, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "14" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, April 22, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "15" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, April 23, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "16" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, April 24, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "17" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, April 25, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "18" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, April 26, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "19" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, April 27, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "20" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, April 28, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "21" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, April 29, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "22" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, April 30, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "23" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, May 01, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "24" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, May 02, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "25" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, May 03, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "26" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, May 04, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "27" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, May 05, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "28" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, May 06, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "29" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, May 07, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "30" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, May 08, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "31" && cmb4.Text.ToString() == "July" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, May 09, 2019._________________");
                    return;
                }


    //AUGUST 2018 AND 30-DAY CYCLE STARTS FROM HERE...
                else if (cmb3.Text.ToString() == "1" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, May 10, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "2" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, May 11, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "3" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, May 12, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "4" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, May 13, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "5" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, May 14, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "6" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, May 15, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "7" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, May 16, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "8" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, May 17, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "9" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, May 18, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "10" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, May 19, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "11" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, May 20, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "12" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, May 21, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "13" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, May 22, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "14" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, May 23, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "15" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, May 24, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "16" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, May 25, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "17" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, May 26, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "18" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, May 27, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "19" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, May 28, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "20" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, May 29, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "21" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, May 30, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "22" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, May 31, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "23" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, June 01, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "24" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, June 02, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "25" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, June 03, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "26" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, June 04, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "27" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, June 05, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "28" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, June 06, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "29" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, June 07, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "30" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, June 08, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "31" && cmb4.Text.ToString() == "August" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, June 09, 2019._________________");
                    return;
                }


    //SEPTEMBER 2018 AND 30-DAY CYCLE STARTS FROM HERE...
                else if (cmb3.Text.ToString() == "1" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, June 10, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "2" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, June 11, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "3" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, June 12, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "4" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, June 13, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "5" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, June 14, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "6" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, June 15, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "7" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, June 16, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "8" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, June 17, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "9" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, June 18, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "10" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, June 19, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "11" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, June 20, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "12" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, June 21, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "13" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, June 22, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "14" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, June 23, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "15" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, June 24, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "16" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, June 25, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "17" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, June 26, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "18" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, June 27, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "19" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, June 28, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "20" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, June 29, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "21" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, June 30, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "22" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, July 01, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "23" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, July 02, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "24" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, July 03, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "25" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, July 04, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "26" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, July 05, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "27" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, July 06, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "28" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, July 07, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "29" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, July 08, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "30" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, July 09, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "31" && cmb4.Text.ToString() == "September" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Please correct the following errors \n\n***Invalid date given.");
                    return;
                }


    //OCTOBER 2018 AND 30-DAY CYCLE STARTS FROM HERE...
                else if (cmb3.Text.ToString() == "1" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, July 10, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "2" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, July 11, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "3" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, July 12, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "4" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, July 13, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "5" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, July 14, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "6" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, July 15, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "7" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, July 16, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "8" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, July 17, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "9" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, July 18, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "10" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, July 19, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "11" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, July 20, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "12" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, July 21, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "13" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, July 22, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "14" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, July 23, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "15" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, July 24, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "16" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, July 25, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "17" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, July 26, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "18" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, July 27, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "19" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, July 28, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "20" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, July 29, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "21" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, July 30, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "22" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, July 31, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "23" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, August 01, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "24" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, August 02, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "25" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, August 03, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "26" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, August 04, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "27" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, August 05, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "28" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, August 06, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "29" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, August 07, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "30" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, August 08, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "31" && cmb4.Text.ToString() == "October" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, August 09, 2019._________________");
                    return;
                }


    //NOVEMBER 2018 AND 30-DAY CYCLE STARTS FROM HERE...
                else if (cmb3.Text.ToString() == "1" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, August 10, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "2" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, August 11, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "3" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, August 12, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "4" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, August 13, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "5" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, August 14, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "6" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, August 15, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "7" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, August 16, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "8" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, August 17, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "9" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n________________Sunday, August 18, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "10" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, August 19, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "11" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, August 20, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "12" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, August 21, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "13" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, August 22, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "14" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, August 23, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "15" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, August 24, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "16" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, August 25, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "17" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, August 26, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "18" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, August 27, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "19" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, August 28, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "20" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, August 29, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "21" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, August 30, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "22" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, August 31, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "23" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, September 01, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "24" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, September 02, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "25" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, September 03, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "26" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, September 04, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "27" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, September 05, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "28" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, September 06, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "29" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, September 07, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "30" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, September 08, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "31" && cmb4.Text.ToString() == "November" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Please correct the following errors \n\n***Invalid date given.");
                    return;
                }


    //DECEMBER 2018 AND 30-DAY CYCLE STARTS FROM HERE...
                else if (cmb3.Text.ToString() == "1" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, September 09, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "2" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, September 10, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "3" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, September 11, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "4" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, September 12, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "5" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, September 13, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "6" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, September 14, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "7" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, September 15, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "8" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, September 16, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "9" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, September 17, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "10" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, September 18, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "11" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, September 19, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "12" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, September 20, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "13" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, September 21, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "14" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, September 22, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "15" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, September 23, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "16" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, September 24, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "17" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, September 25, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "18" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, September 26, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "19" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, September 27, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "20" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, September 28, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "21" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, September 29, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "22" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, September 30, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "23" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, October 01, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "24" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, October 02, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "25" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Thursday, October 03, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "26" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Friday, October 04, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "27" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Saturday, October 05, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "28" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Sunday, October 06, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "29" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Monday, October 07, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "30" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Tuesday, October 08, 2019._________________");
                    return;
                }
                else if (cmb3.Text.ToString() == "31" && cmb4.Text.ToString() == "December" && cmb5.Text.ToString() == "2018" && cmb6.Text.ToString() == "30")
                {
                    MessageBox.Show("Your baby's estimated due date is on or around... \n\n_________________Wednesday, October 09, 2019._________________");
                    return;
                }
            }
            
            
            catch (Exception)
            {
                //Do something
                MessageBox.Show("Sorry, please try again");
                    
            }


        }
        private void btn_back2_Click(object sender, EventArgs e)
        {
            MainForm fm = new MainForm();
            fm.Close();

            this.Close();
        }

    }
}
