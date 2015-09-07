var animal = (function () {
	var animal = {
		// this property 'init' is like a constructor in classic OOP
		init: function (name, age) {
			this.name = name;
			this.age = age;
			return this;
		},
		get name() {
			return this._name;
		},
		set name(value) {
			if (value.lenght < 3) {
				throw new Error('Name cannot be less than 3 symbols!');
			}

			this._name = value;
		},
		toString: function () {
			return this.name + ' ' + this.age;
		}
	};

	return animal;
} ());

var cat = (function (parent) {
	var cat = Object.create(parent);
	
	// one way of inheritance
// 	cat.init = function (name, age, sleep) {
// 		parent.init.call(this, name, age);
// 		this.sleep = sleep;
// 		return this;
// 	},
// 
// 	cat.toString = function () {
// 		var base = parent.toString.call(this);
// 		//return base + ' ' + this.sleep ? 'sleeps' : 'no';
// 		return base + ' ' + this.sleep;
// 	}
	
	// another way
	Object.defineProperty(cat, 'init', {
		value: function (name, age, sleep) {
			parent.init.call(this, name, age);
			this.sleep = sleep;
			return this;
		}
	});

	Object.defineProperty(cat, 'toString', {
		value: function () {
			var base = parent.toString.call(this);
			return base + ' ' + this.sleep;
		}
	});

	return cat;
} (animal));

var someCat = Object.create(cat).init('Maco', 6, true);
console.log(someCat);
console.log(someCat.toString());



