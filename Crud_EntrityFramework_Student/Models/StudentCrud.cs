using Microsoft.EntityFrameworkCore.Query.Internal;

namespace Crud_EntrityFramework_Student.Models
{
    public class StudentCrud
    {
        ApplicationDbContext context;
        private IConfiguration configuration;
        public StudentCrud(ApplicationDbContext context)
        {
            this.context = context;
        }
        public StudentCrud(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public IEnumerable<Student> GetAllStudents()
        {
            return context.Students.Where(x=>x.IsActive==1).ToList();

        }
        public Student GetStudentById(int id)
        {
            var student = context.Students.Where(x=>x.Sid==id).FirstOrDefault();
            return student;
        }
        public int AddStudent(Student student)
        {
            student.IsActive = 1;
            int result = 0;
            context.Students.Add(student);
            result=context.SaveChanges();
            return result;
        }
        public int UpdateStudent(Student student)
        
        {
            int result = 0;
            // search from dbset
            var s = context.Students.Where(x => x.Sid ==student.Sid).FirstOrDefault();
            if (s != null)
            {
                s.Sname = student.Sname; // b object contains old data book obj contains new data
                s.Marks = student.Marks;
                s.IsActive = 1;
                result = context.SaveChanges(); // update the change from DbSet to DB
            }

            return result;
        }
        public int DeleteStudent(int id)
        {
            int result = 0;
            var s=context.Students.Where(x=>x.Sid == id).FirstOrDefault();
            if (s != null)
            {
                s.IsActive = 0;
                result=context.SaveChanges();
            }
            return result;
        }
    }
}
