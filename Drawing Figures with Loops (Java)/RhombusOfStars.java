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
public class RhombusOfStars {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Scanner s = new Scanner(System.in);
        int n = Integer.parseInt(s.nextLine());
        int stars = 1;
        int spaces = n - stars;
        for(int row = 0; row < n; row++){
           for(int i = 0; i < spaces; i++){
               System.out.print(" ");
           }
           for(int i = 0; i < stars; i++){
               System.out.print("* ");
           }
           spaces--;
           stars++;
           System.out.println();
        }
        spaces = 1;
        stars = n - spaces;
        for(int row = 0; row < 2*n; row++){
           for(int i = 0; i < spaces; i++){
               System.out.print(" ");
           }
           for(int i = 0; i < stars; i++){
               System.out.print("* ");
           }
           stars--;
           spaces++;
           System.out.println();
        }
        
    }
}

