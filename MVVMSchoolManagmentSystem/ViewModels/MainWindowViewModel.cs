using System;

namespace MVVMSchoolManagmentSystem.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private CoursesViewModel _coursesViewModel = new CoursesViewModel();
        private HomeViewModel _homeViewModel = new HomeViewModel();
        public BindableBase _currentViewModel;
        public RelayCommand<string> NavCommand { get; }

        public MainWindowViewModel()
        {
            //CurrentViewModel = new CourseViewModel();
            NavCommand = new RelayCommand<string>(OnNav);
        }
        public BindableBase CurrentViewModel
        {
            get { return _currentViewModel; }
            set { SetProperty(ref _currentViewModel, value); }
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
