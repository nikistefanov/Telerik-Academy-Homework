var eventLoader = (function() {

  function mainEvents($container) {
    $container.on('click', '#btn-popup-open', function(ev) {
      $(this).hide();
      $('#popup-window').show();
    });

    $container.on('click', '.btn-popup-close', function(ev) {
      $('#popup-window').hide();
      $('#btn-popup-open').show();
    });
  }

  return {
    mainEvents: mainEvents,
  };
})();
