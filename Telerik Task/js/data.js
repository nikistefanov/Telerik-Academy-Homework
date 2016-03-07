var data = (function() {
  function load(name) {
    $.get('templates/' + name + '.html', function(data) {
      $('#main').append(data);
    });
  }

  return {
    load: load
  };
}());
