var n,
    i,
    result = [];
// input from the user
function InputOutputBrowser() {

    alert('Some explanation text');

    n = prompt('N = ');

    if (n < 1 || isNaN(n)) {
        alert('Invalid input!');
    } else {
        n = +n;
        for (i = 1; i < n + 1; i++) {
            result.push(i);
        }
        result = result.join(', ');
        alert(result);
    }
}

InputOutputBrowser();

// get numbers from the user
var number,
    numbers = [];

while (number = prompt('Enter number [Enter to exit]')) {
    numbers.push(parseInt(number));
}