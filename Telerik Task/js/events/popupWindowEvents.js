var popupWindowEvents = (function() {
  var $mainContent = $('.main-content'),
    isDataLoaded = false;

  function load($container) {
    var mainProduct = new MainProduct($container),
      selectedProduct = new SelectedProduct($container);

    $container.on('click', '#button-popup-open', function() {
      var currentActivePage = $('.menu__item--active').attr('id'),
        $loader = $('.loading'),
        $popup = $('#popup'),
        $popupMainContent = $('#popup-main'),
        allPages = 'all-pages',
        selectedPages = 'selected-pages';


      if (!isDataLoaded) {
        $loader.hide();

        mainProduct.setItems(allPages, $popupMainContent);
        selectedProduct.setItems(selectedPages, $popupMainContent);

        isDataLoaded = true;
      }

      $(this).hide();
      $mainContent.hide();
      $popup.show();
      $('.' + currentActivePage + '').show();
    });

    $container.on('click', '.button-popup-close', function() {
      $('#popup').hide();
      $mainContent.show();
      $('#button-popup-open').show();
    });

    $container.on('click', '#popup', function(ev) {
      if (ev.target.id == 'popup') {
        $('#popup').hide();
        $mainContent.show();
        $('#button-popup-open').show();
      }
    });
  }
  return {
    load: load,
  };
})();
