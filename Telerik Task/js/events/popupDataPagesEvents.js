var popupDataPagesEvents = (function () {
  function load($container) {
    $(document).ready(function() {
      data.load('all-pages');
      data.load('selected-pages');
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
