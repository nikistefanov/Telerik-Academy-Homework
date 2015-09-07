/* globals $ */

/* 

 Create a function that takes a selector and COUNT, then generates inside a UL with COUNT LIs:
 * The UL must have a class `items-list`
 * Each of the LIs must:
 * have a class `list-item`
 * content "List item #INDEX"
 * The indices are zero-based
 * If the provided selector does not selects anything, do nothing
 * Throws if
 * COUNT is a `Number`, but is less than 1
 * COUNT is **missing**, or **not convertible** to `Number`
 * _Example:_
 * Valid COUNT values:
 * 1, 2, 3, '1', '4', '1123'
 * Invalid COUNT values:
 * '123px' 'John', {}, []
 */

function solve() {
    return function (selector, count) {
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
            checkIfValidNumber: function (number) {
                if (isNaN(number)) {
                    throw new Error('You must provide a valid number!');
                }

                if (number < 1) {
                    throw new Error('You must provide a number greater than 0!');
                }
            }
        };

        var $selectedElement = $(selector),
            $ulElement = $('<ul/>'),
            $liElement = $('<li/>');

        validator.checkIfValidSelector(selector);
        validator.checkIfUndefindOrNull(selector);
        validator.checkIfUndefindOrNull(count);
        validator.checkIfValidNumber(count);


        $ulElement.addClass('items-list');
        $liElement.addClass('list-item');


        for (var i = 0; i < count; i += 1) {
            var $currentLiElement = $liElement.clone();

            $currentLiElement.html('List item #' + i);
            $ulElement.append($currentLiElement);
        }

        $selectedElement.append($ulElement);
    };
};


module.exports = solve;