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

public class DJ extends SoloMusician {
//match base class constructor
	public DJ(String name, String genre) {
		super(name, genre);
		//djs use mixing tables as their main instruments
		this.setMainInstrument("Mixing Table");
	}
	//the best part of every EDM song is when the bass drops
	public String dropTheBass(){
		return(this.getName() + " is about to drop the bass: \n..." + "\nWUB WUB WUB WUB WUB WUB");
	}

}
