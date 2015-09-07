/*Problem 4. Third digit

Write an expression that checks for given integer if its third digit (right-to-left) is 7.*/

var arrayOfNumbers = [5, 701, 1732, 9703, 877, 777877, 9999799];

for (var i = 0; i < arrayOfNumbers.length; i++) {
	console.log("Is in " + arrayOfNumbers[i] + " third digit 7?");

	if (((arrayOfNumbers[i] / 100) % 10 | 0) === 7) {
		console.log(true);
	}
	else {
	console.log(false);
	};
};