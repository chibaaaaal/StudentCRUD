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
        List<Student> students = new List<Student>(); // Student List

        public Form1()
        {
            InitializeComponent();
            gcStudents.DataSource = students;
        }

        public void btnAdd_Click(object sender, EventArgs e)
        {
            students.Add(new Student { FirstName = txtbxFirstName.Text, MiddleName = txtbxMiddleName.Text, LastName = txtbxLastName.Text, NameExtension = txtbxNameExtension.Text, Gender = cbGender.SelectedText, BirthDate = dteditBirthDate.DateTime });
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
        }
    }
}
