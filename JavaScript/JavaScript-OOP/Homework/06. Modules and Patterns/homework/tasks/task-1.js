/* Task Description */
/* 
* Create a module for a Telerik Academy course
  * The course has a title and presentations
    * Each presentation also has a title
    * There is a homework for each presentation
  * There is a set of students listed for the course
    * Each student has firstname, lastname and an ID
      * IDs must be unique integer numbers which are at least 1
  * Each student can submit a homework for each presentation in the course
  * Create method init
    * Accepts a string - course title
    * Accepts an array of strings - presentation titles
    * Throws if there is an invalid title
      * Titles do not start or end with spaces
      * Titles do not have consecutive spaces
      * Titles have at least one character
    * Throws if there are no presentations
  * Create method addStudent which lists a student for the course
    * Accepts a string in the format 'Firstname Lastname'
    * Throws if any of the names are not valid
      * Names start with an upper case letter
      * All other symbols in the name (if any) are lowercase letters
    * Generates a unique student ID and returns it
  * Create method getAllStudents that returns an array of students in the format:
    * {firstname: 'string', lastname: 'string', id: StudentID}
  * Create method submitHomework
    * Accepts studentID and homeworkID
      * homeworkID 1 is for the first presentation
      * homeworkID 2 is for the second one
      * ...
    * Throws if any of the IDs are invalid
  * Create method pushExamResults
    * Accepts an array of items in the format {StudentID: ..., Score: ...}
      * StudentIDs which are not listed get 0 points
    * Throw if there is an invalid StudentID
    * Throw if same StudentID is given more than once ( he tried to cheat (: )
    * Throw if Score is not a number
  * Create method getTopStudents which returns an array of the top 10 performing students
    * Array must be sorted from best to worst
    * If there are less than 10, return them all
    * The final score that is used to calculate the top performing students is done as follows:
      * 75% of the exam result
      * 25% the submitted homework (count of submitted homeworks / count of all homeworks) for the course
*/

function solve() {
  function isTitleValid(title) {
    if (title === null || typeof title !== 'string') {
      return false;
    }

    if (title.trim() === '' || title.length === 0 || title != title.trim() || /\s{2,}/.test(title)) {
      return false;
    }

    return true;
  }

  function isPresentationValid(presentation) {

    if (presentation === null || presentation.length == 0) {

      return false;
    }

    for (var i = 0; i < presentation.length; i++) {
      if (!isTitleValid(presentation[i])) {
        return false;
      }
    }
    return true;
  }

  function isValidSting(value, msg) {
    if (value === null || typeof value !== 'string' || value.trim() === '') {
      throw new Error('Invalid ' + msg);
    }
  }

  function isValidName(name) {
    if (name[0] === name[0].toLowerCase()) {
      return false;
    }
    for (var i = 1; i < name.length; i++) {
      if (name[i] === name[i].toUpperCase()) {
        return false;
      }
    }

    return true;
  }

  function isValidID(id) {
    if (!(id % 1 === 0 && id > 0)) {
      throw new Error('ID must be a valid number, greater than 0');
    }
  }

  function checkIfStudentIdExists(students, studentID) {
    return students.some(function (student) {
      return student.id === studentID;
    });
  }

  function isValidHomeworkID(presentations, homeworkID) {
    if (homeworkID < 1 || homeworkID > presentations.length || isNaN(parseInt(homeworkID))) {
      return false;
    }

    return true;
  }

  var Course = {
    init: function (title, presentations) {
      this.title = title;
      this.presentations = presentations;
      this.students = [];
      //this.homework = [];
      //this.homeworkIDs = [];
      this.id = 1;
      this.students.homeworkID = [];
      return this;
    },
    addStudent: function (name) {
      var fullname = name.split(' '),
        firstname = fullname[0].trim(),
        lastname = fullname[1].trim();

      if (fullname.length !== 2) {
        throw new Error('Invalid name!');
      }
      if (!isValidName(firstname) || !isValidName(lastname)) {
        throw new Error('Invalid name!');
      }


      var student = {
        firstname: firstname,
        lastname: lastname,
        id: this.id
      }

      this.students.push(student);

      this.id++;
      return this.id - 1;
    },
    getAllStudents: function () {
      return this.students.slice();
    },
    submitHomework: function (studentID, homeworkID) {
      if (!checkIfStudentIdExists(this.students, studentID)) {
        throw new Error('Invalid student ID!');
      }
      if (!isValidHomeworkID(this.presentations, homeworkID)) {
        throw new Error('Invalid homework ID!');
      }
      
      this.students.forEach(function (student) {
        if (student.id === studentID) {
          if (student.homework === undefined) {
            student.homework = 1;
          } else {
            student.homework++;
          }
        }
        //this.homeworkIDs[studentID].push(homeworkID);
      });

      return this;
    },
    pushExamResults: function (results) {
      var studentID,
        score;

      if (!Array.isArray(results)) {
        throw new Error('An array should be passed!');
      }

      for (var i = 0; i < results.length; i++) {
        studentID = results[i].StudentID;
        score = results[i].score;

        if (isNaN(parseInt(score))) {
          throw new Error('Invalid score!');
        }
        if (this.students[studentID - 1].takenExam) {
          throw new Error('Student with ID: ' + studentID + ' has taken an exam!');
        }

        this.students[studentID - 1].takenExam = true;
        this.students[studentID - 1].score = score;
      }
    },
    getTopStudents: function () {
      var topStudents;
      this.students.forEach(function (student) {
        student.totalScore = (25 * (student.homework / this.presentations.length)) + (0.75 * student.score);
      });

      this.students.sort(function (firstStudent, secondStudent) {
        return firstStudent.totalScore - secondStudent.totalScore;
      });

      topStudents = this.students.slice(0, 10);

      return topStudents;
    }
  };

  Object.defineProperty(Course, 'title', {
    get: function () {
      return this._title;
    },
    set: function (value) {
      if (!isTitleValid(value)) {
        throw new Error('Invalid title');
      }

      this._title = value;
    }
  });

  Object.defineProperty(Course, 'presentations', {
    get: function () {
      return this._presentations;
    },
    set: function (value) {
      if (!isPresentationValid(value)) {
        throw new Error('Invalid presentations');
      }

      this._presentations = value;
    }
  });

  // Course.init('Title', 'presen');
  // Course.addStudent('Pesho Prezident');
  // Course.addStudent('Gosho Nextprezident');
  // Course.addStudent('Marulq Marulkova');
  // Course.pushExamResults([{ StudentID: 1, score: 75 }]);
  // Course.pushExamResults([{ StudentID: 2, score: 85 }]);
  // Course.pushExamResults([{ StudentID: 3, score: 55 }]);
  // Course.submitHomework(2, 2);
  // Course.submitHomework(2, 1);
  // Course.submitHomework(3, 3);
  // Course.submitHomework(3, 3);
  // console.log(Course.getAllStudents());
  // // console.log(Course.getTopStudents());

  return Course;
}


module.exports = solve;
