/*
Example:

input: 2, 1, 1, 2, 3, 3, 2, 2, 2, 1
result: 2, 2, 2*/

var sequence = [2, 1, 1, 2, 3, 3, 2, 2, 2, 1],
	SecondSequence = [1, 5, 5, 6, 4, 3, 3, 3, 3, 2, 6, 7, 8, 1];

console.log(getMaxEqualSequence(sequence).join(', '));
console.log(getMaxEqualSequence(SecondSequence).join(', '));

function getMaxEqualSequence(arr) {
	var i,
		len,
		longest = [arr[0]],
		temp = [arr[0]];

	for (i = 1, len = arr.length; i < len; i += 1) {
		if (arr[i] !== temp[0]) {
			temp = [arr[i]];
		} else {
			temp.push(arr[i]);
		}

		if (temp.length > longest.length) {
			longest = temp;
		}
	}

	return longest;
}