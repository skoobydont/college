package skubakaj_Assignment09;

public class SiriusBlack extends HarryPotterCharacter {
//constructor from base class
	public SiriusBlack(String characterName) {
		super(characterName);
	}
//following methods inheritted from interface, MagicalPowers
	public void doSomethingMagical() {
		System.out.println(this.getCharacterName() + " turns into a dog!");
	}

	public boolean tryToKillVoldemort() {
		return false;
	}

	public void getSavedByHarryPotterFromAHorribleFate() {
		System.out.println("Harry casts a spell to save " + this.getCharacterName() + "\n");
	}
}
