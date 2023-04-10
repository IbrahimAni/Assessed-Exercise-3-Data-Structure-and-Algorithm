namespace Assessment_3_Task_C
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
            this.studentList = new System.Windows.Forms.ListBox();
            this.studentIdTextBox = new System.Windows.Forms.TextBox();
            this.studentNameTextBox = new System.Windows.Forms.TextBox();
            this.studentIdEditTextBox = new System.Windows.Forms.TextBox();
            this.addStudentBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.enrolled = new System.Windows.Forms.RadioButton();
            this.unEnrolled = new System.Windows.Forms.RadioButton();
            this.studentId = new System.Windows.Forms.Label();
            this.studentName = new System.Windows.Forms.Label();
            this.studentIdEdit = new System.Windows.Forms.Label();
            this.displayEnrolledStudentsBtn = new System.Windows.Forms.Button();
            this.searchByNameBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // studentList
            // 
            this.studentList.FormattingEnabled = true;
            this.studentList.Location = new System.Drawing.Point(25, 8);
            this.studentList.Name = "studentList";
            this.studentList.Size = new System.Drawing.Size(242, 368);
            this.studentList.TabIndex = 0;
            // 
            // studentIdTextBox
            // 
            this.studentIdTextBox.Location = new System.Drawing.Point(287, 33);
            this.studentIdTextBox.Name = "studentIdTextBox";
            this.studentIdTextBox.Size = new System.Drawing.Size(120, 20);
            this.studentIdTextBox.TabIndex = 1;
            // 
            // studentNameTextBox
            // 
            this.studentNameTextBox.Location = new System.Drawing.Point(411, 33);
            this.studentNameTextBox.Name = "studentNameTextBox";
            this.studentNameTextBox.Size = new System.Drawing.Size(108, 20);
            this.studentNameTextBox.TabIndex = 2;
            // 
            // studentIdEditTextBox
            // 
            this.studentIdEditTextBox.Location = new System.Drawing.Point(287, 201);
            this.studentIdEditTextBox.Name = "studentIdEditTextBox";
            this.studentIdEditTextBox.Size = new System.Drawing.Size(232, 20);
            this.studentIdEditTextBox.TabIndex = 3;
            // 
            // addStudentBtn
            // 
            this.addStudentBtn.Location = new System.Drawing.Point(287, 72);
            this.addStudentBtn.Name = "addStudentBtn";
            this.addStudentBtn.Size = new System.Drawing.Size(232, 23);
            this.addStudentBtn.TabIndex = 4;
            this.addStudentBtn.Text = "Add Student";
            this.addStudentBtn.UseVisualStyleBackColor = true;
            this.addStudentBtn.Click += new System.EventHandler(this.addStudentBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(413, 262);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(106, 23);
            this.updateBtn.TabIndex = 5;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(287, 353);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(120, 23);
            this.searchBtn.TabIndex = 6;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.Location = new System.Drawing.Point(413, 353);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(106, 23);
            this.RemoveBtn.TabIndex = 7;
            this.RemoveBtn.Text = "Remove";
            this.RemoveBtn.UseVisualStyleBackColor = true;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // enrolled
            // 
            this.enrolled.AutoSize = true;
            this.enrolled.Location = new System.Drawing.Point(287, 242);
            this.enrolled.Name = "enrolled";
            this.enrolled.Size = new System.Drawing.Size(47, 17);
            this.enrolled.TabIndex = 8;
            this.enrolled.TabStop = true;
            this.enrolled.Text = "True";
            this.enrolled.UseVisualStyleBackColor = true;
            // 
            // unEnrolled
            // 
            this.unEnrolled.AutoSize = true;
            this.unEnrolled.Location = new System.Drawing.Point(287, 265);
            this.unEnrolled.Name = "unEnrolled";
            this.unEnrolled.Size = new System.Drawing.Size(50, 17);
            this.unEnrolled.TabIndex = 9;
            this.unEnrolled.TabStop = true;
            this.unEnrolled.Text = "False";
            this.unEnrolled.UseVisualStyleBackColor = true;
            // 
            // studentId
            // 
            this.studentId.AutoSize = true;
            this.studentId.Location = new System.Drawing.Point(284, 9);
            this.studentId.Name = "studentId";
            this.studentId.Size = new System.Drawing.Size(58, 13);
            this.studentId.TabIndex = 10;
            this.studentId.Text = "Student ID";
            // 
            // studentName
            // 
            this.studentName.AutoSize = true;
            this.studentName.Location = new System.Drawing.Point(408, 8);
            this.studentName.Name = "studentName";
            this.studentName.Size = new System.Drawing.Size(75, 13);
            this.studentName.TabIndex = 11;
            this.studentName.Text = "Student Name";
            // 
            // studentIdEdit
            // 
            this.studentIdEdit.AutoSize = true;
            this.studentIdEdit.Location = new System.Drawing.Point(284, 172);
            this.studentIdEdit.Name = "studentIdEdit";
            this.studentIdEdit.Size = new System.Drawing.Size(119, 13);
            this.studentIdEdit.TabIndex = 12;
            this.studentIdEdit.Text = "Enter Student ID/Name";
            // 
            // displayEnrolledStudentsBtn
            // 
            this.displayEnrolledStudentsBtn.Location = new System.Drawing.Point(411, 309);
            this.displayEnrolledStudentsBtn.Name = "displayEnrolledStudentsBtn";
            this.displayEnrolledStudentsBtn.Size = new System.Drawing.Size(106, 23);
            this.displayEnrolledStudentsBtn.TabIndex = 13;
            this.displayEnrolledStudentsBtn.Text = "Display Enrolled Students";
            this.displayEnrolledStudentsBtn.UseVisualStyleBackColor = true;
            this.displayEnrolledStudentsBtn.Click += new System.EventHandler(this.displayEnrolledStudentsBtn_Click);
            // 
            // searchByNameBtn
            // 
            this.searchByNameBtn.Location = new System.Drawing.Point(287, 309);
            this.searchByNameBtn.Name = "searchByNameBtn";
            this.searchByNameBtn.Size = new System.Drawing.Size(106, 23);
            this.searchByNameBtn.TabIndex = 14;
            this.searchByNameBtn.Text = "Search By Name";
            this.searchByNameBtn.UseVisualStyleBackColor = true;
            this.searchByNameBtn.Click += new System.EventHandler(this.searchByNameBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 450);
            this.Controls.Add(this.searchByNameBtn);
            this.Controls.Add(this.displayEnrolledStudentsBtn);
            this.Controls.Add(this.studentIdEdit);
            this.Controls.Add(this.studentName);
            this.Controls.Add(this.studentId);
            this.Controls.Add(this.unEnrolled);
            this.Controls.Add(this.enrolled);
            this.Controls.Add(this.RemoveBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.addStudentBtn);
            this.Controls.Add(this.studentIdEditTextBox);
            this.Controls.Add(this.studentNameTextBox);
            this.Controls.Add(this.studentIdTextBox);
            this.Controls.Add(this.studentList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox studentList;
        private System.Windows.Forms.TextBox studentIdTextBox;
        private System.Windows.Forms.TextBox studentNameTextBox;
        private System.Windows.Forms.TextBox studentIdEditTextBox;
        private System.Windows.Forms.Button addStudentBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button RemoveBtn;
        private System.Windows.Forms.RadioButton enrolled;
        private System.Windows.Forms.RadioButton unEnrolled;
        private System.Windows.Forms.Label studentId;
        private System.Windows.Forms.Label studentName;
        private System.Windows.Forms.Label studentIdEdit;
        private System.Windows.Forms.Button displayEnrolledStudentsBtn;
        private System.Windows.Forms.Button searchByNameBtn;
    }
}

