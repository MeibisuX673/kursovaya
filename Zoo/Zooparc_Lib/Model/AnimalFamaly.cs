using System;


namespace ZooParc_Lib.Model
{
    [Serializable]
    /// <summary>
    /// Семейство животных
    /// </summary>
    public class AnimalFamily
    {
        /// <summary>
        /// Название семейства.
        /// </summary>
        public string Name_famaly { get; set; }
        /// <summary>
        /// Численность.
        /// </summary>
        public int Count_animal { get; set; }
        /// <summary>
        /// Создание семейства.
        /// </summary>
        /// <param name="name">Название семейства</param>
        /// <param name="count_animal">Численность</param>
        public AnimalFamily(string name, int count_animal)
        {
            Name_famaly = name;
            Count_animal = count_animal;
        }
    }
}
