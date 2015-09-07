//Problem 2. Print Company Information

//A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
//Write a program that reads the information about a company and its manager and prints it back on the console.

using System;
using System.Text;

class CompanyInfo
{
    static void Main()
    {
        
        string star = new string('*', 40);
                
        Console.Write("Enter the name of the company: ");
        string name = Console.ReadLine();
        Console.Write("Enter the address of the company: ");
        string address = Console.ReadLine();
        Console.Write("Enter the phone number of the company: ");
        string phoneNumber = Console.ReadLine();
        Console.Write("Enter the fax number of the company: ");
        string faxNumber = Console.ReadLine();
        Console.Write("Enter the web site of the company: ");
        string webSite = Console.ReadLine();
        Console.Write("Enter the full (first and last) name of the manager: ");
        string managerName = Console.ReadLine();
        Console.Write("Enter the age of the manager: ");
        short managerAge = short.Parse(Console.ReadLine());
        Console.Write("Enter the phone number of the manager: ");
        string managerNumber = Console.ReadLine();

        Console.Write(star);
        Console.Write(@"
Comnpany: {0}
Address: {1}
Tel. {2}
Fax: {4}
Web site: {3}
", name, address, phoneNumber, webSite, faxNumber.Length < 6 ? "(No fax)" : faxNumber);
        Console.WriteLine("Manager: {0} (age: {1}, tel. {2},", managerName, managerAge, managerNumber);
        Console.WriteLine(star);
    }
}
