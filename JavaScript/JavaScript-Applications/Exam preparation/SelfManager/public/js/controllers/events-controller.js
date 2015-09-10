var eventsController = function () {

    function all(context) {
        // thats how we take the query params the ones in the url after "?category=..."
        var category = context.params.category;
        if (category){
            category = category.toLowerCase();
        }
        var events;
        data.events.get()
            .then(function (resEvents) {
                events = resEvents.result;
                return templates.get('events');
            })
            .then(function (template) {
                var groups = _.chain(events)
                    .groupBy('category')
                    // first is value == events then its the index == categoryName
                    .map(function (events, categoryName) {
                        return {
                            category: categoryName,
                            events: events
                        };
                    })
                    .filter(function(group){
                        // hackers way from checking if there is a category provided trough the url
                        return !category || group.category.toLowerCase() === category;
                    })
                    .value();
                //console.log(groups);

                context.$element().html(template(groups));
            })
    }

    function add(context) {
        templates.get('event-add')
            .then(function (template) {
                context.$element().html(template());
                $('#btn-event-add').on('click', function () {
                    var event = {
                        title: $('#tb-event-title').val(),
                        category: $('#tb-event-category').val(),
                        description: $('#tb-event-desc').val(),
                        date: $('#tb-event-date').val() + ' ' + $('#tb-event-time').val()
                    };
                    //toastr.info(event.date);
                    data.events.add(event)
                        .then(function (event) {
                            event = event.result;
                            toastr.success('event ' + event.title + ' added!');
                            context.redirect('#/events')
                        });
                });

                return data.categories.get();
            })
            .then(function (categories) {
                $('#tb-event-category').autocomplete({
                    source: categories.result
                });
                $('#tb-event-date').datepicker();
                $('#tb-event-time').timepicker({'timeFormat' : 'H:i'});
            })
    }

    return {
        all: all,
        add: add
    };
}();