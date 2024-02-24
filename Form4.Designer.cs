namespace Project2
{
    partial class Form_ClassManagement
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
            this.button_change = new System.Windows.Forms.Button();
            this.button_classmanage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_change
            // 
            this.button_change.Location = new System.Drawing.Point(293, 127);
            this.button_change.Name = "button_change";
            this.button_change.Size = new System.Drawing.Size(168, 23);
            this.button_change.TabIndex = 0;
            this.button_change.Text = "View your Information";
            this.button_change.UseVisualStyleBackColor = true;
            this.button_change.Click += new System.EventHandler(this.button_change_Click);
            // 
            // button_classmanage
            // 
            this.button_classmanage.Location = new System.Drawing.Point(293, 206);
            this.button_classmanage.Name = "button_classmanage";
            this.button_classmanage.Size = new System.Drawing.Size(168, 23);
            this.button_classmanage.TabIndex = 1;
            this.button_classmanage.Text = "Manage Class Data";
            this.button_classmanage.UseVisualStyleBackColor = true;
            this.button_classmanage.Click += new System.EventHandler(this.button_classmanage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(319, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome Administrator!";
            // 
            // button_logout
            // 
            this.button_logout.Location = new System.Drawing.Point(293, 287);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(168, 23);
            this.button_logout.TabIndex = 4;
            this.button_logout.Text = "Logout";
            this.button_logout.UseVisualStyleBackColor = true;
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click);
            // 
            // Form_ClassManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 361);
            this.Controls.Add(this.button_logout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_classmanage);
            this.Controls.Add(this.button_change);
            this.Name = "Form_ClassManagement";
            this.Text = "Management Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_change;
        private System.Windows.Forms.Button button_classmanage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_logout;
    }
}