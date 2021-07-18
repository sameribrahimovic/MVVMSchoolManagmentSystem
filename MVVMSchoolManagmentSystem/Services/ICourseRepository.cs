using System.Collections.Generic;
using System.Threading.Tasks;
using Data.Models;

namespace MVVMSchoolManagmentSystem.Services
{
    public interface ICourseRepository
    {
        Task<List<Course>> GetCoursesAsync();
        Task<Course> GetCourseAsync(int id);
        Task<Course> AddCourseAsync(Course course);
        Task<Course> UpdateCourseAsync(Course course);
        Task DeleteCourseAsync(int Id);
    }
}
