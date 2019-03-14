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
public class Fibonacci {

    
    public static void main(String[] args) {
        Scanner s = new Scanner(System.in);
        int n = Integer.parseInt(s.nextLine());
        int n1 = 0;
        int n2 = 1;
        int sum = 0;
        if(n < 2){
            System.out.println(1);
        }
        else{
            for(int i = 0; i < n; i++){
                sum = n1 + n2;
                n1 = n2;
                n2 = sum;
            }
            System.out.println(sum);
        }
    }
    
}
