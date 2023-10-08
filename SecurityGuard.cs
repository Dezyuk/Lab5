using System;

namespace Lab5
{
    /// <summary>
    /// Класс SecurityGuard. Содержит свойства SecurityGuard, а также имитирует свойства класса Community
    /// </summary>
    internal class SecurityGuard : Community
    {
        private byte _experienceYears;
        private uint _salary;
        private byte _workingHours;
        private const byte MIN_EXPERIENCE_YEAR = 0;
        private const byte MIN_WORK_HOURS = 1;
        private const byte MAX_WORK_HOURS = 9;
        private const int MIN_SALARY = 12000;
        private const int MAX_SALARY = 18000;

        /// <summary>
        /// Установка и получение поля _experienceYears.
        /// </summary>
        public byte ExperienceYears
        {
            get => _experienceYears;
            set
            {
                if (value >= MIN_EXPERIENCE_YEAR)
                {
                    _experienceYears = value;
                }
                else
                {
                    throw new FormatException("Incorrect experience year.");
                }
            }
        }

        /// <summary>
        /// Установка и получение поля _salary.
        /// </summary>
        public uint Salary
        {
            get => _salary;
            set
            {
                if (value >= MIN_SALARY && value <= MAX_SALARY)
                {
                    _salary = value;
                }
                else
                {
                    throw new FormatException("Incorrect salary.");
                }
            }
        }

        /// <summary>
        /// Установка и получение поля _workingHours.
        /// </summary>
        public byte WorkingHours
        {
            get => _workingHours;
            set
            {
                if (value > MIN_WORK_HOURS && value < MAX_WORK_HOURS)
                {
                    _workingHours = value;
                }
                else
                {
                    throw new FormatException("Incorrect salary.");
                }
            }
        }

        /// <summary>
        /// Создает новый экземпляр класса SecurityGuard и наследует свойства Community.
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="age">Возраст</param>
        /// <param name="gender">Гендер (true men, false woman)</param>
        /// <param name="address">Адрес проживания</param>
        /// <param name="contact">Номер телефона</param>
        /// <param name="experienceYears">Опыт работы</param>
        /// <param name="salary">Зарплата</param>
        /// <param name="workingHours">Рабочие часы</param>
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
