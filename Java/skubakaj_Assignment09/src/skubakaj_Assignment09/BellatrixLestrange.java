package skubakaj_Assignment09;

public class BellatrixLestrange extends HarryPotterCharacter {
//constructor from base class
	public BellatrixLestrange(String characterName) {
		super(characterName);
	}
//following methods inheritted from interface, MagicalPowers
	public void doSomethingMagical() {
		System.out.println(this.getCharacterName() + " casts an evil spell!");
	}

	public boolean tryToKillVoldemort() {
		return false;
	}

	public void getSavedByHarryPotterFromAHorribleFate() {
		System.out.println("Harry doesn't save the bad characters...");
	}

}
