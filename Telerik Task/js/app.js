(function() {
  var $container = $('#wrapper'),
    $loader = $('.loading');


  $.get('templates/popup.html', function(data) {
    $container.html(data);
    $(document).ready(function() {
      $loader.hide();
      eventLoader.loadAllEvents($container);
    });
  });
}());
