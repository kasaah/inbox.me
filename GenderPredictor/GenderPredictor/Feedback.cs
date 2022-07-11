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
    public partial class Feedback : Form
    {
        public Feedback()
        {
            InitializeComponent();

            //MAKE THE FIRST BOX FOCUSED
            this.ActiveControl = fdbtxt1;

        }

        private void Feedback_Load(object sender, EventArgs e)
        {

        }

        private void fdbbtn1_Click(object sender, EventArgs e)
        {
            try
            {
                //METHOD NOT TO ACCEPT NULLS IN THE VARIOUS TEXT FIELDS
                if (String.IsNullOrEmpty(fdbtxt1.Text))
                {
                    MessageBox.Show("Field can't be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (String.IsNullOrEmpty(fdbtxt2.Text))
                {
                    MessageBox.Show("Field can't be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (String.IsNullOrEmpty(fdbtxt3.Text))
                {
                    MessageBox.Show("Field can't be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    //CONNECTION OF THE DATABASE TO THE APPLICATION
                    SqlConnection connection = new SqlConnection("Data Source=tonny-pc\\sqlexpress;Initial Catalog=feedback;Integrated Security=True");
                    connection.Open();

                    //ACCEPT INPUTS FROM THE USER
                    string newcom = "insert into feedback(name,email,comment) VALUES ('" + fdbtxt1.Text + "','" + fdbtxt2.Text + "','" + fdbtxt3 + "')";

                    SqlCommand cmd = new SqlCommand(newcom, connection);    //sqlcommand query
                    cmd.ExecuteNonQuery();

                    fdblbl.Text = "Complaint successfully sent!";           //message to show succesful submission 

                    fdbtxt1.Clear();                                        //clear text after sending
                    fdbtxt2.Clear();                                        //clear text after sending
                    fdbtxt3.Clear();                                        //clear text after sending
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Sorry, try again another time");
            }
        }

        private void fdbtxt3_TextChanged(object sender, EventArgs e)
        {
            fdbtxt3.ScrollBars = ScrollBars.Vertical;       //ADD SCROLLBAR TO THE COMMENT TEXTBOX
        }

//BACK TO THE MAIN FORM
        private void btn_back1_Click(object sender, EventArgs e)
        {
            MainForm fm = new MainForm();
            fm.Close();

            this.Close();
        }
    }
}
