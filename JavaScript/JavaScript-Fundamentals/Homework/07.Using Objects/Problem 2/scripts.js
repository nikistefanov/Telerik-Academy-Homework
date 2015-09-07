var arr = [1, 2, 1, 4, 1, 3, 4, 1, 111, 3, 2, 1, '1'];


Array.prototype.remove = function(arr, number) {
	var i,
		len = arr.length;
	for (i = 0; i < len; i += 1) {
		if (number === arr[i]) {
			arr.splice(i, 1);
		}
	}
	return arr;
};

console.log(arr);
console.log('After using "remove" (1)');
console.log(arr.remove(arr, 1)); 
//arr = [2,4,3,4,111,3,2,'1'];