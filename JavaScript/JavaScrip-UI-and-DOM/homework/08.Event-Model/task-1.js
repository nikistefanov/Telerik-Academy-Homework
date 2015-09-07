/* globals $ */

/* 

Create a function that takes an id or DOM element and:
  If an id is provided, select the element
Finds all elements with class button or content within the provided element
Change the content of all .button elements with "hide"
When a .button is clicked:
Find the topmost .content element, that is before another .button and:
If the .content is visible:
Hide the .content
Change the content of the .button to "show"
If the .content is hidden:
Show the .content
Change the content of the .button to "hide"
If there isn't a .content element after the clicked .button and before other .button, do nothing
Throws if:
The provided DOM element is non-existant
The id is either not a string or does not select any DOM element

*/

function solve() {
    var validator = {
        checkIfUndefindOrNull: function (parameter) {
            if (parameter === undefined || parameter === null) {
                throw new Error('Not valid parameter');
            }
        },
        checkIfValidElement: function (element) {
            if (typeof element === "string") {
                element = document.getElementById(element);
            }

            if (!(element instanceof HTMLElement)) {
                throw new Error('You must provide a HTML element');
            }
        }
    }

    function getAllElementsByClassName(element, className) {
        var result = [],
            children = element.children;

        for (var i = 0, len = children.length; i < len; i += 1) {
            var current = children[i];

            if (current.className === className) {
                result.push(current);
            }
        }

        return result;
    }

    function clickedButton(ev) {
        if (ev.target.className === 'button') {
            var target = ev.target;
            var next = target;

            while (next) {
                if (next.className === 'content') {
                    break;
                }
                next = next.nextElementSibling;
            }

            if (next.style.display === '') {
                target.innerHTML = 'show';
                next.style.display = 'none';
            } else if (next.style.display === 'none') {
                target.innerHTML = 'hide';
                next.style.display = '';
            }
        }
    }

    return function (selector) {
        validator.checkIfUndefindOrNull(selector);
        validator.checkIfValidElement(selector);
        var element = document.getElementById(selector);

        var buttons = getAllElementsByClassName(element, 'button');

        for (var i = 0, len = buttons.length; i < len; i += 1) {
            buttons[i].innerHTML = 'hide';
        }
        buttons.map(function (button) {
            button.addEventListener('click', clickedButton, false);
        });

    };
};

module.exports = solve;