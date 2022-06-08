
using StudentAPI.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAPI.Logic.IRepository
{
    public interface IStudentRepository
    {
        //Read all
        Task<IEnumerable<Student>> GetAllStudents();

        //Read one
        Task<Student> GetStudent(int id);

        //create student
        Task<Student> AddStudent(Student student);

        Task DeleteStudent(Student student);

        Task UpdateStudent(Student student);
    }
}
