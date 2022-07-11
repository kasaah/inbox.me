import java.util.*;
public class Population{
    public static void main (String[] args){
        int popStart;
        double avgIncrease;
        double dailyGrowth;
        int numOfDays;
        int date=1;
    Scanner keyboard = new Scanner(System.in);
    popStart = keyboard.nextInt();
    
    if(popStart<2){
        System.out.println("You must enter a value from two and above");
    }
    
    avgIncrease=keyboard.nextDouble();
    if(avgIncrease<0){
        System.out.println("You can't enter a negative figure");
    }
    
    numOfDays = keyboard.nextInt();
    if(numOfDays<1){
        System.out.println("You must enter two or more");
    }
    
    for(date; date<=numOfDays; date++){
        dailyGrowth = (popStart/avgIncrease)*100;
        System.out.println("Population size for day" + date + "is" + dailyGrowth);
    }
        
    }
    
}