#include <iostream>

using namespace std;

int main()
{
	char forBreak;

	int limit;
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
		cout << f1 << ", ";
		cout << f2 << ", ";
		for (int i = 2; i < limit; i++)
		{
			f3 = f1 + f2;
			f1 = f2;
			f2 = f3;
			(i == limit - 1) ? cout << f3 : cout << f3 << ", ";
			//cout << f3 << (i == limit - 1) ? "" : ", ";
		}
	}

	cin >> forBreak;

	return 0;
}