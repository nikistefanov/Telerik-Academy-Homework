function solve() {
    var module = (function () {
        var item,
            book,
            media,
            catalog,
            bookCatalog,
            mediaCatalog,
            validator,
            CONSTANTS = {
                NAME_MIN_LENGTH: 2,
                NAME_MAX_LENGTH: 40,
                ISBN_MIN_LENGTH: 10,
                ISBN_MAX_LENGTH: 13,
                BOOK_GENRE_MIN_LENGTH: 2,
                BOOK_GENRE_MAX_LENGTH: 20,
                MIN_RATING: 1,
                MAX_RATING: 5,
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
                    return 1;
                } else if (first[firstParameter] > second[firstParameter]) {
                    return -1;
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
            },

            validateStringLength: function (value, name, minLength, maxLength) {
                name = name || 'Value'
                if (value.length < minLength || value.length > maxLength) {
                    throw new Error(name + ' must be between ' + minLength + ' and ' + maxLength + ' symbols.');
                }
            },

            validateIfIsOnlyDigits: function (value, name) {
                name = name || 'Value'
                var isnum = /^\d+$/.test(value);
                if (!isnum) {
                    throw new Error(name + ' must contains only digits [0-9].');
                }
            },

            validateRating: function (value) {
                this.validateIfUndefined(value, 'Media Rating');
                this.validateIfNumber(value, 'Media Rating');

                if (value < CONSTANTS.MIN_RATING || value > CONSTANTS.MAX_RATING) {
                    throw new Error('Media Rating must be between ' + CONSTANTS.MIN_RATING + ' and ' + CONSTANTS.MAX_RATING);
                }
            },

            validatePositiveNumber: function (value, name) {
                name = name || 'Value';
                this.validateIfUndefined(value, name);
                this.validateIfNumber(value, name);

                if (value <= 0) {
                    throw new Error(name + ' must be a positve number.');
                }
            }
        };

        item = (function () {
            var currentItemId = 0,
                item = Object.create({});

            Object.defineProperty(item, 'init', {
                value: function (name, description) {
                    this.name = name;
                    this.description = description;
                    this._id = ++currentItemId;
                    return this;
                }
            });

            Object.defineProperty(item, 'id', {
                get: function () {
                    return this._id;
                }
            });

            Object.defineProperty(item, 'name', {
                get: function () {
                    return this._name;
                },
                set: function (value) {
                    validator.validateString(value, 'Item name');
                    validator.validateStringLength(value, 'Item name', CONSTANTS.NAME_MIN_LENGTH, CONSTANTS.NAME_MAX_LENGTH);

                    this._name = value;
                }
            });

            Object.defineProperty(item, 'description', {
                get: function () {
                    return this._description;
                },
                set: function (value) {
                    validator.validateString(value, 'Description');
                    if (value.length <= 0) {
                        throw new Error('Description must contains more than 1 symbols!');
                    }

                    this._description = value;
                }
            });

            return item;
        }());

        book = (function (parent) {
            var book = Object.create(parent);

            Object.defineProperty(book, 'init', {
                value: function (name, isbn, genre, description) {
                    parent.init.call(this, name, description);
                    this.isbn = isbn;
                    this.genre = genre;
                    return this;
                }
            });

            Object.defineProperty(book, 'isbn', {
                get: function () {
                    return this._isbn;
                },
                set: function (value) {
                    validator.validateString(value, 'Book ISBN');
                    validator.validateStringLength(value, 'Book ISBN', CONSTANTS.ISBN_MIN_LENGTH, CONSTANTS.ISBN_MAX_LENGTH);
                    validator.validateIfIsOnlyDigits(value, 'Book ISBN');

                    this._isbn = value;
                }
            });

            Object.defineProperty(book, 'genre', {
                get: function () {
                    return this._genre;
                },
                set: function (value) {
                    validator.validateString(value, 'Book genre');
                    validator.validateStringLength(value, 'Book genre', CONSTANTS.BOOK_GENRE_MIN_LENGTH, CONSTANTS.BOOK_GENRE_MAX_LENGTH);

                    this._genre = value;
                }
            });

            return book;
        }(item));

        media = (function (parent) {
            var media = Object.create(parent);

            Object.defineProperty(media, 'init', {
                value: function (name, rating, duration, description) {
                    parent.init.call(this, name, description);
                    this.rating = rating;
                    this.duration = duration;
                    return this;
                }
            });

            Object.defineProperty(media, 'rating', {
                get: function () {
                    return this._rating;
                },
                set: function (value) {
                    validator.validateRating(value);

                    this._rating = value;
                }
            });

            Object.defineProperty(media, 'duration', {
                get: function () {
                    return this._duration;
                },
                set: function (value) {
                    validator.validatePositiveNumber(value, 'Media duration');

                    this._duration = value;
                }
            });

            return media;
        }(item));

        catalog = (function () {
            var currentCatalogId = 0
            catalog = Object.create({});

            Object.defineProperty(catalog, 'init', {
                value: function (name) {
                    this.name = name;
                    this._id = ++currentCatalogId;
                    this._items = [];
                    return this;
                }
            });

            Object.defineProperty(catalog, 'id', {
                get: function () {
                    return this._id;
                }
            });

            Object.defineProperty(catalog, 'name', {
                get: function () {
                    return this._name;
                },
                set: function (value) {
                    validator.validateString(value, 'Catalog name');
                    validator.validateStringLength(value, 'Catalog name', CONSTANTS.NAME_MIN_LENGTH, CONSTANTS.NAME_MAX_LENGTH);

                    this._name = value;
                }
            });

            Object.defineProperty(catalog, 'add', {
                value: function () {
                    var i,
                        len;
                    if (arguments.length <= 0) {
                        throw new Error('Items must be providate!');
                    }

                    for (i = 0, len = arguments.length; i < len; i += 1) {
                        if (!item.isPrototypeOf(arguments[i])) {
                            throw new Error('Catalog accepts only {Item} like objects!');
                        }
                    }

                    for (i = 0, len = arguments.length; i < len; i += 1) {
                        this._items.push(arguments[i]);
                    }

                    return this;
                }
            });

            Object.defineProperty(catalog, 'find', {
                value: function (id) {
                    validator.validateIfUndefined(id, 'id');
                    //validator.validateIfNumber(id, 'id');

                    var foundIndex = indexOfElementWithIdInCollection(this._items, id);
                    if (foundIndex < 0) {
                        return null;
                    }

                    return this._items[foundIndex];
                }
            });

            Object.defineProperty(catalog, 'getAllItems', {
                value: function () {
                    return this._items.slice();
                }
            });

            Object.defineProperty(catalog, 'search', {
                value: function (pattern) {
                    var i,
                        len;

                    validator.validateString(pattern, 'Search pattern');

                    pattern = pattern.toLowerCase();
                    var foundedItems = [];

                    for (i = 0, len = this._items.length; i < len; i += 1) {
                        if ((this._items[i].description.toLowerCase().indexOf(pattern) > -1) || (this._items[i].name.toLowerCase().indexOf(pattern) > -1)) {

                            foundedItems.push(this._items[i]);
                        }
                    }

                    if (foundedItems.length > 0) {
                        return foundedItems;
                    } else {
                        return [];
                    }

                }
            });



            return catalog;
        }());

        bookCatalog = (function (parent) {
            var bookCatalog = Object.create(parent);

            Object.defineProperty(bookCatalog, 'init', {
                value: function (name) {
                    parent.init.call(this, name);
                    return this;
                }
            });

            Object.defineProperty(bookCatalog, 'add', {
                value: function () {
                    var i,
                        len;
                    if (arguments.length <= 0) {
                        throw new Error('Items must be providate!');
                    }

                    for (i = 0, len = arguments.length; i < len; i += 1) {
                        if (!book.isPrototypeOf(arguments[i])) {
                            throw new Error('Catalog accepts only {Book} like objects!');
                        }
                    }

                    for (i = 0, len = arguments.length; i < len; i += 1) {
                        this._items.push(arguments[i]);
                    }

                    return this;
                }
            });

            return bookCatalog;
        }(catalog));

        mediaCatalog = (function (parent) {
            var mediaCatalog = Object.create(parent);

            Object.defineProperty(mediaCatalog, 'init', {
                value: function (name) {
                    parent.init.call(this, name);
                    return this;
                }
            });

            Object.defineProperty(mediaCatalog, 'add', {
                value: function () {
                    var i,
                        len;
                    if (arguments.length <= 0) {
                        throw new Error('Items must be providate!');
                    }

                    for (i = 0, len = arguments.length; i < len; i += 1) {
                        if (!media.isPrototypeOf(arguments[i])) {
                            throw new Error('Catalog accepts only {Media} like objects!');
                        }
                    }

                    for (i = 0, len = arguments.length; i < len; i += 1) {
                        this._items.push(arguments[i]);
                    }

                    return this;
                }
            });

            Object.defineProperty(mediaCatalog, 'getTop', {
                value: function () {
                    var i,
                        len,
                        topCountMedia = [];

                    for (i = 0, len = this._items.length; i < len; i += 1) {

                    }
                }
            });

            Object.defineProperty(mediaCatalog, 'getSortedByDuration', {
                value: function () {
                    var sortedMediaCatalog = [];


                    sortedMediaCatalog = this._items.slice().sort(function (x, y) {
                        if (x._duration < y._duration) {
                            return -1;
                        } else if (x._duration > y._duration) {
                            return 1;
                        } else {
                            0;
                        }
                    })
                        .sort(function (x, y) {
                            if (x.id < y.id) {
                                return 1;
                            } else if (x.id > y.id) {
                                return -1;
                            } else {
                                0;
                            }
                        }).slice();
                    console.log(sortedMediaCatalog);
                    //return sortedMediaCatalog;
                    //for (i = 0, len = this._items.length; i < len; i += 1) {

                    //}
                }
            });

            return mediaCatalog;
        }(catalog));

        return {
            getBook: function (name, isbn, genre, description) {
                return Object.create(book).init(name, isbn, genre, description);
            },
            getMedia: function (name, rating, duration, description) {
                return Object.create(media).init(name, rating, duration, description);
            },
            getBookCatalog: function (name) {
                return Object.create(bookCatalog).init(name);
            },
            getMediaCatalog: function (name) {
                return Object.create(mediaCatalog).init(name);
            }
        };
    }());

    return module;
/*
var module = solve();
var catalog = module.getBookCatalog('John\'s catalog');

var book1 = module.getBook('The secrets of the JavaScript Ninja', '1234567890', 'IT', 'A book about JavaScript');
var book2 = module.getBook('JavaScript: The Good Parts', '0123456789', 'IT', 'A good book about JS');
catalog.add(book1);
catalog.add(book2);

console.log(catalog.find(book1.id));
//returns book1

console.log(catalog.find({id: book2.id, genre: 'IT'}));
//returns book2

console.log(catalog.search('js')); 
// returns book2

console.log(catalog.search('javascript'));
//returns book1 and book2

console.log(catalog.search('Te sa zeleni'))
//returns []
*/