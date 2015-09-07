/* Task Description */
/* 
	Create a function constructor for Person. Each Person must have:
	*	properties `firstname`, `lastname` and `age`
		*	firstname and lastname must always be strings between 3 and 20 characters, containing only Latin letters
		*	age must always be a number in the range 0 150
			*	the setter of age can receive a convertible-to-number value
		*	if any of the above is not met, throw Error 		
	*	property `fullname`
		*	the getter returns a string in the format 'FIRST_NAME LAST_NAME'
		*	the setter receives a string is the format 'FIRST_NAME LAST_NAME'
			*	it must parse it and set `firstname` and `lastname`
	*	method `introduce()` that returns a string in the format 'Hello! My name is FULL_NAME and I am AGE-years-old'
	*	all methods and properties must be attached to the prototype of the Person
	*	all methods and property setters must return this, if they are not supposed to return other value
		*	enables method-chaining
*/
function solve() {
	var Person = (function () {
		function validateName(value) {
			if (typeof (value) !== 'string') {
				throw new Error('Invalid name!');
			}

			if (value.length > 20 || value.length < 3) {
				throw new Error('Name cannot be less than 3 symbols and more than 20 symbols!');
			}

			if (!(/^[a-zA-Z]*$/.test(value))) {
				throw new Error('Name must containing only Latin letters!');
			}
		};

		function Person(firstname, lastname, age) {
			this.firstname = firstname;
			this.lastname = lastname;
			this.age = age;
		}

		Object.defineProperty(Person.prototype, 'firstname', {
			get: function () {
				return this._firstname;
			},

			set: function (value) {
				validateName(value);
				this._firstname = value;
				return this;
			}
		});

		Object.defineProperty(Person.prototype, 'lastname', {
			get: function () {
				return this._lastname;
			},

			set: function (value) {
				validateName(value);
				this._lastname = value;
				return this;
			}
		});

		Object.defineProperty(Person.prototype, 'age', {
			get: function () {
				return this._age;
			},

			set: function (value) {
				if (value != Number(value)) {
					throw new Error('Age must be a valid number');
				}

				if (value < 0 || value > 150) {
					throw new Error('Damn! You cannot be ' + value + ' years old!');
				}

				this._age = value;
				return this;
			}
		});

		Object.defineProperty(Person.prototype, 'fullname', {
			get: function () {
				return this._firstname + ' ' + this._lastname;
			},

			set: function (value) {
				var names = value.split(' ');
				this.firstname = names[0];
				this.lastname = names[1];
			}
		});

		Person.prototype.introduce = function () {
			return 'Hello! My name is ' + this.fullname + ' and I am ' + this.age + '-years-old';
		}

		// 		Object.defineProperties(Person.prototype, {
		// 			'firstname': {
		// 				get: function () {
		// 					return this._firstname;
		// 				},
		// 
		// 				set: function (value) {
		// 					validateName(value);
		// 					this._firstname = value;
		// 					return this;
		// 				}
		// 			},
		// 
		// 			'lastname': {
		// 				get: function () {
		// 					return this._lastname;
		// 				},
		// 
		// 				set: function (value) {
		// 					validateName(value);
		// 					this._lastname = value;
		// 					return this;
		// 				}
		// 			},
		// 
		// 			'age': {
		// 				get: function () {
		// 					return this._age;
		// 				},
		// 
		// 				set: function (value) {
		// 					if (value != Number(value)) {
		// 						throw new Error('Age must be a valid number');
		// 					}
		// 
		// 					if (value < 0 || value > 150) {
		// 						throw new Error('Damn! You cannot be ' + value + ' years old!');
		// 					}
		// 
		// 					this._age = value;
		// 					return this;
		// 				}
		// 			},
		// 
		// 			'fullname': {
		// 				get: function () {
		// 					return this._firstname + ' ' + this._lastname;
		// 				},
		// 
		// 				set: function (value) {
		//                     var names = value.split(' ');
		//                     this.firstname = names[0];
		//                     this.lastname = names[1];
		//                 }
		// 			}
		// 		});		

		return Person;
	} ());

	// var p = new Person('Pich', 'Tarikatov', 19);
	// console.log(p.introduce());

	return Person;
}
module.exports = solve;
 
//solve();

