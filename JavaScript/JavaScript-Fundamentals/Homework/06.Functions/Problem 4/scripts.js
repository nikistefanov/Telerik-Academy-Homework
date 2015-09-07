var divs,
	divsCount;

function divsCounter() {
	divs = document.getElementsByTagName('div');
	divsCount = divs.length;

	console.log('The number of div elements in this html -> ' + divsCount);
}

divsCounter();