///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  Lab 4 - Searching and Sorting
//	File Name:         Searching.cs
//	Description:       Contains various overloads for searching using Sequential and Binary searches.
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

public class Searching
{
    /// <summary>
    /// This method searches an array for a specified item using the sequential search algorithm.
    /// If the value is found in the array, it's index in the array is returned.
    /// Otherwise, -1 is returned to denote the item is not within the array.
    /// </summary>
    /// <param name="arrayToSearch">the array of values to search</param>
    /// <param name="itemToFind">the item to search for in the array</param>
    /// <returns>the position of the item to find, if found; otherwise, -1</returns>
    public static int SequentialSearch(int[] arrayToSearch, int itemToFind)
    {
        int index = 0;      //looping variable
        int foundPos = -1;  //the position that we find the item we are searching for at;
                            //-1 can't be an index, so we can use it to denote we didn't find the item
        bool found = false; //whether or not we have found the item we are searching for

        //Go through the array one element at a time, OR until we found the item
        while (index < arrayToSearch.Length && !found)
        {
            //For each element of the array, check if that element is the one we are searching for
            if (arrayToSearch[index] == itemToFind)
            {
                //If so, we found it and we can return that position
                found = true;
                foundPos = index;
            }

            //If not, keep checking
            index++; //go to next element
        }

        //Return -1 if not found, or the index of where it was found if we did find it
        return foundPos;
    }

    //TODO: Write an overload for the sequential search method that searches an array of strings instead of an array of integers
    public static int SequentialSearch(string[] arrayToSearch, string itemToFind)
    {
        for (int i = 0; i < arrayToSearch.Length; i++)
        {
            if(itemToFind == arrayToSearch[i])
            {
                return i;
            }
        }
        return -1;
    }

    //TODO: Write an overload for the sequential search method that searches an array of Person objects instead of an array of integers - the comparison should be based on the Person's name
    public static int SequentialSearch(Person[] arrayToSearch, string itemToFind)
    {
        for (int i = 0; i < arrayToSearch.Length; i++)
        {
            if (itemToFind == arrayToSearch[i].GetName())
            {
                return i;
            }
        }
        return -1;
    }

    /// <summary>
    /// Performs a binary search on arrayToSearch to attempt to find itemToFind
    /// </summary>
    /// <param name="arrayToSearch">the array to search for the value; assumed to be sorted</param>
    /// <param name="itemToFind">the item to search for in arrayToSearch</param>
    /// <returns>the position of the found item, if found; else -1 if not found; 
    /// undefined behavior for unsorted arrayToSearch</returns>
    public static int BinarySearch(int[] arrayToSearch, int itemToFind)
    {
        int first = 0;                          //the first array element; used to 'eliminate' half the array
        int last = arrayToSearch.Length - 1;    //the last array element; used to 'eliminate' half the array
        int middle;                             //the middle item
        int foundPos = -1;                      //the position of item to find, or -1 if not found
        bool found = false;                     //whether or not we have found the item 

        //Repeat the process while we haven't found the value and there are still items in the array we haven't
        //eliminated
        while (!found && first <= last)
        {
            //Check the middle element and see if it is the item we are searching for
            middle = (first + last) / 2;
            if (arrayToSearch[middle] == itemToFind) //if the middle if the item we are searching for
            {
                //If so, we found it and can return that position
                found = true;
                foundPos = middle;
            }
            else if (arrayToSearch[middle] > itemToFind) //if middle item > item to find
            {
                //then, eliminate latter half
                last = middle - 1;
            }
            else //if middle item < item to find
            {
                //then, eliminate first half
                first = middle + 1;
            }
        }

        return foundPos;
    }

    //TODO: Write an overload for the binary search method that searches an array of strings instead of an array of integers
    public static int BinarySearch(string[] arrayToSearch, string itemToFind)
    {
        int first = 0;                          //the first array element; used to 'eliminate' half the array
        int last = arrayToSearch.Length - 1;    //the last array element; used to 'eliminate' half the array
        int middle;                             //the middle item
        int foundPos = -1;                      //the position of item to find, or -1 if not found
        bool found = false;                     //whether or not we have found the item 

        //Repeat the process while we haven't found the value and there are still items in the array we haven't
        //eliminated
        while (!found && first <= last)
        {
            //Check the middle element and see if it is the item we are searching for
            middle = (first + last) / 2;
            if (itemToFind.CompareTo(arrayToSearch[middle]) == 0) //if the middle if the item we are searching for
            {
                //If so, we found it and can return that position
                found = true;
                foundPos = middle;
            }
            else if (itemToFind.CompareTo(arrayToSearch[middle]) < 0) //if middle item > item to find
            {
                //then, eliminate latter half
                last = middle - 1;
            }
            else //if middle item < item to find
            {
                //then, eliminate first half
                first = middle + 1;
            }
        }

        return foundPos;
    }

    //TODO: Write an overload for the binary search method that searches an array of Person objects instead of an array of integers - the comparison should be based on the Person's name
    public static int BinarySearch(Person[] arrayToSearch, string itemToFind)
    {
        int first = 0;                          //the first array element; used to 'eliminate' half the array
        int last = arrayToSearch.Length;        //the last array element; used to 'eliminate' half the array
        int middle;                             //the middle item
        int foundPos = -1;                      //the position of item to find, or -1 if not found
        bool found = false;                     //whether or not we have found the item 

        //Repeat the process while we haven't found the value and there are still items in the array we haven't
        //eliminated
        while (!found && first <= last)
        {
            //Check the middle element and see if it is the item we are searching for
            middle = (first + last) / 2;
            if (itemToFind.CompareTo(arrayToSearch[middle].GetName()) == 0) //if the middle if the item we are searching for
            {
                //If so, we found it and can return that position
                found = true;
                foundPos = middle;
            }
            else if (itemToFind.CompareTo(arrayToSearch[middle].GetName()) < 0) //if middle item > item to find
            {
                //then, eliminate latter half
                last = middle - 1;
            }
            else //if middle item < item to find
            {
                //then, eliminate first half
                first = middle + 1;
            }
        }

        return foundPos;
    }
}
