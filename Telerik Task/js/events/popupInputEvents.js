var popupInputEvents = (function() {
  function load($container) {
    $container.on('focusin', '#search-bar', function() {
      $(this).closest('.popup__search').addClass('search--focused');
    });

    $container.on('focusout', '#search-bar', function() {
      $(this).closest('.popup__search').removeClass('search--focused');
    });

    $container.on('click', '.popup__checkbox', function() {
      var classToAddOrRemove = 'product__item__content--selected',
        closestElementNeedingTheClass = '.product__item__content';

      if ($(this).closest(closestElementNeedingTheClass).hasClass(classToAddOrRemove)) {
        $(this).closest(closestElementNeedingTheClass).removeClass(classToAddOrRemove);
      } else {
        $(this).closest(closestElementNeedingTheClass).addClass(classToAddOrRemove);
      }
    });
  }
  return {
    load: load
  };
})();
