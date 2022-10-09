using WinForms_4.Classes;
using WinForms_4.UserControls;

namespace WinForms_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Student> students = new()
            {
                new Student(1, "./../../../Resources/maleAvatar.png", "Tural", "Haji-Nabili", "Mahir", new DateTime(2022, 10, 9), StudentStatus.Unknown, 0, 0, 0, ""),
                new Student(2, "./../../../Resources/femaleAvatar.png", "Aylin", "Ehmedli", "Kenan", new DateTime(2022, 10, 8), StudentStatus.Unknown, 0, 0, 0, ""),
                new Student(3, "./../../../Resources/maleAvatar.png", "Nadir", "Hemidov", "Turan", new DateTime(2022, 10, 6), StudentStatus.Unknown, 0, 0, 0, ""),
                new Student(4, "./../../../Resources/maleAvatar.png", "Nazim", "Nerimanov", "Yusif", new DateTime(2022, 10, 5), StudentStatus.Unknown, 0, 0, 0, ""),
                new Student(5, "./../../../Resources/femaleAvatar.png", "Zeyneb", "Feteliyeva", "Islam", new DateTime(2022, 10, 7), StudentStatus.Unknown, 0, 0, 0, "")
            };

            foreach (var item in students)
            {
                UC_student ucStudent = new UC_student(item);
                ucStudent.DisableEverything();
                pnl_students.Controls.Add(ucStudent);
            }

        }
    }
}