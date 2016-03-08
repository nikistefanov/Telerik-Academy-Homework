(function() {
  var $container = $('#wrapper'),
    $loader = $('.loading');


  $.get('templates/popup.html', function(data) {
    $container.html(data);
    $loader.hide();
    $(document).ready(function() {
      eventLoader.loadAllEvents($container);
    });
  });
}());
