using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Assessment_3_Task_B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Dictionary<int, Student> studentDictionary = new Dictionary<int, Student>();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addStudentBtn_Click(object sender, EventArgs e)
        {
            // Get the entered values from the text boxes
            int id;
            if (!int.TryParse(studentIdTextBox.Text, out id))
            {
                MessageBox.Show("Please enter a valid numeric ID.");
                return;
            }

            string name = studentNameTextBox.Text;

            // Check if the name is not empty
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter a name.");
                return;
            }

            // Create a new student instance and add it to the dictionary
            Student student = new Student(id, name);
            studentDictionary.Add(id, student);

            // Clear the text boxes
            studentIdTextBox.Clear();
            studentNameTextBox.Clear();

            // Refresh the student list display
            DisplayStudents();
        }
        private void DisplayStudents()
        {
            studentList.Items.Clear();
            foreach (Student student in studentDictionary.Values)
            {
                studentList.Items.Add($"ID: {student.Id} Name: {student.Name} Enrollment Status: {student.EnrollmentStatus}");
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            // Get the entered values from the text boxes
            int id;
            if (!int.TryParse(studentIdEditTextBox.Text, out id))
            {
                MessageBox.Show("Please enter a valid numeric ID.");
                return;
            }

            // Check if the ID is present in the dictionary
            if (studentDictionary.ContainsKey(id))
            {
                // Get the student with the specified ID
                Student student = studentDictionary[id];

                // Display the student's information
                studentList.Items.Clear();
                studentList.Items.Add($"ID: {student.Id} Name: {student.Name} Enrollment Status: {student.EnrollmentStatus}");
            }
            else
            {
                MessageBox.Show($"No student found with ID: {id}");
            }

            // Clear the search text box
            studentIdEditTextBox.Clear();
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            // Get the entered values from the text boxes
            int id;
            if (!int.TryParse(studentIdEditTextBox.Text, out id))
            {
                MessageBox.Show("Please enter a valid numeric ID.");
                return;
            }

            // Check if the ID is present in the dictionary
            if (studentDictionary.ContainsKey(id))
            {
                // Remove student from the dictionary
                studentDictionary.Remove(id);

                // Refresh the student list display
                DisplayStudents();
            }
            else
            {
                MessageBox.Show($"No student found with ID: {id}");
            }
            // Clear the search text box
            studentIdEditTextBox.Clear();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            // Get the entered values from the text boxes
            int id;
            if (!int.TryParse(studentIdEditTextBox.Text, out id))
            {
                MessageBox.Show("Please enter a valid numeric ID.");
                return;
            }

            // Check if one of the radio buttons is selected
            if (!enrolled.Checked && !unEnrolled.Checked)
            {
                MessageBox.Show("Please select the enrollment status.");
                return;
            }

            // Check if the ID is present in the dictionary
            if (studentDictionary.ContainsKey(id))
            {
                // Update the enrollment status of the student
                studentDictionary[id].EnrollmentStatus = enrolled.Checked;

                // Refresh the student list display
                DisplayStudents();
            }
            else
            {
                MessageBox.Show($"No student found with ID: {id}");
            }
            // Clear the search text box
            studentIdEditTextBox.Clear();

            // Clear the radio buttons selection
            enrolled.Checked = false;
            unEnrolled.Checked = false;
        }
    }
}
