/*Problem 5. Digit as word

Write a script that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English).
Print “not a digit” in case of invalid input.
Use a switch statement.*/

var digit;

function DigitAsWord(digit) {
	switch (digit) {
		case 0:
			console.log('Zero');
			break;
		case 1:
			console.log('One');
			break;
		case 2:
			console.log('Two');
			break;
		case 3:
			console.log('Three');
			break;
		case 4:
			console.log('Four');
			break;
		case 5:
			console.log('Five');
			break;
		case 6:
			console.log('Six');
			break;
		case 7:
			console.log('Seven');
			break;
		case 8:
			console.log('Eight');
			break;
		case 9:
			console.log('Nine');
			break;
		default:
			console.log('Not a digit!');
			break;
	}
}

digit = +digit;

DigitAsWord(2);
DigitAsWord(1);
DigitAsWord(0);
DigitAsWord(5);
DigitAsWord(-0.1);
DigitAsWord('hi');
DigitAsWord(9);
DigitAsWord(10);

