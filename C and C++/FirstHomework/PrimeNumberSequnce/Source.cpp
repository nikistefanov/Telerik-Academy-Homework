/*
11.	Write a program that calculates the following:
R = p1 – p2 + p3 – p4…  pN
where pi is the i-th prime number. N is input by the user.

*/

#include <iostream>
#include <math.h>
#include <vector>

using namespace std;

int main()
{
	char forBreak;
	int limit;
	cout << "Enter a positive number: ";
	cin >> limit;
	int result = 0;
	int count = 1;
	vector<bool> primeNumbers (limit);

	/*for (int i = 0; i < limit; i++)
	{
		primeNumbers.push_back = false;
	}*/

	for (int i = 2; i < sqrt(limit); i++)
	{
		if (primeNumbers[i] == false)
		{
			for (int j = i * i; j < limit; j += i)
			{
				primeNumbers[j] = true;
			}
		}
	}

	for (int i = 2; i < limit; i++)
	{
		if (!primeNumbers[i])
		{
			// this will print all the prime numbers
			//cout << i << " ";
			if (count % 2 == 0)
			{
				result -= i;
			}
			else
			{
				result += i;
			}
			count++;
		}
	}

	cout << "Using this formula: R = p1 - p2 + p3 - p4...pN the result of all the prime numbers from 0 to " << limit << " is: " << result << endl;

	cin >> forBreak;

	return 0;
}