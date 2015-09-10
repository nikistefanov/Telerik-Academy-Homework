// better code than the one below
var homeController = function () {

    function all(context) {
        templates.get('home')
            .then(function (template) {
                context.$element().html(template());
            });
    }

    return {
        all: all
    };
}();

/*
 var homeController = function () {

 function all(context) {
 // way to display some template on the DOM using jQuery
 $.get('templates/home.handlebars', function (html) {
 // using only jQuery - but we know that there is a el with id content
 //$('#content').html(html);
 // using handlebars and we dont know for a el with id content and we have to use "context"
 context.$element().html(html);
 }

 return {
 all: all
 }
 }
 }();
 */