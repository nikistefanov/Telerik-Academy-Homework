var MainProduct = (function(parent) {
  function MainProduct(element) {
		parent.call(this, element);
    this.bindEvents();
	}

	MainProduct.prototype = parent.prototype;

  MainProduct.prototype.bindEvents = function() {
    this.element.on('click', '.popup__checkbox', this.handleClick);
  };

  MainProduct.prototype.handleClick = function(ev) {
    var classToAddOrRemove = 'product__item__content--selected',
      elementNeedingTheClass = '.product__item__content';
    var $target = $(ev.target).closest(elementNeedingTheClass);

    if (($target).closest(elementNeedingTheClass).hasClass(classToAddOrRemove)) {
      $target.closest(elementNeedingTheClass).removeClass(classToAddOrRemove);
    } else {
      $target.closest(elementNeedingTheClass).addClass(classToAddOrRemove);
    }
  };

	return MainProduct;
}(Product));
