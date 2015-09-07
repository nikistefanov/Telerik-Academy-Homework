function Solve(input) {
	var rowsColsAndJumps = parseNumbers(input[0]);
	var startPosition = parseNumbers(input[1]);

	var rows = rowsColsAndJumps[0],
		cols = rowsColsAndJumps[1],
		allJumps = rowsColsAndJumps[2];

	var currentRow = startPosition[0],
		currentCol = startPosition[1];

	return getAnswer();

	function getAnswer() {
		var field = initField();
		var jumps = readJumps();

		//console.log(jumps);
		//console.log(field);

		var escaped = false;
		var sumOfNumbers = 0;
		var totalJumps = 0;
		var jumpsIndex = 0;

		while (1) {
			if (currentRow < 0 || currentRow >= rows || currentCol < 0 || currentCol >= cols) {
				escaped = true;
				break;
			}

			if (field[currentRow][currentCol] === 'X') {
				escaped = false;
				break;
			}

			sumOfNumbers += field[currentRow][currentCol];
			totalJumps++;

			var currentJump = jumps[jumpsIndex++];
			if (jumpsIndex >= jumps.length) {
				jumpsIndex = 0;
			}

			field[currentRow][currentCol] = 'X';

			currentRow += currentJump.row;
			currentCol += currentJump.col;
		}

		return escaped ? 'escaped ' + sumOfNumbers : 'caught ' + totalJumps;
	}

	function initField() {
		var field = [],
			counter = 1;
		for (var i = 0; i < rows; i++) {
			field[i] = [];
			for (var j = 0; j < cols; j++) {
				field[i][j] = counter++;
			}
		}
		return field;
	}

	function readJumps() {
		var jumps = [];

		for (var i = 2; i < 2 + allJumps; i++) {
			var parsedJump = parseNumbers(input[i]);
			var currentJump = {
				row: parsedJump[0],
				col: parsedJump[1]
			};
			jumps.push(currentJump);
		}
		return jumps;
	}

	function parseNumbers(input) {
		return input.split(' ').map(Number);
	}
}

var input = [
	'6 7 3',
	'0 0',
	'2 2',
	'-2 2',
	'3 -1'
];

console.log(Solve(input));
