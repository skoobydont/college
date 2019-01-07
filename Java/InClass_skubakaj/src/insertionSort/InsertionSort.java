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

public class InsertionSort {
	// https://introcs.cs.princeton.edu/java/42sort/
    /**
     * Sort an array of Strings
     * @param strings The array to sort. The sort is performed 'in place', meaning that strings is overwritten.
     */
    public static void sort(String[] strings) {
        int n = strings.length;
        for (int i = 1; i < n; i++) {
            for (int j = i; j > 0; j--) {
                if (strings[j-1].compareTo(strings[j]) > 0) {
                    exch(strings, j, j-1);
                } else break;
            }
        }
    }
    private static void exch(String[] s, int i, int j) {
                   String tmp = s[i];
                   s[i] = s[j];
                   s[j] = tmp;
    }
    /**
     * Sort an array of Integers
     * @param integers The array to sort. The sort is performed 'in place', meaning that strings is overwritten.
     */
    public static void sort(int[] integers) {
        int n = integers.length;
        for (int i = 1; i < n; i++) {
            for (int j = i; j > 0; j--) {
                if (integers[j-1] > integers[j]) {
                    exch(integers, j, j-1);
                } else break;
            }
        }
    }
    // Polymorphism!
    private static void exch(int[] integers, int i, int j) {
                   int tmp = integers[i];
                   integers[i] = integers[j];
                   integers[j] = tmp;
    }
}
