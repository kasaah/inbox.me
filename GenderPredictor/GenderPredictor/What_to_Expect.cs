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
    public partial class What_to_Expect : Form
    {
        public What_to_Expect()
        {
            InitializeComponent();
        }

        private void btntri1_Click(object sender, EventArgs e)
        {
            _1st_trimester firsttri = new _1st_trimester();     //OPEN FIRST TRIMESTER WINDOW
            firsttri.ShowDialog();
        }

        private void btntri2_Click(object sender, EventArgs e)
        {
            _2nd_trimester secondtri = new _2nd_trimester();        //OPEN SECOND TRIMESTER WINDOW
            secondtri.ShowDialog();
        }

        private void btntri3_Click(object sender, EventArgs e)
        {
            _3rd_trimester thirdtri = new _3rd_trimester();     //OPEN THIRD TRIMESTER WINDOW
            thirdtri.ShowDialog();
        }

        private void btn_backtri_Click(object sender, EventArgs e)
        {
            this.Close();                                     //BACK TO THE MAIN FORM
        }
    }
}
