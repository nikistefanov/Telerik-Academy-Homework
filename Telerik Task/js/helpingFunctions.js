var helpingFunctions = (function () {
  function checkIfContentLoaded($container) {
    // if ($container.find('#popup-window')) {
    //   getDataForPage('all-pages');
    // }
  }

  function getDataForPage(name) {
    $.get('templates/' + name + '.html', function(data) {
      $('#main').html(data);
    });
  }

  return {
    checkIfContentLoaded: checkIfContentLoaded,
    getDataForPage: getDataForPage
  };
}());
