/*Problem 2. Multiplication Sign

Write a script that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
Use a sequence of if operators.*/

var a,
	b,
	c;

function AddMultiplicationSing(a, b, c) {
	if (a === 0 || b === 0 || c === 0) {
		console.log('0');
	} else if (a < 0 && b > 0 && c > 0) {
		console.log('-');
	} else if (a > 0 && b < 0 && c > 0) {
		console.log('-');
	} else if (a > 0 && b > 0 && c < 0) {
		console.log('-');
	} else if (a < 0 && b < 0 && c < 0) {
		console.log('-');
	} else {
		console.log('+');
	}
}

AddMultiplicationSing(5, 2, 2);
AddMultiplicationSing(-2, -2, 1);
AddMultiplicationSing(-2, 4, 3);
AddMultiplicationSing(0, -2.5, 4);
AddMultiplicationSing(-1, -0.5, -5.1);