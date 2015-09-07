/*Problem 1. Exchange if greater

Write an if statement that takes two double variables a and b and exchanges their values if the first one is greater than the second.
As a result print the values a and b, separated by a space.*/

var a,
	b,
	greater;

function ExchangeGreater(a, b) {
	greater = a;
	if (a === b) {
		console.log('They are equal!');
	} else if (b > a) {
		greater = b;
		console.log('Second value is greater: ' + greater);
	} else {
		console.log('First value is greater: ' + greater);
	}
}

ExchangeGreater(5, 2);
ExchangeGreater(3, 4);
ExchangeGreater(5.5, 4.5);