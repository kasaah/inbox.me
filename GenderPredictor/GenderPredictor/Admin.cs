using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GenderPredictor
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void fdbbtn1_Click(object sender, EventArgs e)
        {
            //CONNECTION OF THE DATABASE TO THE APPLICATION
            SqlConnection connection = new SqlConnection("Data Source=UNICORN;Initial Catalog=feedback;Integrated Security=True");
            connection.Open();

            //ACCEPT INPUTS FROM THE USER
            string newcom = "insert into feedback(name,email,comment) VALUES ('" + fdbtxt1.Text + "','" + fdbtxt2.Text + "','" + fdbtxt3 + "')";

            SqlCommand cmd = new SqlCommand(newcom, connection);    //sqlcommand query
            cmd.ExecuteNonQuery();
        }
    }
}
