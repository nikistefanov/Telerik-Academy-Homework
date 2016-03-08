(function() {
  var containerId = '#wrapper',
    $container = $(containerId),
    $loader = $('.loading');

  var sammyApp = Sammy(containerId, function() {
    this.get('#/', function() {
      templates.load('popup')
        .then(function(templateHtml) {
          $loader.hide();
          $container.html(templateHtml);
        });
    });
  });

  $(function() {
    sammyApp.run('#/');
    eventLoader.loadAllEvents($container);
  });
}());
