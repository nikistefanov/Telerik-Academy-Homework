/*Problem 1. Odd or Even

Write an expression that checks if given integer is odd or even.*/

var arr = [3, 2, -2, -1, 0];

for (var i = 0; i < arr.length; i++) {
	console.log(arr[i] + " is it odd? \t" + (arr[i] % 2 == 0 ? "flase" : "true"));
};
