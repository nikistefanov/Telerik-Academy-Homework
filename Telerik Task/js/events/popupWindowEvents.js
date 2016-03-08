var popupWindowEvents = (function() {
  function load($container) {
    $container.on('click', '#button-popup-open', function() {
      var currentActivePage = $('.menu__item--active').attr('id');
      $('.' + currentActivePage + '').show();

      $(this).hide();
      $('#popup-window').show();
    });

    $container.on('click', '.button-popup-close', function() {
      $('#popup-window').hide();
      $('#button-popup-open').show();
    });

    $container.on('click', '#popup-window', function(ev) {
      if (ev.target.id == 'popup-window') {
        $('#popup-window').hide();
        $('#button-popup-open').show();
      }
    });
  }
  return {
    load: load
  };
})();
