  var Product = (function() {
    function Product(element) {
      if (!element) {
        throw 'No arguments provided!';
      }

      this.element = $(element);
    }

    Product.prototype.setItems = function(templateHtmlName, $content) {
      if (!templateHtmlName || !$content) {
        throw "No valid arguments are provided";
      }
      template.load(templateHtmlName)
        .then(function(templateHtml) {
          $content.append(templateHtml);
        });
    };

    return Product;
  }());
