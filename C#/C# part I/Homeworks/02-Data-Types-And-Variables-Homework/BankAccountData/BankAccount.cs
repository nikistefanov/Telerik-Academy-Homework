//Problem 11. Bank Account Data

//A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
//Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.

using System;
class BankAccount
{
    static void Main()
    {
        Console.Title = "Bank account details";
        string firstName = "Rich";
        string middleName = "Richert";
        string lastName = "Richerson";
        string holder = firstName + " " + middleName + " " + lastName;
        decimal balance = 2975621.96M;
        string bankName = "UBB";
        string iban = "BG78UBB215523483";
        long firstCard = 4300258765885647;
        long secondCard = 4301336616457841;
        long thirdCard = 4301336714234578;

        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine(@"The details of this account are as following:
Holder:             {0}
Current balance:    {1}$
Name of the bank:   {2}
IBAN:               {3}
***Credit cards***
Visa:               {4}
Visa Electron:      {5}
MasterCard:         {6}", holder, balance, bankName, iban, firstCard, secondCard, thirdCard);
    }
}
