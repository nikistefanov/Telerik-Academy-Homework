#include <iostream>
#include <iomanip>
#include <string>

using namespace std;

int main()
{
	char forBreak;

	int height = 11;
	char symbol = '*';

	int width = (height * 2) - 1;
	int emptySpacesForSide = height - 1;
	int starCount = 1;

	for (int i = 0; i < height; i++)
	{
		cout << string(emptySpacesForSide, ' ') << string(starCount, symbol) << string(emptySpacesForSide, ' ') << endl;
		emptySpacesForSide--;
		starCount += 2;
	}


	cin >> forBreak;

	return 0;
}