using DevExpress.XtraEditors;
using StudentCRUD.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StudentCRUD
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        // Student List
        List<Student> students = new List<Student>(); 

        // form
        public Form1()
        {
            InitializeComponent();
            gcStudents.DataSource = students;
        }

        // student add button
        public void btnAdd_Click(object sender, EventArgs e)
        {
            students.Add(new Student { FirstName = txtbxFirstName.Text, MiddleName = txtbxMiddleName.Text, LastName = txtbxLastName.Text, NameExtension = txtbxNameExtension.Text, Gender = cbGender.SelectedText, BirthDate = dteditBirthDate.DateTime });
            LoadData();
            ClearTextBox();
        }

        // load data button
        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        // load data method
        private void LoadData()
        {
            gcStudents.DataSource = null;
            gcStudents.DataSource = students;
        }

        // clear text box
        private void ClearTextBox()
        {
            txtbxFirstName.Clear();
            txtbxMiddleName.Clear();
            txtbxLastName.Clear();
            txtbxNameExtension.Clear();
            cbGender.Clear();
            dteditBirthDate.Clear();
        }

        // edit button
        private void btnEdit_Click(object sender, EventArgs e)
        {
            string FirstName = Convert.ToString(gvStudents.GetFocusedRowCellValue("FirstName"));
            var person = students.FirstOrDefault(x => x.FirstName == FirstName);
            if (person != null)
            {
                person.FirstName = txtbxFirstName.Text;
                person.MiddleName = txtbxMiddleName.Text;
                person.LastName = txtbxLastName.Text;
                person.NameExtension = txtbxNameExtension.Text;
                person.Gender = cbGender.SelectedText;
                person.BirthDate = dteditBirthDate.DateTime;
            }

            else
            {
                XtraMessageBox.Show("Person Not Found...");
            }

            LoadData();
            ClearTextBox();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
