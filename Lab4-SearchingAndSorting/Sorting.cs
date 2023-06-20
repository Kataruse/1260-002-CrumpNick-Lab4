///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  Lab 4 - Searching and Sorting
//	File Name:         Sorting.cs
//	Description:       Contains various overloads for sorting using Selection sort.
//	Course:            CSCI 1260-002
//	Author:            Katie Wilson, wilsonkl4@etsu.edu, East Tennessee State University
//                     Nick Crump, CRUMPNA@ETSU.EDU
//	Created:           02/19/2023
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_SearchingAndSorting;

public class Sorting
{
    /// <summary>
    /// Performs a selection sort on arrayToSort; the array is modified by the sort, so it is not returned.
    /// </summary>
    /// <param name="arrayToSort">the array of which you want to sort its items</param>
    public static void SelectionSort(int[] arrayToSort)
    {
        //Repeat, starting with full array, and ignoring the "locked in" items one by one with each iteration
        for (int i = arrayToSort.Length; i > 1; i--)
        {
            //Find the largest
            int largestPos = FindLargest(arrayToSort, i);

            //Swap the largest and the last item, but only if the largest and last item aren't the same
            if (largestPos != i - 1) //if largest is not the same as the last item
            {
                //Swap
                int temp = arrayToSort[largestPos];
                arrayToSort[largestPos] = arrayToSort[i - 1];
                arrayToSort[i - 1] = temp;
            }
        }
    }

    //TODO: Write an overload for the selection sort method that sorts an array of strings instead of an array of integers
    public static void SelectionSort(string[] arrayToSort)
    {
        //Repeat, starting with full array, and ignoring the "locked in" items one by one with each iteration
        for (int i = arrayToSort.Length; i > 1; i--)
        {
            //Find the largest
            int largestPos = FindLargest(arrayToSort, i);

            //Swap the largest and the last item, but only if the largest and last item aren't the same
            if (arrayToSort[i - 1].Length != arrayToSort[largestPos].Length) //if largest is not the same as the last item
            {
                //Swap
                string temp = arrayToSort[largestPos];
                arrayToSort[largestPos] = arrayToSort[i - 1];
                arrayToSort[i - 1] = temp;
            }
        }
    }

    //TODO: Write an overload for the selection sort method that sorts an array of Person objects instead of an array of integers - the comparison should be based on the Person's name
    public static void SelectionSort(Person[] arrayToSort)
    {
        //Repeat, starting with full array, and ignoring the "locked in" items one by one with each iteration
        for (int i = arrayToSort.Length; i > 1; i--)
        {
            //Find the largest
            int largestPos = FindLargest(arrayToSort, i);

            //Swap the largest and the last item, but only if the largest and last item aren't the same
            if (arrayToSort[i - 1].GetName().Length != arrayToSort[largestPos].GetName().Length) //if largest is not the same as the last item
            {
                //Swap
                Person temp = arrayToSort[largestPos];
                arrayToSort[largestPos] = arrayToSort[i - 1];
                arrayToSort[i - 1] = temp;
            }
        }
    }

    /// <summary>
    /// Finds the position of the largest of the first "size" number of items in the given array.
    /// Works in combination with SelectionSort.
    /// </summary>
    /// <param name="array">the array to find the largest value within</param>
    /// <param name="size">how many items in the array to look at, allowing you to ignore "locked in" items</param>
    /// <returns>the position of the largest of the first "size" number of items in the array</returns>
    public static int FindLargest(int[] array, int size)
    {
        int posOfLargest = 0; //Holds the index of the largest item in the array;
                              //Assume that the first item is the largest to start

        //Look through each item in the array - size is used to ignore the "locked in" items
        for (int i = 1; i < size; i++)
        {
            //If the item is largest than our current largest
            if (array[i] > array[posOfLargest])
            {
                //Save the position of the largest item
                posOfLargest = i;
            }
        }

        //Return the largest item in the array
        return posOfLargest;
    }

    //TODO: Write an overload for the find largest method that finds the largest (last alphabetically) string in an array of strings instead of an array of integers
    public static int FindLargest(string[] array, int size)
    {
        int posOfLargest = 0; //Holds the index of the largest item in the array;
                              //Assume that the first item is the largest to start

        //Look through each item in the array - size is used to ignore the "locked in" items
        for (int i = 1; i < size; i++)
        {
            //If the item is largest than our current largest
            if (array[i].Length > array[posOfLargest].Length)
            {
                //Save the position of the largest item
                posOfLargest = i;
            }
        }

        //Return the largest item in the array
        return posOfLargest;
    }

    //TODO: Write an overload for the find largest method that finds the largest Person (by name, last alphabetically) in an array of Person objects instead of an array of integers
    public static int FindLargest(Person[] array, int size)
    {
        int posOfLargest = 0; //Holds the index of the largest item in the array;
                              //Assume that the first item is the largest to start

        //Look through each item in the array - size is used to ignore the "locked in" items
        for (int i = 1; i < size; i++)
        {
            //If the item is largest than our current largest
            if (array[i].GetName().Length > array[posOfLargest].GetName().Length)
            {
                //Save the position of the largest item
                posOfLargest = i;
            }
        }

        //Return the largest item in the array
        return posOfLargest;
    }
}


