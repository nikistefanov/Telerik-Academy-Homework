/*
input 3, 2, 3, 4, 2, 2, 4	
result 2, 3, 4
*/

var sequence = [3, 2, 3, 4, 2, 2, 4],
	SecondSequence = [1, 5, 5, 6, 4, 3, 3, 3, 3, 2, 4, 6, 7, 8, 1];

console.log(getMaxIncreasingSequence(sequence).join(', '));
console.log(getMaxIncreasingSequence(SecondSequence).join(', '));

function getMaxIncreasingSequence(arr) {
    var i,
        len,
		longest = [arr[0]],
		temp = [arr[0]];

    for (i = 1, len = arr.length; i < len; i += 1) {
        if (arr[i] > arr[i - 1]) {
            temp.push(arr[i]);
        } else {
            temp = [arr[i]];
        }

        if (temp.length > longest.length) {
            longest = temp;
        }
    }

    return longest;
}