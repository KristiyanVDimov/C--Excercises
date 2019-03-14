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
public class VolleyBall {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Scanner s = new Scanner(System.in);
        
        String year = s.next();
        int p = s.nextInt();
        int h = s.nextInt();
        
        int hs = 48 - h;
        double gamesSofia = hs * (3.0/4);
        double gamesHoliday = p * (2.0/3);
        double result = h + gamesSofia + gamesHoliday;
        
        
        switch(year){
            case "leap": result = result + (result * 0.15);
                System.out.println(Math.floor(result));
                break;
            case "normal": System.out.println(Math.floor(result));
                break;
        }
       /* if(year.equals("leap")){
            result = result + (result * 0.15);
        }
        else if(year.equals("normal")){
            result = result;
        }
        System.out.println(Math.floor(result));*/
    }
    
}
