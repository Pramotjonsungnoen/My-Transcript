
namespace My_Transcript
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonAddCourse = new System.Windows.Forms.Button();
            this.textBoxGrade = new System.Windows.Forms.TextBox();
            this.TextBoxCourseCredit = new System.Windows.Forms.TextBox();
            this.textBoxCourseName = new System.Windows.Forms.TextBox();
            this.textBoxCourseID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewY1S1 = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageYear1Sem1 = new System.Windows.Forms.TabPage();
            this.tabPageYear1Sem2 = new System.Windows.Forms.TabPage();
            this.dataGridViewY1S2 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewY1S1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageYear1Sem1.SuspendLayout();
            this.tabPageYear1Sem2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewY1S2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(332, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "My university name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(332, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "My faculty name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonAddCourse);
            this.groupBox1.Controls.Add(this.textBoxGrade);
            this.groupBox1.Controls.Add(this.TextBoxCourseCredit);
            this.groupBox1.Controls.Add(this.textBoxCourseName);
            this.groupBox1.Controls.Add(this.textBoxCourseID);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(16, 305);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 133);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add new course";
            // 
            // buttonAddCourse
            // 
            this.buttonAddCourse.Location = new System.Drawing.Point(315, 86);
            this.buttonAddCourse.Name = "buttonAddCourse";
            this.buttonAddCourse.Size = new System.Drawing.Size(75, 23);
            this.buttonAddCourse.TabIndex = 8;
            this.buttonAddCourse.Text = "Add";
            this.buttonAddCourse.UseVisualStyleBackColor = true;
            this.buttonAddCourse.Click += new System.EventHandler(this.AddGrade);
            // 
            // textBoxGrade
            // 
            this.textBoxGrade.Location = new System.Drawing.Point(191, 86);
            this.textBoxGrade.Name = "textBoxGrade";
            this.textBoxGrade.Size = new System.Drawing.Size(100, 22);
            this.textBoxGrade.TabIndex = 7;
            this.textBoxGrade.Text = "B+";
            this.textBoxGrade.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // TextBoxCourseCredit
            // 
            this.TextBoxCourseCredit.Location = new System.Drawing.Point(191, 64);
            this.TextBoxCourseCredit.Name = "TextBoxCourseCredit";
            this.TextBoxCourseCredit.Size = new System.Drawing.Size(100, 22);
            this.TextBoxCourseCredit.TabIndex = 6;
            this.TextBoxCourseCredit.Text = "3";
            // 
            // textBoxCourseName
            // 
            this.textBoxCourseName.Location = new System.Drawing.Point(191, 43);
            this.textBoxCourseName.Name = "textBoxCourseName";
            this.textBoxCourseName.Size = new System.Drawing.Size(100, 22);
            this.textBoxCourseName.TabIndex = 5;
            this.textBoxCourseName.Text = "Computer Laboratory";
            // 
            // textBoxCourseID
            // 
            this.textBoxCourseID.Location = new System.Drawing.Point(191, 22);
            this.textBoxCourseID.Name = "textBoxCourseID";
            this.textBoxCourseID.Size = new System.Drawing.Size(100, 22);
            this.textBoxCourseID.TabIndex = 4;
            this.textBoxCourseID.Text = "12345678";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "\tGrade";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Credit";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Course Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Course ID";
            // 
            // dataGridViewY1S1
            // 
            this.dataGridViewY1S1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewY1S1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewY1S1.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewY1S1.Name = "dataGridViewY1S1";
            this.dataGridViewY1S1.RowHeadersWidth = 51;
            this.dataGridViewY1S1.RowTemplate.Height = 24;
            this.dataGridViewY1S1.Size = new System.Drawing.Size(603, 178);
            this.dataGridViewY1S1.TabIndex = 4;
            this.dataGridViewY1S1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageYear1Sem1);
            this.tabControl1.Controls.Add(this.tabPageYear1Sem2);
            this.tabControl1.Location = new System.Drawing.Point(16, 86);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(617, 213);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPageYear1Sem1
            // 
            this.tabPageYear1Sem1.Controls.Add(this.dataGridViewY1S1);
            this.tabPageYear1Sem1.Location = new System.Drawing.Point(4, 25);
            this.tabPageYear1Sem1.Name = "tabPageYear1Sem1";
            this.tabPageYear1Sem1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageYear1Sem1.Size = new System.Drawing.Size(609, 184);
            this.tabPageYear1Sem1.TabIndex = 0;
            this.tabPageYear1Sem1.Text = " Year1 Sem1";
            this.tabPageYear1Sem1.UseVisualStyleBackColor = true;
            // 
            // tabPageYear1Sem2
            // 
            this.tabPageYear1Sem2.Controls.Add(this.dataGridViewY1S2);
            this.tabPageYear1Sem2.Location = new System.Drawing.Point(4, 25);
            this.tabPageYear1Sem2.Name = "tabPageYear1Sem2";
            this.tabPageYear1Sem2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageYear1Sem2.Size = new System.Drawing.Size(609, 184);
            this.tabPageYear1Sem2.TabIndex = 1;
            this.tabPageYear1Sem2.Text = "Year1 Sem2";
            this.tabPageYear1Sem2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewY1S2
            // 
            this.dataGridViewY1S2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewY1S2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewY1S2.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewY1S2.Name = "dataGridViewY1S2";
            this.dataGridViewY1S2.RowHeadersWidth = 51;
            this.dataGridViewY1S2.RowTemplate.Height = 24;
            this.dataGridViewY1S2.Size = new System.Drawing.Size(603, 178);
            this.dataGridViewY1S2.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewY1S1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPageYear1Sem1.ResumeLayout(false);
            this.tabPageYear1Sem2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewY1S2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxGrade;
        private System.Windows.Forms.TextBox TextBoxCourseCredit;
        private System.Windows.Forms.TextBox textBoxCourseName;
        private System.Windows.Forms.TextBox textBoxCourseID;
        private System.Windows.Forms.Button buttonAddCourse;
        private System.Windows.Forms.DataGridView dataGridViewY1S1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageYear1Sem1;
        private System.Windows.Forms.TabPage tabPageYear1Sem2;
        private System.Windows.Forms.DataGridView dataGridViewY1S2;
    }
}

