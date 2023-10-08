using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class Community
    {
        private School _school;
        private Community[] _community;

        public Community(string name, byte age, bool gender, string address, string contact)
        {
            _school = new School(name, age, gender, address, contact);
        }

        public Community()
        {
            _community = new Community[0];
        }

        public void AddPerson(Community community)
        {
            Array.Resize(ref _community, _community.Length + 1);
            _community[_community.Length - 1] = community;
        }

        public void DeletePerson(int personId)
        {
            if (personId >= 0 && personId < _community.Length)
            {
                Array.Copy(_community, personId + 1, _community, personId, _community.Length - personId - 1);
                Array.Resize(ref _community, _community.Length - 1);
            }
        }



        public Community[] SchoolCommunity => _community;
        public School School { get { return _school; } }

        public override string ToString()
        {
            return _school.Gender ? $"\nName: {_school.Name};\nAge: {_school.Age};\nGender: Man;\nAddress: {_school.Address};\nContact: {_school.Contact};" :
            $"\nName: {_school.Name};\nAge: {_school.Age};\nGender: Woman;\nAddress: {_school.Address};\nContact: {_school.Contact};";
        }
    }
}
