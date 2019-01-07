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

public class SoloMusician extends Artist {
//need the inherited constructor
	public SoloMusician(String name, String genre) {
		super(name, genre);
	}
	//all solo artists have a main instrument they use
	private String mainInstrument;
	public String getMainInstrument() {return mainInstrument;}
	public void setMainInstrument(String mainInstrument) {this.mainInstrument = mainInstrument;}

}
