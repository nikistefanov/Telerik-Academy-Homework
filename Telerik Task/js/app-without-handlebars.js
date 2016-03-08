(function() {
  var $container = $('#wrapper');

  $.get('templates/popup.html', function(data) {
    $container.html(data);
    eventLoader.loadAllEvents($container);
  });
}());
