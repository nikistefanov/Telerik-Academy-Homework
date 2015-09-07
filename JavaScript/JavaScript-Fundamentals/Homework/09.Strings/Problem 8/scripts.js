/*
 Write a JavaScript function that replaces in a HTML document given as string all the tags
 <a href="…">…</a> with corresponding tags [URL=…]…/URL].
 */

var htmlDocument = '<p>Please visit <a href="http://academy.telerik.com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>';

function replaceTags(html) {
    var result = '';

    for (var i = 0; i < html.length; i += 1) {
        if (html[i] === '<' && html[i + 1] === 'a') {
            result += '[URL=';
            i += 8;
        } else if (html[i] === '"' && html[i + 1] === '>') {
            result += ']';
            i += 1;
        } else if (html[i] === '<' && html[i + 1] === '/' && html[i + 2] === 'a') {
            result += '[/URL]';
            i += 3;
        } else {
            result += html[i];
        }
    }
    console.log(result);
}

console.log(htmlDocument);
console.log('----------------------------------------');
replaceTags(htmlDocument);