/*Problem 7. The biggest of five numbers

Write a script that finds the greatest of given 5 variables.
Use nested if statements.*/

var biggest;

function BiggestNumber(a, b, c, d, e) {
	biggest = a;

	if (b > biggest) {
		biggest = b;
	}
	if (c > biggest) {
		biggest = c;
	}
	if (d > biggest) {
		biggest = d;
	}
	if (e > biggest) {
		biggest = e;
	}
	console.log('The biggest of them is :', biggest);
}

BiggestNumber(5, 2, 2, 4, 1);
BiggestNumber(-2, -22, 1, 0, 0);
BiggestNumber(-2, 4, 3, 2, 0);
BiggestNumber(0, -2.5, 0, 5, 5);
BiggestNumber(-3, -0.5, -1.1, -2, -0.1);
