var numbers = [4, 3, 1, 1, 3, 4, 3, 4, 2, 3, 4, 4, 3, 1, 2, 4, 3, 9, 3];

numberAppearance(numbers, 4);

function numberAppearance(numbers, number) {
	var count = 0,
		i,
		len = numbers.length;

	for (i = 0; i < len; i += 1) {
		if (numbers[i] == number) {
			count += 1;
		}
	}
	console.log('Number: ' + number + ' appears ' + count + ' times!');
}