using System;
using System.Text.RegularExpressions;

namespace Lab5
{
    /// <summary>
    /// Класс School содержит общую информацию о школе.
    /// </summary>
    internal class School
    {
        private string _name;
        private byte _age;
        private bool _gender;
        private string _address;
        private string _contact;
        private const byte MAX_YEAR = 100;

        /// <summary>
        /// Установка и получение поля _name.
        /// </summary>
        public string Name
        {
            get => _name;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _name = value.Trim();
                }
                else
                {
                    throw new FormatException("Incorrect name.");
                }
            }
        }

        /// <summary>
        /// Установка и получение поля _age.
        /// </summary>
        public byte Age
        {
            get => _age;
            set
            {
                if (value < MAX_YEAR)
                {
                    _age = value;
                }
                else
                {
                    throw new FormatException("Incorrect age.");
                }
            }
        }

        /// <summary>
        /// Установка и получение поля _gender.
        /// </summary>
        public bool Gender
        {
            get => _gender;
            set => _gender = value;
        }

        /// <summary>
        /// Установка и получение поля _address.
        /// </summary>
        public string Address
        {
            get => _address;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _address = char.ToUpper(value[0]) + value.Substring(1).ToLower().Trim();
                }

                else
                {
                    throw new FormatException("Incorrect address.");
                }
            }
        }

        /// <summary>
        /// Установка и получение поля _contact.
        /// Номер телефона в формате +************
        /// </summary>
        public string Contact
        {
            get => _contact;
            set
            {
                if ((!string.IsNullOrEmpty(value)) && (Regex.IsMatch(value, @"^\+\d{12}$")))
                {
                    _contact = value.Trim();
                }
                else
                {
                    throw new FormatException("Incorrect phone number");
                }
            }
        }

        //gender - true men, false woman
        /// <summary>
        /// Создает новый экземпляр класса School с заданными значениями.
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="age">Возраст</param>
        /// <param name="gender">Гендер (true men, false woman)</param>
        /// <param name="address">Адрес проживания</param>
        /// <param name="contact">Номер телефона</param>
        public School(string name, byte age, bool gender, string address, string contact)
        {
            Name = name;
            Age = age;
            Gender = gender;
            Address = address;
            Contact = contact;
        }
    }
}
