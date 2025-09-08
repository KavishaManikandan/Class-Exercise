using RestApiApp.Models;

namespace RestApiApp.Data
{
    public static class FakeRepository
    {
        public static List<Student> Students = new()
        {
            new Student { Id = 1, Name = "Kavisha",
                Courses = new List<Course> {
                    new Course{ Id=1, Title="C#" },
                    new Course{ Id=2, Title="ASP.NET Core" }
                }
            },
            new Student { Id = 2, Name = "Rahul",
                Courses = new List<Course> {
                    new Course{ Id=3, Title="Angular" }
                }
            }
        };
    }
}
