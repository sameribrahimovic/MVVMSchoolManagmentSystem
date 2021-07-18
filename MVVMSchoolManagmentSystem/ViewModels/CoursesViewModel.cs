using Data.Models;
using MVVMSchoolManagmentSystem.Services;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace MVVMSchoolManagmentSystem.ViewModels
{
    public class CoursesViewModel : BindableBase
    {
        private ObservableCollection<Course> _courses;
        private ICourseRepository _repository = new CourseRepository();

        public CoursesViewModel()
        {
            if (DesignerProperties.GetIsInDesignMode(
                new System.Windows.DependencyObject())) return;

            Courses = new ObservableCollection<Course>(_repository.GetCoursesAsync().Result);
        }

        public ObservableCollection<Course> Courses
        {
            get
            {
                return _courses;
            }
            set
            {
                _courses = value;
            }
        }

        private bool _EditMode;

        public bool EditMode
        {
            get { return _EditMode; }
            set { SetProperty(ref _EditMode, value); }
        }

        private Course _editingCourse = null;

        public void SetCustomer(Course course)
        {
            _editingCourse = course;
        }
    }
}
