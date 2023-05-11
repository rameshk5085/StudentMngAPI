using StudentsManagementAPI.Interface;
using StudentsManagementAPI.Models;

namespace StudentsManagementAPI.Repository
{
    public class StudentManager : IDataRepository<Student>
    {
        
        public Student Get(long id)
        {
           var student =  StudentData.GetStudents().Where(s => s.Id == id).FirstOrDefault();
            return student;
        }

        public IEnumerable<Student> GetAll()
        {
            return StudentData.GetStudents();
        }
        
    }
}
