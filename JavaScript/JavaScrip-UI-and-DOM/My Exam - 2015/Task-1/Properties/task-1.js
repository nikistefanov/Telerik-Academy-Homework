function solve() {
    return function (selector, isCaseSensitive) {
        var validator = {
            checkIfUndefindOrNull: function (parameter) {
                if (parameter === undefined || parameter === null) {
                    throw new Error('Not valid parameter!');
                }
            },
            checkIfValidSelector: function (selector) {
                if (typeof selector !== "string") {
                    throw new Error('Selector must be a string!');
                }
            },
            checkIfValidBool: function (parameter) {
                if (typeof parameter !== "boolean") {
                    throw new Error('Value must be a boolean!');
                }
            }
        };

        validator.checkIfUndefindOrNull(selector);
        validator.checkIfValidSelector(selector);

        var isCaseSensitive = isCaseSensitive || false;
        validator.checkIfValidBool(isCaseSensitive);

        var root = document.querySelector(selector);
        root.className += ' items-control';
        var addSection = document.createElement('div');
        addSection.className += ' add-controls';
        var addingLabel = document.createElement('label');
        addingLabel.innerHTML = 'Enter text';
        var addingInput = document.createElement('input');
        var addButton = document.createElement('button');
        addButton.className += ' button';
        addButton.innerHTML = 'Add';

        addSection.appendChild(addingLabel);
        addSection.appendChild(addingInput);
        addSection.appendChild(addButton);

        var searchSection = document.createElement('div');
        searchSection.className += ' search-controls';
        var searchLabel = document.createElement('label');
        searchLabel.innerHTML = 'Search';
        var searchInput = document.createElement('input');

        searchSection.appendChild(searchLabel);
        searchSection.appendChild(searchInput);

        var resultSection = document.createElement('div');
        resultSection.className += ' result-controls';
        var ulElement = document.createElement('ul');
        ulElement.className += ' items-list';

        resultSection.appendChild(ulElement);

        root.appendChild(addSection);
        root.appendChild(searchSection);
        root.appendChild(resultSection);

        addButton.addEventListener('click', function (ev) {
            var target = ev.target;
            var text = addingInput.value;
            var strongElement = document.createElement('strong');
            strongElement.innerHTML += text;

            if (text.length > 0) {
                var liElement = document.createElement('li');
                var removeButton = document.createElement('button');
                liElement.className += ' list-item';
                removeButton.innerHTML += 'X';
                removeButton.className += ' button';
                liElement.appendChild(removeButton);
                liElement.appendChild(strongElement);
                ulElement.appendChild(liElement);
            }
            else {
                addingInput.value = '';
            }

            addingInput.value = '';

            removeButton.addEventListener('click', function (ev) {
                var target = ev.target;
                target.parentElement.parentElement.removeChild(target.parentElement);
            });
        });

        searchInput.addEventListener('input', function (ev) {
            var text = ev.target.value;
            var resultElements = ulElement.getElementsByTagName('li');

            for (var i = 0, len = resultElements.length; i < len; i += 1) {
                var currentElement = resultElements[i];
                var currentElementText = resultElements[i].lastElementChild.innerHTML;

                if (isCaseSensitive) {
                    if (currentElementText.indexOf(text) >= 0) {
                        currentElement.style.display = '';
                    }
                    else {
                        currentElement.style.display = 'none';
                    }
                } else {
                    if (currentElementText.toLowerCase().indexOf(text.toLowerCase()) >= 0) {
                        currentElement.style.display = '';
                    }
                    else {
                        currentElement.style.display = 'none';
                    }
                }
            }
        });
    };
}

module.exports = solve;