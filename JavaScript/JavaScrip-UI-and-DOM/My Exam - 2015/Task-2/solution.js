function solve() {
    $.fn.datepicker = function () {
        var MONTH_NAMES = ["January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"];
        var WEEK_DAY_NAMES = ['Su', 'Mo', 'Tu', 'We', 'Th', 'Fr', 'Sa'];

        Date.prototype.getMonthName = function () {
            return MONTH_NAMES[this.getMonth()];
        };

        Date.prototype.getDayName = function () {
            return WEEK_DAY_NAMES[this.getDay()];
        };

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
            }
        };

        // you are welcome :)
        // thank you, good sir!
        var $this = $(this);
        console.log($this);
        var date = new Date();
        console.log(date.getDayName());
        console.log(date.getMonthName());

        validator.checkIfUndefindOrNull($this);
        //validator.checkIfValidSelector($this);

        // no time for this...or $this.. whatever :)

        var wrapper = $this.parent();
        wrapper.addClass('datepicker-wrapper');

        return $this;
    };
};