var eventLoader = (function() {
  function mainEvents($container) {
    $container.on('click', '#button-popup-open', function() {
      var dataName = $('.menu__item--active').attr('id');

      helpingFunctions.getDataForPage(dataName);
      helpingFunctions.loadCheckboxesValues();

      $(this).hide();
      $('#popup-window').show();
    });

    $container.on('click', '.button-popup-close', function() {
      helpingFunctions.saveCheckboxesValues();

      $('#popup-window').hide();
      $('#button-popup-open').show();
    });

    $container.on('click', '#popup-window', function(ev) {
      ev.preventDefault();
      if (ev.target.id == 'popup-window') {
        $('#popup-window').hide();
        $('#button-popup-open').show();
      }
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
        if ($(this).closest('.product__item__content').hasClass(classToAddOrRemove)) {
          $(this).closest('.product__item__content').removeClass(classToAddOrRemove);
        } else {
          $(this).closest('.product__item__content').addClass(classToAddOrRemove);
        }
      }
    });
  }

  return {
    mainEvents: mainEvents
  };
})();
