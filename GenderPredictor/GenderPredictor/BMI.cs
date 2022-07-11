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
    public partial class BMI : Form
    {
//VARIABLE CREATION
        double weight;
        double height;
        double result;

        public BMI()
        {
            

            InitializeComponent();

                        
            this.ActiveControl = txt2;                              // METHOD TO BE ABLE TO TYPE IN THE TXTBOX...    

        }

//METHOD FOR ACCEPTING AND CALCULATING BODY MASS INDEX(BMI)
        private void btn_bmi_Click(object sender, EventArgs e)
        {
            try
            {

                weight = double.Parse(txt2.Text);                          //ACCEPT INPUT FROM USER
                height = double.Parse(txt1.Text);                          //ACCEPT INPUT FROM USER
         

                //METHOD NOT TO ACCEPT NULL
                if (String.IsNullOrEmpty(txt1.Text))
                {
                    MessageBox.Show("Field can't be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (String.IsNullOrEmpty(txt2.Text))
                {
                    MessageBox.Show("Field can't be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                //METHOD NOT TO ACCEPT SOME VALUES
                if (weight==635 || weight>635)
                
                {
                    MessageBox.Show("You cant enter value above 635.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt1.Clear();
                }
                if (height > 2.7 || height == 2.7)
                {
                    MessageBox.Show("You cant enter value above 2.7.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt2.Clear();
                    MessageBox.Show("Re-enter values correctly");
                }



                else
                {
                    result = weight / height;                                //CALCULATE BMI
                    result = Math.Round(result, 2);                         //CONVERT BMI TO 2 DECIMAL PLACES
                    lblBMI.Text = "Your BMI is " + result.ToString();       //PASS RESULT TO LABEL

                    BMI_Message();                                          //METHOD CALL OF BMI MESSAGE

                }


            }

            catch (Exception )
            {
                MessageBox.Show("Sorry, try again by checking if values are enter correctly");
            }
        }
    

//BMI METHOD
        public void BMI_Message()
        {
            if (result <= 18.5)
            {
                lblMESSAGE.Text = "You are underweight ";

                rtxt.Text = "TIPS TO GAIN NORMAL WEIGHT\n\n\b" 
                             +"Eat breakfast every day. \n\n\b" 
                             +"Peanut butter or a slice of cheese on toast can give you an extra protein boost.\n\n\b"
                             +"Snack between meals; yogurt and dried fruits can provide protein, calcium, and minerals.\n\n\b"
                             +"Try to eat more foods that are high in good fats such as nuts, fatty fish, avocados, and olive oil.\n\n\b"
                             +"Drink juices made from real fruit that are high in vitamin C or beta carotene, such as grapefruit juice, orange juice, papaya nectar, apricot nectar, and carrot juice.\n\n\b"
                             +"Avoid junk food.\n\n\b"
                             +"Consult your health care provider about taking prenatal vitamins and any additional supplements.";
            }
            else if (result > 18.5 && result <= 25)
            {
                lblMESSAGE.Text = "You have a normal weight ";

                rtxt.Text = "TIPS TO MAINTAIN NORMAL WEIGHT\n\n\b"
                             + "Start pregnancy at a healthy weight if possible.\n\n\b"
                             + "Eat moderately and often.\n\n\b"
                             + "Drink up (water).\n\n\b"
                             + "Make your cravings constructive.\n\n\b"
                             + "Make starches work harder.\n\n\b"
                             + "Start a simple walking regime.";
            }
            else if (result > 25 && result <= 29.9)
            {
                lblMESSAGE.Text = "Your are overweight";

                rtxt.Text = "TIPS TO LOSE WEIGHT\n\n\b"
                            + "Eat a high-protein breakfast.\n\n\b"
                            + "Avoid sugary drinks and fruit juice.\n\n\b"
                            + "Drink water a half hour before meals.\n\n\b"
                            + "Choose weight loss-friendly foods (see list).\n\n\b"
                            + "Eat soluble fiber.\n\n\b"
                            + "Drink coffee or tea.\n\n\b"
                            + "Eat mostly whole, unprocessed foods.\n\n\b"
                            + "Eat your food slowly.";
            }
            else if (result > 30)
            {
                lblMESSAGE.Text = "You are obese";

                rtxt.Text = "OVERCOMING  THE WOES OF OBESITY\n\n\b"
                            + "Eat more fruit, vegetables, nuts, and whole grains.\n\n\b"
                            + "Exercise, even moderately, for at least 30 minutes a day.\n\n\b"
                            + "Cut down your consumption of fatty and sugary foods.\n\n\b"
                            + "Use vegetable-based oils rather than animal-based fats.\n\n\b"
                            + "Promoting healthy eating habits and encouraging exercise.\n\n\b"
                            + "Developing public policies that promote access to healthy, low-fat, high-fiber foods\n\n\b"
                            + "Training healthcare professionals so that they can effectively support people who need to lose weight and help others avoid gaining weight";
            }
             
        }
        

//CLICK TO SEND YOU BACK TO THE MAIN PAGE
        private void btn_back1_Click(object sender, EventArgs e)
        {
            MainForm fm = new MainForm();
            fm.Close();

            this.Close();
        }


//TEXTBOX 1 VALIDATION
        private void txt1_TextChanged(object sender, EventArgs e)
        {
            double num;
            bool isNum = double.TryParse(txt1.Text.Trim(), out num);
            
            {
                if (!isNum && txt1.Text != string.Empty)
                {
                    MessageBox.Show("Enter numerical value", "Invalid Value Detected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt1.Clear();
                }

                
            }

        }


//TEXTBOX 2 VALIDATION...
        private void txt2_TextChanged(object sender, EventArgs e)
        {
            double num2;
            bool isNum = double.TryParse(txt2.Text.Trim(), out num2);

            if (!isNum && txt2.Text != string.Empty)
            {

                MessageBox.Show("Enter numerical value", "Invalid Value Detected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt2.Clear();
            }
            
         }
        



//RESET OR CLEAR THE CONTENT OF THE TEXTBOX
        private void resetbtn_Click(object sender, EventArgs e)
        {
            txt1.Clear();
            txt2.Clear();
            rtxt.Clear();
            this.ActiveControl = txt2;
        }

        private void txt2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        

    }
}




/*

 //   height = float.Parse(txt1.Text);
                //    weight = float.Parse(txt2.Text);



                if (height == 2.72 && height > 2.75)
                {
                    MessageBox.Show("You can't enter a height above that value");
                }

                else if (weight == 635 && weight > 635)
                {
                    MessageBox.Show("You can't enter weight above 635");
                }






*/