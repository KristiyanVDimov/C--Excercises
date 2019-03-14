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
public class Diamond {

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
        
        int dash = (n - 2) / 2;
        int middle = n - 4;
        
        if(n % 2 == 0){
            for(int i = 0; i < n / 2; i++){
                System.out.println(repeatStr("-", dash) + "*" + repeatStr("-", 2 * i) + "*" + repeatStr("-", dash));
                dash--;
            }
            dash = 1;
            
            for(int i = 0; i < (n/2 - 1); i++){
                System.out.println(repeatStr("-", dash) + "*" + repeatStr("-", middle) + "*" + repeatStr("-", dash));
                middle -= 2;
                dash++;
            }
        }
        else if(n == 1){
            System.out.println("*");
        }
        else{
            System.out.println(repeatStr("-", (n-1) / 2) + "*" + repeatStr("-",(n-1)/2));
            for(int i = 0; i < n / 2; i++){
                System.out.println(repeatStr("-", dash) + "*" + repeatStr("-", 2 * i + 1) + "*" + repeatStr("-", dash));
                dash--;
            }
            for(int i = 0; i < (n/2 - 1); i++){
                System.out.println(repeatStr("-", i + 1) + "*" + repeatStr("-", middle) + "*" + repeatStr("-", i + 1));
                middle -= 2;
                dash++;
            }
            System.out.println(repeatStr("-", (n - 1) / 2) + "*" + repeatStr("-",(n-1) / 2));
        }
        
    }
    
}
