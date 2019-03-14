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
public class EnterEvenNumber {

    public static void main(String[] args) {
        Scanner s = new Scanner(System.in);
        while (true) {
            try {
                int n = Integer.parseInt(s.nextLine());
                if (n % 2 == 0) {
                    System.out.println("Even number entered: " + n);
                    break;
                } else {
                    System.out.println("The number is not even.");
                    continue;
                }

            } catch (NumberFormatException n) {
                System.out.println("Invalid number!");
                continue;
            }

        }
    }

}
