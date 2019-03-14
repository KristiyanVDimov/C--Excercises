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
public class EvenPowersOf2 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Scanner s = new Scanner(System.in);
        int n = Integer.parseInt(s.nextLine());
        int num = 1;
        
        for(int i = 0; i <= n; i++){
            if(i%2 == 0){
            System.out.println(num);
            num = num * (int)Math.pow(2,2);
            }
        }
    }
    
}
