var db = (function () {
	var objs = [],
		result;
	function add(obj) {
		objs.push(obj);
		return result;
	}
	function list() {
		return objs.slice();
	}
	result = {
		add: add,
		list: list
	};
	return result;
}());

console.log(db.add(5)
				.add(7)
				.list());