using Microsoft.EntityFrameworkCore;
using ProjectPRN211_Block5.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectPRN211_Block5
{
    public partial class Form4 : Form
    {
        int _teachingscheduleId;
        public Form4()
        {
            InitializeComponent();
        }
        public Form4(int teachingscheduleId) : this()
        {
            _teachingscheduleId = teachingscheduleId;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

            using (var context = new APContext())
            {
                var result = context.RollCallBooks
                .Include(x => x.Student)
                .Include(x => x.TeachingSchedule)
                .Where(x => x.TeachingScheduleId == _teachingscheduleId)
                .Select(x => new
                {
                    x.StudentId,
                    Fullname = x.Student.FirstName + "" + x.Student.MidName + x.Student.LastName,
                    x.IsAbsent,
                    x.TeachingSchedule.TeachingDate,
                    x.RollCallBookId
                })
                .ToList();
                dgv2.DataSource = result;
                dgv2.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgv2.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgv2.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgv2.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                txtClass.Text = (from t in context.CourseSchedules
                                 where t.TeachingScheduleId == _teachingscheduleId
                                 join c in context.Courses on t.CourseId equals c.CourseId
                                 select c.CourseCode).FirstOrDefault();

                txtRollCallBookId.Text = (from t in context.CourseSchedules
                                          where t.TeachingScheduleId == _teachingscheduleId
                                          join c in context.RollCallBooks on t.TeachingScheduleId equals c.TeachingScheduleId
                                          select c.RollCallBookId).FirstOrDefault().ToString();

                txtClass.Enabled = true;
            }

        }

        private void dgv2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv2.Rows[e.RowIndex];
                txtStudentId.Text = Convert.ToInt32(row.Cells[0].Value).ToString();
                txtFullName.Text = row.Cells[1].Value.ToString();
                if (row.Cells[2].Value.ToString() == "True")
                {
                    rdAttend.Checked = true;
                }
                else
                {
                    rdAbsent.Checked = true;
                }
                txtRollCallBookId.Text = Convert.ToInt32(row.Cells[4].Value).ToString();
                txtStudentId.Enabled = true;
                txtFullName.Enabled = true;
            }
        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Bạn có muốn thoát không", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            RollCallBook rollCallBook = new RollCallBook();
            rollCallBook.RollCallBookId = Convert.ToInt32(txtRollCallBookId.Text);
            rollCallBook.StudentId = Convert.ToInt32(txtStudentId.Text);
            rollCallBook.TeachingScheduleId = _teachingscheduleId;
            if (rdAbsent.Checked)
            {
                rollCallBook.IsAbsent = false;
            }
            else
            {
                rollCallBook.IsAbsent = true;
            }
            using (var context = new APContext())
            {
                context.RollCallBooks.Update(rollCallBook);
                var d = context.SaveChanges();
                if (d > 0)
                {
                    MessageBox.Show("Điểm danh thành công");
                }
                
            }
            
        }

        private void rdAttend_Click(object sender, EventArgs e)
        {
            RollCallBook rollCallBook = new RollCallBook();
            rollCallBook.RollCallBookId = Convert.ToInt32(txtRollCallBookId.Text);
            rollCallBook.StudentId = Convert.ToInt32(txtStudentId.Text);
            rollCallBook.TeachingScheduleId = _teachingscheduleId;
            if (rdAbsent.Checked)
            {
                rollCallBook.IsAbsent = false;
            }
            else
            {
                rollCallBook.IsAbsent = true;
            }
            using (var context = new APContext())
            {
                context.RollCallBooks.Update(rollCallBook);
                var d = context.SaveChanges();
                if (d > 0)
                {
                    MessageBox.Show("Điểm danh thành công");
                }
                dgv2.DataSource = context.RollCallBooks
                .Include(x => x.Student)
                .Include(x => x.TeachingSchedule)
                .Where(x => x.TeachingScheduleId == _teachingscheduleId)
                .Select(x => new
                {
                    x.StudentId,
                    Fullname = x.Student.FirstName + "" + x.Student.MidName + x.Student.LastName,
                    x.IsAbsent,
                    x.TeachingSchedule.TeachingDate,
                    x.RollCallBookId
                })
                .ToList();
            }
        }

        private void rdAbsent_CheckedChanged(object sender, EventArgs e)
        {
            RollCallBook rollCallBook = new RollCallBook();
            rollCallBook.RollCallBookId = Convert.ToInt32(txtRollCallBookId.Text);
            rollCallBook.StudentId = Convert.ToInt32(txtStudentId.Text);
            rollCallBook.TeachingScheduleId = _teachingscheduleId;
            if (rdAbsent.Checked)
            {
                rollCallBook.IsAbsent = false;
            }
            else
            {
                rollCallBook.IsAbsent = true;
            }
            using (var context = new APContext())
            {
                context.RollCallBooks.Update(rollCallBook);
                var d = context.SaveChanges();
                if (d > 0)
                {
                    MessageBox.Show("Điểm danh thành công");
                }
                dgv2.DataSource = context.RollCallBooks
                .Include(x => x.Student)
                .Include(x => x.TeachingSchedule)
                .Where(x => x.TeachingScheduleId == _teachingscheduleId)
                .Select(x => new
                {
                    x.StudentId,
                    Fullname = x.Student.FirstName + "" + x.Student.MidName + x.Student.LastName,
                    x.IsAbsent,
                    x.TeachingSchedule.TeachingDate,
                    x.RollCallBookId
                })
                .ToList();
            }
        }
    }
}
