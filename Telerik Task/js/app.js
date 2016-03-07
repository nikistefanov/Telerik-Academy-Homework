(function() {
  var containerId = '#wrapper',
    $container = $(containerId);

  var sammyApp = Sammy(containerId, function() {
    this.get('#/', function() {
      
      templates.load('popup')
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
