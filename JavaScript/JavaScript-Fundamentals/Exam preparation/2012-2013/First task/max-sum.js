//['9', -9', '-8', '-8','-7', '-6','-5','-1','-7','-6']
// ['8','1','6','-9','4','4','-2','10','-1']

function Solve(args) {
	//args = args.map(Number); 
	//this (^) is shorter version of this:
	/*var numbers = [];
	for (var i = 1; i < args.length; i+= 1) {
		number.push(parseInt(args[i]));
	}*/
	// and another way for parsing: 
	var numbers = args.slice(1).map(Number); //that's how we remove the input N and parse str to numbers

	var bestSum = numbers[0];

	for (var i = 0; i < numbers.length; i += 1) {
		var currentSum = 0;
		for (var j = i; j < numbers.length; j += 1) {
			currentSum += numbers[j];
			if (currentSum > bestSum) {
				bestSum = currentSum;
			}
		}
	}
	return bestSum;
}
			//v - this is the input! 
var input = ['8', '1', '6', '-9', '4', '4', '-2', '10', '-1'
];

console.log(Solve(input));