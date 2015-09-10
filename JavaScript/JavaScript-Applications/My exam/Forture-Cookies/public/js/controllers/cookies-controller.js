var cookiesController = function () {

    function all(context) {
        var cookies;
        data.cookies.get()
            .then(function (resCookie) {
                cookies = resCookie;
                return templates.get('cookies');
            })
            .then(function (template) {
                context.$element().html(template(cookies))
            })
    }

    function add(context) {
        templates.get('cookie-add')
            .then(function (template) {
                context.$element().html(template());
                $('#btn-cookie-add').on('click', function(){
                    var cookie = {
                        text: $('#tb-cookie-text').val(),
                        category: $('#tb-cookie-category').val()
                    };
                    data.cookies.add(cookie)
                        .then(function(cookie){
                            toastr.success('Cookie added!');
                            context.redirect('#/cookies');
                        });
                });
            });
    }

    return {
        all: all,
        add: add
    };
}();