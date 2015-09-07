var number,
	anotherNumber,
	obj,
	anotherObj;

number = 5;
anotherNumber = deepCopy(number);

console.log(number);
console.log(anotherNumber);

console.log(number === anotherNumber);

obj = {
	name: 'Johnny',
	age: 28
};
anotherObj = deepCopy(obj);

console.log(obj);
console.log(anotherObj);

console.log(obj === anotherObj);

function deepCopy(obj) {
	var cloned,
		prop;

	if (typeof obj !== 'object') {
		return obj;
	}

	cloned = {};
	for (prop in obj) {
		cloned[prop] = deepCopy(obj[prop]);
	}

	return cloned;
}