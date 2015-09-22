/*
12.	Write a program that prints the length of a hailstone sequence, given the seed N. The seed is entered from the standard input.
*/

# include <iostream>
# include <vector>

using namespace std;

int main()
{
	char forBreak;
	vector<int> sequnce;

	int number;
	cout << "Please enter a positive number(seed): "; 
	cin >> number;

	if (number < 0)
	{
		throw "Not a positive number provided...";
	}

	while (number != 1)
	{
		if (number % 2 == 0)
		{
			number /= 2;
			sequnce.push_back(number);
		}
		else
		{
			number = number * 3 + 1;
			sequnce.push_back(number);
			
		}
	}

	/*for (int i = 0; i < sequnce.size(); i++)
	{
		cout << sequnce[i] << " ";
	}*/

	cout << "The length of a hailstone sequence before the repeating cycle begins is: " << sequnce.size() << endl;


	cin >> forBreak;

	return 0;
}