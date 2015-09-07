function solve(args) {
	var s = +args[0],
		i,
		j,
		k,
		count = 0;

	// loop for checking how many cars will match - 10 wheels
	for (i = 0; i <= s / 10; i += 1) {
		// loop for checking how many cars will match - 4 wheels
		for (j = 0; j <= s / 4; j += 1) {
			// loop for checking how many cars will match - 2 wheels
			for (k = 0; k <= s / 3; k += 1) {
				if ((i * 10 + j * 4 + k * 3) === s) {
					count += 1;
				}
			}
		}
	}
	//console.log(count);
	return count;
}


/*solve(['7']);
solve(['10']);
solve(['40']);*/

var tests = [['7'], ['10'], ['40']];
//foreach!!!
tests.forEach(function(test) {
console.log(solve(test));
});
