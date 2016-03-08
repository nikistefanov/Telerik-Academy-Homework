var eventLoader = (function() {
  function loadAllEvents ($container) {
    popupInputEvents.load($container);
    popupWindowEvents.load($container);
    popupDataPagesEvents.load($container);
  }

  return {
    loadAllEvents: loadAllEvents
  };
})();
