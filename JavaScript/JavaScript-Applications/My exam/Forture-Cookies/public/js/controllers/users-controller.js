var usersController = function () {
    var CONSTANTS = {
        NAME_MIN_LENGTH: 6,
        NAME_MAX_LENGTH: 30,
        PASSWORD_MIN_LENGTH: 3,
        PASSWORD_MAX_LENGTH: 30,
    };

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

                    validate.valueLength(user.password, 'Password', CONSTANTS.PASSWORD_MIN_LENGTH, CONSTANTS.PASSWORD_MAX_LENGTH);
                    validate.ifUndefined(user.username, 'Username');
                    validate.ifString(user.username, 'Username');
                    validate.valueLength(user.username, 'Username', CONSTANTS.NAME_MIN_LENGTH, CONSTANTS.NAME_MAX_LENGTH);
                    //validate.containsOnlyTheCorrectCharacters(user.username, 'Username');

                    data.users.register(user)
                        .then(function () {
                            toastr.success('User ' + user.username + ' registered!');
                            context.redirect('#/');
                        })
                });

                $('#btn-login').on('click', function () {
                    var user = {
                        username: $('#tb-username').val(),
                        password: $('#tb-password').val()
                    };

                    validate.valueLength(user.password, 'Password', CONSTANTS.PASSWORD_MIN_LENGTH, CONSTANTS.PASSWORD_MAX_LENGTH);
                    validate.ifUndefined(user.username, 'Username');
                    validate.ifString(user.username, 'Username');
                    validate.valueLength(user.username, 'Username', CONSTANTS.NAME_MIN_LENGTH, CONSTANTS.NAME_MAX_LENGTH);
                    //validate.containsOnlyTheCorrectCharacters(user.username, 'Username');

                    data.users.login(user)
                        .then(function (res) {
                            //console.log(res);
                            toastr.success('User ' + user.username + ' logged in.');
                            //console.log(context.$element().prev().find('#login-logout'));
                            templates.get('login-logout')
                                .then(function (template) {
                                    context.$element().prev().find('#login-logout').html(template(user.username));
                                });
                            context.redirect('#/');
                            //var test = data.users.currentUser(user.id);
                        })
                });
            })
    }

    function logout(context) {
        toastr.error('Logged out!');
        templates.get('login-logout')
            .then(function (template) {
                context.$element().prev().find('#login-logout').html(template);
                context.redirect('#/');
            });

    }

    function getUsers(context) {
    }

    return {
        register: register,
        logout: logout,
        all: getUsers
    };
}();