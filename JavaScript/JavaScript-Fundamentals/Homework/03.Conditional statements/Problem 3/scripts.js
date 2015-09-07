/*Problem 3. The biggest of Three

Write a script that finds the biggest of three numbers.
Use nested if statements.
Examples:

a	b	c	biggest
5	2	2	5
-2	-2	1	1
-2	4	3	4
0	-2.5	5	5
-0.1	-0.5	-1.1	-0.1*/

var a,
	b,
	c,
	biggest;

function BiggestNumber(a, b, c) {
	biggest = a;

	if (b > biggest) {
		biggest = b;
	}
	if (c > biggest) {
		biggest = c;
	}
	console.log('The biggest of: | ' + a + ' | ' + b + ' | ' + c + ' | ' + 'is: ', biggest);
}

BiggestNumber(5, 2, 2);
BiggestNumber(-2, -2, 1);
BiggestNumber(-2, 4, 3);
BiggestNumber(0, -2.5, 5);
BiggestNumber(-0.1, -0.5, -1.1);