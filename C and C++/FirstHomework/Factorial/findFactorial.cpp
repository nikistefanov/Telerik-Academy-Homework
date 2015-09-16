/*
Write a program that inputs a positive integer N and outputs N! (N factorial).
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

	cout << "Please enter a positive integer: ";
	cin >> number;
	if (number < 0)
	{
		cout << "That is not a positive integer.\n";
	}
	else
	{
		cout << number << "! is: " << findFactorial(number) << endl;
		
	}

	cin >> forBreak;

	return 0;
}