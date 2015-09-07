var numbers = [4, 3, 1, 1, 3, 4, 3];
console.log(isLarger(numbers, 5));
console.log(isLarger(numbers, 3));

/*function isLarger(arr, index) {
    var i,
        len = arr.length,
        isLarger = true;

    if (index < 1 || index > len) {
        console.log('Element at index[' + index + '] does not have two neighbours!');
        isLarger = false;
    } else {
        for (i = index - 1; i <= index + 1; i += 2) {
            if (i >= 0 && i < len) {
                if (arr[i] >= arr[index]) {
                    isLarger = false;
                    break;
                }
            }
        }
    }
    return isLarger;
}*/

function isLarger(arr, index){
    var isLarger = false;

    if (index < arr.length - 1 && index > 0)
    {
        if ((arr[index] > arr[index + 1]) && (arr[index] > arr[index - 1]))
        {
           isLarger = true;
        }
    }

    return isLarger;
}