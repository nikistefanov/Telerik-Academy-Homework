var helpingFunctions = (function() {
  function checkIfContentLoaded($container) {
    if ($container.find('.popup')) {
      getDataForPage('all-pages');
    }
  }

  function getDataForPage(name) {
    $.get('templates/' + name + '.html', function(data) {
      $('#main').html(data);
    });
  }

  function saveCheckboxesValues() {
    console.log('saved');
    var i, checkboxes = document.querySelectorAll('input[type=checkbox]');

    function save() {
      for (i = 0; i < checkboxes.length; i++) {
        localStorage.setItem(checkboxes[i].value, checkboxes[i].checked);
      }
    }
  }

  function loadCheckboxesValues() {
    console.log('loaded');
    var i, checkboxes = document.querySelectorAll('input[type=checkbox]');

    function load_() {
      for (i = 0; i < checkboxes.length; i++) {
        checkboxes[i].checked = localStorage.getItem(checkboxes[i].value) === 'true' ? true : false;
      }
    }
  }

  return {
    checkIfContentLoaded: checkIfContentLoaded,
    getDataForPage: getDataForPage,
    saveCheckboxesValues: saveCheckboxesValues,
    loadCheckboxesValues: loadCheckboxesValues
  };
}());
