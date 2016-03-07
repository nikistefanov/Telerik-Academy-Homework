var eventLoader = (function() {
  function loadAllEvents ($container) {
    inputsEvents.load($container);
    popupWindowEvents.load($container);
    popupDataPagesEvents.load($container);
  }

  return {
    loadAllEvents: loadAllEvents
  };
})();
