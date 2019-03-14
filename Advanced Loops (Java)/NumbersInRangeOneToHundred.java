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
public class NumberInRange1100 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Scanner s = new Scanner(System.in);
        System.out.println("Еnter a number in the range [1...100]:");
        int num = Integer.parseInt(s.nextLine());
        
        while(num < 1 || num > 100){
            System.out.println("Invalid number!");
            num = Integer.parseInt(s.nextLine());
        }
        System.out.println("The number is: " + num);
    }
    
}
