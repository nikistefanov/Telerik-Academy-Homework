var validate = (function () {

    function ifUndefined(value, name) {
        name = name || 'Value';
        if (value === undefined) {
            toastr.error(name + ' cannot be undefined.');
            throw new Error;
        }
    }

    function ifString(value, name) {
        name = name || 'Value'

        if (typeof value !== 'string') {
            toastr.error(name + ' must be a string.');
            throw new Error;
        }
    }

    function valueLength(value, name, minLength, maxLength) {
        name = name || 'Value'
        if (value.length < minLength || value.length > maxLength) {
            toastr.error(name + ' must be between ' + minLength + ' and ' + maxLength + ' symbols.');
            throw new Error;
        }
    }

    function containsOnlyTheCorrectCharacters(value, name) {
        name = name || 'Value'
        if(value.matches("^[a-zA-Z0-9]")){
            toastr.error(name + ' Can contain only Latin letters, digits and the characters "_" and "."!');
            throw new Error;
        }
    }

    return {
        ifUndefined: ifUndefined,
        ifString: ifString,
        valueLength: valueLength,
        containsOnlyTheCorrectCharacters: containsOnlyTheCorrectCharacters
    }
}());