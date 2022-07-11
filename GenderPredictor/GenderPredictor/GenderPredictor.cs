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
    public partial class GenderPredictor : Form
    {
        public GenderPredictor()
        {
            InitializeComponent();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
             if (rbt1.Checked)
            {
                MessageBox.Show("Chances are that you will deliver a boy is"  
                                + "\n\nreduced by 5% due to the fertility drug taken."
                                + "\n\nClick on OK to reveal the gender of your baby.");
            }
            else if (rbt2.Checked)
            {
                MessageBox.Show("Chances are that you will deliver a boy is reduced" 
                                 + "\n\nby 5% due to your exposure to farming chemicals."
                                 + "\n\n__Click on OK to reveal the gender of your baby.__");
            }
            else if (rbt3.Checked)
            {
                MessageBox.Show("Your condition makes it more likely that you will deliver a girl" 
                                 + "\n\n________Click on OK to reveal the gender of your baby.________");
            }


//AGE EIGHTEEN (18) STARTS FROM HERE...
               if (cmb1.Text.ToString() == "18" && cmb2.Text.ToString() == "January")
                {
                    MessageBox.Show("Be expecting a bouncing baby GIRL.");
                    return;
                }
                else if (cmb1.Text.ToString() == "18" && cmb2.Text.ToString() == "February")
                {
                    MessageBox.Show("Be ready to mother a SON.");
                    return;
                }
                else if (cmb1.Text.ToString() == "18" && cmb2.Text.ToString() == "March")
                {
                    MessageBox.Show("Be expecting a bouncing baby GIRL.");
                    return;
                }
                else if (cmb1.Text.ToString() == "18" && cmb2.Text.ToString() == "April")
                {
                    MessageBox.Show("Be ready to mother a SON.");
                    return;
                }
                else if (cmb1.Text.ToString() == "18" && cmb2.Text.ToString() == "May")
                {
                    MessageBox.Show("Be ready to mother a SON.");
                    return;
                }
                else if (cmb1.Text.ToString() == "18" && cmb2.Text.ToString() == "June")
                {
                    MessageBox.Show("Be ready to mother a SON.");
                    return;
                }
                else if (cmb1.Text.ToString() == "18" && cmb2.Text.ToString() == "July")
                {
                    MessageBox.Show("Be ready to mother a SON.");
                    return;
                }
                else if (cmb1.Text.ToString() == "18" && cmb2.Text.ToString() == "August")
                {
                    MessageBox.Show("Be ready to mother a SON.");
                    return;
                }
                else if (cmb1.Text.ToString() == "18" && cmb2.Text.ToString() == "September")
                {
                    MessageBox.Show("Be ready to mother a SON.");
                    return;
                }
                else if (cmb1.Text.ToString() == "18" && cmb2.Text.ToString() == "October")
                {
                    MessageBox.Show("Be ready to mother a SON.");
                    return;
                }
                else if (cmb1.Text.ToString() == "18" && cmb2.Text.ToString() == "November")
                {
                    MessageBox.Show("Be ready to mother a SON.");
                    return;
                }
                else if (cmb1.Text.ToString() == "18" && cmb2.Text.ToString() == "December")
                {
                    MessageBox.Show("Be ready to mother a SON.");
                    return;
                }


//AGE NINETEEN (19) STARTS FROM HERE...
            else if (cmb1.Text.ToString() == "19" && cmb2.Text.ToString() == "January")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "19" && cmb2.Text.ToString() == "February")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "19" && cmb2.Text.ToString() == "March")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "19" && cmb2.Text.ToString() == "April")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "19" && cmb2.Text.ToString() == "May")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "19" && cmb2.Text.ToString() == "June")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "19" && cmb2.Text.ToString() == "July")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "19" && cmb2.Text.ToString() == "August")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "19" && cmb2.Text.ToString() == "September")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "19" && cmb2.Text.ToString() == "October")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "19" && cmb2.Text.ToString() == "November")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "19" && cmb2.Text.ToString() == "December")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }

//AGE TWENTY (20) STARTS FROM HERE...
            else if (cmb1.Text.ToString() == "20" && cmb2.Text.ToString() == "January")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "20" && cmb2.Text.ToString() == "February")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "20" && cmb2.Text.ToString() == "March")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "20" && cmb2.Text.ToString() == "April")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "20" && cmb2.Text.ToString() == "May")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "20" && cmb2.Text.ToString() == "June")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "20" && cmb2.Text.ToString() == "July")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "20" && cmb2.Text.ToString() == "August")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "20" && cmb2.Text.ToString() == "September")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "20" && cmb2.Text.ToString() == "October")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "20" && cmb2.Text.ToString() == "November")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "20" && cmb2.Text.ToString() == "December")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }

//AGE TWENTY-ONE (21) STARTS FROM HERE...
            else if (cmb1.Text.ToString() == "21" && cmb2.Text.ToString() == "January")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "21" && cmb2.Text.ToString() == "February")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "21" && cmb2.Text.ToString() == "March")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "21" && cmb2.Text.ToString() == "April")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "21" && cmb2.Text.ToString() == "May")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "21" && cmb2.Text.ToString() == "June")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "21" && cmb2.Text.ToString() == "July")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "21" && cmb2.Text.ToString() == "August")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "21" && cmb2.Text.ToString() == "September")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "21" && cmb2.Text.ToString() == "October")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "21" && cmb2.Text.ToString() == "November")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "21" && cmb2.Text.ToString() == "December")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }

//AGE TWENTY-TWO (22) STARTS FROM HERE...
            else if (cmb1.Text.ToString() == "22" && cmb2.Text.ToString() == "January")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "22" && cmb2.Text.ToString() == "February")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "22" && cmb2.Text.ToString() == "March")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "22" && cmb2.Text.ToString() == "April")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "22" && cmb2.Text.ToString() == "May")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "22" && cmb2.Text.ToString() == "June")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "22" && cmb2.Text.ToString() == "July")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "22" && cmb2.Text.ToString() == "August")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "22" && cmb2.Text.ToString() == "September")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "22" && cmb2.Text.ToString() == "October")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "22" && cmb2.Text.ToString() == "November")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "22" && cmb2.Text.ToString() == "December")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }

//AGE TWENTY-THREE (23) STARTS FROM HERE...
            else if (cmb1.Text.ToString() == "23" && cmb2.Text.ToString() == "January")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "23" && cmb2.Text.ToString() == "February")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "23" && cmb2.Text.ToString() == "March")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "23" && cmb2.Text.ToString() == "April")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "23" && cmb2.Text.ToString() == "May")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "23" && cmb2.Text.ToString() == "June")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "23" && cmb2.Text.ToString() == "July")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "23" && cmb2.Text.ToString() == "August")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "23" && cmb2.Text.ToString() == "September")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "23" && cmb2.Text.ToString() == "October")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "23" && cmb2.Text.ToString() == "November")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "23" && cmb2.Text.ToString() == "December")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }

//AGE TWENTY-FOUR (24) STARTS FROM HERE...
            else if (cmb1.Text.ToString() == "24" && cmb2.Text.ToString() == "January")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "24" && cmb2.Text.ToString() == "February")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "24" && cmb2.Text.ToString() == "March")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "24" && cmb2.Text.ToString() == "April")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "24" && cmb2.Text.ToString() == "May")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "24" && cmb2.Text.ToString() == "June")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "24" && cmb2.Text.ToString() == "July")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "24" && cmb2.Text.ToString() == "August")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "24" && cmb2.Text.ToString() == "September")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "24" && cmb2.Text.ToString() == "October")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "24" && cmb2.Text.ToString() == "November")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "24" && cmb2.Text.ToString() == "December")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }

//AGE TWENTY-FIVE (25) STARTS FROM HERE...
            else if (cmb1.Text.ToString() == "25" && cmb2.Text.ToString() == "January")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "25" && cmb2.Text.ToString() == "February")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "25" && cmb2.Text.ToString() == "March")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "25" && cmb2.Text.ToString() == "April")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "25" && cmb2.Text.ToString() == "May")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "25" && cmb2.Text.ToString() == "June")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "25" && cmb2.Text.ToString() == "July")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "25" && cmb2.Text.ToString() == "August")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "25" && cmb2.Text.ToString() == "September")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "25" && cmb2.Text.ToString() == "October")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "25" && cmb2.Text.ToString() == "November")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "25" && cmb2.Text.ToString() == "December")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }

//AGE TWENTY-SIX (26) STARTS FROM HERE...
            else if (cmb1.Text.ToString() == "26" && cmb2.Text.ToString() == "January")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "26" && cmb2.Text.ToString() == "February")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "26" && cmb2.Text.ToString() == "March")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "26" && cmb2.Text.ToString() == "April")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "26" && cmb2.Text.ToString() == "May")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "26" && cmb2.Text.ToString() == "June")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "26" && cmb2.Text.ToString() == "July")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "26" && cmb2.Text.ToString() == "August")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "26" && cmb2.Text.ToString() == "September")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "26" && cmb2.Text.ToString() == "October")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "26" && cmb2.Text.ToString() == "November")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "26" && cmb2.Text.ToString() == "December")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }

//AGE TWENTY-SEVEN (27) STARTS FROM HERE...
            else if (cmb1.Text.ToString() == "27" && cmb2.Text.ToString() == "January")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "27" && cmb2.Text.ToString() == "February")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "27" && cmb2.Text.ToString() == "March")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "27" && cmb2.Text.ToString() == "April")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "27" && cmb2.Text.ToString() == "May")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "27" && cmb2.Text.ToString() == "June")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "27" && cmb2.Text.ToString() == "July")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "27" && cmb2.Text.ToString() == "August")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "27" && cmb2.Text.ToString() == "September")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "27" && cmb2.Text.ToString() == "October")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "27" && cmb2.Text.ToString() == "November")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "27" && cmb2.Text.ToString() == "December")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }

//AGE TWENTY-EIGHT (28) STARTS FROM HERE...
            else if (cmb1.Text.ToString() == "28" && cmb2.Text.ToString() == "January")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "28" && cmb2.Text.ToString() == "February")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "28" && cmb2.Text.ToString() == "March")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "28" && cmb2.Text.ToString() == "April")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "28" && cmb2.Text.ToString() == "May")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "28" && cmb2.Text.ToString() == "June")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "28" && cmb2.Text.ToString() == "July")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "28" && cmb2.Text.ToString() == "August")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "28" && cmb2.Text.ToString() == "September")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "28" && cmb2.Text.ToString() == "October")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "28" && cmb2.Text.ToString() == "November")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "28" && cmb2.Text.ToString() == "December")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }

//AGE TWENTY-NINE (29) STARTS FROM HERE...
            else if (cmb1.Text.ToString() == "29" && cmb2.Text.ToString() == "January")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "29" && cmb2.Text.ToString() == "February")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "29" && cmb2.Text.ToString() == "March")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "29" && cmb2.Text.ToString() == "April")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "29" && cmb2.Text.ToString() == "May")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "29" && cmb2.Text.ToString() == "June")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "29" && cmb2.Text.ToString() == "July")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "29" && cmb2.Text.ToString() == "August")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "29" && cmb2.Text.ToString() == "September")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "29" && cmb2.Text.ToString() == "October")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "29" && cmb2.Text.ToString() == "November")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "29" && cmb2.Text.ToString() == "December")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }

//AGE THIRTY (30) STARTS FROM HERE...
            else if (cmb1.Text.ToString() == "30" && cmb2.Text.ToString() == "January")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "30" && cmb2.Text.ToString() == "February")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "30" && cmb2.Text.ToString() == "March")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "30" && cmb2.Text.ToString() == "April")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "30" && cmb2.Text.ToString() == "May")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "30" && cmb2.Text.ToString() == "June")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "30" && cmb2.Text.ToString() == "July")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "30" && cmb2.Text.ToString() == "August")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "30" && cmb2.Text.ToString() == "September")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "30" && cmb2.Text.ToString() == "October")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "30" && cmb2.Text.ToString() == "November")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "30" && cmb2.Text.ToString() == "December")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }

//AGE THIRTY-ONE (31) STARTS FROM HERE...
            else if (cmb1.Text.ToString() == "31" && cmb2.Text.ToString() == "January")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "31" && cmb2.Text.ToString() == "February")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "31" && cmb2.Text.ToString() == "March")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "31" && cmb2.Text.ToString() == "April")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "31" && cmb2.Text.ToString() == "May")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "31" && cmb2.Text.ToString() == "June")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "31" && cmb2.Text.ToString() == "July")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "31" && cmb2.Text.ToString() == "August")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "31" && cmb2.Text.ToString() == "September")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "31" && cmb2.Text.ToString() == "October")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "31" && cmb2.Text.ToString() == "November")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "31" && cmb2.Text.ToString() == "December")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }

//AGE THIRTY-TWO (32) STARTS FROM HERE...
            else if (cmb1.Text.ToString() == "32" && cmb2.Text.ToString() == "January")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "32" && cmb2.Text.ToString() == "February")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "32" && cmb2.Text.ToString() == "March")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "32" && cmb2.Text.ToString() == "April")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "32" && cmb2.Text.ToString() == "May")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "32" && cmb2.Text.ToString() == "June")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "32" && cmb2.Text.ToString() == "July")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "32" && cmb2.Text.ToString() == "August")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "32" && cmb2.Text.ToString() == "September")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "32" && cmb2.Text.ToString() == "October")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "32" && cmb2.Text.ToString() == "November")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "32" && cmb2.Text.ToString() == "December")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }

//AGE THIRTY-THREE (33) STARTS FROM HERE...
            else if (cmb1.Text.ToString() == "33" && cmb2.Text.ToString() == "January")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "33" && cmb2.Text.ToString() == "February")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "33" && cmb2.Text.ToString() == "March")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "33" && cmb2.Text.ToString() == "April")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "33" && cmb2.Text.ToString() == "May")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "33" && cmb2.Text.ToString() == "June")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "33" && cmb2.Text.ToString() == "July")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "33" && cmb2.Text.ToString() == "August")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "33" && cmb2.Text.ToString() == "September")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "33" && cmb2.Text.ToString() == "October")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "33" && cmb2.Text.ToString() == "November")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "33" && cmb2.Text.ToString() == "December")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }

//AGE THIRTY-FOUR (34) STARTS FROM HERE...
            else if (cmb1.Text.ToString() == "34" && cmb2.Text.ToString() == "January")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "34" && cmb2.Text.ToString() == "February")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "34" && cmb2.Text.ToString() == "March")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "34" && cmb2.Text.ToString() == "April")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "34" && cmb2.Text.ToString() == "May")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "34" && cmb2.Text.ToString() == "June")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "34" && cmb2.Text.ToString() == "July")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "34" && cmb2.Text.ToString() == "August")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "34" && cmb2.Text.ToString() == "September")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "34" && cmb2.Text.ToString() == "October")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "34" && cmb2.Text.ToString() == "November")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "34" && cmb2.Text.ToString() == "December")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }

//AGE THIRTY-FIVE (35) STARTS FROM HERE...
            else if (cmb1.Text.ToString() == "35" && cmb2.Text.ToString() == "January")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "35" && cmb2.Text.ToString() == "February")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "35" && cmb2.Text.ToString() == "March")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "35" && cmb2.Text.ToString() == "April")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "35" && cmb2.Text.ToString() == "May")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "35" && cmb2.Text.ToString() == "June")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "35" && cmb2.Text.ToString() == "July")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "35" && cmb2.Text.ToString() == "August")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "35" && cmb2.Text.ToString() == "September")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "35" && cmb2.Text.ToString() == "October")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "35" && cmb2.Text.ToString() == "November")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "35" && cmb2.Text.ToString() == "December")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }

//AGE THIRTY-SIX (36) STARTS FROM HERE...
            else if (cmb1.Text.ToString() == "36" && cmb2.Text.ToString() == "January")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "36" && cmb2.Text.ToString() == "February")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "36" && cmb2.Text.ToString() == "March")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "36" && cmb2.Text.ToString() == "April")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "36" && cmb2.Text.ToString() == "May")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "36" && cmb2.Text.ToString() == "June")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "36" && cmb2.Text.ToString() == "July")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "36" && cmb2.Text.ToString() == "August")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "36" && cmb2.Text.ToString() == "September")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "36" && cmb2.Text.ToString() == "October")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "36" && cmb2.Text.ToString() == "November")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "36" && cmb2.Text.ToString() == "December")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }

//AGE THIRTY-SEVEN (37) STARTS FROM HERE...
            else if (cmb1.Text.ToString() == "37" && cmb2.Text.ToString() == "January")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "37" && cmb2.Text.ToString() == "February")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "37" && cmb2.Text.ToString() == "March")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "37" && cmb2.Text.ToString() == "April")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "37" && cmb2.Text.ToString() == "May")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "37" && cmb2.Text.ToString() == "June")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "37" && cmb2.Text.ToString() == "July")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "37" && cmb2.Text.ToString() == "August")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "37" && cmb2.Text.ToString() == "September")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "37" && cmb2.Text.ToString() == "October")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "37" && cmb2.Text.ToString() == "November")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "37" && cmb2.Text.ToString() == "December")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }

//AGE THIRTY-EIGHT (38) STARTS FROM HERE...
            else if (cmb1.Text.ToString() == "38" && cmb2.Text.ToString() == "January")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "38" && cmb2.Text.ToString() == "February")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "38" && cmb2.Text.ToString() == "March")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "38" && cmb2.Text.ToString() == "April")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "38" && cmb2.Text.ToString() == "May")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "38" && cmb2.Text.ToString() == "June")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "38" && cmb2.Text.ToString() == "July")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "38" && cmb2.Text.ToString() == "August")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "38" && cmb2.Text.ToString() == "September")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "38" && cmb2.Text.ToString() == "October")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "38" && cmb2.Text.ToString() == "November")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "38" && cmb2.Text.ToString() == "December")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }

//AGE THIRTY-NINE (39) STARTS FROM HERE...
            else if (cmb1.Text.ToString() == "39" && cmb2.Text.ToString() == "January")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "39" && cmb2.Text.ToString() == "February")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "39" && cmb2.Text.ToString() == "March")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "39" && cmb2.Text.ToString() == "April")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "39" && cmb2.Text.ToString() == "May")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "39" && cmb2.Text.ToString() == "June")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "39" && cmb2.Text.ToString() == "July")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "39" && cmb2.Text.ToString() == "August")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "39" && cmb2.Text.ToString() == "September")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "39" && cmb2.Text.ToString() == "October")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "39" && cmb2.Text.ToString() == "November")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "39" && cmb2.Text.ToString() == "December")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }

//AGE FORTY (40) STARTS FROM HERE...
            else if (cmb1.Text.ToString() == "40" && cmb2.Text.ToString() == "January")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "40" && cmb2.Text.ToString() == "February")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "40" && cmb2.Text.ToString() == "March")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "40" && cmb2.Text.ToString() == "April")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "40" && cmb2.Text.ToString() == "May")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "40" && cmb2.Text.ToString() == "June")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "40" && cmb2.Text.ToString() == "July")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "40" && cmb2.Text.ToString() == "August")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "40" && cmb2.Text.ToString() == "September")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "40" && cmb2.Text.ToString() == "October")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "40" && cmb2.Text.ToString() == "November")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "40" && cmb2.Text.ToString() == "December")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }

//AGE FORTY-ONE (41) STARTS FROM HERE...
            else if (cmb1.Text.ToString() == "41" && cmb2.Text.ToString() == "January")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "41" && cmb2.Text.ToString() == "February")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "41" && cmb2.Text.ToString() == "March")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "41" && cmb2.Text.ToString() == "April")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "41" && cmb2.Text.ToString() == "May")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "41" && cmb2.Text.ToString() == "June")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "41" && cmb2.Text.ToString() == "July")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "41" && cmb2.Text.ToString() == "August")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "41" && cmb2.Text.ToString() == "September")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "41" && cmb2.Text.ToString() == "October")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "41" && cmb2.Text.ToString() == "November")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "41" && cmb2.Text.ToString() == "December")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }

//AGE FORTY-TWO (42) STARTS FROM HERE...
            else if (cmb1.Text.ToString() == "42" && cmb2.Text.ToString() == "January")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "42" && cmb2.Text.ToString() == "February")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "42" && cmb2.Text.ToString() == "March")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "42" && cmb2.Text.ToString() == "April")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "42" && cmb2.Text.ToString() == "May")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "42" && cmb2.Text.ToString() == "June")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "42" && cmb2.Text.ToString() == "July")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "42" && cmb2.Text.ToString() == "August")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "42" && cmb2.Text.ToString() == "September")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "42" && cmb2.Text.ToString() == "October")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "42" && cmb2.Text.ToString() == "November")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "42" && cmb2.Text.ToString() == "December")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }

//AGE FORTY-THREE (43) STARTS FROM HERE...
            else if (cmb1.Text.ToString() == "43" && cmb2.Text.ToString() == "January")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "43" && cmb2.Text.ToString() == "February")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "43" && cmb2.Text.ToString() == "March")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "43" && cmb2.Text.ToString() == "April")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "43" && cmb2.Text.ToString() == "May")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "43" && cmb2.Text.ToString() == "June")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "43" && cmb2.Text.ToString() == "July")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "43" && cmb2.Text.ToString() == "August")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "43" && cmb2.Text.ToString() == "September")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "43" && cmb2.Text.ToString() == "October")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "43" && cmb2.Text.ToString() == "November")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "43" && cmb2.Text.ToString() == "December")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }

//AGE FORTY-FOUR (44) STARTS FROM HERE...
            else if (cmb1.Text.ToString() == "44" && cmb2.Text.ToString() == "January")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "44" && cmb2.Text.ToString() == "February")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "44" && cmb2.Text.ToString() == "March")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "44" && cmb2.Text.ToString() == "April")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "44" && cmb2.Text.ToString() == "May")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "44" && cmb2.Text.ToString() == "June")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "44" && cmb2.Text.ToString() == "July")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "44" && cmb2.Text.ToString() == "August")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "44" && cmb2.Text.ToString() == "September")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "44" && cmb2.Text.ToString() == "October")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "44" && cmb2.Text.ToString() == "November")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "44" && cmb2.Text.ToString() == "December")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }

//AGE FORTY-FIVE (45) STARTS FROM HERE...
            else if (cmb1.Text.ToString() == "45" && cmb2.Text.ToString() == "January")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "45" && cmb2.Text.ToString() == "February")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "45" && cmb2.Text.ToString() == "March")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "45" && cmb2.Text.ToString() == "April")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "45" && cmb2.Text.ToString() == "May")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "45" && cmb2.Text.ToString() == "June")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "45" && cmb2.Text.ToString() == "July")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "45" && cmb2.Text.ToString() == "August")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "45" && cmb2.Text.ToString() == "September")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "45" && cmb2.Text.ToString() == "October")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
            else if (cmb1.Text.ToString() == "45" && cmb2.Text.ToString() == "November")
            {
                MessageBox.Show("Be ready to mother a SON.");
                return;
            }
            else if (cmb1.Text.ToString() == "45" && cmb2.Text.ToString() == "December")
            {
                MessageBox.Show("Be expecting a bouncing baby GIRL.");
                return;
            }
        }

        private void btn_back1_Click(object sender, EventArgs e)
        {
            MainForm fm = new MainForm();
            fm.Close();

            this.Close();
        }
    }
}