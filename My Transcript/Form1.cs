﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Transcript
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void AddGrade(object sender, EventArgs e)
        {
            Course newCourse = new Course();
            newCourse.CourseID = textBoxCourseID.Text;
            newCourse.CourseName = textBoxCourseName.Text;
            newCourse.CourseCredit = textBoxCourseID.Text;
            newCourse.Grade = textBoxGrade.Text;
        }
    }
    class Course
    {
        public string CourseID { get; set; }
        public string CourseName { get; set; }
        public string CourseCredit { get; set; }
        public string Grade { get; set; }
    }
}
