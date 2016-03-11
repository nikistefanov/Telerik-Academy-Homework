(function() {
  var html;
  var sandbox;
  var $container;
  var $btn;
  var $popup;

  describe('#Popup Events', function() {

    before(function() {
      html = '<div><div id="#test-wrapper"><div class="popup__button"><button id="button-popup-open">X</button></div><div id="popup"><i class="button-popup-close"></i></div></div></div>';
      $('body').prepend(html);
      container = document.getElementById('#test-wrapper');
      $container = $(container);
      $btnOpen = $('#button-popup-open');
      $popup = $('#popup');
      $btnClose = $('.button-popup-close');
      popupWindowEvents.load($container);
    });

    after(function() {

    });

    beforeEach(function() {
      sandbox = sinon.sandbox.create();
      $btnOpen.show();
      $popup.hide();
    });

    afterEach(function() {
      sandbox.restore();
    });

    it('expect when button-popup-open is clicked to hide to himself', function() {
      $btnOpen.trigger('click');

      expect($btnOpen.css('display')).to.equal('none');
    });

    it('expect when button-popup-open is clicked to show the Popup', function() {
      $btnOpen.trigger('click');

      expect($popup.css('display')).to.equal('block');
    });

    it('expect when button-popup-close is clicked to hide to the Popup', function() {
      $btnClose.trigger('click');

      expect($popup.css('display')).to.equal('none');
    });
  });
}());
