﻿namespace Project2
{
    partial class Form_FinAid
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
            this.button_max = new System.Windows.Forms.Button();
            this.button_min = new System.Windows.Forms.Button();
            this.button_avg = new System.Windows.Forms.Button();
            this.dataGridView_finances = new System.Windows.Forms.DataGridView();
            this.button_search = new System.Windows.Forms.Button();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_course_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_return = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_finances)).BeginInit();
            this.SuspendLayout();
            // 
            // button_max
            // 
            this.button_max.Location = new System.Drawing.Point(203, 387);
            this.button_max.Name = "button_max";
            this.button_max.Size = new System.Drawing.Size(75, 23);
            this.button_max.TabIndex = 0;
            this.button_max.Text = "MAX";
            this.button_max.UseVisualStyleBackColor = true;
            this.button_max.Click += new System.EventHandler(this.button_max_Click);
            // 
            // button_min
            // 
            this.button_min.Location = new System.Drawing.Point(389, 387);
            this.button_min.Name = "button_min";
            this.button_min.Size = new System.Drawing.Size(75, 23);
            this.button_min.TabIndex = 1;
            this.button_min.Text = "MIN";
            this.button_min.UseVisualStyleBackColor = true;
            this.button_min.Click += new System.EventHandler(this.button_min_Click);
            // 
            // button_avg
            // 
            this.button_avg.Location = new System.Drawing.Point(563, 387);
            this.button_avg.Name = "button_avg";
            this.button_avg.Size = new System.Drawing.Size(75, 23);
            this.button_avg.TabIndex = 2;
            this.button_avg.Text = "AVG";
            this.button_avg.UseVisualStyleBackColor = true;
            this.button_avg.Click += new System.EventHandler(this.button_avg_Click);
            // 
            // dataGridView_finances
            // 
            this.dataGridView_finances.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_finances.Location = new System.Drawing.Point(203, 144);
            this.dataGridView_finances.Name = "dataGridView_finances";
            this.dataGridView_finances.Size = new System.Drawing.Size(435, 150);
            this.dataGridView_finances.TabIndex = 3;
            this.dataGridView_finances.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_finances_CellContentClick);
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(563, 86);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(75, 23);
            this.button_search.TabIndex = 4;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(286, 88);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(229, 20);
            this.textBox_name.TabIndex = 5;
            this.textBox_name.TextChanged += new System.EventHandler(this.textBox_name_TextChanged);
            // 
            // textBox_course_id
            // 
            this.textBox_course_id.Location = new System.Drawing.Point(389, 334);
            this.textBox_course_id.Name = "textBox_course_id";
            this.textBox_course_id.Size = new System.Drawing.Size(249, 20);
            this.textBox_course_id.TabIndex = 6;
            this.textBox_course_id.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Student First Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button_return
            // 
            this.button_return.Location = new System.Drawing.Point(629, 25);
            this.button_return.Name = "button_return";
            this.button_return.Size = new System.Drawing.Size(142, 23);
            this.button_return.TabIndex = 47;
            this.button_return.Text = "Return to Previous Screen";
            this.button_return.UseVisualStyleBackColor = true;
            this.button_return.Click += new System.EventHandler(this.button_return_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "Course Information";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "Course ID";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(163, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "Search Student Finances";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form_FinAid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_return);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_course_id);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.dataGridView_finances);
            this.Controls.Add(this.button_avg);
            this.Controls.Add(this.button_min);
            this.Controls.Add(this.button_max);
            this.Name = "Form_FinAid";
            this.Text = "Financial Aid";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_finances)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_max;
        private System.Windows.Forms.Button button_min;
        private System.Windows.Forms.Button button_avg;
        private System.Windows.Forms.DataGridView dataGridView_finances;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_course_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_return;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}