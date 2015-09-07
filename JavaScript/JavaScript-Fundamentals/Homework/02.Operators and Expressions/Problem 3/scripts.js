/*Problem 3. Rectangle area

Write an expression that calculates rectangle’s area by given width and height.*/

var area;
function calcArea (x, y) {
	console.log("***********************************");
	process.stdout.write("Width = " + x + "\nHeigth = " + y);
	console.log("Area = " + (area = x * y));	
}

calcArea(3, 4);
calcArea(2.5, 3);
calcArea(5, 5);