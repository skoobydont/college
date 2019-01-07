/*REQUIRED INFORMATION
 * Name: Sean Panoushek (panousse)
 *  and Aj Skubak (skubakaj)
 * Course Name/Section: IS4010 001 
 * Assignment #: Assignment 06
 * Due Date: 10/19/2017
 * Description: Exception Handling
 * Citations: https://www.javatpoint.com/try-catch-block
 * Misc.: 
 */
package inClass10122017;

public class Assignment06 {

	public static void main(String[] args) {
		int number;
		try {
			//1st test to check if number is divisible by 42
			number = 714;
			isDivisibleBy42(number);
			//if true, then number is divisible and system prints accordingly
			System.out.println(number + " is evenly divisible by 42." + '\n' + number + " / 42 = " + number/42);
		} catch (Exception ex){ //if false, catch exception thrown by isDivisibleBy42() and print message
			System.out.println("Exception caught! " + ex.getMessage());	
		}
		try {
			//2nd test
			number = 500;
			isDivisibleBy42(number);
			//if true, then number is divisible and system prints accordingly
			System.out.println(number + " is evenly divisible by 42." + '\n' + number + " / 42 = " + number/42);
		} catch (Exception ex){ //if false, catch exception thrown by isDivisibleBy42() and print message
			System.out.println("Exception caught! " + ex.getMessage());
		}
	}
	
	public static boolean isDivisibleBy42(int number) throws Exception{
		 boolean a = true;
		 //number is not evenly divisible by 42 if the remainder does not equal 0
		 if (number % 42 != 0){
			 a = false;
			 //throw exception if number is not evenly divisible by 42
			 throw new Exception(number + " is not evenly divisible by 42." + '\n' 
					 + number + " / 42 = " + (number / 42) + "." + (number % 42));
		 } return a; 
	}
}
