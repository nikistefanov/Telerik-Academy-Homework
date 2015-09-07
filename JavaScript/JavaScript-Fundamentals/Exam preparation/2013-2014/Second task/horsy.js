function solve(params) {
	function getPoints(row, col) {
		return Math.pow(2, row) - col;
	}

	function getRowsAndCols(str) {
		var parts = str.split(' ');
		return [parseInt(parts[0]), parseInt(parts[1])];
	}

	function getValue(params, row, col) {
		return params[row + 1][col];
	}

	var rowsAndCols = getRowsAndCols(params[0]),
		rows = rowsAndCols[0],
		cols = rowsAndCols[1],
		row = rows - 1,
		col = cols - 1,
		points = 0,
		moves = 0,
		used = [];

	var horseMoves = [
		[-2, 1],		[-1, 2],		[1, 2],		[2, 1],
		[2, -1],		[1, -2],		[-1, -2],		[-2, -1]
	];

	while (true) {
		// check if out of the matrix
		if (row >= rows || col >= cols || row < 0 || col < 0) {
			console.log("Go go Horsy! Collected " + points + " weeds");
			break;
		}
		// така се намира номера на index-а на който сме стъпили (с тази формула)
		if (used[row * cols + col]) {
			console.log("Sadly the horse is doomed in " + moves + " jumps");
			break;
		}

		moves = moves + 1;
		points = points + getPoints(row, col);

		var move = horseMoves[getValue(params, row, col) - 1];
		// така се намира номера на index-а на който сме стъпили (с тази формула)
		used[row * cols + col] = true;
		row += move[0];
		col += move[1];
	}
}

solve(['3 5', '54561', '43328', '52388']);
solve(['3 5', '54361', '43326', '52188']);