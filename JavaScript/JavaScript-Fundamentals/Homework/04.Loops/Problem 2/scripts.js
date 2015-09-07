/*Problem 2. Numbers not divisible

Write a script that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time*/

// using nodejs console
/*var i;

function PrintNumber(end) {
	if (end < 1) {
		console.log('Invalid input! "To" number cannot be less than 1!');
		return;
	} else {
		for (i = 1; i <= end; i++) {
			if (!!(i % 3) && !!(i % 7)) {
				process.stdout.write(i + ' ');
				// console.log(i + ' ');
			}
		}
		console.log();
	}
}


PrintNumber(15);*/


// prompt-alert browser
var n,
	i,
	result = [];

function PrintNumbers() {

	alert('This is problem 2 from loops homework. Enter a number so we can print all the numbers from 1 to N that are not divisible by 3 and 7 at the same time.');

	n = prompt('N = ');

	if (n < 1 || isNaN(n)) {
		alert('Invalid input!');
	} else {
		n = +n;
		for (i = 1; i < n + 1; i++) {
			if ((i % 3 !== 0) && (i % 7 !== 0)) {
				result.push(i);
			}
		}
		result = result.join(', ');
		alert(result);
	}
}

PrintNumbers();