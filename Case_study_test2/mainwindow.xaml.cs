using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;
using static System.Collections.Specialized.BitVector32;

namespace Case_study_test2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += new RoutedEventHandler(MainWindow_Loaded);

            EditProfile editProfile = new EditProfile();    
            editProfile.ProfileUpdated += HandleProfileUpdated;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            using (var context = new section27Entities())
            {
                GetDashBoard();

                GetCurrentCourses();

                var academicHistory = (from course in context.Courses
                                       join section in context.Sections on course.course_code equals section.course_code
                                       join studentSection in context.StudentSections on section.offering_code equals studentSection.offering_code
                                       where studentSection.grade != null
                                       select new AcademicHistoryItem
                                       {
                                           CourseCode = course.course_code,
                                           CourseName = course.course_name,
                                           Semester = section.semester,
                                           Grade = studentSection.grade
                                       }).ToList();
                FillAcademicHistory(academicHistory);
            }
        }
        public void GetDashBoard()
        {
            using (var context = new section27Entities())
            { 
                // get all the students
                var students = context.Students.Where(s => s.student_id == 991234567).ToList();

                // to display the student in the datagrid
                FillDataGrid(students);
            }
        }

        private void FillDataGrid(List<Student> students)
        {
            grid_Student.ItemsSource = students;
        }

        public void GetCurrentCourses()
        {
            using (var context = new section27Entities())
            {
                GetDashBoard();

                int studentId = 991234567;

                var courseCodes = from s in context.Sections
                                  where s.offering_code ==
                                        (from stds in context.StudentSections
                                         where stds.student_id == studentId
                                         select stds.offering_code).FirstOrDefault() // or .Single() if you expect a single value
                                  select s.course_code;

                var currentCourses = (from c in context.Courses
                                      join s in context.Sections on c.course_code equals s.course_code
                                      join ss in context.StudentSections on s.offering_code equals ss.offering_code
                                      where ss.grade == null && ss.student_id == 991234567
                                      select new currentCoursesItem
                                      {
                                          CourseCode = c.course_code,
                                          CourseName = c.course_name
                                      }).ToList();

                FillCurrentCourses(currentCourses);
            }
        }
        public class currentCoursesItem
        {
            public string CourseCode { get; set; }
            public string CourseName { get; set; }
        }
        private void FillCurrentCourses(List<currentCoursesItem> currentCourses)
        {
            grid_CurrentCourses.ItemsSource = currentCourses;
            //grid_CurrentCourses.Columns[2].Visibility = Visibility.Hidden;
            //grid_CurrentCourses.Columns[3].Visibility = Visibility.Hidden;
        }
        public class AcademicHistoryItem
        {
            public string CourseCode { get; set; }
            public string CourseName { get; set; }
            public string Semester { get; set; }
            public string Grade { get; set; }
        }

        private void FillAcademicHistory(List<AcademicHistoryItem> academicHistory)
        {
            grid_AcademicHistory.ItemsSource = academicHistory;
        }
        private void btn_AddCourses_Click(object sender, RoutedEventArgs e)
        {
            AddCourses productWindow = new AddCourses();
            productWindow.Show();
        }

        public String selectedDrop;
        private void grid_DropCourse_DoubleClick(object sender, MouseButtonEventArgs e)
        {
            // if something is selected
            if (grid_CurrentCourses.Items.IndexOf(grid_CurrentCourses.CurrentItem) != -1)
            {
                var cellInfo = grid_CurrentCourses.SelectedCells[0];

                selectedDrop = (cellInfo.Column.GetCellContent(cellInfo.Item) as TextBlock).Text;
            }
        }

        private void btn_DropCourse_Click(object sender, RoutedEventArgs e)
        {

            using (var context = new section27Entities())
            {
                // find a single student by id
                Course c = context.Courses.Find(selectedDrop);
                var regdrop = (from ss in context.StudentSections
                               join s in context.Sections on ss.offering_code equals s.offering_code
                               join course in context.Courses on s.course_code equals course.course_code
                               where course.course_code == selectedDrop && ss.student_id == 991234567
                               select ss).FirstOrDefault();

                if (regdrop != null)
                {
                    // remove student entity from entity set
                    // and save changes
                    context.StudentSections.Remove(regdrop);
                    context.SaveChanges();
                    
                    MessageBox.Show("Course Dropped");
                    GetCurrentCourses();
                }
                else
                {
                    MessageBox.Show("Failed to drop. Please try again.");
                }
            }

        }

        private void btn_EditProfile_Click(object sender, RoutedEventArgs e)
        {
            EditProfile editProfile = new EditProfile();
            editProfile.Show();
        }

        private void HandleProfileUpdated()
        {
            // Handle the profile update here
            GetDashBoard(); // Assuming GetDashBoard is the method you want to call when the profile is updated
            MessageBox.Show("Profile updated");
        }

        //Display diff students
        //private void btnFind_Student_Click(object sender, RoutedEventArgs e)
        //{
        //    // read id from textbox
        //    if (txtId.Text == null)
        //    {
        //        MessageBox.Show("Please enter a valid student id");
        //    }
        //    else
        //    {
        //        int id = int.Parse(txtId.Text);

        //        using (var context = new section27Entities())
        //        {
        //            // find a single student by id
        //            var student = context.Students.Find(id);

        //            if (student != null)
        //            {
        //                var students = context.Students.Where(s => s.student_ == id).ToList();

        //                // display fetched orders in data grid
        //                FillDataGrid(students);
        //            }
        //            else
        //            {
        //                MessageBox.Show("Invalid ID. Please try again.");
        //                txtId.Focus();
        //            }
        //        }
        //    }
        //}


    }
}
