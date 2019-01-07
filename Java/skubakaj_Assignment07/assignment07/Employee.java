/*REQUIRED INFORMATION
 * Name: Aj Skubak (skubakaj)
 * Course Name/Section: IS4010 001 
 * Assignment #: Assignment 07
 * Due Date: 26 October 2017
 * Description: Employee Class and calculating amount earned
 * Citations: 
 * Misc.: 
 */
package assignment07;

public class Employee {
	//Declare the four properties necessary for Employee class
	private String firstName; //stores the employee's first name
	private String lastName; //employee's last name
	double hoursWorked; //store how many hours the employee works
	double hourlyRate; //how much the employee makes per hour
	
	//Now to add the get and set methods for each private property 
	//get and set first name 
	public String getFirstName(){return firstName;}
	public void setFirstName(String firstName){this.firstName = firstName;}
	
	//get and set last name
	public String getLastName(){return lastName;}
	public void setLastName(String lastName){this.lastName = lastName;}
	
	//get and set hours worked
	public double getHoursWorked(){return hoursWorked;}
	public void setHoursWorked(double hoursWorked)throws Exception{ //overtime issues?
		if (hoursWorked > 60){ //if the employee is working beyond overtime, throw exception
			throw new Exception("Working too many hours!");
		}
		this.hoursWorked = hoursWorked;
	}
	
	//get and set hourly wage
	public double getHourlyRate(){return hourlyRate;}
	public void setHourlyRate(double hourlyRate) throws Exception{ //we cannot have a negative hourly wage.
		if (hourlyRate < 0){ //if the employee's wage is negative, throw exception
			throw new Exception("Hourly Rate cannot be negative!");
		}
		this.hourlyRate = hourlyRate;
	}
	
	//method to calculate the amount an employee has earned this week
	public double calculateAmountEarned(double hourlyRate, double hoursWorked){
		//weekly pay = hours worked * hourly wage
		double amountEarned = hoursWorked * hourlyRate;
		return amountEarned;
	}
}
