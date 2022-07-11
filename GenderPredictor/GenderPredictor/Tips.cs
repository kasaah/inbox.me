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
    public partial class Tips : Form
    {
        public Tips()
        {
            InitializeComponent();
        }

        private void btn_back1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            try
            {
                if (tipscmb.Text.ToString() == "1st Trimester")
                {
                    tipsrtxt.Text = "FIRST TRIMESTER: YOUR ESSENTIAL PREGNANCY TO-DO LIST\n\n\b"
                        +"Arrange your first appointment with your midwife->\n"
                        +"As soon as you find out you’re pregnant, let your GP know \n"
                        + "so that you can book your first appointment with a midwife.\n"
                        +"The timing of your first official antenatal appointment, \n"
                        +"called your booking appointment, depends on where you live.\n" 
                        +"You should have your booking appointment by the time you're 10 weeks\n"
                        +"pregnant, but it may happen any time between eight weeks and 12 weeks.\n\n\b"
                        
                        +"Take a daily folic acid supplement->\n"
                        +"Start taking a daily folic acid supplement straight away.\n" 
                        +"Folic acid is an essential nutrient that protects your baby\n" 
                        +"against brain and spinal cord problems such as spina bifida.\n"
                        +"You need a 400 microgram (mcg) supplement of folic acid (vitamin B9).\n" 
                        +"You can buy these over the counter from pharmacies or supermarkets.\n" 
                        +"As well as folic acid, you’ll need to take a supplement containing 10mcg\n" 
                        +"of vitamin D every day. You can also take a pregnancy multivitamin if\n" 
                        +"you like, but eating a balanced diet should help you get all the vitamins\n" 
                        +"and minerals you need.\n\n\b"

                        +"Check before taking medicines->\n"
                        +"You need to be careful about taking medicines, even over-the-counter\n"
                        +"ones. They may be harmful to your unborn baby. Talk to your GP or\n"
                        +"midwife about any prescription medicines you’re taking and ask your \n"
                        +"pharmacist for advice when buying over-the-counter remedies.\n\n\b"

                        +"If you smoke, it’s time to quit->\n"
                        +"Smoking during pregnancy puts you at higher risk of miscarriage,\n" 
                        +"ectopic pregnancy and premature labour. The smoke you inhale can\n" 
                        +"also affect how your unborn baby grows, resulting in a low birth weight.\n\n\b" 

                        +"Cut out alcohol->\n"
                        +"There is no way to know for sure how much alcohol is safe during\n" 
                        +"pregnancy. That’s why most experts advise you to cut out alcohol\n" 
                        +"completely while you’re expecting.\n\n\b"

                        +"Cut down on caffeine->\n"
                        +"You can still enjoy a cup of coffee during your pregnancy.\n" 
                        +"But you should limit yourself to 200mg of caffeine a day,\n" 
                        +"which is two cups of instant coffee or one cup of brewed coffee.\n" 
                        +"If you regularly have more than 200mg of caffeine a day during\n" 
                        +"your pregnancy, it could increase your risk of miscarriage.\n"
                        +"This 200mg limit includes all sources of caffeine, so as\n" 
                        +"well as coffee you’ll need to count teas (including green tea),\n" 
                        +"cola, energy drinks and chocolate.\n\n\b"

                        + "Learn what to eat and what not to eat->\n"
                        + "A healthy, balanced diet will make sure that you get all the nutrients\n"
                        + "you and your developing baby need. Check out our pregnancy diet and get\n"
                        + "yourself into good eating habits now. It may surprise you to know that\n"
                        + "you don’t need extra calories in your first trimester or second trimester.\n"
                        + "But you will need to avoid certain foods in pregnancy, because they may\n"
                        + "contain bacteria, parasites or toxins that could harm your baby. This\n"
                        + "includes some cheeses and unpasteurised dairy products, raw or\n"
                        + "undercooked meat, liver and pate, and raw shellfish. You can eat raw\n"
                        + "eggs or lightly cooked eggs, as long as they have the red British\n"
                        + "Lion Quality mark.\n\n\b"

                        + "Get as much rest as you can->\n"
                        + "It’s common to feel tired or even exhausted during your first trimester.\n"
                        + "This is because your body is getting used to rapidly changing hormone\n"
                        + "levels. Take it easy and put your feet up when you get the chance,\n"
                        + "although this can be hard if you’re working. Try to get to bed early at\n"
                        + "least one night a week. Even if you can’t sleep until much later, relaxing\n"
                        + "with a book or soft music will help you to unwind. Turn off your phone and\n"
                        + "forget about work. Once your baby arrives sleep will be so precious, so\n"
                        + "enjoy it while you can. It's also a good idea to get used to sleeping on\n"
                        + "your side now. As your bump grows, lying on your stomach won’t be\n"
                        + "comfortable, and lying on your back can affect the blood supply to your\n"
                        + "baby. In fact, by the third trimester, sleeping on your side reduces \n"
                        + "the risk of stillbirth compared to sleeping on your back. So it’s well\n" 
                        + "worth getting into the habit now.\n";
                }
                else if (tipscmb.Text.ToString() == "2nd Trimester")
                {
                    tipsrtxt.Text = "SECOND TRIMESTER: YOUR ESSENTIAL PREGNANCY TO-DO LIST\n\n\b"
                        + "Implement Gentle Exercise->\n"
                        + "If the first trimester knocked you on the rear-end, the second trimester is a\n"
                        + "good time to implement gentle exercise.  Walking, hiking, swimming or prenatal\n"
                        + "yoga DVDs are excellent ideas and mostly free or inexpensive.\n\n\b"

                        + "Resume Healthy Eating->\n"
                        + "Another side effect of the first trimester is that sometimes “eating healthy”\n"
                        + "is thrown out the window for the sake of survival.  The thing that sounded\n"
                        + "appealing may or may not have been the healthiest thing for a pregnant woman\n"
                        + "to eat.  But you did it… because survival.\n\n\b"

                        + "Book a Prenatal Massage->\n"
                        + "A favorite on this second trimester to-do list is to book a prenatal massage.\n"
                        + "Ladies, trust me on this, you should have a prenatal massage at least once per\n"
                        + "month during pregnancy.  (And don’t forget about postpartum massages!)\n"
                        + "The benefits of prenatal massage include feeling more relaxed, less anxious\n"
                        + "and can relieve typical pregnancy aches and pains.  Massage releases lots of\n"
                        + "feel good hormones like oxytocin – which your unborn baby will experience too!\n"
                        + "TIP:  Be sure to hire a massage therapist with training specific to pregnancy\n"
                        + "to keep mom and baby safe.\n\n\b"

                        + "Sign Up for a Childbirth Class->\n"
                        + "Another fun thing to add to your second trimester to-do list is to\n"
                        + "sign up for and take a really good childbirth class.  Hopefully,\n"
                        + "the area where you live has good options.\n"
                        + "TIP:  Make sure to sign up for a class that will be completed by\n"
                        + "the time you are 37-38 weeks.  Don’t wait until the last second!\n"
                        + "TIP:  Don’t sign up for the first class that comes your way. Ask\n"
                        + "around and try to find ALL the options available in your area.\n"
                        + "Ask doulas and other birth professionals what class they recommend\n"
                        + "and WHY.  At some point it will become clear which option is your\n"
                        + "best bet.\n\n\b"

                        + "Establish Care with the Best Provider->\n"
                        + "Now that you’ve read a book, started feeling better, hired a doula\n"
                        + "and investigated childbirth classes, you likely have a good idea of\n"
                        + "what you are looking for in a care provider.It may seem a bit\n"
                        + "backwards to hire a care provider in the second trimester, but many\n"
                        + "women don’t know what they want until they become educated on their options.\n\n\b"

                        + "Pick a Pediatrician->->\n"
                        + "Ok, so maybe picking a pediatrician isn’t the most fun thing on this\n"
                        + "second trimester to-do list, but picking a pediatrician, or at minimum\n"
                        + "beginning the process of choosing a doctor for your unborn baby,\n"
                        + "is important. Many parents do not know how to choose a pediatrician\n"
                        + "or what to look for in a family doctor.  A great place to start is\n"
                        + "with the topic of vaccinations.\n\n\b"

                        + "Attend Cloth Diaper Workshop->->\n"
                        + "Unless elimination communication is on the table, one thing we know for\n"
                        + "sure is that diapers of some sort will be needed.  It’s best to start\n"
                        + "registering and planning for diapering beginning in the second trimester.\n"
                        + "A prerequisite to registering for a baby is to attend a cloth diaper\n"
                        + "workshop.  A cloth diaper workshop will walk parents through the ins\n"
                        + "and outs of cloth diapering.  Questions will be answered and the process\n"
                        + "of diapering a baby will become demystified.\n\n\b"

                        + "Attend Babywearing Workshop->->\n"
                        + "An additional prerequisite for registering for baby is to attend a baby\n"
                        + "wearing workshop.  Just like cloth diapering, baby carriers come in many\n"
                        + "varieties and sizes that may or may not work for each parent/family.\n"
                        + "It can be overwhelming! If you are fortunate to have a baby wearing\n"
                        + "group or workshop in your area, rejoice!  This is a treasure trove of\n"
                        + "information and advice that can be accessed for FREE. At a babywearing\n"
                        + "workshop you can touch, try on and learn how to use a carrier safely.\n"
                        + "And just an FYI, not all carriers on the market are safe for infants.\n"
                        ;
                
                }
                else if (tipscmb.Text.ToString() == "3rd Trimester")
                {
                    tipsrtxt.Text = "THIRD TRIMESTER: YOUR ESSENTIAL PREGNANCY TO-DO LIST\n\n\b"
                        + "Eat Dates->->\n"
                        + "Women who ate dates daily during their ninth months were less likely than\n" 
                        + "non-date eaters to need medication to start labor or to help it keep\n" 
                        + "progressing, a new study published in the Journal of Obstetrics and\n" 
                        + "Gynaecology found. They were also more dilated upon arrival at the\n" 
                        + "hospital and labored seven hours less.Dates seem to have a compound\n" 
                        + "that mimics the hormone oxytocin [which causes contractions], says\n" 
                        + "Academy of Nutrition and Dietetics spokeswoman Melinda Johnson, M.s.,\n" 
                        + "R.D. Enjoy six dates daily for best results. Have a sweet tooth?\n" 
                        + "Try this date and nut candy.\n\n\b"

                        + "Get More Sleep->->\n"
                        + "Women who slept fewer than six hours during the last month of pregnancy\n"
                        + "labored for 11 hours longer and had Cesarean sections four times more\n"
                        + "frequently than women who slept seven hours or more, according to a study\n"
                        + "published in the American Journal of Obstetrics and Gynecology. To get\n"
                        + "comfortable, use body pillows, sleep in a recliner, or kick your partner\n"
                        + "out of bed, suggests Jodi Mindell, Ph.D., author of Sleep Deprived No\n"
                        + "More: From Pregnancy to Early Motherhood (Da Capo Press).\n\n\b"
                        
                        + "Strengthen Your Legs->->\n"
                        + "Upright positions allow gravity to help move the baby along, which may\n" 
                        + "shorten labor by an hour, an Australian study found. To stay vertical,\n" 
                        + "you'll need strong legs. The most important exercise for childbirth is\n" 
                        + "squatting, says prenatal-exercise specialist Erin O'Brien, creator of\n" 
                        + "The Complete Pregnancy Fitness DVD. Practice your squat by placing an\n" 
                        + "exercise ball between your lower back and a wall. Walk your feet out as\n" 
                        + "far as you can, rotate your toes and hips outward, then do three sets of\n" 
                        + "15 squats.\n" 
                        ;
                    
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Sorry! Please attempt at a later time");
            }
        }
    }
}
