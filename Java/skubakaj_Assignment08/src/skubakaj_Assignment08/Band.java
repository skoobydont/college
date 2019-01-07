/*REQUIRED INFORMATION
 * Name: Aj Skubak (skubakaj)
 * Course Name/Section: IS4010 001 
 * Assignment #: Assignment 08
 * Due Date: 16 November 2017
 * Description: Demonstrating OOP Inheritance
 * Citations: 
 * Misc.: 
 */

package skubakaj_Assignment08;

import java.util.ArrayList;

public class Band extends Artist {
	//constructor of inheriting class has to match parent class
	public Band(String name, String genre) {
		super(name, genre);
	}
	//need multiple people in a band
	private ArrayList<String> bandMembers = new ArrayList<String>();
	
	//methods to get and add band members
	public ArrayList<String> getBandMembers() {return bandMembers;}
	public void addBandMembers(String member) {bandMembers.add(member);}
	
}
