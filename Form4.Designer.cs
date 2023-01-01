namespace ProjectPRN211_Block5
{
    partial class Form4
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
            this.lblClass = new System.Windows.Forms.Label();
            this.groupbox = new System.Windows.Forms.GroupBox();
            this.RollCallBookID = new System.Windows.Forms.Label();
            this.txtRollCallBookId = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.rdAbsent = new System.Windows.Forms.RadioButton();
            this.rdAttend = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.dgv2 = new System.Windows.Forms.DataGridView();
            this.groupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(22, 36);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(187, 20);
            this.lblClass.TabIndex = 0;
            this.lblClass.Text = "Taking attendance for class";
            // 
            // groupbox
            // 
            this.groupbox.Controls.Add(this.RollCallBookID);
            this.groupbox.Controls.Add(this.txtRollCallBookId);
            this.groupbox.Controls.Add(this.txtFullName);
            this.groupbox.Controls.Add(this.btnExit);
            this.groupbox.Controls.Add(this.btnSave);
            this.groupbox.Controls.Add(this.txtStudentId);
            this.groupbox.Controls.Add(this.rdAbsent);
            this.groupbox.Controls.Add(this.rdAttend);
            this.groupbox.Controls.Add(this.label3);
            this.groupbox.Controls.Add(this.label2);
            this.groupbox.Controls.Add(this.txtClass);
            this.groupbox.Controls.Add(this.lblClass);
            this.groupbox.Location = new System.Drawing.Point(32, 38);
            this.groupbox.Name = "groupbox";
            this.groupbox.Size = new System.Drawing.Size(796, 233);
            this.groupbox.TabIndex = 1;
            this.groupbox.TabStop = false;
            this.groupbox.Text = "groupBox1";
            // 
            // RollCallBookID
            // 
            this.RollCallBookID.AutoSize = true;
            this.RollCallBookID.Location = new System.Drawing.Point(253, 108);
            this.RollCallBookID.Name = "RollCallBookID";
            this.RollCallBookID.Size = new System.Drawing.Size(109, 20);
            this.RollCallBookID.TabIndex = 20;
            this.RollCallBookID.Text = "RollCallBookID";
            // 
            // txtRollCallBookId
            // 
            this.txtRollCallBookId.Location = new System.Drawing.Point(368, 101);
            this.txtRollCallBookId.Name = "txtRollCallBookId";
            this.txtRollCallBookId.Size = new System.Drawing.Size(125, 27);
            this.txtRollCallBookId.TabIndex = 19;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(101, 149);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(208, 27);
            this.txtFullName.TabIndex = 18;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(631, 31);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 29);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(503, 32);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtStudentId
            // 
            this.txtStudentId.Location = new System.Drawing.Point(101, 101);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.Size = new System.Drawing.Size(125, 27);
            this.txtStudentId.TabIndex = 11;
            // 
            // rdAbsent
            // 
            this.rdAbsent.AutoSize = true;
            this.rdAbsent.Location = new System.Drawing.Point(546, 152);
            this.rdAbsent.Name = "rdAbsent";
            this.rdAbsent.Size = new System.Drawing.Size(76, 24);
            this.rdAbsent.TabIndex = 10;
            this.rdAbsent.TabStop = true;
            this.rdAbsent.Text = "Absent";
            this.rdAbsent.UseVisualStyleBackColor = true;
            this.rdAbsent.CheckedChanged += new System.EventHandler(this.rdAbsent_CheckedChanged);
            // 
            // rdAttend
            // 
            this.rdAttend.AutoSize = true;
            this.rdAttend.Location = new System.Drawing.Point(547, 79);
            this.rdAttend.Name = "rdAttend";
            this.rdAttend.Size = new System.Drawing.Size(75, 24);
            this.rdAttend.TabIndex = 9;
            this.rdAttend.TabStop = true;
            this.rdAttend.Text = "Attend";
            this.rdAttend.UseVisualStyleBackColor = true;
            this.rdAttend.Click += new System.EventHandler(this.rdAttend_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Full Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "StudentId";
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(215, 33);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(125, 27);
            this.txtClass.TabIndex = 1;
            // 
            // dgv2
            // 
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.Location = new System.Drawing.Point(32, 286);
            this.dgv2.Name = "dgv2";
            this.dgv2.RowHeadersWidth = 51;
            this.dgv2.RowTemplate.Height = 29;
            this.dgv2.Size = new System.Drawing.Size(799, 184);
            this.dgv2.TabIndex = 2;
            this.dgv2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv2_CellContentClick);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 485);
            this.Controls.Add(this.dgv2);
            this.Controls.Add(this.groupbox);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.groupbox.ResumeLayout(false);
            this.groupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblClass;
        private GroupBox groupbox;
        private TextBox txtClass;
        private TextBox txtStudentId;
        private RadioButton rdAbsent;
        private RadioButton rdAttend;
        private Label label3;
        private Label label2;
        private DataGridView dgv2;
        private Button btnExit;
        private Button btnSave;
        private TextBox txtFullName;
        private Label RollCallBookID;
        private TextBox txtRollCallBookId;
    }
}