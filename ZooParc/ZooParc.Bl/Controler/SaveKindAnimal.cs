using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using ZooParc.Bl.Model;

namespace ZooParc.Bl.Controler
{
    /// <summary>
    /// Сохранение вида животного
    /// </summary>
    public class SaveKindAnimal
    {
        /// <summary>
        /// Вид животного
        /// </summary>
        public KindOfAnimal KindOfAnimal { get; set; }
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="kindOfAnimal">Вид животного</param>
        /// <param name="kindOfAnimal">Вид животного</param>

        public SaveKindAnimal(KindOfAnimal kindOfAnimal)
        {

            KindOfAnimal = kindOfAnimal;
        }
        /// <summary>
        /// Сохранение в бинарном виде
        /// </summary>
        /// <param name="path">Путь</param>
        public void SaveKindOfAnimalBinnary(string path)
        {
            var formatter = new BinaryFormatter();
            using (FileStream fstream = new FileStream($"{path}", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fstream, KindOfAnimal);
            }
        }
        /// <summary>
        /// Сохранение в текстовом виде
        /// </summary>
        /// <param name="path">Путь</param>
        public void SaveKindOfAnimalTxt(string path)
        {
            using (var sw = new StreamWriter($"{path}", true, System.Text.Encoding.Default))
            {
                sw.WriteLine(KindOfAnimal.Name_kind);
                sw.WriteLine(KindOfAnimal.AnimalFamily.Name_famaly);
                sw.WriteLine(KindOfAnimal.AnimalFamily.Count_animal);
                sw.WriteLine(KindOfAnimal.Continent);
                
            }
        }
    }
}
