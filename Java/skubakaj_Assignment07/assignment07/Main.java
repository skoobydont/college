/*REQUIRED INFORMATION
 * Name: Aj Skubak (skubakaj)
 * Course Name/Section: IS4010 001 
 * Assignment #: Assignment 07
 * Due Date: 26 October 2017
 * Description: Employee Class and calculating amount earned
 * Citations: US Currency Formatter: https://stackoverflow.com/questions/13791409/java-format-double-value-as-dollar-amount
 * Misc.: 
 */
package assignment07;

import java.text.NumberFormat;

public class Main {

	public static void main(String[] args) {
		//declare and instantiate this variable to format values to US currency
		NumberFormat currency = NumberFormat.getCurrencyInstance();
		
		//declare and instantiate Employee object
		Employee Test1 = new Employee(); 
		//test #1
		System.out.println("Test #1");
		try{ //test if there are any values sent to the set methods that are out of range 
			Test1.setFirstName("Scott");
			Test1.setLastName("Mescudi");
			Test1.setHoursWorked(40);
			Test1.setHourlyRate(9.55);
			//if all tests pass, print employee's properties and amount earned
			System.out.println(Test1.getFirstName() + " " + Test1.getLastName() + " earns " + currency.format(Test1.getHourlyRate()) + 
					" per hour, worked " + Test1.getHoursWorked() + " hours, and earned " + 
					currency.format(Test1.calculateAmountEarned(Test1.getHourlyRate(), Test1.getHoursWorked())));
		} catch (Exception ex){ //if an exception is thrown, catch it and print exception message
			System.out.println(ex.getMessage());
		}
		//declare and instantiate second Employee
		Employee Test2 = new Employee();
		
		//test #2
		System.out.println("Test #2");
		try{ //test second employee's propeties
			Test2.setFirstName("Marshall");
			Test2.setLastName("Mathers");
			Test2.setHoursWorked(40);
			Test2.setHourlyRate(-20);
			//if everytning is within parameters, print properties and amount earned
			System.out.println(Test2.getFirstName() + " " + Test2.getLastName() + " earns " + currency.format(Test2.getHourlyRate()) + 
					" per hour, worked " + Test2.getHoursWorked() + " hours, and earned " + 
					currency.format(Test2.calculateAmountEarned(Test2.getHourlyRate(), Test2.getHoursWorked())));
		} catch (Exception ex){ //if exception is thrown, catch it and print the message
			System.out.println(ex.getMessage());
		} 	
	}
}
