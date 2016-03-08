var eventLoader = (function() {
  function loadAllEvents ($container) {
    popupInputsEvents.load($container);
    popupWindowEvents.load($container);
    popupDataPagesEvents.load($container);
  }

  return {
    loadAllEvents: loadAllEvents
  };
})();
