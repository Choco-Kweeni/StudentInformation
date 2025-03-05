using StudentInformation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace StudentInformation
{
    public partial class Form1 : Form
    {
        private List<Student> students = new List<Student>();
        private int nextId = 1;

        public Form1()
        {
            InitializeComponent();
            LoadStudents();
        }

        private void LoadStudents()
        {
            gcStudents.DataSource = null;
            gcStudents.DataSource = students;
            gcStudents.RefreshDataSource();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(teFirstName.Text) ||
                string.IsNullOrWhiteSpace(teLastName.Text) ||
                string.IsNullOrWhiteSpace(teEmail.Text))
            {
                MessageBox.Show("First Name, Last Name, and Email are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Student student = new Student
            {
                StudentID = nextId++,
                FirstName = teFirstName.Text.Trim(),
                MiddleName = teMiddleName.Text.Trim(),
                LastName = teLastName.Text.Trim(),
                Address = teAddress.Text.Trim(),
                Email = teEmail.Text.Trim(),
                ContactNumber = teContactNumber.Text.Trim()
            };

            students.Add(student);
            LoadStudents();
        }
    }
}
