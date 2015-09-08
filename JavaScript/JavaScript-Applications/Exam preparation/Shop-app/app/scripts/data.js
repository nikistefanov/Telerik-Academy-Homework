import converter from 'scripts/converter.js'

Parse.initialize("uXvNd6q9zARU7sUa5gz49CPSNrP951mFSTUUmfJB", "2IfaJwdFOGsPGQtptCKnAR5HxZZAP9X5qPj490yx");
var Shop = Parse.Object.extend("Shop"),
    Product = Parse.Object.extend("Product");

export default {
    users: {
        login: function (username, password) {
            return Parse.User.logIn(username, password);
        },
        logout: function () {
            return Parse.User.logOut();
        },
        register: function (username, password) {
            var user = new Parse.User();
            user.set("username", username);
            user.set("password", password);

            return user.signUp();
        },
        current: function () {
            return new Promise(function (resolve, reject) {
                var user = Parse.User.current();
                resolve(user ? user.get('username') : undefined);
            })
        }
    },
    shops: {
        all: function () {
            var query = new Parse.Query(Shop);
            return new Promise(function (resolve, reject) {
                query.find()
                    .then(function (data) {
                        return data.map(function (item) {
                            return converter.dbShopToShopVM(item);
                        });
                    })
                    .then(function (data) {
                        var currentUserId = Parse.User.current() ? Parse.User.current().id : '';

                        data.map(function (item) {
                            item.isOwner = currentUserId === item.ownerId;
                            return item;
                        });
                        resolve({shops: data});
                    })
            })
        },
        get: function (id) {

        },
        add: function (shopName) {
            var shop = new Shop();
            shop.set('name', shopName);
            shop.set('owner', Parse.User.current());

            return new Promise(function (resolve, reject) {
                resolve(shop.save());
            });
            //return shop.save();
        },
        remove: function (id) {
            var query = new Parse.Query(Shop);
            return new Promise(function (resolve, reject) {
                query.get(id)
                    .then(function (shop) {
                        resolve(shop.destroy());
                    });
            });
        }
    },
    product: {},
    search: function (value) {
        var query = new Parse.Query(Shop);
        return new Promise(function (resolve, reject) {
            query.contains('name', value);
            query.find()
                .then(function (data) {
                    return data.map(function (item) {
                        return converter.dbShopToShopVM(item);
                    })
                })
                .then(function (data) {
                    resolve({shops: data});
                })
        })


    }
}