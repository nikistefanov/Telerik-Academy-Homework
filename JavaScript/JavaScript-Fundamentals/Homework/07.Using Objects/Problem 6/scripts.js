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

function group(array, key) {
	var i,
		len = array.length,
		groupedPeople = {};

	for (var i = 0; i < len; i += 1) {
		var keyValue = array[i][key];
		groupedPeople[keyValue] = [];
		for (var k = 0; k < len; k += 1) {
			if (keyValue == array[k][key]) {
				groupedPeople[keyValue].push(array[k]);
			}
		}

	}
	return groupedPeople;
}

console.log(group(people, 'age'));
