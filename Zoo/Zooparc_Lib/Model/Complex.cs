using System;

namespace ZooParc_Lib.Model
{

    /// <summary>
    /// Комплекс
    /// </summary>
    [Serializable]

    public class Complex
    {
        /// <summary>
        /// Название комплекса.
        /// </summary>
        public string Name_complex { get; }
        /// <summary>
        /// Номер помещения.
        /// </summary>
        public int Number_room { get; }
        /// <summary>
        /// Наличие водоема.
        /// </summary>
        public bool Water { get; set; }
        /// <summary>
        /// Наличие отопления. 
        /// </summary>
        public bool Heating { get; set; }
        /// <summary>
        /// Колличество животных в помещении
        /// </summary>
        public int Count_animal { get; set; }
        /// <summary>
        /// Создание комалекса
        /// </summary>
        /// <param name="name_complex">Название комплекса</param>
        /// <param name="number_room">Номер помещения</param>
        /// <param name="water">Наличие водоема</param>
        /// <param name="heating">Наличие отопления</param>
        /// <param name="count_animal">Колличество животных в помещении</param>
        public Complex(string name_complex, int number_room, bool water, bool heating, int count_animal)
        {
            Name_complex = name_complex;
            Number_room = number_room;
            Water = water;
            Heating = heating;
            Count_animal = count_animal;
        }

    }
}

