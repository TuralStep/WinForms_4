namespace WinForms_4.UserControls
{
    partial class UC_student
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_studentName = new System.Windows.Forms.Label();
            this.pBox_studentPic = new System.Windows.Forms.PictureBox();
            this.lbl_studentNo = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_lastIn = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rBtn_absent = new System.Windows.Forms.RadioButton();
            this.rBtn_late = new System.Windows.Forms.RadioButton();
            this.rBtn_came = new System.Windows.Forms.RadioButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cBox_test = new System.Windows.Forms.ComboBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cBox_classwork = new System.Windows.Forms.ComboBox();
            this.pBox_dia1 = new System.Windows.Forms.PictureBox();
            this.pBox_dia3 = new System.Windows.Forms.PictureBox();
            this.pBox_dia2 = new System.Windows.Forms.PictureBox();
            this.pBox_cancelDia = new System.Windows.Forms.PictureBox();
            this.pBox_comment = new System.Windows.Forms.PictureBox();
            this.txt_comment = new System.Windows.Forms.RichTextBox();
            this.btn_addComment = new System.Windows.Forms.Button();
            this.lbl_comment = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_studentPic)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_dia1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_dia3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_dia2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_cancelDia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_comment)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel6, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel7, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel8, 6, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1181, 64);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbl_studentName);
            this.panel2.Controls.Add(this.pBox_studentPic);
            this.panel2.Controls.Add(this.lbl_studentNo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(289, 58);
            this.panel2.TabIndex = 0;
            // 
            // lbl_studentName
            // 
            this.lbl_studentName.AutoSize = true;
            this.lbl_studentName.Location = new System.Drawing.Point(83, 21);
            this.lbl_studentName.Name = "lbl_studentName";
            this.lbl_studentName.Size = new System.Drawing.Size(81, 15);
            this.lbl_studentName.TabIndex = 2;
            this.lbl_studentName.Text = "Student name";
            // 
            // pBox_studentPic
            // 
            this.pBox_studentPic.Location = new System.Drawing.Point(27, 3);
            this.pBox_studentPic.Name = "pBox_studentPic";
            this.pBox_studentPic.Size = new System.Drawing.Size(50, 50);
            this.pBox_studentPic.TabIndex = 1;
            this.pBox_studentPic.TabStop = false;
            // 
            // lbl_studentNo
            // 
            this.lbl_studentNo.AutoSize = true;
            this.lbl_studentNo.Location = new System.Drawing.Point(2, 21);
            this.lbl_studentNo.Name = "lbl_studentNo";
            this.lbl_studentNo.Size = new System.Drawing.Size(23, 15);
            this.lbl_studentNo.TabIndex = 0;
            this.lbl_studentNo.Text = "No";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbl_lastIn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(298, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(141, 58);
            this.panel3.TabIndex = 1;
            // 
            // lbl_lastIn
            // 
            this.lbl_lastIn.AutoSize = true;
            this.lbl_lastIn.Location = new System.Drawing.Point(59, 21);
            this.lbl_lastIn.Name = "lbl_lastIn";
            this.lbl_lastIn.Size = new System.Drawing.Size(23, 15);
            this.lbl_lastIn.TabIndex = 3;
            this.lbl_lastIn.Text = "No";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.rBtn_absent);
            this.panel4.Controls.Add(this.rBtn_late);
            this.panel4.Controls.Add(this.rBtn_came);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(445, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(141, 58);
            this.panel4.TabIndex = 2;
            // 
            // rBtn_absent
            // 
            this.rBtn_absent.AutoSize = true;
            this.rBtn_absent.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.rBtn_absent.Location = new System.Drawing.Point(93, 23);
            this.rBtn_absent.Name = "rBtn_absent";
            this.rBtn_absent.Size = new System.Drawing.Size(14, 13);
            this.rBtn_absent.TabIndex = 2;
            this.rBtn_absent.TabStop = true;
            this.rBtn_absent.UseVisualStyleBackColor = false;
            // 
            // rBtn_late
            // 
            this.rBtn_late.AutoSize = true;
            this.rBtn_late.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.rBtn_late.Location = new System.Drawing.Point(63, 23);
            this.rBtn_late.Name = "rBtn_late";
            this.rBtn_late.Size = new System.Drawing.Size(14, 13);
            this.rBtn_late.TabIndex = 1;
            this.rBtn_late.TabStop = true;
            this.rBtn_late.UseVisualStyleBackColor = false;
            // 
            // rBtn_came
            // 
            this.rBtn_came.AutoSize = true;
            this.rBtn_came.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.rBtn_came.Location = new System.Drawing.Point(33, 23);
            this.rBtn_came.Name = "rBtn_came";
            this.rBtn_came.Size = new System.Drawing.Size(14, 13);
            this.rBtn_came.TabIndex = 0;
            this.rBtn_came.TabStop = true;
            this.rBtn_came.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.cBox_test);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(592, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(141, 58);
            this.panel5.TabIndex = 3;
            // 
            // cBox_test
            // 
            this.cBox_test.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cBox_test.FormattingEnabled = true;
            this.cBox_test.Items.AddRange(new object[] {
            "   -",
            "   1",
            "   2",
            "   3",
            "   4",
            "   5",
            "   6",
            "   7",
            "   8",
            "   9",
            "   10",
            "   11",
            "   12"});
            this.cBox_test.Location = new System.Drawing.Point(40, 17);
            this.cBox_test.Name = "cBox_test";
            this.cBox_test.Size = new System.Drawing.Size(60, 25);
            this.cBox_test.TabIndex = 0;
            this.cBox_test.Text = "     -";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.cBox_classwork);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(739, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(141, 58);
            this.panel6.TabIndex = 4;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.pBox_cancelDia);
            this.panel7.Controls.Add(this.pBox_dia2);
            this.panel7.Controls.Add(this.pBox_dia3);
            this.panel7.Controls.Add(this.pBox_dia1);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(886, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(141, 58);
            this.panel7.TabIndex = 5;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.lbl_comment);
            this.panel8.Controls.Add(this.btn_addComment);
            this.panel8.Controls.Add(this.txt_comment);
            this.panel8.Controls.Add(this.pBox_comment);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(1033, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(145, 58);
            this.panel8.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1181, 2);
            this.panel1.TabIndex = 1;
            // 
            // cBox_classwork
            // 
            this.cBox_classwork.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cBox_classwork.FormattingEnabled = true;
            this.cBox_classwork.Items.AddRange(new object[] {
            "   -",
            "   1",
            "   2",
            "   3",
            "   4",
            "   5",
            "   6",
            "   7",
            "   8",
            "   9",
            "   10",
            "   11",
            "   12"});
            this.cBox_classwork.Location = new System.Drawing.Point(40, 17);
            this.cBox_classwork.Name = "cBox_classwork";
            this.cBox_classwork.Size = new System.Drawing.Size(60, 25);
            this.cBox_classwork.TabIndex = 1;
            this.cBox_classwork.Text = "     -";
            // 
            // pBox_dia1
            // 
            this.pBox_dia1.Image = global::WinForms_4.Properties.Resources.icons8_gem_stone_48__1_;
            this.pBox_dia1.Location = new System.Drawing.Point(13, 18);
            this.pBox_dia1.Name = "pBox_dia1";
            this.pBox_dia1.Size = new System.Drawing.Size(24, 24);
            this.pBox_dia1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBox_dia1.TabIndex = 1;
            this.pBox_dia1.TabStop = false;
            // 
            // pBox_dia3
            // 
            this.pBox_dia3.Image = global::WinForms_4.Properties.Resources.icons8_gem_stone_48__1_;
            this.pBox_dia3.Location = new System.Drawing.Point(73, 18);
            this.pBox_dia3.Name = "pBox_dia3";
            this.pBox_dia3.Size = new System.Drawing.Size(24, 24);
            this.pBox_dia3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBox_dia3.TabIndex = 2;
            this.pBox_dia3.TabStop = false;
            // 
            // pBox_dia2
            // 
            this.pBox_dia2.Image = global::WinForms_4.Properties.Resources.icons8_gem_stone_48__1_;
            this.pBox_dia2.Location = new System.Drawing.Point(43, 18);
            this.pBox_dia2.Name = "pBox_dia2";
            this.pBox_dia2.Size = new System.Drawing.Size(24, 24);
            this.pBox_dia2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBox_dia2.TabIndex = 3;
            this.pBox_dia2.TabStop = false;
            // 
            // pBox_cancelDia
            // 
            this.pBox_cancelDia.Image = global::WinForms_4.Properties.Resources.icons8_cross_mark_button_48;
            this.pBox_cancelDia.Location = new System.Drawing.Point(103, 18);
            this.pBox_cancelDia.Name = "pBox_cancelDia";
            this.pBox_cancelDia.Size = new System.Drawing.Size(24, 24);
            this.pBox_cancelDia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBox_cancelDia.TabIndex = 4;
            this.pBox_cancelDia.TabStop = false;
            // 
            // pBox_comment
            // 
            this.pBox_comment.Image = global::WinForms_4.Properties.Resources.icons8_comments_48;
            this.pBox_comment.Location = new System.Drawing.Point(12, 18);
            this.pBox_comment.Name = "pBox_comment";
            this.pBox_comment.Size = new System.Drawing.Size(24, 24);
            this.pBox_comment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBox_comment.TabIndex = 0;
            this.pBox_comment.TabStop = false;
            // 
            // txt_comment
            // 
            this.txt_comment.Location = new System.Drawing.Point(12, 10);
            this.txt_comment.Name = "txt_comment";
            this.txt_comment.Size = new System.Drawing.Size(78, 42);
            this.txt_comment.TabIndex = 1;
            this.txt_comment.Text = "";
            this.txt_comment.Visible = false;
            // 
            // btn_addComment
            // 
            this.btn_addComment.Location = new System.Drawing.Point(96, 10);
            this.btn_addComment.Name = "btn_addComment";
            this.btn_addComment.Size = new System.Drawing.Size(46, 43);
            this.btn_addComment.TabIndex = 2;
            this.btn_addComment.Text = "Add";
            this.btn_addComment.UseVisualStyleBackColor = true;
            this.btn_addComment.Visible = false;
            // 
            // lbl_comment
            // 
            this.lbl_comment.AutoSize = true;
            this.lbl_comment.Location = new System.Drawing.Point(42, 18);
            this.lbl_comment.Name = "lbl_comment";
            this.lbl_comment.Size = new System.Drawing.Size(0, 15);
            this.lbl_comment.TabIndex = 4;
            // 
            // UC_student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UC_student";
            this.Size = new System.Drawing.Size(1181, 64);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_studentPic)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_dia1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_dia3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_dia2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_cancelDia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_comment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private Label lbl_studentName;
        private PictureBox pBox_studentPic;
        private Label lbl_studentNo;
        private Label lbl_lastIn;
        private RadioButton rBtn_absent;
        private RadioButton rBtn_late;
        private ComboBox cBox_test;
        private ComboBox cBox_classwork;
        private PictureBox pBox_comment;
        private Button btn_addComment;
        private RichTextBox txt_comment;
        public RadioButton rBtn_came;
        public PictureBox pBox_cancelDia;
        public PictureBox pBox_dia2;
        public PictureBox pBox_dia3;
        public PictureBox pBox_dia1;
        private Label lbl_comment;
    }
}
