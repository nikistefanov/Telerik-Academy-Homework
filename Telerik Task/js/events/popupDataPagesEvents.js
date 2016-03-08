var popupDataPagesEvents = (function() {
  function load($container) {
    var allPages = 'all-pages',
      selectedPages = 'selected-pages';

    $(document).ready(function() {
      data.load(allPages);
      data.load(selectedPages);
    });

    $container.on('click', '.menu__item', function() {
      var currentActivePage = $('.menu__item--active').attr('id'),
        nextActivePage = $(this).attr('id');
      $('.' + currentActivePage + '').hide();
      $('.' + nextActivePage + '').show();

      $('.menu__item--active').removeClass('menu__item--active');
      $(this).addClass('menu__item--active');
    });
  }
  return {
    load: load
  };
}());
