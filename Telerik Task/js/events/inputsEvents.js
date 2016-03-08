var inputsEvents = (function() {
  function load($container) {
    $container.on('focusin', '#search-bar', function() {
      $(this).closest('.popup__search').addClass('search--focused');
    });

    $container.on('focusout', '#search-bar', function() {
      $(this).closest('.popup__search').removeClass('search--focused');
    });

    $container.on('click', '.product__item__content', function(ev) {
      var classToAddOrRemove = 'product__item__content--selected',
        $target = $(ev.target);
      if ($(ev.target).is("input")) {
        if ($(this).hasClass(classToAddOrRemove)) {
          $(this).removeClass(classToAddOrRemove);
        } else {
          $(this).addClass(classToAddOrRemove);
        }
      }
    });
  }
  return {
    load: load
  };
})();
