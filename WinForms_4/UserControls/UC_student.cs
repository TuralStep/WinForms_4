using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms_4.Classes;
using WinForms_4.Properties;

namespace WinForms_4.UserControls
{
    public partial class UC_student : UserControl
    {
        public UC_student(Student s)
        {
            InitializeComponent();

            lbl_studentNo.Text = s.Id.ToString();
            pBox_studentPic.Load(s.Image);
            lbl_studentName.Text = s.FullName;

            lbl_lastIn.Text = s.LastInMystat.ToShortDateString();

            rBtn_came.Checked = s.Status == StudentStatus.Came;
            rBtn_late.Checked = s.Status == StudentStatus.Late;
            rBtn_absent.Checked = s.Status == StudentStatus.Absent;

            cBox_test.SelectedIndex = s.TestGrade;
            cBox_classwork.SelectedIndex = s.ClassworkGrade;

            switch (s.DiaCount)
            {
                case 0:
                    isIt1 = isIt2 = isIt3 = false;
                    pBox_dia3.Image = Resources.icons8_gem_stone_48__1_;
                    pBox_dia2.Image = Resources.icons8_gem_stone_48__1_;
                    pBox_dia1.Image = Resources.icons8_gem_stone_48__1_;
                    break;
                case 1:
                    isIt1 = true;
                    isIt3 = isIt2 = !isIt1;
                    pBox_dia3.Image = Resources.icons8_gem_stone_48__1_;
                    pBox_dia2.Image = Resources.icons8_gem_stone_48__1_;
                    pBox_dia1.Image = Resources.icons8_gem_stone_48;
                    break;
                case 2:
                    isIt2 = true;
                    isIt3 = isIt1 = !isIt2;
                    pBox_dia3.Image = Resources.icons8_gem_stone_48__1_;
                    pBox_dia2.Image = Resources.icons8_gem_stone_48;
                    pBox_dia1.Image = Resources.icons8_gem_stone_48;
                    break;
                case 3:
                    isIt3 = true;
                    isIt2 = isIt1 = !isIt3;
                    pBox_dia3.Image = Resources.icons8_gem_stone_48;
                    pBox_dia2.Image = Resources.icons8_gem_stone_48;
                    pBox_dia1.Image = Resources.icons8_gem_stone_48;
                    break;
            }

            lbl_comment.Text = s.Comment;

        }

        bool isIt3 = false;
        bool isIt2 = false;
        bool isIt1 = false;
        bool canUse = true;

        private void pBox_dia3_Click(object sender, EventArgs e)
        {
            if (!isIt3 && canUse)
            {
                isIt3 = true;
                isIt2 = isIt1 = !isIt3;
                pBox_dia3.Image = Resources.icons8_gem_stone_48;
                pBox_dia2.Image = Resources.icons8_gem_stone_48;
                pBox_dia1.Image = Resources.icons8_gem_stone_48;
            }
        }

        private void pBox_dia2_Click(object sender, EventArgs e)
        {
            if (!isIt2 && canUse)
            {
                isIt2 = true;
                isIt3 = isIt1 = !isIt2;
                pBox_dia3.Image = Resources.icons8_gem_stone_48__1_;
                pBox_dia2.Image = Resources.icons8_gem_stone_48;
                pBox_dia1.Image = Resources.icons8_gem_stone_48;
            }
        }

        private void pBox_dia1_Click(object sender, EventArgs e)
        {
            if (!isIt1 && canUse)
            {
                isIt1 = true;
                isIt3 = isIt2 = !isIt1;
                pBox_dia3.Image = Resources.icons8_gem_stone_48__1_;
                pBox_dia2.Image = Resources.icons8_gem_stone_48__1_;
                pBox_dia1.Image = Resources.icons8_gem_stone_48;
            }
        }

        private void pBox_cancelDia_Click(object sender, EventArgs e)
        {
            if (!canUse)
                return;

            isIt1 = isIt2 = isIt3 = false;
            pBox_dia3.Image = Resources.icons8_gem_stone_48__1_;
            pBox_dia2.Image = Resources.icons8_gem_stone_48__1_;
            pBox_dia1.Image = Resources.icons8_gem_stone_48__1_;
        }

        private void pBox_addComment_Click(object sender, EventArgs e)
        {
            if (!canUse)
                return;

            txt_comment.Text = lbl_comment.Text;
            txt_comment.Visible = true;
            btn_addComment.Visible = true;
        }

        private void btn_addComment_Click(object sender, EventArgs e)
        {
            if (!canUse)
                return;

            lbl_comment.Text = txt_comment.Text;
            txt_comment.Visible = false;
            btn_addComment.Visible = false;
        }


        public void EnableEverything()
        {
            rBtn_came.Enabled = false;
            rBtn_late.Enabled = false;
            rBtn_absent.Enabled = false;

            cBox_test.Enabled = false;
            cBox_classwork.Enabled = false;

            canUse = false;

        }

        public void DisableEverything()
        {
            rBtn_came.Enabled = true;
            rBtn_late.Enabled = true;
            rBtn_absent.Enabled = true;

            cBox_test.Enabled = true;
            cBox_classwork.Enabled = true;

            canUse = true;
        }

    }
}
