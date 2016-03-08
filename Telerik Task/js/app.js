(function() {
  var containerId = '#wrapper',
    $container = $(containerId),
    $loader = $('.loading'),
    templatesLoadOption = 'html';

  var sammyApp = Sammy(containerId, function() {
    this.get('#/', function() {
      templates.load('popup', $container, templatesLoadOption);
      $loader.hide();
    });
  });

  $(function() {
    sammyApp.run('#/');
    eventLoader.loadAllEvents($container);
  });
}());
