var i,
    len,
    numbers = [3, 9, 10, 11, 14, 18, 23, 24, 28, 29, 37, 38, 41, 44, 47],
	numbersToFind = [2, 3, 10, 27, 29, 47, 55];
	
numbers.map(Number).sort();
	
for (i = 0, len = numbersToFind.length; i < len; i+=1) {
	console.log(numbersToFind[i] + '\t[' + 
		binarySearch(numbers, numbersToFind[i], 0, numbers.length - 1) + ']');
}

function binarySearch(arr, num, min, max) {
	var middle = min + Math.floor((max - min) / 2);
	
    if (max < min || num > arr[max]) {
        return -1;
    }

    if (arr[middle] > num) {
        return binarySearch(arr, num, min, middle - 1);
    } else if (arr[middle] < num) {
        return binarySearch(arr, num, middle + 1, max);
    } else {
        return middle;
    }
}