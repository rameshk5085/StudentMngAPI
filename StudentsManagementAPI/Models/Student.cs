namespace StudentsManagementAPI.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public int Age { get; set; }

        public List<string>? Hobbies { get; set; }

    }
}
