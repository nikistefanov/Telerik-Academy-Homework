(function() {
  var html;
  var sandbox;
  var $container;
  var data = [ /* fake data here */ ];

  //sandbox.stub(console, 'log');

  describe('#MainProduct', function() {

    before(function () {
      html = '<div id="#wrapper"></div>';
      $container = $('#wrapper');
    });

    after(function() {

    });

    beforeEach(function() {
      sandbox = sinon.sandbox.create();
      $content = $('<div id="content"></div>');
      $container.append($content);
    });

    afterEach(function() {
      sandbox.restore();
    });

    it('expect MainProduct function constructor to exist', function () {
			expect(MainProduct).to.exist;
		});

		it('expect MainProduct to be a function', function () {
			expect(MainProduct).to.be.a('function');
		});

    it('expect to create MainProduct when correct argumets are provided', function() {
      var product = new MainProduct($container);
      expect(product.element).to.be.eql($('#wrapper'));
    });

    it('expect when none argumets are provided to throw', function() {
      function fn() {
				new MainProduct();
			}
			expect(fn).to.throw();
    });

    it('expect to setItems() to be called with valid items provided', function () {
      var product = new MainProduct($container);
      sandbox.stub(product, 'setItems');

      product.setItems('somePage', $content);

      expect(product.setItems.called).to.be.true;
    });

    it('expect setItems() to throw when invalid items provided', function () {
      var product = new MainProduct($container);

      function fn() {
				product.setItems($content);
			}
			expect(fn).to.throw();
    });
  });
}());
