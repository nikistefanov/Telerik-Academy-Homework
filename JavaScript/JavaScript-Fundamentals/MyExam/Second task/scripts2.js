function solve(params) {
	var rows = parseInt(params[0]),
		cols = parseInt(params[1]),
		tests = parseInt(params[rows + 2]),
		knightMoves = [
			[-2, 1], // up up right
			[-1, 2], // up rigth right
			[1, 2], // down right right
			[2, 1], // down down right
			[2, -1], // down down left
			[1, -2], // down left left
			[-1, -2], // up left left
			[-2, -1] // up up left left
		],
		i, move;

	var field = initField();
	//console.log(field);

	function initField() {
		var field = [],
			letter = 97,
			fieldRows = rows;
		for (var i = 0; i < rows; i++) {
			field[i] = [];
			for (var j = 0; j < cols; j++) {
				field[i][j] = String.fromCharCode(letter++) + fieldRows;
			}
			fieldRows--;
			letter = 97;
		}
		return field;
	}

	var field2 = initFieldWithKandQ();
	//console.log(field2);

	function initFieldWithKandQ() {
		var field = [],
			letter = 97,
			fieldRows = rows;
		for (var i = 0; i < rows; i++) {
			var anotherField = params[2 + i];
			field[i] = [];
			for (var j = 0; j < cols; j++) {
				if (anotherField[j] === '-') {
					field[i][j] = String.fromCharCode(letter++) + fieldRows;
				} else if (anotherField[j] === 'K') {
					field[i][j] = 'K';
					letter++;
				} else if (anotherField[j] === 'Q') {
					field[i][j] = 'Q';
					letter++;
				}
			}
			fieldRows--;
			letter = 97;
		}
		return field;
	}

	function contains(a, obj) {
		for (var i = 0; i < a.length; i++) {
			if (a[i] === obj) {
				return true;
			}
		}
		return false;
	}

	for (i = 0; i < tests; i++) {

		move = params[rows + 3 + i];
		var anotherMoves = move.split(' ');



		var fletter = anotherMoves[0].substr(0, 1),
			fNumber = anotherMoves[0].substr(1, 1);
		var sletter = anotherMoves[1].substr(0, 1),
			sNumber = anotherMoves[1].substr(1, 1);
		var index2 = fNumber - rows;
		if (index2 < 0) {
			index2 = -(index2);
		}
		var index = sNumber - rows;
		if (index < 0) {
			index = -(index);
		}

		function indexOfRowContainingId(id, matrix) {
			for (var i = 0, len = matrix.length; i < len; i++) {
				for (var j = 0, len2 = matrix[i].length; j < len2; j++) {
					if (matrix[i][j] === id) {
						return i + ' ' + j;
					}
				}
			}
			return -1;
		}
		//console.log(indexOfRowContainingId(anotherMoves[0], field));
		var ind = indexOfRowContainingId(anotherMoves[0], field).split(' ');
		//console.log(field2[ind[0]][ind[1]]);
		//console.log(fletter.charCodeAt() + ' ' + fNumber);
		//console.log(sletter.charCodeAt() + ' ' + sNumber);
		if ((fletter.charCodeAt() < 97 || fletter.charCodeAt() > (97 + cols) || fNumber < 1 || fNumber > rows) ||
			(sletter.charCodeAt() < 97 || sletter.charCodeAt() > (97 + cols) || sNumber < 1 || sNumber > rows)) {
			//console.log('no');
		} else if (contains(field2[index], anotherMoves[1])) {
			if (field2[ind[0]][ind[1]] === 'Q') {
				var max = Math.max(fNumber, sNumber),
					min = Math.min(fNumber, sNumber);
				for (i = min; i <= max; i+=1) {
					//console.log(field2[ind[0]][ind[1]]);
				}
				//console.log('Queen');
			}
			//console.log('yes');
		} else {
			//console.log('yes');
		}
		/*if (contains(field[index2], anotherMoves[0])) {

		}*/

		
	}
}

//solve(['3', '4']);
//solve(['5', '8']);

var test = [
	'3',
	'4',
	'--K-',
	'K--K',
	'Q--Q',
	'12',
	'd1 b3',
	'a1 a3',
	'c3 b2',
	'a1 c1',
	'a1 b2',
	'a1 c3',
	'a2 c1',
	'd2 b1',
	'b1 b2',
	'c3 a3',
	'a2 a3',
	'd1 d3'
];

solve(test);

var letter = '*';
var number = -1;
//console.log(letter.charCodeAt());

/*if (letter.charCodeAt() < 97 || number < 1) {
	console.log('No!');
}*/