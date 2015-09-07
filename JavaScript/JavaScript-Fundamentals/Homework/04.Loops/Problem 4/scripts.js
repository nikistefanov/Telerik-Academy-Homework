/*Problem 4. Lexicographically smallest

Write a script that finds the lexicographically smallest and largest property in document, window and navigator objects.*/

var prop,
	list = [];

for (prop in document) {
	list.push(prop);
}

console.log('Smallest propertylist in document: ' + list[0]);
console.log('Largest propertylist in document: ' + list[list.length - 1]);

for (prop in window) {
	list.push(prop);
}

console.log('Smallest propertylist in window: ' + list[0]);
console.log('Largest propertylist in window: ' + list[list.length - 1]);

for (prop in navigator) {
	list.push(prop);
}

console.log('Smallest propertylist in navigator: ' + list[0]);
console.log('Largest propertylist in navigator: ' + list[list.length - 1]);

/*function print() {
	var i;
	for (i in arguments) {
		console.log(arguments[i]);
	}
}

print(navigator);*/
