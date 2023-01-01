using Microsoft.EntityFrameworkCore;
using ProjectPRN211_Block5.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectPRN211_Block5
{
    public partial class Form3 : Form
    {
        int _courseId;
        int _teachingscheduleId;
        public Form3()
        {
            InitializeComponent();
        }
        public Form3(int courseid):this()
        {
            _courseId = courseid;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            using(var context = new APContext())
            {
                var listSchedules = context.CourseSchedules
                .Include(cs => cs.Course)
                .ThenInclude(c => c.Subject)
                .Include(c => c.Course)
                .ThenInclude(c => c.Instructor)
                .Where(cs => cs.CourseId == _courseId)
                .Select(x => new
                {
                    x.TeachingScheduleId,
                    x.Course.CourseCode,
                    Time = x.TeachingDate,
                    Slot = x.Slot,
                    Class = x.Course.CourseDescription,                 
                    Room=x.Room.RoomId,
                    

                })
                .ToList();

                dgv1.DataSource = listSchedules;
                txtCourseName.Text = (from t in context.Courses
                                 where t.CourseId == _courseId
                                 select t.CourseCode).FirstOrDefault();
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv1.Columns[e.ColumnIndex].Name == "TakeAttendance")
            {

                _teachingscheduleId = Convert.ToInt32(dgv1.Rows[e.RowIndex].Cells[1].Value);
                Form4 O = new Form4(_teachingscheduleId);
                O.Show();
                this.Close();
            }
        }
    }
}
