var data = function () {
    const STORAGE_AUTH_KEY = 'AUTHENTICATION-KEY';

    function register(user) {
        var promise = new Promise(function (reslove, reject) {
            var url = 'api/users';

            var reqUser = {
                username: user.username,
                passHash: CryptoJS.SHA1(user.password).toString()
            }

            $.ajax(url, {
                method: 'POST',
                contentType: 'application/json',
                data: JSON.stringify(reqUser),
                success: function (res) {
                    //console.log(res);
                    reslove(res);
                }
            })
        });

        return promise;
    }

    function login(user) {
        var promise = new Promise(function (reslove, reject) {
            var url = 'api/auth';

            var reqUser = {
                username: user.username,
                passHash: CryptoJS.SHA1(user.password).toString()
            }

            $.ajax(url, {
                method: 'PUT',
                contentType: 'application/json',
                data: JSON.stringify(reqUser),
                success: function (res) {
                    localStorage.setItem(STORAGE_AUTH_KEY, res.result.authKey);
                    //console.log(res);
                    //console.log(res);
                    reslove(res);
                }
            })
        });

        return promise;
    }

    function currentUser() {
        var promise = new Promise(function (reslove, reject) {
            var url = 'api/users';


            $.ajax(url, {
                method: 'GET',
                contentType: 'application/json',
                success: function (res) {
                    //console.log(res);
                    reslove(res);
                }
            })
        });

        return promise;
    }

    function cookiesGet() {
        var promise = new Promise(function (resolve, reject) {
            var url = 'api/cookies';
            $.ajax(url, {
                method: 'GET',
                contentType: 'application/json',
                headers: {
                    'x-auth-key': localStorage.getItem(STORAGE_AUTH_KEY)
                },
                success: function (res) {
                    resolve(res.result);
                },
                error: function (err) {
                    reject(err);
                }
            });
        });

        return promise;
    }

    function cookieAdd(cookie){

        var promise = new Promise(function (resolve, reject) {
            var url = 'api/cookies';
            $.ajax(url, {
                method: 'POST',
                contentType: 'application/json',
                data: JSON.stringify(cookie),
                headers: {
                    'x-auth-key': localStorage.getItem(STORAGE_AUTH_KEY)
                },
                success: function (res) {
                    resolve(res);
                },
                error: function (err) {
                    reject(err);
                }
            })
        });

        return promise;
    }

    return {
        users: {
            register: register,
            login: login,
            currentUser: currentUser
        },
        cookies: {
            get: cookiesGet,
            add: cookieAdd
        }
    }
}();