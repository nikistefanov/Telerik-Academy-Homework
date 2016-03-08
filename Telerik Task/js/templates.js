var templates = (function() {
  function load(name, $container, option) {
    $.get('templates/' + name + '.handlebars', function(data) {
      if (option == 'html') {
        $container.html(data);
      } else if (option == 'append') {
        $container.append(data);
      }

    });
  }
  return {
    load: load
  };
})();
