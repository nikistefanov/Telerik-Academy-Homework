var eventLoader = (function() {
  function loadAllEvents($container) {
    popupSearchEvents.load($container);
    popupWindowEvents.load($container);
    popupDataPagesEvents.load($container);
  }

  return {
    loadAllEvents: loadAllEvents
  };
})();
