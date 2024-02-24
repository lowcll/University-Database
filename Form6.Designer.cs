namespace Project2
{
    partial class Form_ClassData
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
            this.button_courses = new System.Windows.Forms.Button();
            this.button_departments = new System.Windows.Forms.Button();
            this.button_instructors = new System.Windows.Forms.Button();
            this.button_locations = new System.Windows.Forms.Button();
            this.button_students = new System.Windows.Forms.Button();
            this.button_return = new System.Windows.Forms.Button();
            this.button_calculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome Administrator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Choose the Set of Data to Manage";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button_courses
            // 
            this.button_courses.Location = new System.Drawing.Point(145, 117);
            this.button_courses.Name = "button_courses";
            this.button_courses.Size = new System.Drawing.Size(75, 23);
            this.button_courses.TabIndex = 2;
            this.button_courses.Text = "Courses";
            this.button_courses.UseVisualStyleBackColor = true;
            this.button_courses.Click += new System.EventHandler(this.button_courses_Click);
            // 
            // button_departments
            // 
            this.button_departments.Location = new System.Drawing.Point(145, 189);
            this.button_departments.Name = "button_departments";
            this.button_departments.Size = new System.Drawing.Size(75, 23);
            this.button_departments.TabIndex = 3;
            this.button_departments.Text = "Departments";
            this.button_departments.UseVisualStyleBackColor = true;
            this.button_departments.Click += new System.EventHandler(this.button_departments_Click);
            // 
            // button_instructors
            // 
            this.button_instructors.Location = new System.Drawing.Point(145, 261);
            this.button_instructors.Name = "button_instructors";
            this.button_instructors.Size = new System.Drawing.Size(75, 23);
            this.button_instructors.TabIndex = 4;
            this.button_instructors.Text = "Instructors";
            this.button_instructors.UseVisualStyleBackColor = true;
            this.button_instructors.Click += new System.EventHandler(this.button_instructors_Click);
            // 
            // button_locations
            // 
            this.button_locations.Location = new System.Drawing.Point(145, 328);
            this.button_locations.Name = "button_locations";
            this.button_locations.Size = new System.Drawing.Size(75, 23);
            this.button_locations.TabIndex = 5;
            this.button_locations.Text = "Locations";
            this.button_locations.UseVisualStyleBackColor = true;
            this.button_locations.Click += new System.EventHandler(this.button_locations_Click);
            // 
            // button_students
            // 
            this.button_students.Location = new System.Drawing.Point(145, 392);
            this.button_students.Name = "button_students";
            this.button_students.Size = new System.Drawing.Size(75, 23);
            this.button_students.TabIndex = 6;
            this.button_students.Text = "Students";
            this.button_students.UseVisualStyleBackColor = true;
            this.button_students.Click += new System.EventHandler(this.button_students_Click);
            // 
            // button_return
            // 
            this.button_return.Location = new System.Drawing.Point(220, 513);
            this.button_return.Name = "button_return";
            this.button_return.Size = new System.Drawing.Size(142, 23);
            this.button_return.TabIndex = 7;
            this.button_return.Text = "Return to Previous Screen";
            this.button_return.UseVisualStyleBackColor = true;
            this.button_return.Click += new System.EventHandler(this.button_return_Click);
            // 
            // button_calculate
            // 
            this.button_calculate.Location = new System.Drawing.Point(120, 453);
            this.button_calculate.Name = "button_calculate";
            this.button_calculate.Size = new System.Drawing.Size(132, 23);
            this.button_calculate.TabIndex = 8;
            this.button_calculate.Text = "Enter to Calculate Data ";
            this.button_calculate.UseVisualStyleBackColor = true;
            this.button_calculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_ClassData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 548);
            this.Controls.Add(this.button_calculate);
            this.Controls.Add(this.button_return);
            this.Controls.Add(this.button_students);
            this.Controls.Add(this.button_locations);
            this.Controls.Add(this.button_instructors);
            this.Controls.Add(this.button_departments);
            this.Controls.Add(this.button_courses);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Form_ClassData";
            this.Text = "Form_ClassData";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_courses;
        private System.Windows.Forms.Button button_departments;
        private System.Windows.Forms.Button button_instructors;
        private System.Windows.Forms.Button button_locations;
        private System.Windows.Forms.Button button_students;
        private System.Windows.Forms.Button button_return;
        private System.Windows.Forms.Button button_calculate;
    }
}