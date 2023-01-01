using Microsoft.EntityFrameworkCore.Metadata;
using ProjectPRN211_Block5.Models;

namespace ProjectPRN211_Block5
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using(var context = new APContext())
            {
                var data = context.Instructors.Select(x => new
                {   
                    x.InstructorId,
                    Fullname = x.InstructorFirstName + " " + x.InstructorMidName + " " + x.InstructorLastName
                })
                .ToList();
                cboIntructorsName.ValueMember = "InstructorId";
                cboIntructorsName.DisplayMember = "FullName";
                cboIntructorsName.DataSource= data;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Bạn có muốn thoát không", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int instructorId = int.Parse(cboIntructorsName.SelectedValue.ToString());
            Form2 F = new Form2(instructorId);
            F.Show();
            this.Hide();
        }
    }
}