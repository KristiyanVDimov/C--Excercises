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
public class Sunglasses {

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
        
        System.out.println(repeatStr("*", n*2) + repeatStr(" ",n) + repeatStr("*", n*2));
        
        for(int i = 0; i < n - 2; i++){
            System.out.print("*" + repeatStr("/", 2*n-2) + "*");
            if(i == (n-1)/2-1){
                System.out.print(repeatStr("|",n));
            }
            else{
                System.out.print(repeatStr(" ",n));
            }
            System.out.print("*" + repeatStr("/",2*n-2) + "*");
            System.out.println();
        }
        
        System.out.println(repeatStr("*", n*2) + repeatStr(" ",n) + repeatStr("*", n*2));
    }
    
}
