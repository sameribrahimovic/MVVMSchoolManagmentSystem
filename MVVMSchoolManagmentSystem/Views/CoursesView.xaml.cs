using MVVMSchoolManagmentSystem.ViewModels;
using System.Windows.Controls;

namespace MVVMSchoolManagmentSystem.Views
{
    /// <summary>
    /// Interaction logic for CoursesView.xaml
    /// </summary>
    public partial class CoursesView : UserControl
    {
        public CoursesView()
        {
            InitializeComponent();
            DataContext = new CoursesViewModel();
        }
    }
}
