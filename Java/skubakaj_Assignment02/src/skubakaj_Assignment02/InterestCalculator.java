/*REQUIRED INFORMATION
 * Name: Aj Skubak
 * Course Name/Section: IS4010 001 
 * Assignment #: Assignment02
 * Due Date: 7 September 2017
 * Description: Simple Loan Calculator
 * Citations:  
 * * Misc.: 
 */
package skubakaj_Assignment02;

import java.util.Scanner;

public class InterestCalculator {
	
	public static void main(String[] args) {
		int P; //P = principal amount
		float r; //i = interest rate
		int n; //n = number of payment periods
		
		
		Scanner in = new Scanner(System.in); //to read input from keyboard
		System.out.println("Hello! I am your interest calculator. To get started, please enter your principal amount below:");
		P = in.nextInt(); //reads principal amount
		
		System.out.println("Now let's get your interest rate:");
		r = in.nextFloat(); //reads interest rate
		
		System.out.println("Lastly, I will need the number of payment periods:");
		n = in.nextInt(); //reads number of periods
		
		
		System.out.println("Based on that information, the amount of interest will be $" 
				+ (P * r * n)); //(P * r * n) is the simple interest formula
		
		
		
		
	}

}
