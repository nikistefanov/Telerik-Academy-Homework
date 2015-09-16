#include <iostream>
#include <iomanip> 

using namespace std;

bool isValidSide(int x, int y, int z)
{
	if ((x + y > z) && (y + z > x) && (x + z > y))
	{
		return true;
	}
	else
	{
		return false;
	}
}

int main()
{
	char forBreak;

	int a;
	int b;
	int c;

	cout << "Plese enter side a value for side A: ";
	cin >> a;
	cout << "Plese enter side a value for side B: ";
	cin >> b;
	cout << "Plese enter side a value for side C: ";
	cin >> c;

	if (a < 0 || b < 0 || c < 0)
	{
		cout << "Nope! Those values cannot be a side for a triangle!";
	}


	cout << "Sides: " << a << setw(3) << b << setw(3) << c;

	if (isValidSide(a, b, c))
	{
		cout << " can ";
	}
	else 
	{
		cout << " cannot ";
	}
	cout << "be sides for a triangle!";

	cin >> forBreak;
	
	return 0;
}