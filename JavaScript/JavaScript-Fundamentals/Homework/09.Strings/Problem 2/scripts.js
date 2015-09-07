/*
 Write a JavaScript function to check if in a given expression the brackets are put correctly.
 Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).
 */

var firstExpression = '((a+b)/5-d)',
    secondExpression = ')(a+b))',
    brackets = 0;


function isBracketsCorrect(expression) {
    var i,
        len = expression.length,
        isCorrect = false;

    for (i = 0; i < len; i += 1) {

        if (expression[i] === '(') {
            brackets += 1;
        }
        else if (expression[i] === ')') {
            brackets -= 1;
        }
    }

    if (brackets === 0) {
        isCorrect = true;
    }

    return isCorrect;
}

console.log('Is correct: ' + isBracketsCorrect(firstExpression));

console.log('Is correct: ' + isBracketsCorrect(secondExpression));