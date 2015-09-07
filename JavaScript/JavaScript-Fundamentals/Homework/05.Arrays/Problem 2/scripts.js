var firstArray = ['s', 'o', 'm', 'e', 't', 'h', 'i', 'n', 'g'],
	// secondArray = ['s', 'o', 'm', 'e', 't', 'h', 'i', 'n', 'g'];
	secondArray = ['b', 'u', 'l', 'l', 's', 'h', 'e', 'e', 'p'];



function checkIfEqual(fArr, sArr) {
	var i,
		len;
		
	if (fArr.length === sArr.length) {
		for (i = 0, len = fArr.length; i < len; i += 1) {
			if (fArr[i] !== sArr[i]) {
				return 'Not!';
			}
		}
		return 'Yes!';
	} else {
		return 'Not!';
	}
}

console.log(checkIfEqual(firstArray, secondArray));