namespace RestApiApp.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // One-to-Many: A Student has many Courses
        public List<Course> Courses { get; set; } = new();
    }
}
