/*Problem 5. Third bit

Write a boolean expression for finding if the bit #3 (counting from 0) of a given integer.
The bits are counted from right to left, starting from bit #0.
The result of the expression should be either 1 or 0.*/

var arrayOfNumbers = [5, 8, 0, 15, 5343, 62241];

for (var i = 0; i < arrayOfNumbers.length; i++) {
	var bitIndex = 3;
	var mask = 1 << bitIndex;
	var numberAndMask = arrayOfNumbers[i] & mask;
	var bit = numberAndMask >> bitIndex;
	
	process.stdout.write("Bit #3 in the number " + arrayOfNumbers[i] + " is: " );
	console.log(bit == 1 ? "1" : "0");
};
