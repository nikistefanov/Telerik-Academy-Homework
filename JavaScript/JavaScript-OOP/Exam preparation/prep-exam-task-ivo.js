function solve() {
    var module = (function () {
        var player,
            playlist,
            playable,
			audio,
            video,
			validator,
			CONSTANTS = {
			    TEXT_MIN_LENGTH: 3,
			    TEXT_MAX_LENGTH: 25,
			    IMDB_MIN_RATING: 1,
			    IMDB_MAX_RATING: 5,
			    MAX_NUMBER: 9007199254740992
			};

        function indexOfElementWithIdInCollection(collection, id) {
            var i,
                len;

            for (i = 0, len = collection.length; i < len; i++) {
                if (collection[i].id == id) {
                    return i;
                }
            }

            return -1;
        };

        function getSortingFunction(firstParameter, secondParameter) {
            return function (first, second) {
                if (first[firstParameter] < second[firstParameter]) {
                    return -1;
                } else if (first[firstParameter] > second[firstParameter]) {
                    return 1;
                }

                if (first[secondParameter] < second[secondParameter]) {
                    return -1;
                } else if (first[secondParameter] > second[secondParameter]) {
                    return 1;
                } else {
                    return 0;
                }
            };
        }

        validator = {
            validateIfUndefined: function (value, name) {
                name = name || 'Value';
                if (value === undefined) {
                    throw new Error(name + ' cannot be undefined.');
                }
            },

            validateIfObject: function (value, name) {
                name = name || 'Value';
                if (typeof value !== 'object') {
                    throw new Error(name + ' must be an object.');
                }
            },

            validateIfNumber: function (value, name) {
                name = name || 'Value';
                if (typeof value !== 'number') {
                    throw new Error(name + ' must be a number.');
                }
            },

            validateString: function (value, name) {
                name = name || 'Value'
                this.validateIfUndefined(value, name);

                if (typeof value !== 'string') {
                    throw new Error(name + ' must be a string.');
                }

                if (value.legnth < CONSTANTS.TEXT_MIN_LENGTH || value.legnth > CONSTANTS.TEXT_MAX_LENGTH) {
                    throw new Error(name + ' must be between ' + CONSTANTS.TEXT_MIN_LENGTH + ' and ' + CONSTANTS.TEXT_MAX_LENGTH + ' symbols.');
                }
            },

            validatePositiveNumber: function (value, name) {
                name = name || 'Value';
                this.validateIfUndefined(value, name);
                this.validateIfNumber(value, name);

                if (value <= 0) {
                    throw new Error(name + ' must be a positve number.');
                }
            },

            validateImdbRating: function (value) {
                this.validateIfUndefined(value, 'IMDB Rating');
                this.validateIfNumber(value, 'IMDB Rating');

                if (value < CONSTANTS.IMDB_MIN_RATING || value > CONSTANTS.IMDB_MAX_RATING) {
                    throw new Error('IMDB Rating must be between ' + CONSTANTS.IMDB_MIN_RATING + ' and ' + CONSTANTS.IMDB_MAX_RATING);
                }
            },

            validateId: function (id) {
                this.validateIfUndefined(id, 'Object id');

                if (typeof id !== 'number') {
                    id = id.id;
                }

                this.validateIfUndefined(id, 'Object id');
                return id;
            },

            validatePageAndSize: function (page, size, maxElements) {
                this.validateIfUndefined(page);
                this.validateIfUndefined(size);
                this.validateIfNumber(page);
                this.validateIfNumber(size);

                if (page < 0) {
                    throw new Error('Page must be a greater or equal to 0');
                }

                this.validatePositiveNumber(size, 'Size');

                if (page * size > maxElements) {
                    throw new Error('Page * size will not return any elements');
                }
            }
        };

        player = (function () {
            var currentPlayerId = 0,
                player = Object.create({});

            Object.defineProperty(player, 'init', {
                value: function (name) {
                    this.name = name;
                    this._id = ++currentPlayerId;
                    this._playlists = [];
                    return this;
                }
            });

            Object.defineProperty(player, 'id', {
                get: function () {
                    return this._id;
                }
            });

            Object.defineProperty(player, 'name', {
                get: function () {
                    return this._name;
                },
                set: function (value) {
                    validator.validateString(value, 'Player name');
                    this._name = value;
                }
            });

            Object.defineProperty(player, 'addPlaylist', {
                value: function (playlist) {
                    validator.validateIfUndefined(playlist, 'Added playlist');
                    if (playlist.id === undefined) {
                        throw new Error('Added playlist must have an id.');
                    }

                    this._playlists.push(playlist);

                    return this;
                }
            });

            Object.defineProperty(player, 'getPlaylistById', {
                value: function (id) {
                    validator.validateIfUndefined(id, 'Playlist id');
                    validator.validateIfNumber(id, 'Playlist id');

                    var foundIndex = indexOfElementWithIdInCollection.call(this._playlist, id);
                    if (foundIndex < 0) {
                        return null;
                    }

                    return this._playlist[foundIndex];
                }
            });

            Object.defineProperty(player, 'removePlaylist', {
                value: function (id) {
                    id = validator.validateId(id);

                    var foundIndex = indexOfElementWithIdInCollection(this._playlists, id);

                    if (foundIndex < 0) {
                        throw new Error('Playlist with id ' + id + ' was not found');
                    }

                    this._playlists.splice(foundIndex, 1);

                    return this;
                }
            });

            Object.defineProperty(player, 'listPlaylists', {
                value: function (page, size) {
                    validator.validatePageAndSize(page, size, this._playlists.length);

                    return this
                        ._playlists
                        .slice()
                        .sort(getSortingFunction('name', 'id'))
                        .splice(page * size, size);
                }
            });

            Object.defineProperty(player, 'contains', {
                value: function (playable, playlist) {
                    validator.validateIfUndefined(playable);
                    validator.validateIfUndefined(playlist);

                    var playableId = validator.validateId(playable.id);
                    var playlistId = validator.validateId(playlist.id);

                    var playlist = this.getPlaylistById(playlistId);
                    if (playlist == null) {
                        return false;
                    }

                    var playable = playlist.getPlayableById(playableId);
                    if (playable == null) {
                        return false;
                    }

                    return true;
                }
            });

            Object.defineProperty(player, 'search', {
                value: function (pattern) {
                    validator.validateString(pattern, 'Search pattern');

                    return this._playlists
                        .filter(function (playlist) {
                            return playlist
                                .listPlayables()
                                .some(function (playable) {
                                    return playable.length !== undefined
                                        && playable
                                            .title
                                            .toLowerCase()
                                            .indexOf(pattern.toLowerCase()) >= 0;
                                });
                        })
                        .map(function (playlist) {
                            return {
                                id: playlist.id,
                                name: playlist.name,
                            }
                        });
                }
            })

            return player;
        }());

        playlist = (function () {
            var currentPlaylistId = 0,
                playlist = Object.create({});

            Object.defineProperty(playlist, 'init', {
                value: function (name) {
                    this.name = name;
                    this._id = ++currentPlaylistId;
                    this._playables = [];
                    return this;
                }
            });

            Object.defineProperty(playlist, 'id', {
                get: function () {
                    return this._id;
                }
            });

            Object.defineProperty(playlist, 'name', {
                get: function () {
                    return this._name;
                },
                set: function (value) {
                    validator.validateString(value, 'Playlist name');
                    this._name = value;
                }
            })

            Object.defineProperty(playlist, 'addPlayable', {
                value: function (playable) {
                    validator.validateIfUndefined(playable, 'Added playable');
                    validator.validateIfObject(playable, 'Added playable');
                    validator.validateIfUndefined(playable.id, 'Added playable must have an ID');

                    this._playables.push(playable);
                    return this;
                }
            });

            Object.defineProperty(playlist, 'getPlayableById', {
                value: function (id) {
                    validator.validateIfUndefined(id, 'Playable id');
                    validator.validateIfNumber(id, 'Playable id');

                    var foundIndex = indexOfElementWithIdInCollection(this._playables, id);
                    if (foundIndex < 0) {
                        return null;
                    }

                    return this._playables[foundIndex];
                }
            });

            Object.defineProperty(playlist, 'removePlayable', {
                value: function (id) {
                    id = validator.validateId(id);

                    var foundIndex = indexOfElementWithIdInCollection(this._playables, id);

                    if (foundIndex < 0) {
                        throw new Error('Playable with id ' + id + ' was not found');
                    }

                    this._playables.splice(foundIndex, 1);

                    return this;
                }
            });

            Object.defineProperty(playlist, 'listPlayables', {
                value: function (page, size) {
                    page = page || 0;
                    size = size || CONSTANTS.MAX_NUMBER;
                    validator.validatePageAndSize(page, size, this._playables.length);

                    return this
                        ._playables
                        .slice()
                        .sort(getSortingFunction('title', 'id'))
                        .splice(page * size, size)
                    // if page must start from 1:
                    // .splice((page - 1) * size, size)
                }
            });

            return playlist;
        }());

        playable = (function () {
            var currentPlayableID = 0,
                playable = Object.create({});

            Object.defineProperty(playable, 'init', {
                value: function (title, author) {
                    this.title = title;
                    this.author = author;
                    this._id = ++currentPlayableID;
                    return this;
                }
            });

            Object.defineProperty(playable, 'id', {
                get: function () {
                    return this._id;
                }
            });

            Object.defineProperty(playable, 'title', {
                get: function () {
                    return this._title;
                },
                set: function (value) {
                    validator.validateString(value, 'Playable title');
                    this._title = value;
                }
            });

            Object.defineProperty(playable, 'author', {
                get: function () {
                    return this._author;
                },
                set: function (value) {
                    validator.validateString(value, 'Playable author');
                    this._author = value;
                }
            });

            Object.defineProperty(playable, 'play', {
                value: function () {
                    return this.id + '. ' + this.title + ' - ' + this.author;
                }
            });

            return playable;
        }());

        audio = (function (parent) {
            var audio = Object.create(parent);

            Object.defineProperty(audio, 'init', {
                value: function (title, author, length) {
                    parent.init.call(this, title, author)
                    this.length = length;
                    return this;
                }
            });

            Object.defineProperty(audio, 'length', {
                get: function () {
                    return this._length;
                },
                set: function (value) {
                    validator.validatePositiveNumber(value, 'Audio length');
                    this._length = value;
                }
            });

            Object.defineProperty(audio, 'play', {
                value: function () {
                    return parent.play.call(this) + ' - ' + this.length;
                }
            });

            return audio;
        }(playable));

        video = (function (parent) {
            var video = Object.create(parent);

            Object.defineProperty(video, 'init', {
                value: function (title, author, imdbRating) {
                    parent.init.call(this, title, author);
                    this.imdbRating = imdbRating;
                    return this;
                }
            });

            Object.defineProperty(video, 'imdbRating', {
                get: function () {
                    return this._imdbRating;
                },
                set: function (value) {
                    validator.validateImdbRating(value);
                    this._imdbRating = value;
                }
            });

            Object.defineProperty(video, 'play', {
                value: function () {
                    return parent.play.call(this) + ' - ' + this.imdbRating;
                }
            });

            return video;
        }(playable));

        return {
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
    }());

    return module;
}