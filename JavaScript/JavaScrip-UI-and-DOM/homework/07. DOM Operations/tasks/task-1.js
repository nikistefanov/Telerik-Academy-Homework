/* globals $ */

/* 

 Create a function that takes an id or DOM element and an array of contents

 * if an id is provided, select the element
 * Add divs to the element
 * Each div's content must be one of the items from the contents array
 * The function must remove all previous content from the DOM element provided
 * Throws if:
 * The provided first parameter is neither string or existing DOM element
 * The provided id does not select anything (there is no element that has such an id)
 * Any of the function params is missing
 * Any of the function params is not as described
 * Any of the contents is neight `string` or `number`
 * In that case, the content of the element **must not be** changed
 */
module.exports = function () {
    function checkIfUndefindOrNull(parameter) {
        if (parameter === undefined || parameter === null) {
            throw new Error('Not valid parameter');
        }
    }

    function validateContents(contents) {
        if (!Array.isArray(contents)) {
            throw new Error('Provided contents must be an Array');
        }

        for (var i = 0, len = contents.length; i < len; i += 1) {
            validateContent(contents[i]);
        }

        function validateContent(content) {
            if (typeof content !== "string" && typeof content !== "number") {
                throw new Error('Every contents is neight `string` or `number`');
            }
        }
    }

    function getValidElement(element) {
        if (typeof element === "string") {
            element = document.getElementById(element);
        }

        if (!(element instanceof HTMLElement)) {
            throw new Error('You must provide a HTML element');
        }

        return element;
    }

    function appendContents(element, contents) {
        element.innerHTML = '';
        var div = document.createElement('div');
        var fragment = document.createDocumentFragment();

        for (var i = 0, len = contents.length; i < len; i += 1) {
            var currentDiv = div.cloneNode(true);
            currentDiv.innerHTML = contents[i];
            fragment.appendChild(currentDiv);
        }

        element.appendChild(fragment);
    }

    return function (element, contents) {
        checkIfUndefindOrNull(element);
        checkIfUndefindOrNull(contents);
        validateContents(contents);
        element = getValidElement(element);
        appendContents(element, contents);
    };
};