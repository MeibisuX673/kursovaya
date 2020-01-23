using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using ZooParc_Lib.Model;

namespace ZooParc_Lib.Controler
{
    /// <summary>
    /// Контроллер комплекса
    /// </summary>
    public class ComplexController
    {


        /// <summary>
        /// Путь бинарного файла
        /// </summary>
        public string PathBin { get; set; }
        /// <summary>
        /// Путь текстового файла
        /// </summary>
        public string PathTxt { get; set; }
        /// <summary>
        /// Комплекс
        /// </summary>
        public Complex Complex { get; set; }
        /// <summary>
        /// Создание Комплекса
        /// </summary>
        /// <param name="complex_name">Название комплекса</param>
        /// <param name="number_room">Номер помещения</param>
        /// <param name="water">Наличие водоема</param>
        /// <param name="heating">Наличие отопления</param>
        /// <param name="count_animal">Колличество животных в помещении</param>
        public ComplexController(string complex_name, int number_room, bool water, bool heating, int count_animal)
        {

            #region Проверка данных
            if (string.IsNullOrWhiteSpace(complex_name))
            {
                throw new ArgumentNullException("Имя комплекса не может быть пустым", nameof(complex_name));
            }
            if (number_room < 0)
            {
                throw new ArgumentException("Номер помещения не может быть отрицательным либо null", nameof(number_room));
            }
            //if (water != true || water != false)
            //{
            //    throw new ArgumentException("Неверно введенные данные", nameof(water));
            //}
            //if (heating != true || heating != false)
            //{
            //    throw new ArgumentException("Неверно введенные данные", nameof(heating));
            //}
            if (count_animal < 0)
            {
                throw new ArgumentException("Колличество животных не может быть отрицательным", nameof(count_animal));
            }
            #endregion

            Complex = new Complex(complex_name, number_room, water, heating, count_animal);

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
            var sc = new SaveComplex(Complex);
            sc.SaveComplexBinnary(path);

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
            var sc = new SaveComplex(Complex);
            sc.SaveComplexTxt(path);
        }
        /// <summary>
        /// Создание комплекса
        /// </summary>
        public ComplexController(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
            {
                throw new ArgumentNullException("Путь не может быть пустым или null", nameof(path));
            }

            var formatter = new BinaryFormatter();
            using (FileStream fstream = new FileStream($"{path}", FileMode.Open))
            {
                if (formatter.Deserialize(fstream) is Complex complex)
                {
                    Complex = complex;
                }
            }
            // TODO: Что то с лоад если не открывается
        }

    }


}
