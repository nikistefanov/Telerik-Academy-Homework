/*
 Write a JavaScript function that reverses a string and returns it.
 Example:

 input	output
 sample	elpmas
 */

var text = 'sample';

function reverseString(text) {
    var reveredInput =  [].map.call(text, function (x) {return x;}).reverse().join('');

    console.log('Input string is: ' + text);
    console.log('Reversed input string is: ' + reveredInput);
}

reverseString(text);

