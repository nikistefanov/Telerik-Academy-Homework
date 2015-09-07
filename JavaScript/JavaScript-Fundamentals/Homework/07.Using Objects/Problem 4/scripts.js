var hasProp,
	obj,
	anotherObj;
obj = {
	name: 'Buhar',
	age: 28
};

anotherObj = {
	length: 32,
	height: 120
};

console.log(hasProp = hasProperty(obj, 'length'));
console.log(hasProp = hasProperty(anotherObj, 'length'));

function hasProperty(obj, property) {
	if (obj.hasOwnProperty(property)) {
		return true;
	} else {
		return false;
	}
}