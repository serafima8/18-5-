using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Компьютерный_практикум_5
{
    /// <summary>
    /// Создание абстрактного базового класса 
    /// </summary>
    abstract class Commodity
    {
        /// <summary>
        /// Свойства Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Свойства Price
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Commodity() { }
        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="name"></param>
        /// <param name="price"></param>
        public Commodity(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }
        /// <summary>
        /// Создание абстрактного метода для вывода информации о товаре
        /// </summary>
        abstract public void Print();
        /// <summary>
        /// Создание абстрактного метода для вывода просроченных продуктов
        /// </summary>
        /// <returns></returns>
        abstract public string DeadLineExpirationDate();
    }
}
