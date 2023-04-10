namespace Assessment_3_Task_B
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.studentList = new System.Windows.Forms.ListBox();
            this.studentIdEditTextBox = new System.Windows.Forms.TextBox();
            this.studentNameTextBox = new System.Windows.Forms.TextBox();
            this.studentIdTextBox = new System.Windows.Forms.TextBox();
            this.studentId = new System.Windows.Forms.Label();
            this.studentName = new System.Windows.Forms.Label();
            this.studentIdEdit = new System.Windows.Forms.Label();
            this.addStudentBtn = new System.Windows.Forms.Button();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.enrolled = new System.Windows.Forms.RadioButton();
            this.unEnrolled = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // studentList
            // 
            this.studentList.FormattingEnabled = true;
            this.studentList.Location = new System.Drawing.Point(12, 38);
            this.studentList.Name = "studentList";
            this.studentList.Size = new System.Drawing.Size(200, 511);
            this.studentList.TabIndex = 0;
            // 
            // studentIdEditTextBox
            // 
            this.studentIdEditTextBox.Location = new System.Drawing.Point(227, 239);
            this.studentIdEditTextBox.Name = "studentIdEditTextBox";
            this.studentIdEditTextBox.Size = new System.Drawing.Size(206, 20);
            this.studentIdEditTextBox.TabIndex = 1;
            // 
            // studentNameTextBox
            // 
            this.studentNameTextBox.Location = new System.Drawing.Point(333, 60);
            this.studentNameTextBox.Name = "studentNameTextBox";
            this.studentNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.studentNameTextBox.TabIndex = 3;
            // 
            // studentIdTextBox
            // 
            this.studentIdTextBox.Location = new System.Drawing.Point(227, 60);
            this.studentIdTextBox.Name = "studentIdTextBox";
            this.studentIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.studentIdTextBox.TabIndex = 4;
            // 
            // studentId
            // 
            this.studentId.AutoSize = true;
            this.studentId.Location = new System.Drawing.Point(224, 38);
            this.studentId.Name = "studentId";
            this.studentId.Size = new System.Drawing.Size(58, 13);
            this.studentId.TabIndex = 5;
            this.studentId.Text = "Student ID";
            // 
            // studentName
            // 
            this.studentName.AutoSize = true;
            this.studentName.Location = new System.Drawing.Point(330, 38);
            this.studentName.Name = "studentName";
            this.studentName.Size = new System.Drawing.Size(75, 13);
            this.studentName.TabIndex = 6;
            this.studentName.Text = "Student Name";
            // 
            // studentIdEdit
            // 
            this.studentIdEdit.AutoSize = true;
            this.studentIdEdit.Location = new System.Drawing.Point(224, 212);
            this.studentIdEdit.Name = "studentIdEdit";
            this.studentIdEdit.Size = new System.Drawing.Size(86, 13);
            this.studentIdEdit.TabIndex = 7;
            this.studentIdEdit.Text = "Enter Student ID";
            // 
            // addStudentBtn
            // 
            this.addStudentBtn.Location = new System.Drawing.Point(227, 103);
            this.addStudentBtn.Name = "addStudentBtn";
            this.addStudentBtn.Size = new System.Drawing.Size(206, 23);
            this.addStudentBtn.TabIndex = 9;
            this.addStudentBtn.Text = "Add Student";
            this.addStudentBtn.UseVisualStyleBackColor = true;
            this.addStudentBtn.Click += new System.EventHandler(this.addStudentBtn_Click);
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.Location = new System.Drawing.Point(342, 517);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(91, 23);
            this.RemoveBtn.TabIndex = 10;
            this.RemoveBtn.Text = "Remove";
            this.RemoveBtn.UseVisualStyleBackColor = true;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(342, 296);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(91, 23);
            this.updateBtn.TabIndex = 11;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(227, 517);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(100, 23);
            this.searchBtn.TabIndex = 12;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // enrolled
            // 
            this.enrolled.AutoSize = true;
            this.enrolled.Location = new System.Drawing.Point(227, 279);
            this.enrolled.Name = "enrolled";
            this.enrolled.Size = new System.Drawing.Size(47, 17);
            this.enrolled.TabIndex = 13;
            this.enrolled.TabStop = true;
            this.enrolled.Text = "True";
            this.enrolled.UseVisualStyleBackColor = true;
            // 
            // unEnrolled
            // 
            this.unEnrolled.AutoSize = true;
            this.unEnrolled.Location = new System.Drawing.Point(227, 302);
            this.unEnrolled.Name = "unEnrolled";
            this.unEnrolled.Size = new System.Drawing.Size(50, 17);
            this.unEnrolled.TabIndex = 14;
            this.unEnrolled.TabStop = true;
            this.unEnrolled.Text = "False";
            this.unEnrolled.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 647);
            this.Controls.Add(this.unEnrolled);
            this.Controls.Add(this.enrolled);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.RemoveBtn);
            this.Controls.Add(this.addStudentBtn);
            this.Controls.Add(this.studentIdEdit);
            this.Controls.Add(this.studentName);
            this.Controls.Add(this.studentId);
            this.Controls.Add(this.studentIdTextBox);
            this.Controls.Add(this.studentNameTextBox);
            this.Controls.Add(this.studentIdEditTextBox);
            this.Controls.Add(this.studentList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ListBox studentList;
        private System.Windows.Forms.TextBox studentIdEditTextBox;
        private System.Windows.Forms.TextBox studentNameTextBox;
        private System.Windows.Forms.TextBox studentIdTextBox;
        private System.Windows.Forms.Label studentId;
        private System.Windows.Forms.Label studentName;
        private System.Windows.Forms.Label studentIdEdit;
        private System.Windows.Forms.Button addStudentBtn;
        private System.Windows.Forms.Button RemoveBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.RadioButton enrolled;
        private System.Windows.Forms.RadioButton unEnrolled;
    }
}

