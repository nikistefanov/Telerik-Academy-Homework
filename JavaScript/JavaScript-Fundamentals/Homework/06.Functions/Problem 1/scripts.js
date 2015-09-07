var n;
InputOutputBrowser();

function InputOutputBrowser() {
    alert('Please insert a number.');

    n = prompt('N = ');
    n = +n;
    ExtractLastDigit(n);

    function ExtractLastDigit(number) {
        var numberAsWords = ['zero', 'one', 'two', 'three', 'four', 'five', 'six', 'seven', 'eigth', 'nine'],
            digit = number % 10;
        alert('The last digit is: ' + numberAsWords[digit]);
    }
}