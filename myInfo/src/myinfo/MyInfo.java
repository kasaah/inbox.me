/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package myinfo;

/**
 *
 * @author Kofi_Saah
 */
import java.util.*;
public class MyInfo {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        //VARIABLE DECLARATION
        String name;
        int age;
        double annualPay;
        
        //ACCEPT INPUT
        //1. NAME
        Scanner keyboard=new Scanner(System.in);
        System.out.println("Enter your name");
        name=keyboard.nextLine();
        
        //2. AGE
        System.out.println("Enter your age");
        age=keyboard.nextInt();
        
        //3. DESIRED ANNUAL PAY
        System.out.println("Enter your desired annual pay");
        annualPay=keyboard.nextDouble();
        
        //OUTPUT INFORMATION
        System.out.println("My name is" + " " + name + "\nMy age is " + age + "\nI hope to receive $10,000.00");
        
        
    }
    
}
