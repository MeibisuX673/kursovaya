using System;


namespace ZooParc_Lib.Model
{
    [Serializable]
    /// <summary>
    /// Вид животного
    /// </summary>
    public class KindOfAnimal
    {
        /// <summary>
        /// Название вида
        /// </summary>
        public string Name_kind { get; set; }
        // TODO: Суточное потребления корма
        /// <summary>
        /// Суточное потребление корма
        /// </summary>
        public double DailyFeedIntake { get { return DailyFeedIntake; } set { DailyFeedIntake = 320 * Math.Pow(100, 0.75); } }

        /// <summary>
        /// Название симейства
        /// </summary>
        public AnimalFamily AnimalFamily { get; set; }
        /// <summary>
        /// Континент обитания
        /// </summary>
        public string Continent { get; set; }
        /// <summary>
        /// Создание вида животного
        /// </summary>
        /// <param name="name_kind">Название вида</param>
        /// <param name="animalFamily">Названия семейства</param>
        /// <param name="continent">Континент обитания</param>
        public KindOfAnimal(string name_kind, AnimalFamily animalFamily, string continent)
        {
            Name_kind = name_kind;
            AnimalFamily = animalFamily;
            Continent = continent;
        }
    }
}
