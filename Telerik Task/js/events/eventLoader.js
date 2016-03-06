var eventLoader = (function() {
  function mainEvents($container) {
    $container.on('click', '#button-popup-open', function() {
      $.get("templates/all-pages.html", function(data) {
        helpingFunctions.getDataForPage('all-pages');
      });
      $(this).hide();
      helpingFunctions.loadCheckboxesValues();
      $('#popup-window').show();
    });

    $container.on('click', '.button-popup-close', function() {
      helpingFunctions.saveCheckboxesValues();
      $('#popup-window').hide();
      $('#button-popup-open').show();
    });

    $container.on('click', '.menu__item', function() {
      $('.menu__item--active').removeClass('menu__item--active');
      $(this).addClass('menu__item--active');
      helpingFunctions.getDataForPage($(this).attr('id'));
    });

    $container.on('focusin', '#search-bar', function() {
      $(this).closest('.popup__search').addClass('search--focused');
    });

    $container.on('focusout', '#search-bar', function() {
      $(this).closest('.popup__search').removeClass('search--focused');
    });

    $container.on('click', '.product__item__content', function(ev) {
      var classToAddOrRemove = 'product__item__content--selected';

      if ($(ev.target).is("input")) {
        //ev.preventDefault();
        //ev.stopPropagation();
        if ($(this).closest('.product__item__content').hasClass(classToAddOrRemove)) {
          $(this).closest('.product__item__content').removeClass(classToAddOrRemove);
        } else {
          $(this).closest('.product__item__content').addClass(classToAddOrRemove);
        }
      }
    });

    //$('document').ready(helpingFunctions.loadCheckboxesValues());
  }

  return {
    mainEvents: mainEvents
  };
})();
