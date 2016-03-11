var data = (function() {
  function load(name) {
    return $.ajax({type: "GET", url: 'templates/' + name + '.html', async: false}).responseText;
  }
  return {
    load: load
  };
}());
