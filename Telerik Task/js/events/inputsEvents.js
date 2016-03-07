var inputsEvents = (function() {
  function load($container) {
    $container.on('focusin', '#search-bar', function() {
      $(this).closest('.popup__search').addClass('search--focused');
    });

    $container.on('focusout', '#search-bar', function() {
      $(this).closest('.popup__search').removeClass('search--focused');
    });

    $container.on('click', '.product__item__content', function(ev) {
      var classToAddOrRemove = 'product__item__content--selected';
      $target = $(ev.target);

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
    load: load
  };
})();
