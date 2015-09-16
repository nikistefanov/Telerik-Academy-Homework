/*
Write a program that counts and outputs the number of digits in N! result.
*/

#include <iostream>

using namespace std;

int findFactorial(int number)
{
	if (number <= 1)
	{
		return 1;
	}
	else
	{
		return number * findFactorial(number - 1);
	}
}

int main()
{
	char forBreak;
	int number;
	int foundedFactorial;
	int digit;
	int counter = 0;

	cout << "Please enter a positive integer: ";
	cin >> number;
	if (number < 0)
	{
		cout << "That is not a positive integer.\n";
	}
	else
	{
		foundedFactorial = findFactorial(number);
		do 
		{
			digit = foundedFactorial % 10;
			foundedFactorial /= 10;
			counter++;
		} 
		while (foundedFactorial > 0);	
		cout << "Number of digits in " << number << "! is: " << counter;
	}

	cin >> forBreak;

	return 0;
}