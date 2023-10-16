using System;

namespace Lab5
{
    /// <summary>
    /// Базовый класс-агрегат, который состоит из общей информации о школе.
    /// Также содержит коллекцию людей, связанных со школой.
    /// </summary>
    internal class School
    {
        private Person[] _people;

        /// <summary>
        /// Создает массив, который будет содержать людей, связанных со школой.
        /// </summary>
        public School()
        {
            _people = new Person[0];
        }

        /// <summary>
        /// Добавление объекта в массив.
        /// </summary>
        /// <param name="person">Экземпляр класса Person или производных от него классов.</param>
        public void AddPerson(Person person)
        {
            if(person is null)
            {
                throw new FormatException("Incorrect person parameter.");
            }
            else
            {
                Array.Resize(ref _people, _people.Length + 1);
                _people[_people.Length - 1] = person;
            }
            
        }

        /// <summary>
        /// Удаление объекта из массива.
        /// </summary>
        /// <param name="personId">Индекс элемента который необходимо удалить.</param>
        public void DeletePerson(int personId)
        {
            if (personId >= 0 && personId < _people.Length)
            {
                Array.Copy(_people, personId + 1, _people, personId, _people.Length - personId - 1);
                Array.Resize(ref _people, _people.Length - 1);
            }
        }

        /// <summary>
        /// Изменение элементов массива (реализована замена одного элемента на переданный новый, так как возможно изменять поля объектов напрямую).
        /// </summary>
        /// <param name="index">Индекс элемента который необходимо заменить.</param>
        /// <param name="element">Новый элемент.</param>
        /// <exception cref="FormatException"></exception>
        public void EditCommunity(uint index, Person element)
        {
            if (index >= 0 && index < People.Length && !(element is null))
            {
                People[index] = element;
            }
            else
            {
                throw new FormatException("Incorrect array index, or person parameter");
            }
        }
        public Person[] People => _people;

    }
}
