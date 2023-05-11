using StudentsManagementAPI.Models;

namespace StudentsManagementAPI.Repository
{
    public static class StudentData
    {
        static List<Student> Students { get; set; }
        static StudentData()
        {
            Students = new List<Student>(){
             new Student() { Id = 1, Name = "Alice", Age = 20, Hobbies = new List<string>() { "reading", "swimming", "coding" } },
             new Student() { Id = 2, Name = "Bob", Age = 22, Hobbies = new List<string>() { "painting", "dancing", "singing" } }
            };

        }

        public static List<Student> GetStudents()
        {
            return Students;
        }
    }
}
