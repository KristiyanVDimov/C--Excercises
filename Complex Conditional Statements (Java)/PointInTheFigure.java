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
public class PointInTheFigure {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Scanner s = new Scanner(System.in);
        
        int h = s.nextInt();
        int x = s.nextInt();
        int y = s.nextInt();
        
        if ((x >= 0 && x <= h * 3 && y >= 0 && y <= h) || (x >= h && x <= h * 2 && y >= h && y <= h * 4)){
             if ((x > 0 && x < h * 3 && y > 0 && y < h) || (x > h && x < h * 2 && y > h && y < h * 4)){
                 System.out.println("inside");
             }
             else{
                 if(x > h && x < h * 2 && y == h){
                     System.out.println("inside");
                 }
                 else{
                     System.out.println("border");
                 }
                 
             }
        }
        else{
            System.out.println("outside");
        }
    }
    
}
