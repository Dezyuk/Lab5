using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class Teacher : Community
    {
        private string _subject;
        private byte _experienceYears;
        private string _qualification;
        public string Subject
        {
            get => _subject;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _subject = char.ToUpper(value[0]) + value.Substring(1).ToLower().Trim();
                }

                else
                {
                    throw new FormatException("Incorrect subject.");
                }
            }
        }
        public byte ExperienceYears
        {
            get => _experienceYears;
            set
            {
                if (value >= 0)
                {
                    _experienceYears = value;
                }
                else
                {
                    throw new FormatException("Incorrect experience year.");
                }
            }
        }
        public string Qualification
        {
            get => _qualification;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _qualification = char.ToUpper(value[0]) + value.Substring(1).ToLower().Trim();
                }

                else
                {
                    throw new FormatException("Incorrect qualification.");
                }
            }
        }

        public Teacher(string name, byte age, bool gender, string address, string contact, string subject, byte experienceYears, string qualification) : base(name, age, gender, address, contact)
        {
            Subject = subject;
            ExperienceYears = experienceYears;
            Qualification = qualification;
        }

        public override string ToString()
        {
            return "Teacher:" + base.ToString() + $"\nSubject: {Subject};\nExpirience: {ExperienceYears};\nQualification: {Qualification};\n\n";
        }
    }
}
