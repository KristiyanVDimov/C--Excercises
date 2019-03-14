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
public class TriangleOfDollars {
    public static void main(String[] args) {
        Scanner s = new Scanner(System.in);
        int n = Integer.parseInt(s.nextLine());
        int n1 = 1;
        for(int i = 0; i < n; i++){
            
            for(int j = 0; j < n1; j++){
                
                System.out.print("$ ");
                
            }
            n1++;
            System.out.println();
        }
    }
    
}
