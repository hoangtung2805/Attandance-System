namespace ProjectPRN211_Block5
{
    partial class Form2
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
            this.TxtIntructors = new System.Windows.Forms.Label();
            this.txtInstructorName = new System.Windows.Forms.TextBox();
            this.TxtCourse = new System.Windows.Forms.Label();
            this.cboCourse = new System.Windows.Forms.ComboBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.TakeAttendance = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtIntructors
            // 
            this.TxtIntructors.AutoSize = true;
            this.TxtIntructors.Location = new System.Drawing.Point(88, 9);
            this.TxtIntructors.Name = "TxtIntructors";
            this.TxtIntructors.Size = new System.Drawing.Size(65, 20);
            this.TxtIntructors.TabIndex = 0;
            this.TxtIntructors.Text = "Intructor";
            // 
            // txtInstructorName
            // 
            this.txtInstructorName.Enabled = false;
            this.txtInstructorName.Location = new System.Drawing.Point(188, 6);
            this.txtInstructorName.Name = "txtInstructorName";
            this.txtInstructorName.Size = new System.Drawing.Size(221, 27);
            this.txtInstructorName.TabIndex = 1;
            this.txtInstructorName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TxtCourse
            // 
            this.TxtCourse.AutoSize = true;
            this.TxtCourse.Location = new System.Drawing.Point(474, 13);
            this.TxtCourse.Name = "TxtCourse";
            this.TxtCourse.Size = new System.Drawing.Size(54, 20);
            this.TxtCourse.TabIndex = 2;
            this.TxtCourse.Text = "Course";
            // 
            // cboCourse
            // 
            this.cboCourse.FormattingEnabled = true;
            this.cboCourse.Location = new System.Drawing.Point(534, 10);
            this.cboCourse.Name = "cboCourse";
            this.cboCourse.Size = new System.Drawing.Size(261, 28);
            this.cboCourse.TabIndex = 3;
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TakeAttendance});
            this.dgv.Location = new System.Drawing.Point(30, 86);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 29;
            this.dgv.Size = new System.Drawing.Size(913, 269);
            this.dgv.TabIndex = 5;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // TakeAttendance
            // 
            this.TakeAttendance.HeaderText = "TakeAttendance";
            this.TakeAttendance.MinimumWidth = 6;
            this.TakeAttendance.Name = "TakeAttendance";
            this.TakeAttendance.Text = "TakeAttendance";
            this.TakeAttendance.UseColumnTextForButtonValue = true;
            this.TakeAttendance.Width = 125;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 382);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.cboCourse);
            this.Controls.Add(this.TxtCourse);
            this.Controls.Add(this.txtInstructorName);
            this.Controls.Add(this.TxtIntructors);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label TxtIntructors;
        private TextBox txtInstructorName;
        private Label TxtCourse;
        private ComboBox cboCourse;
        private DataGridView dgv;
        private DataGridViewButtonColumn TakeAttendance;
    }
}