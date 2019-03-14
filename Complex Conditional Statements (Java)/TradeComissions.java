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
public class TradeComissions {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Scanner s = new Scanner(System.in);
        
        String city = s.next().toLowerCase();
        double sales = s.nextDouble();
        double comission = -1.0;
        
        if(city.equals("sofia")){
            if(sales >= 0 && sales <= 500){ comission = 0.05;}
            else if(sales > 500 && sales <= 1000){ comission = 0.07;}
            else if(sales > 1000 && sales <= 10000){ comission = 0.08;}
            else if(sales > 10000){ comission = 0.12;}
        }
        else if(city.equals("varna")){
            if(sales >= 0 && sales <= 500){ comission = 0.045;}
            else if(sales > 500 && sales <= 1000){ comission = 0.075;}
            else if(sales > 1000 && sales <= 10000){ comission = 0.1;}
            else if(sales > 10000){ comission = 0.13;}
        }
        else if(city.equals("plovdiv")){
            if(sales >= 0 && sales <= 500){ comission = 0.055;}
            else if(sales > 500 && sales <= 1000){ comission = 0.08;}
            else if(sales > 1000 && sales <= 10000){ comission = 0.12;}
            else if(sales > 10000){ comission = 0.145;}
        }
        if(comission >= 0){
            System.out.printf("%.2f", (comission * sales));
        }
        else{
            System.out.println("error");
        }
    }
    
}
