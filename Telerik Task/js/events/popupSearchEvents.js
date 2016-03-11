var popupSearchEvents = (function() {
  function load($container) {
    $container.on('focusin', '#popup-search-bar', function() {
      $(this).closest('.popup__search').addClass('popup__search__bar--focused');
      $('#popup-button-clear').show();
    });

    $container.on('focusout', '#popup-search-bar', function() {
      $(this).closest('.popup__search').removeClass('popup__search__bar--focused');
      $('#popup-button-clear').hide();
    });
  }
  return {
    load: load
  };
})();
