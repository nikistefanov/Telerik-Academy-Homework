function solve() {
    function isStringValid(string, minLength, maxLength) {
        return typeof string === 'string' && string.length >= minLength && string.length <= maxLength;
    }

    var player = {
        init: function (name) {
            return this;
        },

        addPlaylist: function (playlist) {

        },

        getPlaylistById: function (id) {

        },

        removePlaylist: function (id) {

        },

        listPlaylists: function (page, size) {

        }
    };

    var playlist = {
        init: function (name) {
            return this;
        },

        addPlayable: function (playable) {

        },

        getPlayableById: function (id) {

        },

        removePlayable: function (id) {

        },

        listPlayables: function (page, size) {

        }
    };

    var playable = function () {
        var lastId = 0,
            playable = {
                init: function (title, author) {
                    this.title = title;
                    this.author = author;
                    this.id = lastId += 1;
                    return this;
                },

                get title() {
                    return this._title;
                },
                set title(value) {
                    if (isStringValid(value, 3, 25)) {
                        throw {
                            name: 'InvalidTitleError',
                            message: 'Title must be a string between 3 and 25 symbols!'
                        };
                    }
                    this._title = value;
                },

                get author() {
                    return this._author;
                },
                set author(value) {
                    if (isStringValid(value, 3, 25)) {
                        throw {
                            name: 'InvalidAuthorError',
                            message: 'Author must be a string between 3 and 25 symbols!'
                        };
                    }
                    this._author = value;
                },

                play: function () {
                    return this.id + '. ' + this.title + ' - ' + this.author;
                }
            };

        return playable
    }();

    var audio = function (parent) {
        var audio = Object.create(parent);

        audio.init = function (title, author, length) {
            parent.init.call(this, title, author);
            this.length = length;
            return this;
        };

        audio.play = function () {
            return parent.play.call(this) + ' - ' + this.length;
        };

        return audio;
    }(playable);

    var video = {
        init: function () {
            return this;
        },

        play: function () {

        }
    };

    var module = {
        getPlayer: function (name) {
            return Object.create(player).init(name);
        },
        getPlaylist: function (name) {
            return Object.create(playlist).init(name);
        },
        getAudio: function (title, author, length) {
            return Object.create(audio).init(title, author, length);
        },
        getVideo: function (title, author, imdbRating) {
            return Object.create(video).init(title, author, imdbRating);
        }
    };

    return module;
};