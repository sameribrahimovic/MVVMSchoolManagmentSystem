using Data.Models;

namespace MVVMSchoolManagmentSystem.ViewModels.EditorViewModels
{
    public class AddEditCoursesViewModel : BindableBase
    {
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
