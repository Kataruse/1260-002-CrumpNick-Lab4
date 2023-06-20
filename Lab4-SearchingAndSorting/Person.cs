///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  Lab 4 - Searching and Sorting
//	File Name:         Person.cs
//	Description:       Implements a Person class to be used in searching/sorting. This file should not be modified.
//	Course:            CSCI 1260-002
//	Author:            Katie Wilson, wilsonkl4@etsu.edu, East Tennessee State University
//	Created:           02/19/2023
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_SearchingAndSorting;

public class Person
{
    private string name;
    private int age;

    public Person()
    {
        SetName("Bob");
        SetAge(45);
    }

    public Person(string name, int age)
    {
        SetName(name);
        SetAge(age);
    }

    public Person(Person existing)
    {
        SetName(existing.name);
        SetAge(existing.age);
    }

    public string GetName() { return name; }
    public int GetAge() { return age; }
    public void SetName(string name) { this.name = name; }
    public void SetAge(int age) { this.age = age; }

    public override string ToString()
    {
        return $"\n\tName: {name}\n\tAge: {age}";
    }
}
