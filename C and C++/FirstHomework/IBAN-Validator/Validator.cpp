#include <string>
#include <iostream>
#include <map>
#include <algorithm>
#include <cctype>

using namespace std;

int main()
{
	// link: https://en.wikipedia.org/wiki/International_Bank_Account_Number
	// IBAN from wiki GB82 WEST 1234 5698 7654 32
	// WEST 12345698765432 GB82
	// 3214282912345698765432161182

	const int ConvertingNumberFromAsciiCode = 55;
	const int IbanLengthBG = 22;
	bool isValid = false;
	int charactersToBeMoved = 4;
	char forBreak;

	//string iban = "BG80 BNBG 9661 1020 3456 78";
	string iban;
	cout << "Please enter IBAN to be checked: ";
	cin >> iban;

	
	
	for (int i = 0; i < charactersToBeMoved; i++)
	{
		iban += iban[i];
		iban[i] = ' ';
	}

	// remove empty spaces
	iban.erase(remove(iban.begin(), iban.end(), ' '), iban.end());

	// check iban length
	if (iban.length() != IbanLengthBG)
	{
		isValid = false;
	}
	else
	{
		string ibanWithOnlyDigits;
		for (int i = 0; i < iban.length(); i++) {
			if (isalpha(iban[i]))
				ibanWithOnlyDigits += to_string(static_cast<int>(iban[i]) - ConvertingNumberFromAsciiCode);
			if (isdigit(iban[i]))
				ibanWithOnlyDigits += iban[i];			
		}

		// I will be honest. That's so far I can go with my knowledge. From this point down I found solution online.
		int start = 0;
		int step = 9;
		string prepended;
		long number = 0;
		while (start  < ibanWithOnlyDigits.length() - step)
		{
			number = stol(prepended + ibanWithOnlyDigits.substr(start, step));
			int remainder = number % 97;
			prepended = to_string(remainder);
			if (remainder < 10)
				prepended = "0" + prepended;
			start = start + step;
			step = 7;
		}
		number = stol(prepended + ibanWithOnlyDigits.substr(start));
		
		if (number % 97 == 1)
		{
			isValid = true;
		}
	}

	cout << "This IBAN is " << (isValid ? "valid!" : "NOT valid!\n");

	cin >> forBreak;

	return 0;
}