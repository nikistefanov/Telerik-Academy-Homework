/*Problem 8. Trapezoid area

Write an expression that calculates trapezoid's area by given sides a and b and height h.*/


function calcArea (a, b, h) {
	var area = ((a + b) / 2) * h;
	console.log("***********************************");
	console.log("a = " + a + " b = " + b + " h = " + h);
	console.log("Area is: " + area);
}

calcArea(5, 7, 12);
calcArea(2, 1, 33);
calcArea(8.5, 4.3, 2.7);
calcArea(100, 200, 300);
calcArea(0.222, 0.333, 0.555);
