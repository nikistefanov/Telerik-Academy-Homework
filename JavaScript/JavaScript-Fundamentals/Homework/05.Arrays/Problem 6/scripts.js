/*
input 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3	
result 4 (5 times)
*/

var numbers = [4, 3, 1, 1, 3, 4, 3, 4, 2, 3, 4, 4, 3, 1, 2, 4, 3, 9, 3];

var mostFrequentNum = getMostFrequentNumber(numbers);
console.log(mostFrequentNum[0] + ' (' + mostFrequentNum[1] + ' times)');

function getMostFrequentNumber(arr) {
	var i,
		len,
		num,
		modeMap = {},
		maxNum = arr[0],
		maxCount = 1;

	for (i = 0, len = arr.length; i < len; i += 1) {
		num = arr[i];

		if (modeMap[num] == null) {
			modeMap[num] = 1;
		} else {
			modeMap[num] ++;
		}

		if (modeMap[num] > maxCount) {
			maxNum = num;
			maxCount = modeMap[num];
		}
	}

	return [maxNum, maxCount];
}