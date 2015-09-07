reverseNumber(45.65);
console.log('-----------------------------');
reverseNumber(256);
console.log('-----------------------------');
reverseNumber(123.45);

function reverseNumber(number) {
    var reversed = number.toString().split('').reverse().join('');
    console.log('Normal number is: ' + number);
    console.log('Reversed number is: ' + reversed);
}