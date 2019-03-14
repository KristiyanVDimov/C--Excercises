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
public class CheckPrimes {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Scanner s = new Scanner(System.in);
        int num = Integer.parseInt(s.nextLine());
        String p = "Prime";
        
        if(num < 2){
            System.out.println("Not Prime");
        }
        else{
            for(int i = 2; i < num; i++){
                if(num % i == 0){
                    p = "Not Prime";
                    break;
                }
            }
            System.out.println(p);
            
        }
    }
    
}
