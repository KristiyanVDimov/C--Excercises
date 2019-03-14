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
public class SquareOfStars {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Scanner s = new Scanner(System.in);
        int n = Integer.parseInt(s.nextLine());
        
        for(int i = 0; i < n; i++){
            System.out.print("*");
            for(int j = 1; j < n; j++){
                System.out.print(" " + "*");
            }
            System.out.println();
        }
    }
    
}
