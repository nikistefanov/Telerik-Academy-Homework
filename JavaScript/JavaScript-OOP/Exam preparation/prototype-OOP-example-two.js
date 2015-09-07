var vehicle = (function () {
	var vehicle = {};

	vehicle.init = function (brand) {
		this.brand = brand;
		return this;
	}

	vehicle.move = function () {
		return this.brand + ' is moving';
	}

	return vehicle;
} ());

var car = (function (parent) {
	var car = Object.create(parent);
	
	// using defineProperty
	Object.defineProperty(car, 'init', {
		value: function (brand, wheels) {
			parent.init.call(this, brand);
			this.wheels = wheels;
			return this;
		}
	});
	
	Object.defineProperty(car, 'wheels', {
		get: function () {
			return this._wheels;
		},
		set: function (value) {
			if (value > 4) {
				throw new Error ('Wheels must be less than 4!');
			}
			
			this._wheels = value;
		}
	});

	Object.defineProperty(car, 'move', {
		value: function () {
			var base = parent.move.call(this);
			return base + ' with ' + this.wheels + ' wheels';
		}
	})

	// car.init = function (brand, wheels) {
	// 	parent.init.call(this, brand);
	// 	this.wheels = wheels;
	// 	return this;
	// }
	// car.move = function () {
	// 	var base = parent.move.call(this);
	// 	return base + ' with ' + this.wheels + ' wheels';
	// }
	
	return car;
} (vehicle));

var someVehicle = Object.create(vehicle).init('Mercedes');
console.log(someVehicle);

var someCar = Object.create(car).init('Auid', 4);
console.log(someCar);
console.log(someCar.move());