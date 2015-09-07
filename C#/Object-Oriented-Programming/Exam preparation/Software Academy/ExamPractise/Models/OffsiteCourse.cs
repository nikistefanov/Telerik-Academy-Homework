using ExamPractise.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPractise.Models
{
    class OffsiteCourse : Course, IOffsiteCourse, ICourse
    {
        public OffsiteCourse(string name, ITeacher teacher, string town)
            : base (name, teacher)
        {
            this.Town = town;
        }

        public string Town { get; set; }

        public override string ToString()
        {
            return string.Format("{0}; Town={1}", base.ToString(), this.Town);
        }
    }
}
