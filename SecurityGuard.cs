using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class SecurityGuard : Community
    {
        private byte _experienceYears;
        private uint _salary;
        private byte _workingHours;


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

        public uint Salary
        {
            get => _salary;
            set
            {
                if (value >= 12000 && value <= 18000)
                {
                    _salary = value;
                }
                else
                {
                    throw new FormatException("Incorrect salary.");
                }
            }
        }

        public byte WorkingHours
        {
            get => _workingHours;
            set
            {
                if (value > 1 && value < 9)
                {
                    _workingHours = value;
                }
                else
                {
                    throw new FormatException("Incorrect salary.");
                }
            }
        }

        public SecurityGuard(string name, byte age, bool gender, string address, string contact, byte experienceYears, uint salary, byte workingHours) : base(name, age, gender, address, contact)
        {
            ExperienceYears = experienceYears;
            Salary = salary;
            WorkingHours = workingHours;
        }

        public override string ToString()
        {
            return "Security Guard:" + base.ToString() + $"\nExperience: {ExperienceYears};\nSalary: {Salary};\nWork time: {WorkingHours};\n\n";
        }
    }
}
