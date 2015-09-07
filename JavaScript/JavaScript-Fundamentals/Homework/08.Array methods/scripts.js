function Person(firstname, lastname, age, gender) {
	'use strict';
	if (!this instanceof Person) {
		return new Person(firstname, lastname, age, gender);
	}

	this.firstname = firstname;
	this.lastname = lastname;
	this.age = age;
	this.gender = gender;
}


var people = [
	new Person('Gosho', 'Petrov', 32, false),
	new Person('Bay', 'Ivan', 81, false),
	new Person('Lucy', 'Gushuva', 23, true),
	new Person('Ivanka', 'Ivanova', 18, true),
	new Person('Rich', 'Richerson', 19, false),
	new Person('Vaflio', 'Borecov', 56, false),
	new Person('Mariika', 'Fifova', 14, true)
];


/*Problem 1. Make person

Write a function for creating persons.
Each person must have firstname, lastname, age and gender (true is female, false is male)
Generate an array with ten person with different names, ages and genders*/

function makePerson() {
    'use strict';
    var result = '';

    people.forEach(function (item) {
        result += 'Name: ' + item.firstname + ' ' + item.lastname + ' Age: ' + item.age + ' Is female: ' + item.gender + '\n';
    });

    console.log(result);
}

makePerson();
