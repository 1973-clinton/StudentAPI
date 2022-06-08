using Microsoft.EntityFrameworkCore;
using StudentAPI.Data.Context;
using StudentAPI.Logic.IRepository;
using StudentAPI.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAPI.Logic.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly ApplicationContext _context;
        public StudentRepository(ApplicationContext context)
        {
            _context = context;
        }

        public async Task<Student> AddStudent(Student student)
        {
            _context.Students.Add(student);
            await _context.SaveChangesAsync();

            return student;
        }

        public async Task<int> DeleteStudent(int id)
        {
            var student = await _context.Students.FirstOrDefaultAsync(u => u.Id == id);
            if (student != null)
            {
                _context.Students.Remove(student);
            }
            return await _context.SaveChangesAsync();

        }

        public async Task<IEnumerable<Student>> GetAllStudents()
        {
            var students = await  _context.Students.ToListAsync();

            return students;
        }

        public async Task<Student> GetStudent(int id)
        {
            var student = await _context.Students.FirstOrDefaultAsync(u => u.Id == id);
            return student;
        }

        public async Task<int> UpdateStudent(Student student)
        {
            var stu = await _context.Students.FirstOrDefaultAsync(u => u.Id == student.Id);
            if (stu != null)
            {
                student.Id = stu.Id;
                student.Age = stu.Age;
                student.FirstName = stu.FirstName;
                student.LastName = stu.LastName;
                student.Email = stu.Email;
                student.DateJoined = stu.DateJoined;
                student.Gender = stu.Gender;
                student.DateOfBirth = stu.DateOfBirth;
            }

            _context.Students.Update(student);
            var result = await _context.SaveChangesAsync();

            return result;

        }

       
    }
}
