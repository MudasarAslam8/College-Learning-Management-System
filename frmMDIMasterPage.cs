using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CollegeManagementSystem
{
    public partial class frmMDIMasterPage : Form
    {
        public frmMDIMasterPage()
        {
            InitializeComponent();
            this.toolMenuFeeReports.Visible = true;
            this.mnuStripCMS.Renderer = new ToolStripProfessionalRenderer(new lib.CustomMenuColor());
        }
        
        private void frmMDIMasterPage_Load(object sender, EventArgs e)
        {
           frmLogin UserLogin = new frmLogin();
            UserLogin.ShowDialog();
           LoginMode(true);
            MenuEvent(true);
        }

        private void LoginMode(bool Mode)
        {
            if (Mode == true)
            {
                toolStripUserName.Text = "[User Name:- " + Global.UserName + "]";
                toolStripRole.Text = "[Role:- " + Global.UserType + "]";
            }
            else
            {
                this.toolStripUserName.Text = "Process...";
                this.toolStripRole.Text = "Process...";
            }
        }

        private void MenuEvent(bool Mode)
        {
            if (Mode == true)
            {
                if (Global.UserType == "User")
                {
                    editToolStripMenuItem.Enabled = false;
                }
                else
                {
                    editToolStripMenuItem.Enabled = true;
                }
            }
        }

        #region "MDI Master page menus"

        #region "File Menu"
        private void mnuItemLogOff_Click(object sender, EventArgs e)
        {
            
            frmLogin frn = new frmLogin();
            frn.MdiParent = this;
            frn.Show();

        
        }

        private void mnuItemChngPsw_Click(object sender, EventArgs e)
        {
            Users.frmChangePassword frn = new Users.frmChangePassword();
            frn.MdiParent = this;
            frn.Show();
           
        }

        private void mnuItemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region "Edit Menu"
        private void toolMenuCreateUsers_Click(object sender, EventArgs e)
        {
            Users.frmCreateUser frn = new Users.frmCreateUser();
            frn.MdiParent = this;
            frn.Show();
           
        }

        private void toolMenuSemester_Click(object sender, EventArgs e)
        {
            CourseDetails.frmSemester frn = new CourseDetails.frmSemester();
            frn.MdiParent = this;
            frn.Show();
           
        }

        private void toolMenuCourse_Click(object sender, EventArgs e)
        {
            CourseDetails.frmCourse frn = new CourseDetails.frmCourse();
            frn.MdiParent = this;
            frn.Show();
        }

        private void toolMenuSubject_Click(object sender, EventArgs e)
        {
            CourseDetails.frmSubject frn = new CourseDetails.frmSubject();
            frn.MdiParent = this;
            frn.Show();
        }

        private void toolMenuFeeManage_Click(object sender, EventArgs e)
        {
            Utility.frmFeeManage frn = new Utility.frmFeeManage();
            frn.MdiParent = this;
            frn.Show();
        }
        #endregion

        #region "Student Menu"
        private void toolMenuStudentAdmission_Click(object sender, EventArgs e)
        {
            Student.frmStudentRegister frn = new Student.frmStudentRegister();
            frn.MdiParent= this;
            frn.Show();
        }

        private void toolMenuAttendance_Click(object sender, EventArgs e)
        {
            Student.frmAttendance frn = new Student.frmAttendance();
            frn.MdiParent = this;
            frn.Show();
        }

        private void toolMenuAttendanceHistory_Click(object sender, EventArgs e)
        {
           /* Student.frmSAttendanceHistory frn = new Student.frmSAttendanceHistory();
            frn.MdiParent = this;
            frn.Show();*/
        }

        private void toolMenuStudentFee_Click(object sender, EventArgs e)
        {
            Student.frmStudentAccount frn = new Student.frmStudentAccount();
            frn.MdiParent = this;
            frn.Show();
        }

        private void toolMenuFeeView_Click(object sender, EventArgs e)
        {

           //Student.frmStudentFeeView frn = new Student.frmStudentFeeView();
           //frn.MdiParent = this;
           // frn.Show();
        }
        #endregion

        #region "Teacher Menu"
        private void toolMenuTeacherRegister_Click(object sender, EventArgs e)
        {
            Teacher.frmTeacherRegister frn = new Teacher.frmTeacherRegister();
            frn.MdiParent = this;
            frn.Show();
        }

        private void toolMenuTeacherAttendance_Click(object sender, EventArgs e)
        {
            Teacher.frmTeacherAttendance frn = new Teacher.frmTeacherAttendance();
            frn.MdiParent = this;
            frn.Show();
        }

        private void toolMenuTimeSchedule_Click(object sender, EventArgs e)
        {
            Teacher.frmTimeSchedule frn = new Teacher.frmTimeSchedule();
            frn.MdiParent = this;
            frn.Show();
        }

        private void toolMenuTeacherAttendanceHistory_Click(object sender, EventArgs e)
        {
            Teacher.frmTAttendanceHistory frn = new Teacher.frmTAttendanceHistory();
            frn.MdiParent= this;
            frn.Show();
          
        }

        private void toolMenuScheduleHistory_Click(object sender, EventArgs e)
        {
            Teacher.frmTimeScheduleHistory frn = new Teacher.frmTimeScheduleHistory();
            frn.MdiParent = this;
            frn.Show();
            
        }
        #endregion

        #region "Reports Menu"
        private void toolMenuStudentReports_Click(object sender, EventArgs e)
        {
            Reports.frmStudentReports frn = new Reports.frmStudentReports();
            frn.MdiParent = this;
            frn.Show();
            
        }

        private void toolMenuFeeReports_Click(object sender, EventArgs e)
        {
            Reports.frmFeeReport frn = new Reports.frmFeeReport();
            frn.MdiParent = this;
            frn.Show();
            
        }
        #endregion

        #region "Tools Menu"
        private void toolMenudatabaseBackupRestore_Click(object sender, EventArgs e)
        {
           // DatabaseBackup.frmDatabaseBackup frn = new DatabaseBackup.frmDatabaseBackup();
           // frn.MdiParent = this;
           // frn.Show();
        }
        #endregion

        #region "Help Menu"
        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAboutUs frn = new frmAboutUs();
            frn.MdiParent = this;
            frn.Show();
        }
        #endregion

        #endregion
    }
}
