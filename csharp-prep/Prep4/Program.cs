using System;
using System.Collections.Generic;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        List <int> nums = new List<int>();
        int userNumber = 1;

         while (userNumber != 0)
         {
            Console.Write("Enter a number: ");
            userNumber = int.Parse(Console.ReadLine());
            nums.Add(userNumber); // ad the number from the user to the array

        }

//remove the last element in the array which is 0
        nums.RemoveAt(nums.Count - 1);

        // find the sum of numbers in the array with the SUM() method
        int sumMethod = nums.Sum();
        Console.WriteLine($"sum is: {sumMethod}");

// finds the sum of numbers in the array with a FOREACH method
        int sums = 0;
        foreach(var num in nums)
        {
            Console.WriteLine($"element in the array: {num}");
            sums += num; // add all the numbers in the array

        }
        // displays the sum of the numbers in the array
        Console.WriteLine();
        Console.WriteLine($"The Sum is: {sums}");
        Console.WriteLine();


        int numsTotal = nums.Count();
        Console.WriteLine($"The total number of items in the list is: {numsTotal}");
        Console.WriteLine();
// finds the average in the array
        float arrAverage = sums / numsTotal;
        Console.WriteLine($"The Average is: {Math.Round(arrAverage, 3)}");
        Console.WriteLine();

// finds the maximum and minimum number in the array
    int numsMax = nums.Max();
    Console.WriteLine($"The largest Number in the list is: {numsMax}");

    int numsMin = nums.Min();
    Console.WriteLine($"The smallest number in the list is: {numsMin}");
    Console.WriteLine();


        List<int> positiveNums = new List<int>();//create a list of positive numbers
        List<int> negativeNums = new List<int>();// create a list of negative numbers

    // add positive and negative numbers to their respective arrays
    foreach (var num in nums)
    {
        if(num >= 0)
        {
            positiveNums.Add(num);
        } 
        else if(num < 0)
        {
            negativeNums.Add(num);
        }

    }
        Console.WriteLine($"smallest positive number is: {positiveNums.Min()}");
        Console.WriteLine($"smallest negative number is: {negativeNums.Min()}");
        Console.WriteLine();


        
    nums.Sort(); // sort the order of elements in the array
    // display elements of the sorted array
    Console.WriteLine("The sorted list: ");
        foreach (var num in nums)
    {
        Console.WriteLine(num);
    }


    }


}