
//JAVA API IMPORTS
import java.util.*;

//BEGINNING OF THE MAIN CLASS AND OBJECT
public class Ifelse1 {

       public static void main(String[] args) {
       //VARIABLE DECLARATION
       double a;
       double b;
       double c;
       
       //CREATE A SCANNER CLASS FOR KEYBOARD INPUT
       Scanner input = new Scanner(System.in);
       
       //PROMPT THE USER TO ENTER THE NUMBERS
       System.out.println("Enter your first number");
       a=input.nextDouble();
       
       System.out.println("Enter the second number");
       b=input.nextDouble();
       
       System.out.println("Enter the third number");
       c=input.nextDouble();
       
       //CONSTRAINT
       if(a<10)
       {
        b=0;
        c=1;
       System.out.println("The value of B is " + b);
       System.out.println("The value of B is " + c);
       }
        
       else
       {
        b=-99;
        c=0;
        System.out.println("The value of B is " + b);
        System.out.println("The value of B is " + c);
                }
       
    }
       
    
}
