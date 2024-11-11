using Microsoft.Win32;
using System.Data;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfLoadfilejson_BusinessObject;
using WpfLoadfilejson_Repo;
using WpfLoadfilejson_Service;

namespace WpfLoadfilejson
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly StudentService _studentService;

        public MainWindow()
        {
            InitializeComponent();
            _studentService = new StudentService();
        }

        private void BrowseButton_Click(object sender, RoutedEventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*"
            };

            if (openFileDialog.ShowDialog() == true)
            {
                string filePath = openFileDialog.FileName;
                txtFileName.Text = filePath;
                List<Student> students = _studentService.GetAllStudents(filePath);
                StudentDataGrid.ItemsSource = students;
            }
        }
    }
}