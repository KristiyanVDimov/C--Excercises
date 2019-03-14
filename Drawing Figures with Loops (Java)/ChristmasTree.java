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
public class ChristmasTree {
     
    public static void main(String[] args) {
        Scanner s = new Scanner(System.in); 
        int n = Integer.parseInt(s.nextLine()); 
        int count = 0; 
        int center = n; 
        for(int i = 0; i <= n; i++){ 
            for(int j = 0; j < center; j++){ 
                System.out.print(" "); 
            } 
            for(int j = 0; j < count; j++){ 
                System.out.print("*"); 
            } 
            System.out.print(" | "); 
            for(int j = 0; j < count; j++){ 
                System.out.print("*"); 
            } 
            System.out.println(); 
            count++; 
            center--; 
        } 
    }
}
    

