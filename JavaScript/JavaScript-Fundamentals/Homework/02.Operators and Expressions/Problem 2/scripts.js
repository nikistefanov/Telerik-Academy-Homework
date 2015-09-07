/*Problem 2. Divisible by 7 and 5

Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.*/

var arrayOfNumbers = [3, 0, 5, 7, 35, 140];

for (var i = 0; i < arrayOfNumbers.length; i++) {	
	console.log(arrayOfNumbers[i] + " is it divided by 7 and 5? \t");

	if (arrayOfNumbers[i] % 5 == 0 && arrayOfNumbers[i] % 7 == 0) {
		 console.log(true);
	}

    else {
        console.log(false);
    }
};
