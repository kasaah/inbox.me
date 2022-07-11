//JAVA API IMPORTS
import java.util.*;
import javax.swing.JOptionPane;
import java.io.*;

//BEGINNING OF THE MAIN CLASS AND OBJECT
public class IfElse {

    
    public static void main(String[] args) {
        //VARIABLE DECLARATION
        double number1;
        double number2;
        double number3;
        double quotient;
        String input;
        
        //CREATE A SCANNER CLASS FOR KEYBOARD INPUT
        Scanner keyboard = new Scanner (System.in);
        
        //PROMPT THE USER TO ENTER THE FIRST NUMBER
        System.out.println("Enter the first number");
        number1=keyboard.nextDouble();
        
        //PROMPT THE USER TO ENTER THE SECOND NUMBER
        System.out.println("Enter the second number");
        number2=keyboard.nextDouble();
        
        //SHOW THE NUMBERS ENTERED BY THE USER
        System.out.println("Number 1        " + number1 + "\nNumber 2        " + number2);
        
        //CONSTRAINT
        if(number2==0)
        {
            System.out.println("You can't have the divisor to be zero");
        System.out.println("Re-run the program and enter a number other than 0");
        }
        else{
            quotient=number1/number2;
            System.out.println("The quotient is "+quotient);
            }    
                
        
    }
    
}
