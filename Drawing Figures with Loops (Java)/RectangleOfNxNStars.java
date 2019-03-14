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
public class RectangleOfNXNStars {

    public static String repeatStr(String str, int count){
        StringBuilder sb = new StringBuilder();
        for(int i = 0; i < count; i++){
            sb.append(str);
        }
        return sb.toString();
    }
    public static void main(String[] args) {
        Scanner s = new Scanner(System.in);
        int n = Integer.parseInt(s.nextLine());
        for(int i = 0; i < n; i++){
            System.out.println(repeatStr("*", n));
        }
    }
    
}
