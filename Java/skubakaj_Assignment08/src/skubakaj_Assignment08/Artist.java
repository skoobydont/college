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

public class Artist {
	//properties shared by all artists
	private String name;
	private String genre;
	private String radioStation;
	private String latestHit;
	
	//constructor for all artists; must have name and genre
	public Artist(String name, String genre){
		this.name = name;
		this.genre = genre;
		this.radioStation = findRadioStation(genre);
	}
	//method that will be inherited
	public String soundCheck(){
		return(Artist.this.getName() + " is performing a soundcheck from the base class: Artist");
	}
	
	//getter and setters for class properties
	public String getName() {return name;}
	public void setName(String name) {this.name = name;}
	public String getGenre() {return genre;}
	public void setGenre(String genre) {this.genre = genre;}
	public String getRadioStation() {return radioStation;}
	public String getLatestHit() {return latestHit;}
	public void setLatestHit(String latestHit) {this.latestHit = latestHit;}
	
	//method to see what station or outlet the artist can be found based on their genre
	public static String findRadioStation(String genre){
		String station = "";
		if(genre.matches("Country")){
			station = "105.1, WUBE-FM";
		} else if(genre.matches("Alternative")){
			station = "100.7 or 106.3, The Project";
		} else if(genre.matches("Rock")){
			station = "102.7, WEBN";
		} else if(genre.matches("Pop")){
			station = "Kiss 107.1";
		} else if(genre.matches("Rap")){
			station = "101.1, The Wiz";
		} else station = "YouTube or Spotify";
		return station;
	}
}

