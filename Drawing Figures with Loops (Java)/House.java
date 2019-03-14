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
public class House {
    
    static String repeatStr(String repeatStr, int count){
        String text = "";
        for(int i = 0; i < count; i++){
            text = text + repeatStr;
        }
        return text;
    }
    
    public static void main(String[] args) {
        Scanner s = new Scanner(System.in);
        int n = Integer.parseInt(s.nextLine());
        int count = 1;
        int spaces = n - count;
        if(n % 2 == 0){
            count += 1;
        }
        for(int i = 0;i < (n + 1)/2; i++){
            for(int j = 0; j < (n - count) / 2; j++){
                System.out.print("-");
            }
            for(int j = 0; j < count; j++){
                System.out.print("*");
            }
            for(int j = 0; j < (n - count) / 2; j++){
                System.out.print("-");
            }
            
            spaces--;
            count += 2;
            System.out.println();
        }
        for(int i = 0; i < n /2; i++){
            System.out.println("|" + repeatStr("*", n-2) + "|");
        }
        
    }
    
}
