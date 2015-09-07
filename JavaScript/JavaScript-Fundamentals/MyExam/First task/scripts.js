function solve(args) {
	var rocks = args[0].split(' ').map(Number);
	var count = 0,
		best = 0;

	var isDown = false;
	for (var i = 1; i < rocks.length; i += 1) {
		if (isDown) {
			if (rocks[i - 1] > rocks[i]) {
				count++;
				if (best < count) {
					best = count;
				}
			} else {
				count++;
				if (best < count) {
					best = count;
				}
				if (rocks[i] > rocks[i + 1]) {
					isDown = false;
					count = 0;
				}
			}
		} else if (rocks[i - 1] > rocks[i]) {
			count++;
			isDown = true;
			if (best < count) {
				best = count;
			}
		}
	}
	return best;
}

var test1 = ['5 1 7 4 8'];
var test2 = ['5 1 7 6 3 6 4 2 3 8'];
var test3 = ['10 1 2 3 4 5 4 3 2 1 10'];
var nikiTest = ['5 1 7 6 5 2 6 4 8'];

console.log(solve(test1));
console.log(solve(test2));
console.log(solve(test3));
console.log(solve(nikiTest));