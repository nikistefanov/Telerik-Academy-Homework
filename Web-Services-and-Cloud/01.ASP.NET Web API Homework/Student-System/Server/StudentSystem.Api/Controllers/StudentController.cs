namespace StudentSystem.Api.Controllers
{
    using System.Web.Http;

    using System.Linq;

    using StudentSystem.Api.Models;
    using StudentSystem.Data;
    using StudentSystem.Models;

    public class StudentController : ApiController
    {
        private readonly IRepository<Student> students;

        public StudentController()
        {            
            this.students = new EfGenericRepository<Student>(new StudentSystemContext());
        }
        
        public IHttpActionResult Get()
        {
            var result = this.students.All().ToList();

            return this.Ok(result);
        }

        public IHttpActionResult Post(StudentApiModel student)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            this.students.Add(
                    new Student()
                        {
                            Name = student.Name,
                            Number = student.Number,
                            Courses = student.Courses
                        });
            this.students.SaveChanges();

            return this.Ok();
        }
    }
}
