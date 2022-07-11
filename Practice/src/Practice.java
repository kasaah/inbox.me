
import javax.swing.JOptionPane;
import java.io.*;

public class Practice {
    
    public static void main(String[]args)throws FileNotFoundException{
    
    double test1;
    double test2;
    double test3;
    double avg123;
    String input;
    
    PrintWriter saves=new PrintWriter("mySaves2.txt");
    
    
    input = JOptionPane.showInputDialog("Enter score #1:");
    test1= Double.parseDouble(input);
    
    input = JOptionPane.showInputDialog("Enter score #2:");
    test2= Double.parseDouble(input);
    
    input = JOptionPane.showInputDialog("Enter score #3:");
    test3= Double.parseDouble(input);
    
    avg123 = (test1+test2+test3)/3;
    
    saves.println(avg123);
    JOptionPane.showMessageDialog(null, avg123);
    
    if(avg123>95){
       JOptionPane.showMessageDialog(null, "You have performed creditably well");
       saves.println("You have performed creditably well");
       }
    else JOptionPane.showMessageDialog(null, "You tried your best");{
}
    double test4;
    double fscore=20;
    input=JOptionPane.showInputDialog("Enter score #4");
    test4=Double.parseDouble(input);
    
    if(test4>fscore){
       JOptionPane.showMessageDialog(null, "You enter the right score" );
    }
    else {
       JOptionPane.showMessageDialog(null,fscore=0);
    }
    
    Payrate month = new Payrate();
    
    saves.close();
}
}



class Payrate{
    
    Payrate(){
    
    double pay;
    double payRate;
    double hours;
    double totalPay;
    String text;
    
    text=JOptionPane.showInputDialog("Enter the monthly pay");
    pay=Double.parseDouble(text);
    
    text=JOptionPane.showInputDialog("Enter the hours you worked");
    payRate=Double.parseDouble(text);
    
    text=JOptionPane.showInputDialog("Enter the hours you worked");
    hours=Double.parseDouble(text);
    
    if(hours>40)
    {
      totalPay= pay+(payRate*hours);
      JOptionPane.showMessageDialog(null, totalPay);
    }
    
    }  
}