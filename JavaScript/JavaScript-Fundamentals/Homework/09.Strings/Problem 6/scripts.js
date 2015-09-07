/*
 Write a function that extracts the content of a html page given as text.
 The function should return anything that is in a tag, without the tags.
 Example:

 <html>
  <head>
   <title>Sample site</title>
  </head>
  <body>
   <div>text
   <div>more text</div>
     and more...
   </div>
     in body
  </body>
 </html>

 Result: Sample sitetextmore textand more...in body
 */

var text = '<html><head><title>Sample site</title></head> <body> ' +
  '<div>text <div>more text</div>and more... </div>in body </body>';


function extractTextFromHTML(text) {
  var i,
      len = text.length,
      openTag = '<',
      closedTag = '>',
      isInTag = false,
      result = '';

  for (i = 0; i < len; i += 1) {
    if (text[i] === openTag) {
      isInTag = true;
    } else if (text[i] === closedTag) {
      isInTag = false;
    } else {
      if (!isInTag) {
        result += text[i];
      }
    }
  }

  return result;
}

console.log(extractTextFromHTML(text));