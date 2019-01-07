package skubakaj_Assignment09;

public abstract class HarryPotterCharacter implements MagicalPowers {
	//name: all characters have
	private String characterName;
	public String getCharacterName() {return characterName;}
	public void setCharacterName(String characterName) {this.characterName = characterName;}
	//add constructor for character class - need a name
	public HarryPotterCharacter(String characterName){
		this.characterName = characterName;
	}
	
}
