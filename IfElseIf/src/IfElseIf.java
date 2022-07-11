
import javax.swing.JOptionPane;


public class IfElseIf {

    public static void main(String[] args) {
        //VARIABLE DECLARATION
        double testScore;
        String input;
        
        //ACCEPT INPUT THE FROM THE USER BY FIRST GIVING PROMPT
       input = JOptionPane.showInputDialog("Enter your Test Score");
       testScore=Double.parseDouble(input);
       
       //IF ANALYSIS OF THE TEST SCORE INPUTTED BY THE USER
       if(testScore<=50)
       {
           JOptionPane.showMessageDialog(null, "Your grade is F");
       }
           else if(testScore<=60){
                   JOptionPane.showMessageDialog(null, "Your grade is E");
                   }
                   else if(testScore<=70){
                           JOptionPane.showMessageDialog(null, "Your grade is D");
                           }
                   else if(testScore<=80){
                       JOptionPane.showMessageDialog(null, "Your grade is C");
                   }
                   else if(testScore<=90){
                       JOptionPane.showMessageDialog(null, "Your grade is B");
                   }
                       else if(testScore<=100){
                            JOptionPane.showMessageDialog(null, "Your grade is A");
                            }
                       else {
                           System.exit(0);
                       }
                   }
                   }
       
    


