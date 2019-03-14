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
public class SquareFrame {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Scanner s = new Scanner(System.in);
        int n = Integer.parseInt(s.nextLine());
        
        System.out.print("+ ");
        for(int i = 0; i < n - 2; i++){
            System.out.print("- ");
        }
        System.out.print("+");
        System.out.println();
        for(int i = 0; i < n - 2; i++){
            System.out.print("| ");
            for(int j = 0; j < n - 2; j++){
                System.out.print("- ");
            }
            System.out.println("|");
        }
        System.out.print("+ ");
        for(int i = 0; i < n - 2; i++){
            System.out.print("- ");
        }
        System.out.print("+");
    }
}
