///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  Lab 4 - Searching and Sorting
//	File Name:         Program.cs
//	Description:       The driver program that tests if the Searching and Sorting methods have been implemented
//                     correctly. This file should not be modified.
//	Course:            CSCI 1260-002
//	Author:            Katie Wilson, wilsonkl4@etsu.edu, East Tennessee State University
//	Created:           02/19/2023
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

namespace Lab4_SearchingAndSorting;

public class Program
{
    public static void Main()
    {
        Console.WriteLine();
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("                     INTEGERS                     ");
        Console.WriteLine("--------------------------------------------------");

        int[] numbers = { 84, 85, 75, 45, 26, 71, 17, 77, 34, 94, 26, 28, 11, 47, 9 };

        Console.WriteLine("\nSequential Search:");

        int found71 = Searching.SequentialSearch(numbers, 71);
        DisplayFound(71, found71);

        int found100 = Searching.SequentialSearch(numbers, 100);
        DisplayFound(100, found100);

        Console.WriteLine("\nSelection Sort:");

        Console.WriteLine("\n\tBefore: ");
        DisplayArray(numbers);
        
        Sorting.SelectionSort(numbers);

        Console.WriteLine("\n\tAfter: ");
        DisplayArray(numbers);

        Console.WriteLine("\nBinary Search:");
        found71 = Searching.BinarySearch(numbers, 71);
        DisplayFound(71, found71);

        found100 = Searching.BinarySearch(numbers, 100);
        DisplayFound(100, found100);

        Console.WriteLine();
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("                     STRINGS                      ");
        Console.WriteLine("--------------------------------------------------");

        string[] names = { "Kathy", "Janice", "Andrea", "Wayne", "Kelly", "Sean", "Stephanie", "Jose", "Benjamin", 
            "Nicole", "Jonathan", "Joe", "Samuel", "Victor", "Julie" };

        Console.WriteLine("\nSequential Search:");

        int foundStephanie = Searching.SequentialSearch(names, "Stephanie");
        DisplayFound("Stephanie", foundStephanie);

        int foundBob = Searching.SequentialSearch(names, "Bob");
        DisplayFound("Bob", foundBob);

        Console.WriteLine("\nSelection Sort:");

        Console.WriteLine("\n\tBefore: ");
        DisplayArray(names);

        Sorting.SelectionSort(names);

        Console.WriteLine("\n\tAfter: ");
        DisplayArray(names);

        Console.WriteLine("\nBinary Search:");
        foundStephanie = Searching.BinarySearch(names, "Stephanie");
        DisplayFound("Stephanie", foundStephanie);

        foundBob = Searching.BinarySearch(names, "Bob");
        DisplayFound("Bob", foundBob);

        Console.WriteLine();
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("                      PEOPLE                      ");
        Console.WriteLine("--------------------------------------------------");

        Person[] people = { 
            new Person("Wayne", 34), 
            new Person("Stephanie", 23), 
            new Person("Joe", 47), 
            new Person("Bill", 55), 
            new Person("Ed", 88) 
        };

        Console.WriteLine("\nSequential Search:");

        foundStephanie = Searching.SequentialSearch(people, "Stephanie");
        DisplayFound("Stephanie", foundStephanie);

        foundBob = Searching.SequentialSearch(people, "Bob");
        DisplayFound("Bob", foundBob);

        Console.WriteLine("\nSelection Sort:");

        Console.WriteLine("\n\tBefore: ");
        DisplayArray(people);

        Sorting.SelectionSort(people);

        Console.WriteLine("\n\tAfter: ");
        DisplayArray(people);

        Console.WriteLine("\nBinary Search:");
        foundStephanie = Searching.BinarySearch(people, "Stephanie");
        DisplayFound("Stephanie", foundStephanie);

        foundBob = Searching.BinarySearch(people, "Bob");
        DisplayFound("Bob", foundBob);
    }

    public static void DisplayFound(int numberSearched, int foundResult)
    {
        if (foundResult == -1)
            Console.WriteLine($"\n\t'{numberSearched}' was not found in the array.");
        else
            Console.WriteLine($"\n\t'{numberSearched}' was found at position {foundResult} in the array.");
    }

    public static void DisplayFound(string stringSearched, int foundResult)
    {
        if (foundResult == -1)
            Console.WriteLine($"\n\t'{stringSearched}' was not found in the array.");
        else
            Console.WriteLine($"\n\t'{stringSearched}' was found at position {foundResult} in the array.");
    }

    public static void DisplayArray(int[] array)
    {
        Console.Write("\t");
        for(int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }

    public static void DisplayArray(string[] array)
    {
        Console.Write("\t");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }

    public static void DisplayArray(Person[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }
    }
}