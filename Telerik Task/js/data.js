var data = (function() {
  function load(name) {
    $.get('templates/' + name + '.html', function(data) {
      $('#popup-main').append(data);
    });
  }

  return {
    load: load
  };
}());
