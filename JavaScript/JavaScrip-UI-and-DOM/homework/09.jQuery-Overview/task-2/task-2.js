/* globals $ */

/*
 Create a function that takes a selector and:
 * Finds all elements with class `button` or `content` within the provided element
 * Change the content of all `.button` elements with "hide"
 * When a `.button` is clicked:
 * Find the topmost `.content` element, that is before another `.button` and:
 * If the `.content` is visible:
 * Hide the `.content`
 * Change the content of the `.button` to "show"
 * If the `.content` is hidden:
 * Show the `.content`
 * Change the content of the `.button` to "hide"
 * If there isn't a `.content` element **after the clicked `.button`** and **before other `.button`**, do nothing
 * Throws if:
 * The provided ID is not a **jQuery object** or a `string`

 */
function solve() {
    return function (selector) {
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
            checkIfSelectorSelectNothing: function (selector) {
                if (!selector.length) {
                    throw  new Error ("Provided selector doesn't select anything!" );
                }
            }
        };

        function buttonClicked() {
            var $this = $(this);

            var $nextContent = $this.nextAll('.content').first(),
                $nextBtn = $nextContent.nextAll('.button').first();

            if ($nextBtn.length && $nextContent.length) {
                if ($nextContent.css('display') === 'none') {
                    $nextContent.css('display', '');
                    $this.text('hide');
                } else {
                    $nextContent.css('display', 'none');
                    $this.text('show');
                }
            }
        }

        validator.checkIfValidSelector(selector);
        validator.checkIfUndefindOrNull(selector);

        var $selectedElement = $(selector),
            $buttonElements = $selectedElement.find('.button');

        validator.checkIfSelectorSelectNothing($selectedElement);


        for (var i = 0, len = $buttonElements.length; i < len; i += 1) {

            // this don't work!
            /*$buttonElements[i].text('hide');
            $buttonElements[i].on('click', buttonClicked);*/
            // have to make new element!
            var $currentElement = $($buttonElements[i]);
            $currentElement.text('hide');

            $currentElement.on('click', buttonClicked);
        }
    };
};

module.exports = solve;