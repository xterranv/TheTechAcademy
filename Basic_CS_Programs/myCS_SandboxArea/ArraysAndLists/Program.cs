using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        //LIST EXAMPLES

        List<int> intList = new List<int>();
        intList.Add(4);
        intList.Add(10);
        intList.Add(515);
        intList.Add(200);
        intList.Add(5000);
        intList.Remove(10);

        foreach (int i in intList)
        {
            Console.WriteLine(i);
        }
        
        Console.ReadLine();


        //ARRAY EXAMPLES
        //use an array when you have a Fixed quantity that you know isn't going to change.
        //in an array, once you set the size of it, it's very difficult to change it
        //Also, Another time you will use an Array is when you're storing a very large qty of something
        //Like images into a db.  how to get an image into a db table thru c# is thru a byte array... 
        //which is storing as binary info  
        //Example:  byte[] byteArray = new byte[5000]

        //int[] numArray = new int[5];
        //numArray[0] = 5;
        //numArray[1] = 2;
        //numArray[2] = 10;
        //numArray[3] = 200;
        //numArray[4] = 5000;

        //// more effecient easier way to create the array
        //int[] numArray1 = new int[] { 5, 2, 10, 201, 5000 };

        //// Another way to write an array
        //int[] numArray2 = { 5, 2, 10, 202, 5000, 600, 2300 };

        //// how to change the value of a specific index value in the array.  Here we're changing index 5 from 600 to 650
        //numArray2[5] = 650;

        //Console.WriteLine(numArray2[5]);


        Console.ReadLine();
    }
}
