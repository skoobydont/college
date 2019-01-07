/*REQUIRED INFORMATION
 * Name: Aj Skubak
 * Course Name/Section: IS4010 001 
 * Assignment #: Assignment01
 * Due Date: 24 August 2017
 * Description: HelloWorld Application
 * Citations: https://stackoverflow.com/questions/2506077/how-to-read-integer-value-from-the-standard-input-in-java
 * Misc.: 
 */
package skubakaj_Assignment01;

import java.util.Scanner;

public class HelloWorld {

	public static void main(String[] args) {
		System.out.println("What up fam?");

		int alpha; 	// declare an integer called alpha.
		
		alpha = 42;
		
		System.out.println("alpha = " + alpha);
		
		//Read from the keyboard into alpha
		Scanner in = new Scanner(System.in);
		alpha = in.nextInt();
	}

}
