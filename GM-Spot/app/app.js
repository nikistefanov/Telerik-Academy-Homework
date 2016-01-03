import 'sammy'
import 'jquery'
import 'bootstrapUI'


var containerId = 'wrapper'
var sammyApp = Sammy(containerId, function() {
  this.get('#/', function () {
    this.redirect('#/home')
  });
  this.get('#/home', function () {

  });
});

sammyApp.run('#/');
