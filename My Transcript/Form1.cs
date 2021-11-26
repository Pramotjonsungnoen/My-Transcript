using System;
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
        List<Course> year1Sem1;
        List<Course> year1Sem2;
        public Form1()
        {
            InitializeComponent();
            year1Sem1 = new List<Course>();
            year1Sem2 = new List<Course>();
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

            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    dataGridViewY1S1.DataSource = null;
                    year1Sem1.Add(newCourse);
                    dataGridViewY1S1.DataSource = year1Sem1;
                    break;
                case 1:
                    dataGridViewY1S2.DataSource = null;
                    year1Sem2.Add(newCourse);
                    dataGridViewY1S2.DataSource = year1Sem2;
                    break;
            }
        
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
