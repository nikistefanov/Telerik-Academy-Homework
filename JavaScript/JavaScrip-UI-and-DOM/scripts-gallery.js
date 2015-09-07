/* globals $ */
$.fn.gallery = function (columns) {
	columns = columns || 4;

	var $gallery = $(this);
	// .find() ще търси в децата му и децата на децата му и т.н.
	//var $selected = $this.find('.selected');

	// .childer() ще търси само в децата му
	var $selected = $gallery.children('.selected');
	var $galleryList = $gallery.children('.gallery-list');
	var $imageContainers = $galleryList.children('.image-container');
	var $currentImage = $selected.find('#current-image');
	var $previousImage = $selected.find('#previous-image');
	var $nextImage = $selected.find('#next-image');

	// .each() е като foreach - обхожда всеки елемент в масива, дава ни index
	$imageContainers.each(function (index, element) {
		if (index % columns == 0) {
			$(element).addClass('clearfix');
		}
	});

	$galleryList.on('click', 'img', function () {
		var $this = $(this);
		$galleryList.addClass('blurred');
		$('<div />').addClass('disabled-background').appendTo($gallery);		
		applySelected($this);

		// вместо използването на функция
		/*
		var imageSrc = $this.attr('src');
		// .data() взема арибут, който има data-    пример: data-info; data-value и т.н.! Използва се когато няма да се променя атрибута (неговата стойност)!
		var index = parseInt($this.data('info'));
		$currentImage.attr('src', imageSrc);
		$currentImage.attr('data-info', index);
		*/

		$selected.show();
	});

$currentImage.on('click', function() {
	$galleryList.removeClass('blurred');
	$selected.hide();
	$gallery.children('.disabled-background').remove();
});

$previousImage.on('click', function() {
	var $this = $(this);
	applySelected($this);
});

$nextImage.on('click', function() {
	var $this = $(this);
	applySelected($this);
});

$gallery.addClass('gallery');
$selected.hide();

function applySelected ($element) {
	var currentImageInfo = getImageInformation($element);
	setImageInformation($currentImage, currentImageInfo.src, currentImageInfo.index);
	var previousIndex = getPreviousIndex(currentImageInfo.index);
	var nextIndex = getNextIndex(currentImageInfo.index);
	var previousImage = getImageByIndex(previousIndex);
	var nextImage = getImageByIndex(nextIndex);
	var previousImageInfo = getImageInformation(previousImage);
	var nextImageInfo = getImageInformation(nextImage);
	setImageInformation($previousImage, previousImageInfo.src, previousImageInfo.index);
	setImageInformation($nextImage, nextImageInfo.src, nextImageInfo.index);
};

function getImageInformation ($element) {
	return {
		src: $element.attr('src'),
		index: parseInt($element.attr('data-info'))
	};
};

function getImageByIndex (index) {
		// връща img с атрибут data-info="подадения индекс"
		return $gallery.find('img[data-info="' + index + '"]');
	};

	function setImageInformation ($element, src, index) {
		$element.attr('src', src);
		$element.attr('data-info', index);
	};

	function getNextIndex (index) {
		index++;
		if (index >  $imageContainers.length) {
			index = 1;
		}

		return index;
	};

	function getPreviousIndex (index) {
		index--;
		if (index < 1) {
			index = $imageContainers.length;
		}

		return index;
	};

	return $this;
};