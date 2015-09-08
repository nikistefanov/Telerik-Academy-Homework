import data from 'scripts/data.js'
import notifier from 'scripts/notifier.js'

export default {
    loginPageEvents: function ($container) {
        $container.on('click', '#btn-login', function (ev) {
            ev.stopPropagation();
            ev.preventDefault();
            var username = $('#input-username')[0].value,
                password = $('#input-password')[0].value;

            data.users.login(username, password)
                .then(function () {
                    document.location = document.location.origin;
                })
        });

        $container.on('click', '#btn-reg', function (ev) {
            ev.stopPropagation();
            ev.preventDefault();
            var username = $('#input-username')[0].value,
                password = $('#input-password')[0].value;

            data.users.register(username, password)
                .then(function () {
                    document.location = document.location.origin;
                })
        })
    },
    navigationEvent: function ($container) {
        $container.on('click', '#btn-logout', function (ev) {
            data.users.logout()
                .then(function () {
                    document.location = document.location.origin;
                })
        });
        $container.on('click', '#btn-search', function (ev) {
            ev.stopPropagation();
            ev.preventDefault();

            var value = $('#search')[0].value;
            document.location = document.location.origin + '#/search/' + value;
        });
    },
    shopEvents: function ($container) {
        $container.on('click', '#btn-add-shop', function (ev) {
            var name = $('#tb-shop-name')[0].value;

            data.shops.add(name)
                .then(function (data) {
                    notifier.success('Shop ' + data.get('name') + ' added!');
                })
                .catch(function (err) {
                    notifier.error(err);
                })
        });
        $container.on('click', '#btn-remove-shop', function (ev) {
            ev.stopPropagation();
            ev.preventDefault();

            var shopId = $(ev.target).closest('tr').attr('data-shop-id');
            data.shops.remove(shopId)
                .then(function (data) {
                    notifier.success('Shop ' + data.get('name') + ' removed');
                })
                .catch(function (err) {
                    notifier.err(err);
                })
        })
    }
};
