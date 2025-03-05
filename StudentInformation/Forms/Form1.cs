using DevExpress.XtraGrid;
using StudentInformation.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace StudentInformation
{
    public partial class Form1 : Form
    {
        private List<Student> students = new List<Student>();

        public Form1()
        {
            InitializeComponent();
            // i bind niya diritso padung sa gridcontrol
            gcStudents.DataSource = students; 
        }
        //i load niya ang gridcontrol
        private void LoadDataGrid()
        {
            gcStudents.DataSource = null;
            gcStudents.DataSource = students;
        }
        //Method Validation Para sa akong Crud
        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(teFirstName.Text) ||
                string.IsNullOrWhiteSpace(teLastName.Text) ||
                string.IsNullOrWhiteSpace(teAddress.Text) ||
                string.IsNullOrWhiteSpace(teEmail.Text) ||
                string.IsNullOrWhiteSpace(teContactNumber.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            students.Add(new Student()
            {
                FirstName = teFirstName.Text,
                MiddleName = teMiddleName.Text,
                LastName = teLastName.Text,
                Address = teAddress.Text,
                Email = teEmail.Text,
                ContactNumber = teContactNumber.Text
            });
            MessageBox.Show("Student Information is Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            gcStudents.RefreshDataSource();
            ClearTextBoxes();
        }    

        private void btnUpadate_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            int[] selectedRows = gvStudents.GetSelectedRows();

            if (selectedRows.Length > 0)
            {
                int index = selectedRows[0];
                students[index].FirstName = teFirstName.Text;
                students[index].MiddleName = teMiddleName.Text;
                students[index].LastName = teLastName.Text;
                students[index].Address = teAddress.Text;
                students[index].Email = teEmail.Text;
                students[index].ContactNumber = teContactNumber.Text;
                LoadDataGrid();
                MessageBox.Show("Student Information Updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearTextBoxes();
            }
            else
            {
                MessageBox.Show("Please select a student to update.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }        
        //event nga rowclick para kung mo click ko every row mo padulong sya sa textbox
        private void gvStudents_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (gvStudents.GetFocusedRow() is Student selectedStudent)
            {
                teFirstName.Text = selectedStudent.FirstName;
                teMiddleName.Text = selectedStudent.MiddleName;
                teLastName.Text = selectedStudent.LastName;
                teAddress.Text = selectedStudent.Address;
                teEmail.Text = selectedStudent.Email;
                teContactNumber.Text = selectedStudent.ContactNumber;
            }
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadDataGrid();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int[] selectedRows = gvStudents.GetSelectedRows();

            if (selectedRows.Length > 0)
            {
                int index = selectedRows[0]; // Get the first selected row index
                students.RemoveAt(index);
                LoadDataGrid();
                ClearTextBoxes();
            }

            MessageBox.Show("Selected row deleted.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        //Para ma clear ang textbox if naa kay i add or update
        private void ClearTextBoxes()
        {
            teFirstName.Text = "";
            teMiddleName.Text = "";
            teLastName.Text = "";
            teAddress.Text = "";
            teEmail.Text = "";
            teContactNumber.Text = "";
        }
    }
}
