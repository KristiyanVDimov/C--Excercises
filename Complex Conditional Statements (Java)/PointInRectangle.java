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
public class PointInRectangle {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Scanner s = new Scanner(System.in);
        
        double x1 = s.nextDouble();
        double y1 = s.nextDouble();
        double x2 = s.nextDouble();
        double y2 = s.nextDouble();
        double x = s.nextDouble();
        double y = s.nextDouble();
        
        if(x1 < x2 && y1 < y2){
            if(x >= x1 && x <= x2 && y >= y1 && y <= y2){
                System.out.println("Inside");
            }
            else{
                System.out.println("Outside");
            }
        }
    }
    
}
