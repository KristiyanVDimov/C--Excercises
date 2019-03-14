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
public class NumberTable {

    
    public static void main(String[] args) {
        Scanner s = new Scanner(System.in);
        int n = Integer.parseInt(s.nextLine());
        int num = 0;
        
        for(int row = 1; row <= n; row++){
            for(int col = 1; col <= n; col++){
                num = row + col - 1;
                if(num > n){
                    for(int i = 1; i <= n - col + 1; i++){
                        System.out.printf("%d ", n - i);
                    }
                    break;
                }
                System.out.printf("%d ",num);
            }
            System.out.println();
            
        }
    }
    
}
