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

public class Rapper extends SoloMusician {
//base class constructor
	public Rapper(String name, String genre) {
		super(name, genre);
		//rappers are distinguishable by their use of poetic lyrics
		this.setMainInstrument("Lyrics");
	}
	//the core function of rapping
	public String freestyle(){
		return(this.getName() + " is about to freestyle!");
	}

}
