var people = [{
	firstname: 'Gosho',
	lastname: 'Petrov',
	age: 32
}, {
	firstname: 'Bay',
	lastname: 'Ivan',
	age: 81
}, {
	firstname: 'Lucy',
	lastname: 'Gushuva',
	age: 23
}, {
	firstname: 'Rich',
	lastname: 'Richerson',
	age: 19
}, {
	firstname: 'Vaflio',
	lastname: 'Borecov',
	age: 56
}, {
	firstname: 'Mariika',
	lastname: 'Fifova',
	age: 14
}];

function compareAge(x, y) {
    return x.age - y.age;
}

people.sort(compareAge);
console.log('The youngest person is:');
console.log(people[0].firstname + ' age ' + people[0].age);