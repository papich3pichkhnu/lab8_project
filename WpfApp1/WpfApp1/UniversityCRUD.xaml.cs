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
using System.Collections.ObjectModel;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for UniversityCRUD.xaml
    /// </summary>
    public partial class UniversityCRUD : Window
    {
        ApplicationContext context;
        public UniversityCRUD()
        {
            InitializeComponent();

            context = new ApplicationContext();

            _ = context.Faculties.ToList();
            _ = context.Students.ToList();
            _ = context.AssociateProfessors.ToList();
            _ = context.Lecturers.ToList();
            _ = context.SeniorLecturers.ToList();
            _ = context.Departments.ToList();
            _ = context.Disciplines.ToList();
            _ = context.Exams.ToList();

            FacultiesList.ItemsSource = context.Faculties.Local.ToBindingList();
            StudentsList.ItemsSource = context.Students.Local.ToBindingList();
            ComboBoxFacultiesStudents.ItemsSource = context.Faculties.Local.ToObservableCollection();
            ComboBoxMentorsStudents.ItemsSource = context.AssociateProfessors.Local.ToObservableCollection();
            ComboBoxDepartmentsLecturers.ItemsSource = context.Departments.Local.ToObservableCollection();
            ComboBoxDepartmentsSeniorLecturers.ItemsSource = context.Departments.Local.ToObservableCollection();
            ComboBoxDepartmentsAssociateProfessors.ItemsSource = context.Departments.Local.ToObservableCollection();
            ComboBoxDepartmentsDisciplines.ItemsSource = context.Departments.Local.ToObservableCollection();
            ComboBoxFacultiesDepartments.ItemsSource = context.Faculties.Local.ToObservableCollection();
            ComboBoxAssociateProfessorsDepartments.ItemsSource = context.AssociateProfessors.Local.ToObservableCollection();
            LecturersList.ItemsSource= context.Lecturers.Local.ToBindingList();
            SeniorLecturersList.ItemsSource= context.SeniorLecturers.Local.ToBindingList();
            AssociateProfessorsList.ItemsSource= context.AssociateProfessors.Local.ToBindingList();
            DisciplinesList.ItemsSource= context.Disciplines.Local.ToBindingList();
            DepartmentsList.ItemsSource= context.Departments.Local.ToBindingList();
            ComboBoxStudent.ItemsSource=context.Students.Local.ToObservableCollection();
            ComboBoxLecturers.ItemsSource = context.SeniorLecturers.Local.ToObservableCollection();
            ComboBoxDisciplines.ItemsSource=context.Disciplines.Local.ToObservableCollection(); 
            ExamsList.ItemsSource= context.Exams.Local.ToBindingList();

        }

        private void DeleteFacultyButton_Click(object sender, RoutedEventArgs e)
        {
            if (FacultiesList.SelectedItems.Count > 0)
            {
                for (int i = 0; i < FacultiesList.SelectedItems.Count; i++)
                {
                    Faculty? man = FacultiesList.SelectedItems[i] as Faculty;
                    if (man != null)
                    {
                        context.Faculties.Remove(man);
                    }
                }
            }

          
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            context.Dispose();
        }

        private void SaveChanges()
        {
            context.SaveChanges();
        }

        private void UpdateFacultyButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteStudentButton_Click(object sender, RoutedEventArgs e)
        {
            if (StudentsList.SelectedItems.Count > 0)
            {
                for (int i = 0; i < StudentsList.SelectedItems.Count; i++)
                {
                    Student? man = StudentsList.SelectedItems[i] as Student;
                    if (man != null)
                    {
                        context.Students.Remove(man);
                    }
                }
            }

            
        }

        private void DeleteLecturerButton_Click(object sender, RoutedEventArgs e)
        {
            if (LecturersList.SelectedItems.Count > 0)
            {
                for (int i = 0; i < LecturersList.SelectedItems.Count; i++)
                {
                    Lecturer? man = LecturersList.SelectedItems[i] as Lecturer;
                    if (man != null)
                    {
                        context.Lecturers.Remove(man);
                    }
                }
            }
        }

        private void DeleteSeniorLecturerButton_Click(object sender, RoutedEventArgs e)
        {
            if (SeniorLecturersList.SelectedItems.Count > 0)
            {
                for (int i = 0; i < SeniorLecturersList.SelectedItems.Count; i++)
                {
                    SeniorLecturer? man = SeniorLecturersList.SelectedItems[i] as SeniorLecturer;
                    if (man != null)
                    {
                        context.SeniorLecturers.Remove(man);
                    }
                }
            }
        }

        private void DeleteAssociateProfessorButton_Click(object sender, RoutedEventArgs e)
        {
            if (AssociateProfessorsList.SelectedItems.Count > 0)
            {
                for (int i = 0; i < AssociateProfessorsList.SelectedItems.Count; i++)
                {
                    AssociateProfessor? man = AssociateProfessorsList.SelectedItems[i] as AssociateProfessor;
                    if (man != null)
                    {
                        context.AssociateProfessors.Remove(man);
                    }
                }
            }
        }

        private void DeleteDisciplineButton_Click(object sender, RoutedEventArgs e)
        {
            if (DisciplinesList.SelectedItems.Count > 0)
            {
                for (int i = 0; i < DisciplinesList.SelectedItems.Count; i++)
                {
                    Discipline? man = DisciplinesList.SelectedItems[i] as Discipline;
                    if (man != null)
                    {
                        context.Disciplines.Remove(man);
                    }
                }
            }
        }

        private void DeleteDepartmentButton_Click(object sender, RoutedEventArgs e)
        {
            if (DepartmentsList.SelectedItems.Count > 0)
            {
                for (int i = 0; i < DepartmentsList.SelectedItems.Count; i++)
                {
                    Department? man = DepartmentsList.SelectedItems[i] as Department;
                    if (man != null)
                    {
                        context.Departments.Remove(man);
                    }
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(ComboBoxStudent.SelectedItem==null)
            {
                MessageBox.Show("The student is not selected","Error",MessageBoxButton.OK,MessageBoxImage.Error);return;
            }
            if (ComboBoxLecturers.SelectedItem == null)
            {
                MessageBox.Show("The lecturer is not selected", "Error", MessageBoxButton.OK, MessageBoxImage.Error); return;
            }
            if (ComboBoxDisciplines.SelectedItem == null)
            {
                MessageBox.Show("The discipline is not selected", "Error", MessageBoxButton.OK, MessageBoxImage.Error); return;
            }
            
            Random random = new Random();
            int Mark = random.Next(2, 5);
            MessageBox.Show("Student passed exam with mark = "+Mark.ToString(), "Info", MessageBoxButton.OK, MessageBoxImage.Information);
            if (Mark==2)
            {
                MessageBox.Show("The student is deducted from faculty", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
                Student st = ComboBoxStudent.SelectedItem as Student;
                st.Faculty = null;
            }
            else
            {
                MessageBox.Show("The student will continue study", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            Exam exam = new Exam
            {
                Student = ComboBoxStudent.SelectedItem as Student,
                Date = DateTime.Now,
                Discipline = ComboBoxDisciplines.SelectedItem as Discipline,
                Lecturer = ComboBoxLecturers.SelectedItem as SeniorLecturer,
                Mark = Mark
            };
            context.Exams.Add(exam);
            SaveChanges();
        }

        private void UpdateExamButton_Click(object sender, RoutedEventArgs e)
        {
            SaveChanges();
        }

        private void DeleteExamButton_Click(object sender, RoutedEventArgs e)
        {
            if (ExamsList.SelectedItems.Count > 0)
            {
                for (int i = 0; i < ExamsList.SelectedItems.Count; i++)
                {
                    Exam? man = ExamsList.SelectedItems[i] as Exam;
                    if (man != null)
                    {
                        context.Exams.Remove(man);
                    }
                }
            }
        }
    }
}
