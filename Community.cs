using System;

namespace Lab5
{
    /// <summary>
    /// Базовый класс-агрегат, который состоит из общей информации о школе.
    /// Также содержит коллекцию людей, связанных со школой.
    /// </summary>
    internal class Community
    {
        private School _school;
        private Community[] _community;

        /// <summary>
        /// Создает новый экземпляр класса Community, объединяющий экземпляр класса School.
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="age">Возраст</param>
        /// <param name="gender">Гендер (true men, false woman)</param>
        /// <param name="address">Адрес проживания</param>
        /// <param name="contact">Номер телефона</param>
        public Community(string name, byte age, bool gender, string address, string contact)
        {
            _school = new School(name, age, gender, address, contact);
        }

        /// <summary>
        /// Создает массив, который будет содержать людей, связанных со школой.
        /// </summary>
        public Community()
        {
            _community = new Community[0];
        }

        /// <summary>
        /// Добавление объекта в массив.
        /// </summary>
        /// <param name="community">Экземпляр класса Community или производных от него классов.</param>
        public void AddPerson(Community community)
        {
            Array.Resize(ref _community, _community.Length + 1);
            _community[_community.Length - 1] = community;
        }

        /// <summary>
        /// Удаление объекта из массива.
        /// </summary>
        /// <param name="personId">Индекс элемента который необходимо удалить.</param>
        public void DeletePerson(int personId)
        {
            if (personId >= 0 && personId < _community.Length)
            {
                Array.Copy(_community, personId + 1, _community, personId, _community.Length - personId - 1);
                Array.Resize(ref _community, _community.Length - 1);
            }
        }

        /// <summary>
        /// Изменение элементов массива (реализована замена одного элемента на переданный новый, так как возможно изменять поля объектов напрямую).
        /// </summary>
        /// <param name="index">Индекс элемента который необходимо заменить.</param>
        /// <param name="element">Новый элемент.</param>
        /// <exception cref="FormatException"></exception>
        public void EditCommunity(uint index, Community element)
        {
            if (index >= 0 && index < SchoolCommunity.Length)
            {
                SchoolCommunity[index] = element;
            }
            else
            {
                throw new FormatException("Incorrect array index.");
            }
        }

        /// <summary>
        /// Возвращает значение _community.
        /// </summary>
        public Community[] SchoolCommunity => _community;

        /// <summary>
        /// Возвращает значение _school.
        /// </summary>
        public School School => _school;

        public override string ToString()
        {
            return _school.Gender ? $"\nName: {_school.Name};\nAge: {_school.Age};\nGender: Man;\nAddress: {_school.Address};\nContact: {_school.Contact};" :
            $"\nName: {_school.Name};\nAge: {_school.Age};\nGender: Woman;\nAddress: {_school.Address};\nContact: {_school.Contact};";
        }
    }
}
