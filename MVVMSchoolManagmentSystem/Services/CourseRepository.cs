using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Data;
using Data.Models;

namespace MVVMSchoolManagmentSystem.Services
{
    public class CourseRepository : ICourseRepository
    {
        SchoolDbContext _context = new SchoolDbContext();

        public Task<List<Course>> GetCoursesAsync()
        {
            return _context.Courses.ToListAsync();
        }

        public Task<Course> GetCourseAsync(int id)
        {
            return _context.Courses.FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<Course> AddCourseAsync(Course course)
        {
            _context.Courses.Add(course);
            await _context.SaveChangesAsync();
            return course;
        }

        public async Task<Course> UpdateCourseAsync(Course course)
        {
            if (!_context.Courses.Local.Any(c => c.Id == course.Id))
            {
                _context.Courses.Attach(course);
            }
            _context.Entry(course).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return course;

        }

        public async Task DeleteCourseAsync(int Id)
        {
            var course = _context.Courses.FirstOrDefault(c => c.Id == Id);
            if (course != null)
            {
                _context.Courses.Remove(course);
            }
            await _context.SaveChangesAsync();
        }
    }
}
