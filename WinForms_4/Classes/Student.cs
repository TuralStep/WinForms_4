using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_4.Classes
{
    public class Student
    {

        public int Id { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FatherName { get; set; }
        public DateTime LastInMystat { get; set; }
        public StudentStatus Status { get; set; }
        public byte TestGrade { get; set; }
        public byte ClassworkGrade { get; set; }
        public byte DiaCount { get; set; }
        public string Comment { get; set; }

        public string FullName => $"{Name} {Surname} {FatherName}";

        public Student(int id, string image, string name, string surname, string fatherName, DateTime lastInMystat, StudentStatus status, byte testGrade, byte classworkGrade, byte diaCount, string comment)
        {
            Id = id;
            Image = image;
            Name = name;
            Surname = surname;
            FatherName = fatherName;
            LastInMystat = lastInMystat;
            Status = status;
            TestGrade = testGrade;
            ClassworkGrade = classworkGrade;
            DiaCount = diaCount;
            Comment = comment;
        }
    }

    public enum StudentStatus
    {
        Unknown,
        Came,
        Late,
        Absent
    }

}
