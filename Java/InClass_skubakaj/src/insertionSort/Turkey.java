/*REQUIRED INFORMATION
 * Name: Aj Skubak (skubakaj)
 * Course Name/Section: IS4010 001 
 * Assignment #: Assignment 10
 * Due Date: 21 November 2017
 * Description: Insertion Solution
 * Citations: 
 * Misc.: 
 */

package insertionSort;
/**
 * model of a Thanksgiving turkey on table ready to eat
 * @author skubakaj
 *
 */
public class Turkey implements Comparable<Turkey> {
	//add properties for name, weight, internal temperature
	private String name;
	private double weight;
	private int internalTemp;
	//need constructor for turkey class
	public Turkey(String name, double weight, int internalTemp){
		setName(name);
		setWeight(weight);
		setInternalTemp(internalTemp);
	}
	
	//getters and setters for each property
	public String getName() {return name;}
	public void setName(String name) {this.name = name;}
	public double getWeight() {return weight;}
	public void setWeight(double weight) {this.weight = weight;}
	public int getInternalTemp() {return internalTemp;}
	public void setInternalTemp(int internalTemp) {this.internalTemp = internalTemp;}

	//implementing inherited comparable interface function
	public int compareTo(Turkey o) {
		return this.weight > o.getWeight() ? -1: 1;
	}
	
}
