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
public class GreatestCommonDivisor {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Scanner s = new Scanner(System.in);
        
        int a = Integer.parseInt(s.nextLine());
        int b = Integer.parseInt(s.nextLine());
        
        while(b != 0){
            int c = b;
            b = a%b;
            a = c;
        }
        System.out.println(a);
    }
    
}
