var eventLoader = (function() {
  function mainEvents($container) {
    $container.on('click', '#btn-popup-open', function() {
      $.get("templates/all-pages.html", function(data) {
        helpingFunctions.getDataForPage('all-pages');
      });
      $(this).hide();
    });

    $container.on('click', '.btn-popup-close', function() {
      $('#btn-popup-open').show();
    });

    $container.on('click', '.menu__item', function() {
      $('.menu__item--active').removeClass('menu__item--active');
      $(this).addClass('menu__item--active');
      helpingFunctions.getDataForPage($(this).attr('id'));
    });

    $container.on('focusin', '#search-bar', function() {
      $(this).closest('.search').addClass('search--focused');
    });

    $container.on('focusout', '#search-bar', function() {
      $(this).closest('.search').removeClass('search--focused');
    });

    $container.on('click', '.products', function() {
      console.log($(this));
      $(this).closest('.product__item__content').addClass('product__item__content--selected');
    });

    $container.ready(helpingFunctions.checkIfContentLoaded($container));
  }

  return {
    mainEvents: mainEvents
  };
})();
