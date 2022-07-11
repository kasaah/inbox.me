
import javax.swing.JOptionPane;

class Payrate1{
    
    public static void multiply(String[]args){
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