var numbers = [4, 3, 5, 1, 1, 3, 4, 3];
var anotherSetOfNumbers = [4, 3, 1, 1, 1, 2, 3];
console.log(isLarger(numbers));
console.log(isLarger(anotherSetOfNumbers));

function isLarger(arr) {
    var len = arr.length,
        index = -1;

    for (i = 1; i < len - 1; i += 1) {
        if ((arr[i] > arr[i - 1]) && (arr[i] > arr[i + 1])) {
            index = i;
            break;
        }
    }
    return index;
}