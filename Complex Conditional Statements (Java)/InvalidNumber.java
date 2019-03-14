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
public class InvalidNumber {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Scanner s = new Scanner(System.in);
        
        int number = s.nextInt();
        
        if(number >= 100 && number <= 200 || number == 0){
            System.out.println("");
        }
        else{
            System.out.println("invalid");
        }
    }
    
}
