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
public class NumberPyramid {

    public static void main(String[] args) {
        Scanner s = new Scanner(System.in);
        int n = Integer.parseInt(s.nextLine());
        int count = 1;
        //int num = 1;

        for (int i = 1; i <= n; i++) {
            for (int j = 0; j < i; j++) {

                if (count <= n) {
                    System.out.printf("%d ", count);
                    count++;
                    //num = count;
                } else {
                    break;
                }
            }
            System.out.println();
        }
    }
}
