// See https://aka.ms/new-console-template for more information
using System;

public class Student
{
    private int _id;
    private string _name;
    private int _passMark = 35;

    public int GetPassMark()
    {
        return this._passMark;
    }

    public void SetID(int ID)
    {
        if (ID <= 0)
        {
            throw new Exception("Student ID cannot be negative.");
        }
        this._id = ID;
    }

    public void SetName(string Name)
    {
        if (string.IsNullOrEmpty (Name))
        {
            throw new Exception("Name cannot be null or empty");
        }
        this._name = Name;
    }

    public void SetPassMarks (int marks)
    {
        if (marks < 35)
        {
            throw new Exception ("You are not passed.");
        }
        this._passMark = marks;
    }

    public int GetID()
    {
        return this._id;
    }

    public string Getname()
    {
        return this._name;
    }

    public int GetMarks()
    {
        return this._passMark;
    }
}

public class Program
{
    static void Main()
    {
        Console.WriteLine("This code prints Result Card of a Student.");
        Console.WriteLine("Enter you ID: ");
        int Id = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter your name: ");
        string Name = Console.ReadLine();

        Console.WriteLine("Enter your marks: ");
        int Marks = int.Parse(Console.ReadLine());

        Student S = new Student();
        S.SetID(Id);
        S.SetName(Name);
        S.SetPassMarks(Marks);

        Console.WriteLine("Result Card: \n");

        Console.WriteLine("Passing Marks: {0}", S.GetPassMark());

        Console.WriteLine("\n Student ID: {0} \n Student Name: {1} \n Student Marks: {2} \n Status: Passed", S.GetID(), S.Getname(), S.GetMarks());
    }
}