/*Problem 7. Is prime

Write an expression that checks if given positive integer number n (n ≤ 100) is prime.*/

function isPrime(number){
    if(number < 2) {
    	return false;
    }

    for(var divider = 2; divider <= Math.sqrt(number); divider++){
        if(!(number % divider)) return false;
    }

    return true;
}

var arrayOfNumbers = [1, 2, 3, 4, 9, 37, 97, 51, -3, 0];

for (var i = 0; i < arrayOfNumbers.length; i++) {	
	process.stdout.write(arrayOfNumbers[i] + " is it a Prime number: ");
	console.log(isPrime(arrayOfNumbers[i]));	
};


