using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
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
    public partial class Form2 : Form
    {
        public int _instructorId;
        public String _intructorName;
        public String _Name;
        public int _courseId;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(int instructorId) : this()
        {
            /*_intructorName= intructorName;
            txtIntructorName.Text = _intructorName;
            string _Name = _intructorName.Split(' ')[2];*/
            _instructorId = instructorId;
        }
        

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            using(var context = new APContext())
            {
                var data = context.Instructors
                    .Include(x => x.Department)
                    .Where(x=>x.InstructorId == _instructorId)
                    .Select(x => new
                    {
                        FullName = x.InstructorFirstName + " " + x.InstructorLastName,
                        x.Department.DepartmentName,
                        x.Department.DepartmentId
                        
                    })

                    .ToList();
                txtInstructorName.Text = (from t in context.Instructors
                                          where t.InstructorId ==_instructorId
                                          select t.InstructorLastName).FirstOrDefault();
                                dgv.DataSource= context.Courses
                    .Include(x=>x.Instructor)
                    .Include(x=>x.Subject)
                    .Where(x => x.InstructorId == _instructorId)
                    .Select(x => new
                    {
                        x.CourseId,
                        x.CourseCode,
                        x.CourseDescription,
                        x.Subject.SubjectCode, 
                        x.Subject.SubjectName
                    })
                    .ToList();
                
                cboCourse.SelectedValue = "DepartmentId";
                cboCourse.DisplayMember= "DepartmentName";
                cboCourse.DataSource = data;
                

            }
            
            dgv.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.Columns[e.ColumnIndex].Name == "TakeAttendance")
            {
                
                _courseId = Convert.ToInt32(dgv.Rows[e.RowIndex].Cells[1].Value);       
                Form3 O = new Form3(_courseId);
                O.Show();
                this.Close();
            }
            
        }

        
    }
}
