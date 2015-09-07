/*Problem 6. Point in Circle

Write an expression that checks if given point P(x, y) is within a circle K({0,0}, 5). //{0,0} is the centre and 5 is the radius*/

function isInCircle (x, y) {
	var circleX = 0;
	var circleY = 0;
	var circleR = 5;
	console.log("***********************************");
	console.log("x = " + x + "| y = " + y);

	console.log((x - circleX) * (x - circleX) + (y - circleY) * (y - circleY) <= circleR * circleR);
}

isInCircle(0, 1);
isInCircle(-5, 0);
isInCircle(-4, 5);
isInCircle(1.5, -3);
isInCircle(100, -30);
isInCircle(0, 0);
isInCircle(0.2, -0.8);
isInCircle(0.9, -4.93);
isInCircle(2, 2.655);