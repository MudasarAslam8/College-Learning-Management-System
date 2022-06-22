namespace CollegeManagementSystem.Student
{
    partial class frmAttendance
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picStudent = new System.Windows.Forms.PictureBox();
            this.rdAbsent = new System.Windows.Forms.RadioButton();
            this.rdPresent = new System.Windows.Forms.RadioButton();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.txtRollNo = new System.Windows.Forms.TextBox();
            this.cmbStudentName = new System.Windows.Forms.ComboBox();
            this.cmbSemester = new System.Windows.Forms.ComboBox();
            this.cmbCourse = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gridStudentAttendanceData = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Course = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Semester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RollNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttendanceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Attendance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StuId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridStudentAttendanceData)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picStudent);
            this.groupBox1.Controls.Add(this.rdAbsent);
            this.groupBox1.Controls.Add(this.rdPresent);
            this.groupBox1.Controls.Add(this.datePicker);
            this.groupBox1.Controls.Add(this.txtRollNo);
            this.groupBox1.Controls.Add(this.cmbStudentName);
            this.groupBox1.Controls.Add(this.cmbSemester);
            this.groupBox1.Controls.Add(this.cmbCourse);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(18, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1088, 305);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Attendance Details";
            // 
            // picStudent
            // 
            this.picStudent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.picStudent.BackgroundImage = global::CollegeManagementSystem.Properties.Resources.empty_profile;
            this.picStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picStudent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picStudent.Location = new System.Drawing.Point(807, 26);
            this.picStudent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picStudent.Name = "picStudent";
            this.picStudent.Size = new System.Drawing.Size(260, 256);
            this.picStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStudent.TabIndex = 15;
            this.picStudent.TabStop = false;
            // 
            // rdAbsent
            // 
            this.rdAbsent.AutoSize = true;
            this.rdAbsent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdAbsent.Location = new System.Drawing.Point(270, 188);
            this.rdAbsent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdAbsent.Name = "rdAbsent";
            this.rdAbsent.Size = new System.Drawing.Size(91, 26);
            this.rdAbsent.TabIndex = 7;
            this.rdAbsent.TabStop = true;
            this.rdAbsent.Text = "Absent";
            this.rdAbsent.UseVisualStyleBackColor = true;
            // 
            // rdPresent
            // 
            this.rdPresent.AutoSize = true;
            this.rdPresent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdPresent.Location = new System.Drawing.Point(160, 188);
            this.rdPresent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdPresent.Name = "rdPresent";
            this.rdPresent.Size = new System.Drawing.Size(97, 26);
            this.rdPresent.TabIndex = 6;
            this.rdPresent.TabStop = true;
            this.rdPresent.Text = "Present";
            this.rdPresent.UseVisualStyleBackColor = true;
            // 
            // datePicker
            // 
            this.datePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(598, 140);
            this.datePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(182, 28);
            this.datePicker.TabIndex = 5;
            // 
            // txtRollNo
            // 
            this.txtRollNo.BackColor = System.Drawing.Color.White;
            this.txtRollNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRollNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRollNo.Location = new System.Drawing.Point(160, 140);
            this.txtRollNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRollNo.Name = "txtRollNo";
            this.txtRollNo.ReadOnly = true;
            this.txtRollNo.Size = new System.Drawing.Size(359, 28);
            this.txtRollNo.TabIndex = 4;
            // 
            // cmbStudentName
            // 
            this.cmbStudentName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbStudentName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStudentName.FormattingEnabled = true;
            this.cmbStudentName.Location = new System.Drawing.Point(160, 89);
            this.cmbStudentName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbStudentName.Name = "cmbStudentName";
            this.cmbStudentName.Size = new System.Drawing.Size(620, 30);
            this.cmbStudentName.TabIndex = 3;
            this.cmbStudentName.SelectedIndexChanged += new System.EventHandler(this.cmbStudentName_SelectedIndexChanged);
            // 
            // cmbSemester
            // 
            this.cmbSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSemester.Enabled = false;
            this.cmbSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSemester.ForeColor = System.Drawing.Color.Black;
            this.cmbSemester.FormattingEnabled = true;
            this.cmbSemester.Location = new System.Drawing.Point(644, 40);
            this.cmbSemester.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbSemester.Name = "cmbSemester";
            this.cmbSemester.Size = new System.Drawing.Size(138, 30);
            this.cmbSemester.TabIndex = 2;
            this.cmbSemester.SelectedIndexChanged += new System.EventHandler(this.cmbSemester_SelectedIndexChanged);
            // 
            // cmbCourse
            // 
            this.cmbCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCourse.ForeColor = System.Drawing.Color.Black;
            this.cmbCourse.FormattingEnabled = true;
            this.cmbCourse.Location = new System.Drawing.Point(160, 38);
            this.cmbCourse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbCourse.Name = "cmbCourse";
            this.cmbCourse.Size = new System.Drawing.Size(358, 30);
            this.cmbCourse.TabIndex = 1;
            this.cmbCourse.SelectedIndexChanged += new System.EventHandler(this.cmbCourse_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(24, 191);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Attendance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(540, 143);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(24, 143);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Roll No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(24, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Student Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(540, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Semester";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(24, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Course";
            // 
            // gridStudentAttendanceData
            // 
            this.gridStudentAttendanceData.AllowUserToAddRows = false;
            this.gridStudentAttendanceData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridStudentAttendanceData.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.gridStudentAttendanceData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridStudentAttendanceData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Course,
            this.Semester,
            this.StudentName,
            this.RollNo,
            this.AttendanceDate,
            this.Attendance,
            this.StuId,
            this.CId});
            this.gridStudentAttendanceData.Location = new System.Drawing.Point(18, 395);
            this.gridStudentAttendanceData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gridStudentAttendanceData.Name = "gridStudentAttendanceData";
            this.gridStudentAttendanceData.ReadOnly = true;
            this.gridStudentAttendanceData.RowHeadersVisible = false;
            this.gridStudentAttendanceData.RowHeadersWidth = 62;
            this.gridStudentAttendanceData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridStudentAttendanceData.Size = new System.Drawing.Size(1088, 394);
            this.gridStudentAttendanceData.TabIndex = 3;
            this.gridStudentAttendanceData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridStudentAttendanceData_CellClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 8;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Course
            // 
            this.Course.HeaderText = "Course";
            this.Course.MinimumWidth = 8;
            this.Course.Name = "Course";
            this.Course.ReadOnly = true;
            // 
            // Semester
            // 
            this.Semester.HeaderText = "Semester";
            this.Semester.MinimumWidth = 8;
            this.Semester.Name = "Semester";
            this.Semester.ReadOnly = true;
            // 
            // StudentName
            // 
            this.StudentName.HeaderText = "StudentName";
            this.StudentName.MinimumWidth = 8;
            this.StudentName.Name = "StudentName";
            this.StudentName.ReadOnly = true;
            // 
            // RollNo
            // 
            this.RollNo.HeaderText = "RollNo";
            this.RollNo.MinimumWidth = 8;
            this.RollNo.Name = "RollNo";
            this.RollNo.ReadOnly = true;
            // 
            // AttendanceDate
            // 
            this.AttendanceDate.HeaderText = "AttendanceDate";
            this.AttendanceDate.MinimumWidth = 8;
            this.AttendanceDate.Name = "AttendanceDate";
            this.AttendanceDate.ReadOnly = true;
            // 
            // Attendance
            // 
            this.Attendance.HeaderText = "Attendance";
            this.Attendance.MinimumWidth = 8;
            this.Attendance.Name = "Attendance";
            this.Attendance.ReadOnly = true;
            // 
            // StuId
            // 
            this.StuId.HeaderText = "StudentId";
            this.StuId.MinimumWidth = 8;
            this.StuId.Name = "StuId";
            this.StuId.ReadOnly = true;
            this.StuId.Visible = false;
            // 
            // CId
            // 
            this.CId.HeaderText = "CourseId";
            this.CId.MinimumWidth = 8;
            this.CId.Name = "CId";
            this.CId.ReadOnly = true;
            this.CId.Visible = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(387, 326);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(108, 45);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(876, 798);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(112, 45);
            this.btnConfirm.TabIndex = 3;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(994, 798);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(111, 45);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(504, 326);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(108, 45);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1124, 855);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gridStudentAttendanceData);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAttendance";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Attendance";
            this.Load += new System.EventHandler(this.frmAttendance_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAttendance_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridStudentAttendanceData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView gridStudentAttendanceData;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cmbStudentName;
        private System.Windows.Forms.ComboBox cmbSemester;
        private System.Windows.Forms.ComboBox cmbCourse;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.TextBox txtRollNo;
        private System.Windows.Forms.RadioButton rdAbsent;
        private System.Windows.Forms.RadioButton rdPresent;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.PictureBox picStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Course;
        private System.Windows.Forms.DataGridViewTextBoxColumn Semester;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RollNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttendanceDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Attendance;
        private System.Windows.Forms.DataGridViewTextBoxColumn StuId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CId;
    }
}