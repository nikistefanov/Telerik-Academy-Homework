(function() {
  var html;
  var sandbox;
  var $container;
  var data = [ /* fake data here */ ];

  //sandbox.stub(console, 'log');

  describe('#SelectedProduct', function() {

    before(function () {
      html = '<div id="#wrapper"></div>';
      $container = $('#wrapper');
    });

    after(function() {

    });

    beforeEach(function() {
      sandbox = sinon.sandbox.create();
      $content = $('<div id="content"><div></div></div>');
      $container.append($content);
    });

    afterEach(function() {
      sandbox.restore();
    });

    it('expect Selected Product function constructor to exist', function () {
			expect(SelectedProduct).to.exist;
		});

		it('expect Selected Product to be a function', function () {
			expect(SelectedProduct).to.be.a('function');
		});

    it('expect to create Selected Product when correct argumets are provided', function() {
      var product = new SelectedProduct($container);
      expect(product.element).to.be.eql($('#wrapper'));
    });

    it('expect when none argumets are provided to throw', function() {
      function fn() {
				new SelectedProduct();
			}
			expect(fn).to.throw();
    });

    it('expect setItems() to be called with valid items provided', function () {
      var product = new SelectedProduct($container);
      sandbox.stub(product, 'setItems');

      product.setItems('somePage', $content);

      expect(product.setItems.called).to.be.true;
    });

    it('expect setItems() to throw when invalid items provided', function () {
      var product = new SelectedProduct($container);

      function fn() {
				product.setItems($content);
			}
			expect(fn).to.throw();
    });
  });
}());
