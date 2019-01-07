// Put your documentation here. Cite your source. Otherwise, do not edit this class.
//Citations: https://canopy.uc.edu/bbcswebdav/pid-24507175-dt-content-rid-62252921_1/courses/2178-1_22IS4010001/Assignment%2005%20Fall%202017.pdf
package assignment05Fall2017;

public class Main {

    public static void main(String[] args) {

        int[] test01 = new int[]{2,2,2,2,2};
        int[] test01Results = new int[]{2,2,2,2};

        int[] test02 = new int[]{1,2,1,3,5,6,6,1,2,2,2,99,100};
        int[] test02Results = new int[]{2,2,17,100};

        int[] test03 = new int[]{100,200,300,400,300};
        int[] test03Results = new int[]{300,300,260,400};

        int[] test04 = new int[]{100};
        int[] test04Results = new int[]{100,100,100,100};

//        int[] test05 = new int[]{100,1};
//        int[] test05Results = new int[]{1,100,50,100};

        int totalTestsFailed = 0;

        totalTestsFailed += test("Test 01", test01, test01Results);
        totalTestsFailed += test("Test 02", test02, test02Results);
        totalTestsFailed += test("Test 03", test03, test03Results);
        totalTestsFailed += test("Test 04", test04, test04Results);
//        totalTestsFailed += test("Test 05", test05, test05Results);

        if (totalTestsFailed == 0) {
            System.out.println("All tests passed.");
        } else {
            System.out.println(totalTestsFailed + " tests failed");
        }
    }

    private static int test(String title, int[] n, int[] expectedResults) {
        int answer;
        int testsFailed = 0;
        System.out.println(title + ":");
        ArrayProcessing a = new ArrayProcessing(n);
        answer = a.mode();
        System.out.print("mode = " + a.mode());
        if (answer != expectedResults[0]) {
            System.out.println(" FAILED, expected " + expectedResults[0]);
            testsFailed++;
        } else {System.out.println("");}

        answer = a.median();
        System.out.print("median = " + a.median());
        if (answer != expectedResults[1]) {
            System.out.println(" FAILED, expected " + expectedResults[1]);
            testsFailed++;
        } else {System.out.println("");}

        answer = a.average();
        System.out.print("average = " + a.average());
        if (answer != expectedResults[2]) {
            System.out.println(" FAILED, expected " + expectedResults[2]);
            testsFailed++;
        } else {System.out.println("");}

        answer = a.max();
        System.out.print("max = " + a.max());
        if (answer != expectedResults[3]) {
            System.out.println(" FAILED, expected " + expectedResults[3]);
            testsFailed++;
        } else {System.out.println("");}

        return testsFailed;
    }
}