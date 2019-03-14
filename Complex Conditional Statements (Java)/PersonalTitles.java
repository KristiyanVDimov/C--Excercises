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
public class PersonalTitles {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Scanner s = new Scanner(System.in);
        
        double age = s.nextDouble();
        String gender = s.next();
        
        if(age >= 16){
            if(gender.equals("m")){
                System.out.println("Mr.");
            }
            else if(gender.equals("f")){
                System.out.println("Ms.");
            }
        }
        else{
            if(gender.equals("m")){
                System.out.println("Master");
            }
            else if(gender.equals("f")){
                System.out.println("Miss");
            }
        }
    }
    
}
