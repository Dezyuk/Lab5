using System;

namespace Lab5
{
    /// <summary>
    /// Класс Teacher. Содержит свойства Teacher, а также имитирует свойства класса Community
    /// </summary>
    internal class Teacher : Person
    {
        private string _subject;
        private byte _experienceYears;
        private string _qualification;

        /// <summary>
        /// Установка и получение поля _subject(Преподаваемый предмет).
        /// </summary>
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

        /// <summary>
        /// Установка и получение поля _experienceYears(Опыт работы).
        /// </summary>
        public byte ExperienceYears
        {
            get => _experienceYears;
            set => _experienceYears = value;
        }

        /// <summary>
        /// Установка и получение поля _qualification(Квалификация).
        /// </summary>
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

        /// <summary>
        /// Создает новый экземпляр класса Teacher и наследует свойства Community.
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="age">Возраст</param>
        /// <param name="gender">Гендер (true men, false woman)</param>
        /// <param name="address">Адрес проживания</param>
        /// <param name="contact">Номер телефона</param>
        /// <param name="subject">Предмет который ведёт преподаватель</param>
        /// <param name="experienceYears">Опыт работы</param>
        /// <param name="qualification">Квалификация</param>
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
