/*Problem 1. JavaScript literals
Assign all the possible JavaScript literals to different variables.
Problem 3. Typeof variables
Try typeof on all variables you created.
Problem 4. Typeof null
Create null, undefined variables and try typeof on them.*/


var jsConsole;
var boolVar = true;
var floatVar = 1.25;
var intVar = 99;
var objVar = {};
var strVar = "JavaScript is a woman!";
var nullVar = null;
var undefinedVar;

var arr = [boolVar, floatVar, intVar, objVar, strVar, nullVar, undefinedVar];

for (var i = 0; i < arr.length; i++) {
	console.log("Type = " + typeof(arr[i]))
};

console.log("Type = " + typeof(arr));

