import javax.swing.JOptionPane;
public class TryingHands
       {

public static void main(String[]args){
    String fname;
    String mname;
    String lname;
    int Position;
   

fname=JOptionPane.showInputDialog("What is Firstname");

mname=JOptionPane.showInputDialog("What is your middle name");

lname=JOptionPane.showInputDialog("What is your last name");

JOptionPane.showMessageDialog(null, fname +" "+ " " + mname + " " + lname);

System.out.println(mname.length() + " " + "is the lenght of your middle name");

JOptionPane.showMessageDialog(null,mname.length() + " " + "is the length of your middle name");

JOptionPane.showMessageDialog(null, fname.toUpperCase());

fname=JOptionPane.showInputDialog("Enter the postion");
Position=Integer.parseInt(fname);
JOptionPane.showMessageDialog(null, fname.charAt(Position)+" "+" is the position of the letter you entered");

System.exit(0);
}
}