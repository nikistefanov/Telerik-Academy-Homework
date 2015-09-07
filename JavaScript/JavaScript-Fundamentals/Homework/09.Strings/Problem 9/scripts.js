/*
 Write a function for extracting all email addresses from given text.
 All sub-strings that match the format @… should be recognized as emails.
 Return the emails as array of strings.
 */


var text = 'This is an automated message -- please do not reply at noreply@muhama.com, if you want to ask something write us at outdoors@relax.com or pickaboo@home.net, bye.';

/*console.log(extractEmails(text).join('\n\r'));

function extractEmails(text) {
    return text.match(/([a-zA-Z0-9._-]+@[a-zA-Z0-9._-]+\.[a-zA-Z0-9._-]+)/gi);
}*/

extractEmails(text);

function extractEmails(text) {
    var words = text.split(' '),
        result = [];

    for (var i = 0; i < words.length; i++) {
        if (words[i].indexOf("@") > 0) {

            if (words[i][words[i].length - 1] == '.') {

                words[i] = words[i].substr(0, words[i].length - 1);
            }

            if (words[i].indexOf(".") > 0) {

                if (words[i].indexOf('@') < words[i].indexOf('.')) {

                    result.push(words[i]);
                }
            }
        }
    }

    for (i in result) {
        console.log(result[i]);
    }
}