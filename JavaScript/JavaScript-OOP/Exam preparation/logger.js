(function () {
	var Logger = (function () {
		// constructor
		function Logger() {
			var val = null,
				id = 1,
				history = [];

			Object.defineProperties(this, {
				value: {
					get: function () {
						return val;
					},

					set: function (value) {
						val = value;
						history.push({ id: id, prop: val });
						id += 1;
					}
				},

				getHistory: {
					value: function () {
						return history.slice();
					}
				}
			});
		}

		return Logger;
	} ());

	var logger = new Logger();
	logger.value = 'first value';
	console.log(logger.value);

	logger.value = 'second value';
	console.log(logger.value);

	console.log(logger.getHistory());
} ());