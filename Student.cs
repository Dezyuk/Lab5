using System;

namespace Lab5
{
    /// <summary>
    /// Класс Student. Содержит свойства Student, а также имитирует свойства класса Community
    /// </summary>
    internal class Student : Person
    {
        private byte _mark;
        private byte _grade;
        private string _id;
        private const byte MAX_MARK = 12;
        private const byte MIN_MARK = 1;
        private const byte MAX_GRADE = 11;
        private const byte MIN_GRADE = 1;
        private const byte MIN_ID_LENGHT = 5;

        /// <summary>
        /// Установка и получение поля _mark(Оценка).
        /// </summary>
        public byte Mark
        {
            get => _mark;
            set
            {
                if (value >= MIN_MARK && value <= MAX_MARK)
                {
                    _mark = value;
                }
                else
                {
                    throw new FormatException("Incorrect mark.");
                }
            }
        }

        /// <summary>
        /// Установка и получение поля _id(ID ученика).
        /// </summary>
        public string Id
        {
            get => _id;
            set
            {
                if (!string.IsNullOrEmpty(value) && value.Length >= MIN_ID_LENGHT)
                {
                    _id = (value.ToUpper()).Trim();
                }
                else
                {
                    throw new FormatException("Incorrect id.");
                }
            }
        }

        /// <summary>
        /// Установка и получение поля _grade(Класс в котором учится ученик).
        /// </summary>
        public byte Grade
        {
            get => _grade;
            set
            {
                if (value >= MIN_GRADE && value <= MAX_GRADE)
                {
                    _grade = value;
                }
                else
                {
                    throw new FormatException("Incorrect grade.");
                }
            }
        }

        /// <summary>
        /// Создает новый экземпляр класса Student и наследует свойства Community.
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="age">Возраст</param>
        /// <param name="gender">Гендер (true men, false woman)</param>
        /// <param name="address">Адрес проживания</param>
        /// <param name="contact">Номер телефона</param>
        /// <param name="mark">Оценка</param>
        /// <param name="id">Айди ученика</param>
        /// <param name="grade">Класс</param>
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
