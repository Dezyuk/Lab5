using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab5
{
    internal class School
    {
        private string _name;
        private byte _age;
        private bool _gender;
        private string _address;
        private string _contact;

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
        public byte Age
        {
            get => _age;
            set
            {
                if (value > 0)
                {
                    _age = value;
                }
                else
                {
                    throw new FormatException("Incorrect age.");
                }
            }
        }
        public bool Gender
        {
            get => _gender;
            set => _gender = value;
        }
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
        public School(string name, byte age, bool gender, string address, string contact)
        {
            Name = name;
            Age = age;
            Gender = gender;
            Address = address;
            Contact = contact;
        }

        //public override string ToString()
        //{
        //    return Gender ? $"\nName: {Name};\nAge: {Age};\nGender: Man;\nAddress: {Address};\nContact: {Contact};" :
        //    $"\nName: {Name};\nAge: {Age};\nGender: Woman;\nAddress: {Address};\nContact: {Contact};";
        //}
    }
}
