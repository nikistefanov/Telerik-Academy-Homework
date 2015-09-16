#include <iostream>
#include <iomanip>
#include <string>

using namespace std;

int main()
{
	char forBreak;

	int height;
	char symbol;

	cout << "Please enter the heigth for the pyramid/tree whatever: ";
	cin >> height;

	cout << "Please enter the symbol you want to use: ";
	cin >> symbol;

	int width = (height * 2) - 1;
	int emptySpacesForSide = height - 1;
	int starCount = 1;

	for (int i = 0; i < height; i++)
	{
		// The printing is somehow broken with empty spaces...
		//cout << setw(emptySpacesForSide) << string(starCount, '*') << setw(emptySpacesForSide) << endl;

		cout << string(emptySpacesForSide, ' ') << string(starCount, symbol) << string(emptySpacesForSide, ' ') << endl;
		emptySpacesForSide--;
		starCount += 2;
	}


	cin >> forBreak;

	return 0;
}