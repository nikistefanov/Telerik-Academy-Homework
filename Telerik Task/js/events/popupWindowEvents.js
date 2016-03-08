var popupWindowEvents = (function() {
  var isDataLoaded = false;
  function load($container) {
    $container.on('click', '#button-popup-open', function() {
      var currentActivePage = $('.menu__item--active').attr('id'),
        allPages = 'all-pages',
        selectedPages = 'selected-pages',
        templatesLoadOption = 'append',
        $popupMainContent = $('#popup-main');

      if (!isDataLoaded) {
        templates.load(allPages, $popupMainContent, templatesLoadOption);
        templates.load(selectedPages, $popupMainContent, templatesLoadOption);
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
