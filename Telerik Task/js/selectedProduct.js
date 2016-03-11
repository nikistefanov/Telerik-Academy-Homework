var SelectedProduct = (function(parent) {
  function SelectedProduct(element) {
    parent.call(this, element);
  }

  SelectedProduct.prototype = parent.prototype;

  return SelectedProduct;
}(Product));
