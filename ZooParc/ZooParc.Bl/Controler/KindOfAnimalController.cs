using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using ZooParc.Bl.Model;

namespace ZooParc.Bl.Controler
{
    /// <summary>
    /// Вид животного
    /// </summary>
    public class KindOfAnimalController
    {
        /// <summary>
        /// Название вида
        /// </summary>
        public KindOfAnimal KindOfAnimal { get; set; }
        /// <summary>
        /// Путь бинарного файла
        /// </summary>
        public string PathBin { get; set; }
        /// <summary>
        /// Путь к текстовому файлу
        /// </summary>
        public string PathTxt { get; set; }
        /// <summary>
        /// Создание вида животного
        /// </summary>
        /// <param name="name_kind">Название вида</param>
        /// <param name="name_famaly">Название семейства</param>
        /// <param name="number_of_animals">Численность</param>
        /// <param name="continent">Континент</param>
        public KindOfAnimalController(string name_kind, string name_famaly, int number_of_animals, string continent)
        {
            #region Проверка данных
            if (string.IsNullOrWhiteSpace(name_kind))
            {
                throw new ArgumentNullException("Имя вида не может быть пустым или null", nameof(name_kind));
            }
            if (string.IsNullOrWhiteSpace(name_famaly))
            {
                throw new ArgumentNullException("Имя семейства не может быть пустым или null", nameof(name_famaly));
            }
            if(number_of_animals<0)
            {
                throw new ArgumentException("Численность животных не может быть отрицательной или null", nameof(number_of_animals));
            }
            if(string.IsNullOrWhiteSpace(continent))
            {
                throw new ArgumentNullException("Имя континента не может быть пустым или null", nameof(continent));
            }
            #endregion

            AnimalFamily animalfamyly = new AnimalFamily(name_famaly, number_of_animals);

            KindOfAnimal = new KindOfAnimal(name_kind, animalfamyly, continent);
        }
        /// <summary>
        /// Создание вида животного с помощью чтения бинарного файла 
        /// </summary>
        /// <param name="path"></param>
        public KindOfAnimalController(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
            {
                throw new ArgumentNullException("Путь не может быть пустым или null", nameof(path));
            }
            
            var formatter = new BinaryFormatter();
            using (FileStream fstream = new FileStream($"{path}", FileMode.Open))
            {
                if (formatter.Deserialize(fstream) is KindOfAnimal kindOfAnimal)
                {
                    KindOfAnimal = kindOfAnimal;
                }
            }
            // TODO: Что то с лоад если не открывается
        }
        /// <summary>
        /// Сохранение в бинарном виде
        /// </summary>
        /// <param name="path">Путь</param>
        public void SaveBinnary(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
            {
                throw new ArgumentNullException("Путь не может быть пустым или null", nameof(path));
            }

            PathBin = path;
            var sc = new SaveKindAnimal(KindOfAnimal);
            sc.SaveKindOfAnimalBinnary(path);
        }
        /// <summary>
        /// Сохранение в текстовом виде
        /// </summary>
        /// <param name="path"></param>
        public void SaveTxt(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
            {
                throw new ArgumentNullException("Путь не может быть пустым или null", nameof(path));
            }

            PathTxt = path;
            var sc = new SaveKindAnimal(KindOfAnimal);
            sc.SaveKindOfAnimalTxt(path);
        }
    }
}

