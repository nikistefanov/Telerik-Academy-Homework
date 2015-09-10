(function () {
    var sammyApp = Sammy('#content', function () {

        // routes
        this.get('#/', function () {
            this.redirect('#/home');
        });
        this.get('#/home', homeController.all);

        this.get('#/login', usersController.login);
        this.get('#/register', usersController.register);
        this.get('#/logout', usersController.logout);

        this.get('#/cookies', cookiesController.all);
        this.get('#/my-cookie', cookiesController.add);
    });

    $(function () {
        sammyApp.run('#/');

    });
}());

