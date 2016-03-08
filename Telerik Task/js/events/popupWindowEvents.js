var popupWindowEvents = (function() {
  var isDataLoaded = false;
  function load($container) {
    $container.on('click', '#button-popup-open', function() {
      var currentActivePage = $('.menu__item--active').attr('id'),
        $loader = $('.loading'),
        $popupMainContent = $('#popup-main'),
        allPages = 'all-pages',
        selectedPages = 'selected-pages',
        templatesLoadOption = 'append';

      if (!isDataLoaded) {
        $loader.hide();
        data.load(allPages);
        data.load(selectedPages);
        isDataLoaded = true;
      }

      $(this).hide();
      $('#popup-window').show();
      $('.' + currentActivePage + '').show();
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
