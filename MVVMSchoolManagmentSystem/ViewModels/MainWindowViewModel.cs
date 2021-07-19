using Data.Models;
using MVVMSchoolManagmentSystem.ViewModels.EditorViewModels;
using System;

namespace MVVMSchoolManagmentSystem.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        public BindableBase _currentViewModel;
        private HomeViewModel _homeViewModel = new HomeViewModel();
        private CoursesViewModel _coursesViewModel = new CoursesViewModel();
        private AddEditCoursesViewModel _addEditCoursesViewModel = new AddEditCoursesViewModel();
        public RelayCommand<string> NavCommand { get; }

        public MainWindowViewModel()
        {
            NavCommand = new RelayCommand<string>(OnNav);
            _coursesViewModel.AddCourseRequested += NavToAddCourse;
            _coursesViewModel.EditCourseRequested += NavToEditCourse;
        }

        public BindableBase CurrentViewModel
        {
            get { return _currentViewModel; }
            set { SetProperty(ref _currentViewModel, value); }
        }
        private void NavToAddCourse(Course course)
        {
            _addEditCoursesViewModel.EditMode = false;
            _addEditCoursesViewModel.SetCustomer(course);
            CurrentViewModel = _addEditCoursesViewModel;
        }
        private void NavToEditCourse(Course course)
        {
            _addEditCoursesViewModel.EditMode = true;
            _addEditCoursesViewModel.SetCustomer(course);
            CurrentViewModel = _addEditCoursesViewModel;
        }
        private void OnNav(string destination)
        {
            switch (destination)
            {
                case "home":
                default:
                    CurrentViewModel = _homeViewModel;
                    break;
                case "courses":
                    CurrentViewModel = _coursesViewModel;
                    break;
            }
        }
    }
}
