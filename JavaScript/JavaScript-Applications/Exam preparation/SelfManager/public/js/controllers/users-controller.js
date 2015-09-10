var usersController = function () {

    function register(context) {
        templates.get('register')
            .then(function (template) {
                context.$element().html(template);
                //attach events

                $('#btn-register').on('click', function () {
                    var user = {
                        username: $('#tb-username').val(),
                        password: $('#tb-password').val()
                    };
                    data.users.register(user)
                        .then(function () {
                            console.log('User register');
                        })
                });

                $('#btn-login').on('click', function () {
                    var user = {
                        username: $('#tb-username').val(),
                        password: $('#tb-password').val()
                    };
                    data.users.login(user)
                        .then(function () {
                            //console.log(user);
                            toastr.success('User ' + user.username + ' logged in.')
                            context.redirect('#/');
                        })
                });
            })
    }

    function login(context) {

    }

    return {
        register: register,
        login: login
    };
}();