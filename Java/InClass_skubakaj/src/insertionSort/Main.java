/*REQUIRED INFORMATION
 * Name: Aj Skubak (skubakaj)
 * Course Name/Section: IS4010 001 
 * Assignment #: Assignment 10
 * Due Date: 21 November 2017
 * Description: Insertion Solution
 * Citations: 
 * Misc.: 
 */

package insertionSort;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.Collections;

public class Main {

	public static void main(String[] args) {
		//declare and instantiate an array of strings called fish
		String[] fish = {"Bass", "Cod", "Salmon", "Swordfish", "Piranha", "Bluegill"};
		//use insertion sort class to sort array
		InsertionSort.sort(fish);
		//print sorted array to console
		//System.out.println(); <-doesn't work, points to memory location of array
		//use loop (enhanced for loop)
		//for(String s: fish) {System.out.println(s);}
		
		//now integer array
		int[] numberList = {58, 2, 13, 69, 42, Integer.MIN_VALUE};
		//insertionsort function
		InsertionSort.sort(numberList);
		//then print sorted list using enhanced for loop
		//for(int i: numberList) {System.out.println(i);} //i is set to each element in array, automatically incremented 
		
		//should we write our own sort algorithm? nah- already has built in sort methods
		int[] newArray = {2, 4, 7, 15, 69, -320};
		//array class sort function
		Arrays.sort(newArray);
		//print each value of newArray
		//for(int i: newArray) {System.out.println(i);};
		
		//declare and instantiate array of turkeys
		ArrayList<Turkey> turkeyArray = new ArrayList<Turkey>();
		turkeyArray.add(new Turkey("George", 16.0, 165));
		turkeyArray.add(new Turkey("Ham Gobbler", 18, 185));
		turkeyArray.add(new Turkey("turNkey", 22, 69));
		turkeyArray.add(new Turkey("Lance", 65, 16));
		//sort arraylist
		//Arrays.sort(turkeyArray);
		Collections.sort(turkeyArray); //works cuz Turkey class implements comparable interface
		//print assorted list
		for(Turkey t: turkeyArray) {System.out.println(t.getWeight());};
	}
}
