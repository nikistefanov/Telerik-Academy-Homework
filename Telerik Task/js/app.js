(function() {
  var containerId = '#wrapper',
    $container = $(containerId);

  var sammyApp = Sammy(containerId, function() {
    this.get('#/', function() {
      this.redirect('#/home');
    });

    this.get('#/home', function() {
      //templatesFunctionality.loadHomeTemplate();
      //$('.loader-top').hide();
      templates.load('home')
        .then(function(templateHtml) {
          $container.html(templateHtml);
        });
    });
  });

  $(function() {
    sammyApp.run('#/');
    eventLoader.mainEvents($container);
  });
}());
