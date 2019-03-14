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
public class FruitOrVegetable {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Scanner s = new Scanner(System.in);
        
        String product = s.nextLine();
        
        if(product.equals("banana") || product.equals("kiwi") || product.equals("apple") 
                || product.equals("cherry") || product.equals("lemon") || product.equals("grapes")){
            System.out.println("fruit");
        }
        else if(product.equals("tomato") || product.equals("cucumber") || product.equals("pepper") || product.equals("carrot")){
            System.out.println("vegetable");
        }
        else{
                System.out.println("unknown");
        }
    }
    
}
