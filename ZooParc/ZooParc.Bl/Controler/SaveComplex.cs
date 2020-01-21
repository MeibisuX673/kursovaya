using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using ZooParc.Bl.Controler;

namespace ZooParc.Bl.Model
{
    /// <summary>
    /// Сохранение данных комплекса
    /// </summary>
    public class SaveComplex
    {
        
        /// <summary>
        /// Комплекс
        /// </summary>
        public Complex Complex { get; set; }
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="complex">Комплекс</param>
        public SaveComplex(Complex complex)
        {
            
            Complex = complex;
        }
        /// <summary>
        /// Сохранение в бинарном виде
        /// </summary>
        /// <param name="path">Путь</param>
        public void SaveComplexBinnary(string path)
        {
            var formatter = new BinaryFormatter();
            using (FileStream fstream = new FileStream($"{path}", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fstream, Complex);

            }
        }
        /// <summary>
        /// Сохранение в текстовом виде
        /// </summary>
        /// <param name="path">Путь</param>
        public void SaveComplexTxt(string path)
        {
            using(var sw = new StreamWriter($"{path}",true,System.Text.Encoding.Default))
            {
                sw.WriteLine(Complex.Name_complex);
                sw.WriteLine(Complex.Number_room);
                sw.WriteLine(Complex.Water);
                sw.WriteLine(Complex.Heating);
                sw.WriteLine(Complex.Count_animal);
            }
        }
        
        
        
    }
   
}
