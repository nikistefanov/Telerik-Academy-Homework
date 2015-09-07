var text = 'Swine shoulder frankfurter, tail hamburger strip steak sWine filet mignon. Fatback venison tail ball tip, spare ribs beef ribs doner boudin beef pork loin short loin prosciutto sausage. Bresaola frankfurter ball tip short loin t-bone andouille chuck brisket jerky boudin. Flank venison bacon, andouille pork fatback sausage kielbasa t-bone. Shankle cow corned beef short ribs, shank shoulder venison ribeye bresaola tenderloin ball tip.',
	words = getWords(text),
	wordsCount = countWords(words),
	word;
	console.log(text);
	console.log('------------------------------------------------');
for (word in wordsCount) {
	console.log(word + ' -> ' + wordsCount[word]);
}

function getWords(text) {
	var words = text.split(/[\s\.,-?!)(]/),
		i,
		len = words.length;
		
	for (i = 0; i < len; i += 1) {
		if (words[i] == "") {
			words.splice(i, 1);
		}
	}
	return words;
}

function countWords(words) {
	var wordsCount = {},
		word, i;
	for (i in words) {
		word = words[i].toLowerCase();
		if (wordsCount[word]) {
			wordsCount[word]++;
		} else {
			wordsCount[word] = 1;
		}
	}
	return wordsCount;
}