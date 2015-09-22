/*
Write a program that outputs the first N natural numbers in a square spiral of size S like that:
*/

#include <iostream>
#include <string>
#include <vector>

using namespace std;

void some_function(int &s)
{
	const int const_user_input = s;
	return;
}

int main()
{
	char forBreak;

	int maxNumberToBeDisplayed;
	cout << "Please enter a positive integer: ";
	cin >> maxNumberToBeDisplayed;

	if (maxNumberToBeDisplayed < 0)
	{
		cout << "That is not a positive integer.\n";
	}


	const int s = 5;
	// is there a way so I can use variable provided by the user and make it constant so that it can be used to determine the size of the array?
	//vector<int> matrix(s)(s);
	int matrix[s][s];
	int digit = 1;
	int currentRow = 0;
	int currentCol = 0;
	int side = s;
	bool isReached = false;

	while (digit <= s * s)
	{
		for (int i = 0; i < side; i++)
		{
			if (digit > maxNumberToBeDisplayed) isReached = true;
			matrix[currentRow][currentCol] = isReached ? 0 : digit;
			digit++;
			currentCol++;
		}

		side--;
		currentCol--;
		currentRow++;
		for (int i = 0; i < side; i++)
		{
			if (digit == maxNumberToBeDisplayed) isReached = true;
			matrix[currentRow][currentCol] = isReached ? 0 : digit;
			digit++;
			currentRow++;
		}
		currentRow--;
		currentCol--;
		for (int i = 0; i < side; i++)
		{
			if (digit == maxNumberToBeDisplayed) isReached = true;
			matrix[currentRow][currentCol] = isReached ? 0 : digit;
			digit++;
			currentCol--;
		}
		side--;
		currentCol++;
		currentRow--;

		for (int i = 0; i < side; i++)
		{
			if (digit == maxNumberToBeDisplayed) isReached = true;
			matrix[currentRow][currentCol] = isReached ? 0 : digit;
			digit++;
			currentRow--;
		}
		currentCol++;
		currentRow++;
	}

	for (int row = 0; row < s; row++)
	{
		for (int col = 0; col < s; col++)
		{
			if (matrix[row][col] < 10)
			{
				cout << string(3, ' ') << matrix[row][col];
			}
			else
			{
				cout << string(2, ' ') << matrix[row][col];
			}
		}
		cout << "\n";
	}


	delete[] matrix;

	cin >> forBreak;

	return 0;
}