/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package softuni;

import java.util.Scanner;

/**
 *
 * @author Kristiyan Dimov
 */
public class FruitShop {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Scanner s = new Scanner(System.in);
        
        String fruit = s.next().toLowerCase();
        String day = s.next().toLowerCase();
        double quantity = s.nextDouble();
        double price = -1.0;
        
        if(day.equals("monday") || day.equals("tuesday") || day.equals("wednesday")
                || day.equals("thursday") || day.equals("friday")){
            if(fruit.equals("banana")){ price = 2.50;}
            else if(fruit.equals("apple")){ price = 1.20;}
            else if(fruit.equals("orange")){ price = 0.85;}
            else if(fruit.equals("grapefruit")){ price = 1.45;}
            else if(fruit.equals("kiwi")){ price = 2.70;}
            else if(fruit.equals("pineapple")){ price = 5.50;}
            else if(fruit.equals("grapes")){ price = 3.85;}
        }
        else if(day.equals("saturday") || day.equals("sunday")){
            if(fruit.equals("banana")){ price = 2.70;}
            else if(fruit.equals("apple")){ price = 1.25;}
            else if(fruit.equals("orange")){ price = 0.90;}
            else if(fruit.equals("grapefruit")){ price = 1.60;}
            else if(fruit.equals("kiwi")){ price = 3.00;}
            else if(fruit.equals("pineapple")){ price = 5.60;}
            else if(fruit.equals("grapes")){ price = 4.20;}
        }
        if(price >= 0){
            System.out.println(price * quantity);
        }
        else{
            System.out.println("error");
        }
    }
    
}
