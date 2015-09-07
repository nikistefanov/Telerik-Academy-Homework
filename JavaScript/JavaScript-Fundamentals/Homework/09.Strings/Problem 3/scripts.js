/*
 Write a JavaScript function that finds how many times a substring is contained in a given text
 (perform case insensitive search).

 Example:
 The target sub-string is in

 The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine
 is very tight. So we are drinking all the day. We will move out of it in 5 days.

 The result is: 9
 */

var text = 'We are living in an yellow submarine. We don\'t have anything else. ' +
    'Inside the submarine is very tight. So we are drinking all the day. ' +
    'We will move out of it in 5 days.',
    searchedSubstring = 'in',
    counter = 0;


function substringCounter(text, subSearch) {
    var i,
        lenText = text.length,
        lenSub = subSearch.length;

    for (i = 0; i <= lenText - lenSub; i += 1) {
        var substring = text.substr(i, subSearch.length);
        if (subSearch.toLowerCase() === substring.toLowerCase()) {
            counter += 1;
        }
    }
    return counter;
}

console.log('"in" is found '  + substringCounter(text, searchedSubstring) + ' times');