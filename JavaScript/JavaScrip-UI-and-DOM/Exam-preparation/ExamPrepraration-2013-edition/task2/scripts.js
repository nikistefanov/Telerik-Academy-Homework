$.fn.tabs = function () {
    var $tabControl = this;
    // this - ���� ��� ������������� ������� � $
    $tabControl.addClass('tabs-container');
    hideTabControlContent();

    $tabControl.on('click', '.tab-item-title', function () {
        // this - ���� ��� clicked ������� !! ���� DOM ������� �� ���� jQuery, ������ ���� ������� $
        var $clickedElement = $(this);
        hideTabControlContent();
        $tabControl.find('.tab-item').removeClass('current');
        $clickedElement.next().show();
        // parent - ���� ��� �������� �� ������������ �������
        $clickedElement.parent().addClass('current');
    });

    function hideTabControlContent () {
        // find() - ������ ������ ���� �� ������������� �������, ����� ���� ���� .tab-item-content
        // hide() - ����� ���� display: none
        // show() - ����� ������� display: �� block or inline-block
        $tabControl.find('.tab-item-content').hide();
    }
};

// filter() - ����� ����� ������������� �������� � ������ ��
// closest() - ������ ���-�������� �������, ��������� �� ���������� �������� ��. ('.myClass') ��� (tr). ����� � ��������, ������� � ����