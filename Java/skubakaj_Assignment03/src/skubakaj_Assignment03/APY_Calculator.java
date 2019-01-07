/*REQUIRED INFORMATION
 * Name: Aj Skubak
 * Course Name/Section: IS4010 001 
 * Assignment #: Assignment03
 * Due Date: 14 September 2017
 * Description: APY Calculator
 * Citations: http://proquest.safaribooksonline.com/book/programming/java/9781118087886/firstchapter#X2ludGVybmFsX0h0bWxWaWV3P3htbGlkPTk3ODExMTgwODc4ODYlMkZuYXZwb2ludC0yMSZxdWVyeT0=
 * * Misc.: used book to find the Math.pow function
 */
package skubakaj_Assignment03;

import java.util.Scanner; //import utility to read user input

public class APY_Calculator {

	public static void main(String[] args) {
		double r; //annual interest rate
		int n; //number of compounding periods
		double APY; //annual percentage yield
		
		Scanner in = new Scanner(System.in); //initialize scanner for input
		System.out.println("Hello! I'm here to help calculate your Annual Percentage Yield.");

		//prompt user to enter interest rate
		System.out.println("First, I will need your annual interest rate: "); 
		r = in.nextDouble(); 
		if(r >= 1 || r <= 0){ //validate r is within range i.e. a decimal
			System.out.println("The rate you entered is out of range.");
			System.out.println("Please try again by entering the rate as a decimal: ");
			r = in.nextDouble(); //permits user to reenter rate without restarting program
		}
		System.out.println("Perfect! Now, enter the number of compounding periods: ");
		n = in.nextInt(); //read number of payments
		
		APY = Math.pow((1 + (r / n)), n) - 1; //formula for adding 1 to r/n raised to the n, minus 1
		System.out.print("Based on this information, your APY is: " + APY);
		in.close();
	}

}
