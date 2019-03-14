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
public class SmallShop {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Scanner s = new Scanner(System.in);
        
        String product = s.next().toLowerCase();
        String city = s.next().toLowerCase();
        
        double quantity = s.nextDouble();
        
        if(city.equals("sofia")){
            if(product.equals("coffee")){
                System.out.println(0.50 * quantity);
            }
            else if(product.equals("water")){
                System.out.println(0.80 * quantity);
            }
            else if(product.equals("beer")){
                System.out.println(1.20 * quantity);
            }
            else if(product.equals("sweets")){
                System.out.println(1.45 * quantity);
            }
            else if(product.equals("peanuts")){
                System.out.println(1.60 * quantity);
            }
        }
        if(city.equals("varna")){
            if(product.equals("coffee")){
                System.out.println(0.45 * quantity);
            }
            else if(product.equals("water")){
                System.out.println(0.70 * quantity);
            }
            else if(product.equals("beer")){
                System.out.println(1.10 * quantity);
            }
            else if(product.equals("sweets")){
                System.out.println(1.35 * quantity);
            }
            else if(product.equals("peanuts")){
                System.out.println(1.55 * quantity);
            }
        }
        if(city.equals("plovdiv")){
            if(product.equals("coffee")){
                System.out.println(0.40 * quantity);
            }
            else if(product.equals("water")){
                System.out.println(0.70 * quantity);
            }
            else if(product.equals("beer")){
                System.out.println(1.15 * quantity);
            }
            else if(product.equals("sweets")){
                System.out.println(1.30 * quantity);
            }
            else if(product.equals("peanuts")){
                System.out.println(1.50 * quantity);
            }
        }
    }
    
}
