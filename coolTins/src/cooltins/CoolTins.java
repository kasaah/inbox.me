/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package cooltins;

/**
 *
 * @author Kofi_Saah
 */
import java.io.*;
import java.util.Scanner;
public class CoolTins {

    /**
     * @param args the command line arguments
     * @throws java.io.IOException
     */
    public static void main(String[] args) throws IOException {
        // TODO code application logic here
       // FileWriter fw=new FileWriter("myFiles.txt", true);
      // int a;
       String friends;
       Scanner sc=new Scanner(System.in);
       System.out.println("How many friends do you have?");
            friends=sc.nextLine();
       System.out.println("Enter their names");
            
        for (int a = 1; a>= 10; a++) {
             System.out.println("Friend " + a);
             friends=sc.nextLine();
            
            
        }
          
       
       
        //FileWriter fw=new FileWriter("myFiles.txt",true);
       // PrintWriter outputFile=new PrintWriter(fw);
          //  outputFile.println("we made it");
          //  outputFile.println("we made it");
          //  outputFile.println("we made it"); 
          //  outputFile.close();
    }
    
}
