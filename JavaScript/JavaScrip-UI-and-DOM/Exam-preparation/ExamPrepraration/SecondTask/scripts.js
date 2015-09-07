/* globals $ */
$.fn.gallery = function (colums) {
    colums = colums || 4;
    var $this = this;
    var $selected = $this.find('.selected');

    var count = 0;
    var $imageContainers = $this.find('.image-containers');
    // each is forEach only for jQuery
    $imageContainers.each(function (index, imageContainer) {
        count += 1;
        if (count === colums) {
            var $imageContainer = $(imageContainer);
            $imageContainer.after = ($('<div/>').addClass('clearfix'));
            count = 0;
        }
    });


    
    $('.gallery-list').on('click', '.image-container', function () {
        $selected.show();
    });

    
    $this.addClass('gallery');
    $selected.hide();
};