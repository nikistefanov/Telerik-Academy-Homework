var numbers = [12, 3, 4, 5, 2, 11, 7, 15, 14, 12, 8, 1, 23, 1, 19, 5, 0];
selectionSort(numbers);
console.log(numbers);

function selectionSort(arr) {
	var left,
		right,
		temp,
		len;

	for (left = 0, len = arr.length; left < len; left += 1) {
		for (right = left + 1; right < len; right += 1) {
			if (arr[left] > arr[right]) {
				temp = arr[right];
				arr[right] = arr[left];
				arr[left] = temp;
			}
		}
	}
}