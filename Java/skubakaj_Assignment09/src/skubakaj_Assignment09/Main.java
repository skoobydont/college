package skubakaj_Assignment09;

public class Main {

	public static void main(String[] args) {
		//declare and instantiate a Hagrid object
		Hagrid hagrid = new Hagrid("Hagrid");
		//implement inheritted methods from interface and base class
		hagrid.doSomethingMagical();
		System.out.println(hagrid.tryToKillVoldemort() + ": " + hagrid.getCharacterName() + " does not kill Voldemort");
		hagrid.getSavedByHarryPotterFromAHorribleFate();

		//declare and instantiate a SiriusBlack object
		SiriusBlack siriusBlack = new SiriusBlack("Sirius Black");
		//implement inheritted methods from interface and base class
		siriusBlack.doSomethingMagical();
		System.out.println(siriusBlack.tryToKillVoldemort() + ": " + siriusBlack.getCharacterName() + " does not kill Voldemort");
		siriusBlack.getSavedByHarryPotterFromAHorribleFate();
		
		//declare and instantiate a BellatrixLestrange object
		BellatrixLestrange bellatrix = new BellatrixLestrange("Bellatrix Lestrange");
		//implement inheritted methods from interface and base class
		bellatrix.doSomethingMagical();
		System.out.println(bellatrix.tryToKillVoldemort() + ": " + bellatrix.getCharacterName() + " and Voldemort are on the same team?");
		bellatrix.getSavedByHarryPotterFromAHorribleFate();
		
	}

}
