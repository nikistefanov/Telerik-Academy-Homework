/*
5.	Write a program that calculates and outputs the total sum of the digits of the first N Fibonacci numbers.
*/

#include <iostream>

using namespace std;

int main()
{
	char forBreak;

	int limit;
	unsigned sum = 0;
	cout << "Enter the limit for the Fibonacci sequnce: ";
	cin >> limit;

	unsigned int f1 = 0;
	unsigned int f2 = 1;
	unsigned int f3 = 0;

	if (limit == 0 || limit == 1)
	{
		cout << f1;
	}
	else
	{
		sum += f1;
		sum += f2;
		for (int i = 2; i < limit; i++)
		{
			f3 = f1 + f2;
			f1 = f2;
			f2 = f3;
			sum += f3;
		}
	}

	cout << "The sum of the digits of the first "<< limit << " Fibonacci numbers is " << sum << endl;

	cin >> forBreak;

	return 0;
}