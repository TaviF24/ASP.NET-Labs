using Lab2_24.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lab2_24.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        public static List<Student> students = new List<Student>
        {
            new Student { Id = 1, Name = "Florin", Age = 21},
            new Student { Id = 2, Name = "Alexia", Age = 19},
            new Student { Id = 3, Name = "Vladimir", Age = 22},
            new Student { Id = 4, Name = "Andrei", Age = 25},
            new Student { Id = 5, Name = "Maria", Age = 20},
        };

        // endpoint 
        // Get 
        [HttpGet]
        public List<Student> GetAllOrdered()
        {
            return students.OrderBy(s => s.Name).ToList();
        }



        // Create
        [HttpPost]
        public List<Student> Add(Student student)
        {
            students.Add(student);
            return students;
        }



        // Delete
        [HttpDelete]
        public List<Student> DeleteById(int id)
        {
            List<int> lista_stud = new List<int>();
            for (int i = students.Count - 1; i >= 0; i--)
                if (students[i].Id == id)
                    lista_stud.Add(i);
            foreach (int i in lista_stud)
                students.Remove(students[i]);
            return students;
        }
    }
}
