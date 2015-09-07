function Solve(input) {
	var result = 1;

	// casting from array from string to numbers
	input = input.map(Number);
	// if var i = 2 - that's how we dont take the input N
	for (var i = 2; i < input.length; i++) {
		if (input[i - 1] > input[i]) {
			result++;
		}
	}
	return result;
}

var input = ['9', // this is the input!
			 '1', '8', '8', '7', '6', '5', '7', '7', '6'];
//['9','1', '8', '8', '7', '6', '5', '7', '7', '6']
//['8','7', '1', '2', '-3', '4', '4', '0', '1'];

console.log(Solve(input));