//IMPORT OF JAVA API
import java.util.*;

//THE MAIN CLASS AND OBJECT
public class Nestedif {

    
    public static void main(String[] args) {
        
        //VARIABLE DECLARATION
        double salary;
        double year;
        
        //CREATE A SCANNER CLASS TO ACCEPT KEYBOARD INPUT
        Scanner input = new Scanner(System.in);
        
        //ACCEPT USER INPUT BY FIRST PROMPTING THE USER
        System.out.println("Enter your monthly salary:");
        salary=input.nextDouble();
        
        System.out.println("Enter the number of years you have contributed to the scheme:");
        year=input.nextDouble();
        
        //CONSTRAINTS
        if(salary>30000)
        {
            System.out.println("You qualify to take the loan");
            if(year<2){
                System.out.println("You are young in the service");}
            else{
               System.out.println("You have spent the needed years");
                        }
        }
        else
        {
            System.out.println("Your monthly earning is too small an amount");
                    }
        }
    }
    


