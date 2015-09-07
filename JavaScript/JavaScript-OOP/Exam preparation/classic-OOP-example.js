var Animal = (function () {
	// validate function....
	function Animal(name, age) {
		// call the validating function
		this.name = name;
		this.age = age;
	};

	Animal.prototype.toString = function () {
		return this.name + ' ' + this.age;
	};

	Animal.prototype.eats = function () {
		return this.name + ' eats....';
	};

	return Animal;
} ());

var Cat = (function (parent) {
	function Cat(name, age, sleep) {
		// using the parent constructor with .call(this...)
		parent.call(this, name, age);
		this.sleep = sleep;
	};
	
	// inheritance
	Cat.prototype = parent.prototype;
	
	
	// override toString()
	Cat.prototype.toString = function () {
		var base = parent.prototype.toString().call(this);
		return base + ' ' + this.sleep;
	};

	return Cat;
} (Animal));

var kitty = new Cat ('Macoop', 2, false);

console.log(kitty.eats());
//console.log(kitty.toString());