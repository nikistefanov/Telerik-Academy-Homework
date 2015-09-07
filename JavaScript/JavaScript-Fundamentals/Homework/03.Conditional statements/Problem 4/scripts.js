/*Problem 4. Sort 3 numbers

Sort 3 real values in descending order.
Use nested if statements.
Note: Don’t use arrays and the built-in sorting functionality.*/

var a,
	b,
	c;

function SortByDescending(a, b, c) {
	if (a === b && b === c) {
		console.log(a + ' ' + b + ' ' + c);
	} else if (a >= b && a >= c) {
		process.stdout.write(a + ' ');
		if (b >= c) {
			console.log(b + ' ' + c);
		} else {
			console.log(c + ' ' + b);
		}
	} else if (b >= a && b >= c) {
		process.stdout.write(b + ' ');
		if (a >= c) {
			console.log(a + ' ' + c);
		} else {
			console.log(c + ' ' + a);
		}
	} else if (c >= a && c >= b) {
		process.stdout.write(c + ' ');
		if (a >= b) {
			console.log(a + ' ' + b);
		} else {
			console.log(b + ' ' + a);
		}
	}
}

SortByDescending(5, 1, 2);
SortByDescending(-2, -2, 1);
SortByDescending(-2, 4, 3);
SortByDescending(0, -2.5, 5);
SortByDescending(-1.1, -0.5, -0.1);
SortByDescending(10, 20, 30);
SortByDescending(1, 1, 1);