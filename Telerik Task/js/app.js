(function() {
  var $container = $('#wrapper'),
    $loader = $('.loading');

  template.load('popup')
    .then(function(templateHtml) {
      $loader.hide();
      $container.html(templateHtml);
    });

  $(document).ready(function() {
    eventLoader.loadAllEvents($container);
  });
}());
