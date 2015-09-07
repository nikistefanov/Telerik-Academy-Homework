/*
 Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".
 */


var text = 'ABBA, lamal, palindrome, BaaB, gereg, Ho';


findPalindromes(text);

function findPalindromes(text) {
    var i,
        words = text.split(/\W+/),
        palindromes = [];

    for (i = 0; i < words.length; i += 1) {
        var isPalindrome = true;

        for (var j = 0; j < Math.floor(words[i].length / 2); j += 1) {


            if (words[i][j] !== words[i][words[i].length - 1 - j]) {
                isPalindrome = false;
                break;
            }
        }

        if (isPalindrome && words[i].length > 1) {

            palindromes.push(words[i]);
        }
    }
    for (var index in palindromes) {
        console.log(palindromes[index]);
    }
}