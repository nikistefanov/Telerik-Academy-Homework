function createCalendar(selector, events) {
    var WEEKS = 5;
    var MONTH = 'June';
    var YEAR = '2014';
    var MAX_MONTH_DAYS = 30;
    var WEEK_DAYS = ['Saturday', 'Sunday', 'Monday', 'Tuesday', 'Wednesday',
        'Thursday', 'Friday'];

    var preparedEvents = prepareEvents(events);

    var day = document.createElement('div');
    var week = document.createElement('div');
    var dayTitle = document.createElement('h4');
    var dayEvent = document.createElement('span');


    applyDayAttributes(day);
    applyDayTitleAttributes(dayTitle);
    applyDayEventAttributes(dayEvent);

    var calendar = document.querySelector(selector);
    var month = generateMonth();
    calendar.appendChild(month);

    calendar.addEventListener('click', function (ev) {
        //if (!ev) ev = window.event;
        var selectedTarget = ev.target;
        selectedTarget = getParentIfDayTitle(selectedTarget);

        if (selectedTarget.classList.contains('calendar-day')) {
            changeDayTitleBackgroundColor(selectedTarget, 'white');

            var otherSelectedTargets = calendar.getElementsByClassName('selected');
            for (var i = 0; i < otherSelectedTargets.length; i++) {
                changeDayTitleBackgroundColor(otherSelectedTargets[i], 'lightgray');
                otherSelectedTargets[i].classList.remove('selected');
            }
            selectedTarget.classList.add('selected');
        }
    });

    calendar.addEventListener('mouseover', function (ev) {
        var selectedTarget = ev.target
        selectedTarget = getParentIfDayTitle(selectedTarget);

        if (checkIfCalendarDayAndNotSelected(selectedTarget)) {
            changeDayTitleBackgroundColor(selectedTarget, 'gray');
        }
    });

    calendar.addEventListener('mouseout', function (ev) {
        var selectedTarget = ev.target
        selectedTarget = getParentIfDayTitle(selectedTarget);

        if (checkIfCalendarDayAndNotSelected(selectedTarget)) {
            changeDayTitleBackgroundColor(selectedTarget, 'lightgray');
        }
    });

    function prepareEvents(events) {
        var result = [];

        // Create dictionary
        for (var i = 0; i < events.length; i++) {
            var currentDate = events[i].date;
            result[currentDate] = events[i];
        }
        return result;
    }

    function generateMonth() {
        var fragment = document.createDocumentFragment();
        for (var i = 0; i < WEEKS; i++) {
            var startDay = i * 7 + 1;
            var endDay = startDay + 6;
            var currentWeek = generateWeek(startDay, endDay);
            fragment.appendChild(currentWeek);
        }

        return fragment;
    }

    function generateWeek(startDay, endDay) {
        var currentWeek = week.cloneNode(true);
        for (var i = startDay; i <= endDay && i <= MAX_MONTH_DAYS; i++) {
            var currentDay = generateDay(i);
            currentWeek.appendChild(currentDay);
        }
        return currentWeek;
    }

    function generateDay(date) {
        var currentDay = day.cloneNode(true);
        var currentDayTitle = generateDayTitle(date);
        currentDay.appendChild(currentDayTitle);
        getCurrentEvent(date, currentDay);

        return currentDay;
    }

    function generateDayTitle(date) {
        var currentDayTitle = dayTitle.cloneNode(true);
        var currentDayAsString = WEEK_DAYS[date % 7];
        currentDayTitle.innerText = currentDayAsString + ' ' + date
            + ' ' + MONTH + ' ' + YEAR;
        return currentDayTitle;
    }

    function getCurrentEvent(date, dayElement) {
        var currentDateEvent = preparedEvents[date];
        if (currentDateEvent) {
            var currentDayEvent = dayEvent.cloneNode(true);
            currentDayEvent.innerText = currentDateEvent.hour + ' - '
                + currentDateEvent.duration + ' - ' + currentDateEvent.title;
            dayElement.appendChild(currentDayEvent);
        }
    }

    function applyDayAttributes(day) {
        // jQuery = .addClass()
        day.classList.add('calendar-day');

        day.style.display = 'inline-block';
        day.style.width = '130px';
        day.style.height = '130px';
        day.style.border = '1px solid black';
    }

    function applyDayTitleAttributes(dayTitle) {
        // jQuery = .addClass()
        dayTitle.classList.add('calendar-day-title')

        dayTitle.style.backgroundColor = 'lightgray';
        dayTitle.style.textAlign = 'centre';
        dayTitle.style.borderBottom = '1px solid black';
        dayTitle.style.margin = '0';
    }

    function applyDayEventAttributes(dayEvent) {
        dayEvent.style.float = 'left';
    }

    function changeDayTitleBackgroundColor(element, color) {
        element.getElementsByClassName('calendar-day-title')[0].style.backgroundColor = color;
    }

    function getParentIfDayTitle(element) {
        if (element.classList.contains('calendar-day-title')) {
            // Go to the parent of this tag --> h4 -> div
            element = element.parentNode;
        }

        return element;
    }

    function checkIfCalendarDayAndNotSelected(element) {
        return element.classList.contains('calendar-day')
            && !element.classList.contains('selected');
    }
}