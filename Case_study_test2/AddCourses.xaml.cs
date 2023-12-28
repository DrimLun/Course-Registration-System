using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace Case_study_test2
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class AddCourses : Window
    {
        public AddCourses()
        {
            InitializeComponent();
            //Console.WriteLine(grid_Courses.ItemsSource);
            grid_Courses.Items.Clear();
            this.Loaded += new RoutedEventHandler(MainWindow_Loaded);
        }

        private void FillCourses(List <Course> courses)
        {
            grid_Courses.ItemsSource = courses;
            grid_Courses.Columns[3].Visibility = Visibility.Hidden;
        }
        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            using (var context = new section27Entities())
            {
                //var courses = from c    in context.Courses
                //              join s    in context.Sections on c.course_code equals s.course_code
                //              join ss   in context.StudentSections on s.offering_code equals ss.offering_code
                //              where c.course_code equals !()

                //var sscontext = context.StudentSections;
                //var courses = context.Courses.Where(c => !sscontext.Any(ss => ss.student_id == 991234567)).ToList();
                var courses = context.Courses.Where(c => c.course_code.Contains(txt_course_code.Text)).ToList();
                FillCourses(courses);
            }
        }
        private void closeWindow_Click(object sender, RoutedEventArgs e)
        {
            //grid_Courses.Items.Clear();
            this.Close();
        }

        private void Search_course_code_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new section27Entities())
            {
                var course = context.Courses.Where(c => c.course_code.Contains(txt_course_code.Text)).ToList();
                FillCourses(course);

                txt_course_code.Text = "";
            }
        }

        public String selectedCourse;
        private void grid_Courses_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            // if something is selected
            if (grid_Courses.Items.IndexOf(grid_Courses.CurrentItem) != -1)
            {
                var cellInfo = grid_Courses.SelectedCells[0];

                selectedCourse = (cellInfo.Column.GetCellContent(cellInfo.Item) as TextBlock).Text;
                Console.WriteLine(selectedCourse);

                using (var context = new section27Entities())
                {
                    Course course = context.Courses.Find(selectedCourse);

                  
                    txt_show_course_code.Text = course.course_code.ToString();
                    txt_show_course_name.Text = course.course_name.ToString();
                    txt_show_prereq.Text = course.prereq.ToString();
                }

                //var context = new section27Entities();
                //Course selectedCourse = context.Courses.Find(course_code);   
            }
        }
        private void addCourse_Click(object sender, RoutedEventArgs e)
        {
            using (var Context = new section27Entities())
            {

                Student_Add_Section saswindow = new Student_Add_Section(selectedCourse);
                saswindow.Show();
                //this.sasselectedCourse = selectedCourse;
                //saswindow.sasselectedCourse = selectedCourse;
                //References:
                //https://learn.microsoft.com/en-us/answers/questions/1298322/how-to-pass-list-items-from-a-window-to-another-wi
                //https://stackoverflow.com/questions/20547904/wpf-passing-string-to-new-window
            }
        }
    }
}
