/*
10.	Write a program that inputs an integer and checks whether it is a prime number
*/

#include <iostream>
#include <math.h>

using namespace std;

int main()
{
	char forBreak;
	int number;
	cout << "Enter a positive number: ";
	cin >> number;
	int divider = 2;
	int maxDivider = sqrt(number);
	bool isPrime = true;
	if (number < 0)
	{
		throw "Not a positive number provided...";
	}
	while (isPrime && (divider <= maxDivider))
	{
		if (number % divider == 0)
		{
			isPrime = false;
		}
		divider++;
	}
	cout << number;
	isPrime ? cout << " is" : cout << " is not";
	cout << " a prime number!" << endl;

	cin >> forBreak;

	return 0;
}