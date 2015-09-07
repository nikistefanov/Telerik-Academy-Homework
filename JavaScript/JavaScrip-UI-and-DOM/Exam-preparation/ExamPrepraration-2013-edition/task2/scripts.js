$.fn.tabs = function () {
    var $tabControl = this;
    // this - сочи към селектираният елемент с $
    $tabControl.addClass('tabs-container');
    hideTabControlContent();

    $tabControl.on('click', '.tab-item-title', function () {
        // this - сочи към clicked елемент !! като DOM елемент не като jQuery, заради това слагаме $
        var $clickedElement = $(this);
        hideTabControlContent();
        $tabControl.find('.tab-item').removeClass('current');
        $clickedElement.next().show();
        // parent - сочи към родителя на селектирания елемент
        $clickedElement.parent().addClass('current');
    });

    function hideTabControlContent () {
        // find() - намира всички деца на селектираният елемент, които имат клас .tab-item-content
        // hide() - слага стил display: none
        // show() - връща обратно display: на block or inline-block
        $tabControl.find('.tab-item-content').hide();
    }
};

// filter() - търси между селектираните елементи и децата им
// closest() - намира най-близкият елемент, отговарящ на посочените критерии пр. ('.myClass') или (tr). Търси в родители, съседни и деца