/*Problem 1. Numbers

Write a script that prints all the numbers from 1 to N.*/



// nodejs - console
/*var i;

function PrintNumbers(end) {
	if (end < 1) {
		console.log('Invalid input! "To" number cannot be less than 1!');
		return;
	} else {
		for (i = 1; i <= end; i++) {
			if (i === end) {
				console.log(i);
			} else {
				process.stdout.write(i + ' ');
			}
		}
	}
}

PrintNumbers(10);
console.log('Next sequence:')
PrintNumbers(33);
console.log('Next sequence:')
PrintNumbers(3);
console.log('Next sequence:')
PrintNumbers(-3);*/

// prompt-alert browser
var n,
	i,
	result = [];

function PrintNumbers() {

	alert('This is problem 1 from loops homework. Enter a number so we can print all the numbers from 1 to N.');

	n = prompt('N = ');

	if (n < 1 || isNaN(n)) {
		alert('Invalid input!');
	} else {
		n = +n;
		for (i = 1; i < n + 1; i++) {
			result.push(i);
		}
		result = result.join(', ');
		alert(result);
	}
}

PrintNumbers();