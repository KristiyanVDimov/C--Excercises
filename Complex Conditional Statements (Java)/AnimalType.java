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
public class AnimalType {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Scanner s = new Scanner(System.in);
        
        String type = s.next();
        
        switch(type){
            case "dog": System.out.println("mammal"); break;
            case "crocodile": System.out.println("reptile"); break;
            case "tortoise": System.out.println("reptile"); break;
            case "snake": System.out.println("reptile"); break;
            default: System.out.println("unknown"); break;
        }
    }
    
}
