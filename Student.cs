using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class Student : Community
    {
        //grade - класс
        //mark - оценка
        private byte _mark;
        private byte _grade;
        private string _id;

        public byte Mark
        {
            get => _mark;
            set
            {
                if (value > 0 && value < 13)
                {
                    _mark = value;
                }
                else
                {
                    throw new FormatException("Incorrect mark.");
                }
            }
        }

        public string Id
        {
            get => _id;
            set
            {
                if (!string.IsNullOrEmpty(value) && value.Length >= 5)
                {
                    _id = (value.ToUpper()).Trim();
                }
                else
                {
                    throw new FormatException("Incorrect id.");
                }
            }
        }

        public byte Grade
        {
            get => _grade;
            set
            {
                if (value > 0 && value < 12)
                {
                    _grade = value;
                }
                else
                {
                    throw new FormatException("Incorrect grade.");
                }
            }
        }

        public Student(string name, byte age, bool gender, string address, string contact, byte mark, string id, byte grade) : base(name, age, gender, address, contact)
        {
            Mark = mark;
            Id = id;
            Grade = grade;
        }
        public override string ToString()
        {
            return "Student:" + base.ToString() + $"\nMark: {Mark};\nStudent ID: {Id};\nGrade(Class): {Grade};\n\n";
        }
    }
}
