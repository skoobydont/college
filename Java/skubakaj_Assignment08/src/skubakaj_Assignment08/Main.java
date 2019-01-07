/*REQUIRED INFORMATION
 * Name: Aj Skubak (skubakaj)
 * Course Name/Section: IS4010 001 
 * Assignment #: Assignment 08
 * Due Date: 16 November 2017
 * Description: Demonstrating OOP Inheritance
 * Citations: 
 * Misc.: Kotlin language
 */

package skubakaj_Assignment08;

public class Main {

	public static void main(String[] args) {
		//declare and instantiate a new band(need name and genre), then add band members and latest hit
		Band arcticMonkeys = new Band("Arctic Monkeys", "Alternative");
		arcticMonkeys.addBandMembers("Alex Turner");
		arcticMonkeys.addBandMembers("Matt Helders");
		arcticMonkeys.addBandMembers("Jamie Cook");
		arcticMonkeys.addBandMembers("Nick O'Malley");
		arcticMonkeys.setLatestHit("Do I Wanna Know?");
		//print out information about the band (both inherited and class specific properties)
		System.out.println(arcticMonkeys.soundCheck());
		System.out.println("Name: " + arcticMonkeys.getName() + "\nGenre: " + arcticMonkeys.getGenre() + "\nLatest Hit: " + 
				arcticMonkeys.getLatestHit() + "\nBand Members: " + arcticMonkeys.getBandMembers() + "\nCan be found on: " + 
				arcticMonkeys.getRadioStation() + "\n");
		
		//declare and instantiate a new dj (need name and genre) and latest hit
		DJ dillonFrancis = new DJ("Dillon Francis", "Electronic Dance Music");
		dillonFrancis.setLatestHit("Say Less ft. G-Eazy");
		//print out information about the dj (inherited and class specific)
		System.out.println(dillonFrancis.soundCheck());
		System.out.println("Name: " + dillonFrancis.getName() + "\nGenre: " + dillonFrancis.getGenre() + "\nLatest Hit: " + 
				dillonFrancis.getLatestHit() + "\nMain Instrument: " + dillonFrancis.getMainInstrument() + "\nCan be found on: " + 
				dillonFrancis.getRadioStation());
		//dj class specific method
		System.out.println(dillonFrancis.dropTheBass() + "\n");
		
		//declare and instantiate a new rapper (need name and genre) and latest hit
		Rapper jCole = new Rapper("J.Cole", "Rap");
		jCole.setLatestHit("4 Your Eyez Only");
		//print information about the rapper (inherited and class specific)
		System.out.println(jCole.soundCheck());
		System.out.println("Name: " + jCole.getName() + "\nGenre: " + jCole.getGenre() + "\nLatest Hit: " + jCole.getLatestHit() + 
				"\nMain Instrument: " + jCole.getMainInstrument() + "\nCan be found on: " + jCole.getRadioStation());
		//rapper specific method
		System.out.println(jCole.freestyle());
	}
}
