var todosController = function () {

    function all(context) {
        // thats how we take the query params the ones in the url after "?category=..."
        var category = context.params.category;
        if (category){
            category = category.toLowerCase();
        }
        var todos;
        data.todos.get()
            .then(function (resTodos) {
                todos = resTodos.result;
                return templates.get('todos');
            })
            .then(function (template) {
                var groups = _.chain(todos)
                    .groupBy('category')
                    // first is value == todos then its the index == categoryName
                    .map(function (todos, categoryName) {
                        return {
                            category: categoryName,
                            todos: todos
                        };
                    })
                    .filter(function(group){
                        // hackers way from checking if there is a category provided trough the url
                        return !category || group.category.toLowerCase() === category;
                    })
                    .value();
                //console.log(groups);

                context.$element().html(template(groups));
                $('.todo-state').on('change', function () {
                    var id = $(this).parents('.todo-item').attr('data-id');

                    // check if the checkbox is checked or not -> two ways
                    //var state = $(this).is(':checked');
                    var state = !!$(this).prop('checked');

                    data.todos.update(id, state)
                        .then(function () {
                            toastr.success('State updated!');
                        })
                });
            })
    }

    function add(context) {
        templates.get('todo-add')
            .then(function (template) {
                context.$element().html(template());
                $('#btn-todo-add').on('click', function () {
                    var todo = {
                        text: $('#tb-todo-text').val(),
                        category: $('#tb-todo-category').val()
                    };
                    data.todos.add(todo)
                        .then(function (todo) {
                            todo = todo.result;
                            toastr.success('TODO ' + todo.text + ' added!');
                            context.redirect('#/todos')
                        });
                });

                return data.categories.get();
            })
            .then(function (categories) {
                $('#tb-todo-category').autocomplete({
                    source: categories.result
                });
            })
    }

    return {
        all: all,
        add: add
    };
}();