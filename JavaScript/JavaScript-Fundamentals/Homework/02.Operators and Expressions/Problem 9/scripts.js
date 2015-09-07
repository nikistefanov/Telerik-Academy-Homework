/*Problem 9. Point in Circle and outside Rectangle

Write an expression that checks for given point P(x, y) if it is within the circle K( (1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2).*/


inCircleOutRectangle(2.5, 2);
inCircleOutRectangle(0, 1);
inCircleOutRectangle(2.5, 1);
inCircleOutRectangle(2, 0);
inCircleOutRectangle(4, 0);
inCircleOutRectangle(2.5, 1.5);
inCircleOutRectangle(2, 1.5);
inCircleOutRectangle(1, 2.5);
inCircleOutRectangle(-100, -100);

function isInCircle (x, y) {
	var circleX = 1,
		circleY = 1,
		circleR = 3;
	console.log("***********************************");
	console.log("x = " + x + "| y = " + y);

	return (x - circleX) * (x - circleX) + (y - circleY) * (y - circleY) <= circleR * circleR;
}

function isOutsideRectangle(x, y, top, bottom, left, right){
	var top = 1, 
		left = -1, 
		width = 6, 
		height = 2;
    return !(x >= left && x <= right && y <= top && y >= bottom);
}

function inCircleOutRectangle(function circle, function rectangle) {
	
}