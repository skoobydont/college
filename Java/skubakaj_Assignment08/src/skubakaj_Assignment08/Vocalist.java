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

public class Vocalist extends SoloMusician {
//need base class constructor
	public Vocalist(String name, String genre) {
		super(name, genre);
		//vocalists specialize in manipulating their vocal range
		this.setMainInstrument("Vocal Range");
	}
	//key changes are fun to sing so long as the song is not already in a high note range
	public String beltFinalRefrain(){
		return(this.getName() + " is going to have to belt this final refrain due to the key change!");
	}

}
