using Data.Models;
using MVVMSchoolManagmentSystem.Services;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace MVVMSchoolManagmentSystem.ViewModels
{
    public class CoursesViewModel : BindableBase
    {
        private ObservableCollection<Course> _courses;
        private ICourseRepository _repository = new CourseRepository();
        public RelayCommand AddCommand { get; private set; }
        public RelayCommand<Course> EditCommand { get; private set; }
        public event Action<Course> AddCourseRequested = delegate { };
        public event Action<Course> EditCourseRequested = delegate { };

        public CoursesViewModel()
        {
            if (DesignerProperties.GetIsInDesignMode(
                new System.Windows.DependencyObject())) return;
            Courses = new ObservableCollection<Course>(_repository.GetCoursesAsync().Result);

            AddCommand = new RelayCommand(AddCourse);
            EditCommand = new RelayCommand<Course>(EditCourse);
        }
        private void AddCourse()
        {
            AddCourseRequested(new Course());
        }
        private void EditCourse(Course course)
        {
            EditCourseRequested(course);
        }
        public ObservableCollection<Course> Courses
        {
            get
            {
                return _courses;
            }
            set
            {
                SetProperty(ref _courses, value);
            }
        }
    }
}
