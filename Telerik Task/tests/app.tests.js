(function() {
  var html;
  var sandbox;
  var $container;

  describe('#Popup Events', function() {

    before(function() {
      html = '<div id="#test-wrapper"></div>';
      $('body').prepend(html);
      container = document.getElementById('#test-wrapper');
      $container = $(container);
    });

    beforeEach(function() {
      sandbox = sinon.sandbox.create();
      sandbox.stub(eventLoader, 'loadAllEvents');
      eventLoader.loadAllEvents($container);
    });

    afterEach(function() {
      sandbox.restore();
    });

    it('expect eventLoader.loadAllEvents() to be called', function() {
      //var spy = sinon.spy(eventLoader, 'loadAllEvents');
      //sinon.assert.called(spy);
      
      expect(eventLoader.loadAllEvents.called).to.be.true;
    });
  });
}());
