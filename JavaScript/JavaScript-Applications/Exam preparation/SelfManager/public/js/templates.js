var templates = (function () {
    // hack cuz we dont know if handlebars is with capital H or not
    var handlebars = window.handlebars || window.Handlebars;

    function get(name) {
        var promise = new Promise(function (resolve, reject) {
            // first function is when there is success
            var url = 'templates/' + name + '.handlebars';
            $.get(url, function (html) {
                var template = handlebars.compile(html);
                resolve(template);
            }).error(function (err) {
                reject(err);
            })
        });

        return promise;
    }

    return {
        get: get
    }
}());