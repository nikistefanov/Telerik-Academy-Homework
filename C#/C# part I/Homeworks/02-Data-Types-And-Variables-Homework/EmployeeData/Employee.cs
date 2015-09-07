//Problem 10. Employee Data

//A marketing company wants to keep record of its employees. Each record would have the following characteristics:

//First name
//Last name
//Age (0...100)
//Gender (m or f)
//Personal ID number (e.g. 8306112507)
//Unique employee number (27560000…27569999)
//Declare the variables needed to keep the information for a single employee using appropriate primitive data types. Use descriptive names. Print the data at the console.

using System;

class Employee
{
    static void Main()
    {
        Console.Title = "Employee record";
        Console.ForegroundColor = ConsoleColor.White;

        Console.Write("Enter the first name of the employee: ");
        string firstName = Console.ReadLine();
        Console.Write("Enter the last name of the employee: ");
        string lastName = Console.ReadLine();
        string fullName = firstName + " " + lastName;

        Console.Write("Enter the age of the employee: ");
        byte age = byte.Parse(Console.ReadLine());

        Console.Write("Enter the gender (m or f) of the employee: ");
        char gender = char.Parse(Console.ReadLine());       

        Console.WriteLine("Enter the personal ID of the employee: ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(new string('*', 3) + "From 8306110000 to 8306119999" + new string('*', 3 ));
        Console.ForegroundColor = ConsoleColor.White;
        long personalID = long.Parse(Console.ReadLine());

        Console.WriteLine("Enter the unique employee number: ");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(new string('*', 3) + "From 27560000 to 27569999" + new string('*', 3));
        Console.ForegroundColor = ConsoleColor.White;
        int uniqueNum = int.Parse(Console.ReadLine());

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("The data of this employee is: ");
        Console.WriteLine(@"
Name:           {0}
Age:            {1}
Gender:         {2}
Personal ID:    {3}
Unique Number:  {4}", fullName, age, gender, personalID, uniqueNum);

    }
}
