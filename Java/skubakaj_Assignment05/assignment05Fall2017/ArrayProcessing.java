/*REQUIRED INFORMATION
 * Name: Aj Skubak
 * Course Name/Section: IS4010 001 
 * Assignment #: Assignment 5
 * Due Date: 12 October 2017
 * Description: ArrayProcessing
 * Citations:(for initial code)https://canopy.uc.edu/bbcswebdav/pid-24507175-dt-content-rid-62252921_1/courses/2178-1_22IS4010001/Assignment%2005%20Fall%202017.pdf
 * (framework for mode method) https://stackoverflow.com/questions/4191687/how-to-calculate-mean-median-mode-and-range-from-a-set-of-numbers 
 * (sort function and usage) http://www.tutorialspoint.com/java/util/arrays_sort_int.htm 
 * Misc.: 
 */
package assignment05Fall2017;

import java.util.Arrays;

public class ArrayProcessing {
	private int[] numberArray;
	public ArrayProcessing(int[] numberArray) {
		this.numberArray = numberArray;
	}
	/**
	 *Calculate the average of an array
	 * @return the average
	 */
	public int average() {
		int result = 0;
		//loop to add all iterations of array into result
		for (int i = 0; i < numberArray.length; i++){
			result += numberArray[i];
		}
		//divide sum by length of array and return value
		result /= numberArray.length;
		return result;
	}
	/**
	 * Calculate the mode of the array
	 * mode is the number that appears the most times in the array
	 * @return
	 */
	public int mode() {
		int result = 0; 
		int maxCount = 0;
		//go through each iteration of array and update count when there is more than one instance of a given value
		for (int i = 0; i < numberArray.length; i++){
			int count = 0;
			for(int j = 0; j < numberArray.length; j++){
				if (numberArray[j] == numberArray[i]) count++;
			}
			//whatever value has the highest count will be assigned to maxCount
			if (count > maxCount){
				maxCount = count;
				//corresponding value of the array will be returned
				result = numberArray[i];
			}
		}
		return result;
	}
	/**
	 * Calculate the median of the array
	 * median is the number in the middle of the sorted array
	 * @return
	 */
	public int median() {
		int result = 0;
		//use Arrays function to sort values of numberArray
		Arrays.sort(numberArray);
		//the median will be the number that lies half way through the array (divide by 2). return that number
		result = numberArray[numberArray.length/2];
		return result;
	}
	/**
	 * Calculate the max value in an array
	 * @return The max value
	 */
	public int max() {
		//set result to minimum value in array
		int result = Integer.MIN_VALUE;
		//loop each iteration, if value is larger than result, update result value
		for (int i = 0; i < numberArray.length; i++){
			if (numberArray[i] > result){
				result = numberArray[i];
			}
		}
		return result;
	}
}
