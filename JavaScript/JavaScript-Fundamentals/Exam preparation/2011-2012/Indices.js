function Solve(args) {
	var //len = args.map(Number), // TODO: check the method for taking the first index
		arr = args.slice(1).map(Number),
		currentIndex = 0,
		resultNumbers = [],
		visited = [],
		loopStartIndex = -1;

	while (currentIndex >= 0 && currentIndex < arr.length) {
		resultNumbers.push(currentIndex);
		visited[currentIndex] = true;
		//resultNumbers[currentIndex] = 'X';

		currentIndex = arr[currentIndex];
		/*if (arr[currentIndex] === 'X') {
			// loop
			break;
		}*/
		if (visited[currentIndex] == true) {
			loopStartIndex = resultNumbers.indexOf(currentIndex);
			break;
		}
	}

	if (loopStartIndex != -1) {
		var resultString = '';

		for (var i = 0; i < loopStartIndex - 1; i++) {
			resultString += resultNumbers[i] + ' ';
		}

		if (loopStartIndex != 0) {
			resultString += resultNumbers[loopStartIndex - 1] + '(';

		} else {
			resultString += '(';
		}

		for (var i = loopStartIndex; i < resultNumbers.length - 1; i++) {
			resultString += resultNumbers[i] + ' ';
		}

		resultString += resultNumbers[resultNumbers.length - 1] + ')';
		console.log(resultString);
		return resultString;

	} else {
		console.log(resultNumbers.join(' '));
		return resultNumbers.join(' ');
	}
}

var test1 = [
	6,
	1, 2, 3, 5, 7, 8
];

var test2 = [
	6,
	1, 2, 3, 5, 7, 1
];

Solve(test1);
Solve(test2);