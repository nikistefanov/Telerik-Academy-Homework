var template = (function() {
  var tmplCache = {};

  function load(name) {
    tmplCache[name] = $.get('/templates/' + name + '.html');
    return tmplCache[name];
  }

  return {
    load: load
  };
}());
