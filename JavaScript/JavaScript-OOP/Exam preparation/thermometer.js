(function () {
	var Thermommeter = (function () {
		var tempe = null,
			currentDay = 1,
			archive = [];
			
		// clouser --> this == Thermommeter
		Object.defineProperties(this, {
			temperature: {
				enumerable: true,
				get: function () {
					return tempe;
				},

				set: function (value) {
					tempe = value;
					archive.push({ temperature: 'Day ' + currentDay + ' : ' + tempe });
					currentDay += 1;
				}
			},
			
			// very common mistake - to forget the {} brackets!!!
			// aslo that's how 'archive' == hidden
			getArchive: {
				value: function () {
					return archive.slice();
				}
			}
		});
	});

	var therm = new Thermommeter();
	therm.temperature = 21;
	console.log(therm);
	console.log(therm.temperature);
	therm.temperature = 32;
	therm.temperature = 35;
	console.log(therm.getArchive());
} ());