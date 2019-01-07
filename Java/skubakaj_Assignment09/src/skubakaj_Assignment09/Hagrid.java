package skubakaj_Assignment09;

public class Hagrid extends HarryPotterCharacter {
//constructor for harry potter characters
	public Hagrid(String characterName) {
		super(characterName);
	}
//following methods inheritted from interface, MagicalPowers
	public void doSomethingMagical() {
		System.out.println(this.getCharacterName() + " tells Harry he is a wizard");
	}

	public boolean tryToKillVoldemort() {
		return false;
	}

	public void getSavedByHarryPotterFromAHorribleFate() {
		System.out.println("Harry casts a spell to save " + this.getCharacterName() + "\n");
	}
}
