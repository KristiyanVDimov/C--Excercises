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
public class Cinema {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Scanner s = new Scanner(System.in);
        
        String type = s.next();
        int rows = s.nextInt();
        int cols = s.nextInt();
        double result = 0;
        
        switch(type){
            case "Premiere": result = rows * cols * 12.0;
                System.out.printf("%.2f", result); break;
            case "Normal": result = rows * cols * 7.50;
                System.out.printf("%.2f",result); break;
            case "Discount": result = rows * cols * 5.00;
                System.out.printf("%.2f", result); break;
        }
    }
    
}
