import javax.swing.JOptionPane;
public class Shift {

    public static void main(String []args){
        double annualSalary;
        int creditRating;
        String input;
        
        input=JOptionPane.showInputDialog("What is your salary?");
        annualSalary=Double.parseDouble(input);
    
        input=JOptionPane.showInputDialog("On the scale of 1 through 10\n" + 
                                          " What is your credit rating?\n" + 
                                          " (10 = Excellent, 1 = very bad)" );
        creditRating=Integer.parseInt(input);
    
        if (annualSalary >= 1000 && creditRating > 6 )
            qualify();
        else
            noqualify();
    
    }
    
    public static void qualify(){
        JOptionPane.showMessageDialog(null, "Congratulations! You qualify for the credit card");
    }
    
    public static void noqualify(){
        JOptionPane.showMessageDialog(null, "Sorry! You don't qualify to get the card");
    }
}


