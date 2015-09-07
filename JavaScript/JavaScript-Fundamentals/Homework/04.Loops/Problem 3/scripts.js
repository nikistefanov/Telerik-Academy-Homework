/*Problem 3. Min/Max of sequence

Write a script that finds the max and min number from a sequence of numbers.*/

// prompt-alert browser
var number,
	min,
	max,
	numbers = [];

function MinAndMaxNumber() {

	alert('Problem 3 - Loops Homework. Please enter some numbers.');

	while (number = prompt('Enter number [Enter to exit]')) {
		numbers.push(parseInt(number));
	}

	numbers.sort(function(a, b){return a-b});
	min = numbers.shift();
	max = numbers.pop();

	alert('The smallest number is this sequence is: ' + min + '\n\rThe biggest number is this sequence is: ' + max);
}

MinAndMaxNumber();

// using nodejs console

/*var number,
	min,
	max,
	numbers = [5, 16, 4, 99, 21, 3, 45];

function MinAndMaxNumber() {

	numbers.sort(function(a, b){return a-b});
	min = numbers.shift();
	max = numbers.pop();

	console.log('The smallest number is this sequence is: ' + min);
	console.log('The biggest number is this sequence is: ' + max);
}

console.log(numbers);
MinAndMaxNumber();*/