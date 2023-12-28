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

namespace Case_study_test2
{
    /// <summary>
    /// Interaction logic for EditProfile.xaml
    /// </summary>
    public partial class EditProfile : Window
    {
        public event Action ProfileUpdated;
        public EditProfile()
        {
            InitializeComponent();
        }

        private void UpdateProfile_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new section27Entities())
            {
                Student std = context.Students.Find(991234567);

                // if found, assign new values to its properties
                // and save changes
                if (std != null)
                {
                    if (txtName.Text != "")
                    { 
                        std.student_name = txtName.Text; 
                    }

                    if (txtHomePhone.Text != "")
                    std.phone_number_home   = txtHomePhone.Text;

                    if (txtCellPhone.Text != "")
                    std.phone_number_cell   = txtCellPhone.Text;

                    context.SaveChanges();

                    //MainWindow targetWindow = new MainWindow();
                    //targetWindow.GetDashBoard();

                    ProfileUpdated?.Invoke();

                    MessageBox.Show("Profile updated");

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid ID. Please try again.");
                    txtName.Text = "";
                    txtName.Focus();
                }
            }
        }
        private void EditHomePhone_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void EditName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
