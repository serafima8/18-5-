using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Компьютерный_практикум_5
{
    /// <summary>
    /// Производый класс Комплект
    /// </summary>
    class Set : Product
    {
        /// <summary>
        /// Свойства Products
        /// </summary>
        public int Products { get; set; }
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Set() { }
        /// <summary>
        /// Конструктор с параметрами 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="price"></param>
        /// <param name="date"></param>
        /// <param name="time"></param>
        /// <param name="products"></param>
        public Set(string name, double price,DateTime date,int time ,int products) : base(name, price, date, time)
        {
            this.Products = products;
        }
        /// <summary>
        /// Метод для вывода информации о комплекте 
        /// </summary>
        public override void Print()
        {
            Console.WriteLine($"Название: {Name}\nЦена: {Price}\nПродукты: {Products}\nДата производства: {Date}\nСрок годности: {Time}");
        }
        /// <summary>
        /// Метод для вывода информации о просроченности 
        /// </summary>
        /// <returns></returns>
        public override bool DeadLineExpirationDate()
        {
            if (DateTime.Now > Date.AddMonths(Time))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Метод для ввода информации о комплекте 
        /// </summary>
        /// <returns></returns>
        static public Set Show()
        {
            Console.Write("Название: ");
            string name = Console.ReadLine();
            Console.Write("Цена: ");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.Write("Количество продуктов, входящие в комплект: ");
            int products = Convert.ToInt32(Console.ReadLine());
            DateTime date = DateTime.MinValue; // Инициализируем переменные перед циклом
            int time = 0;
            for (int i = 0; i < products; i++)
            {
                Console.Write($"{i + 1} продукт: ");
                string b = Console.ReadLine();
                Console.Write("Дата производства: ");
                date = Convert.ToDateTime(Console.ReadLine());
                Console.Write("Срок годности: ");
                time = Convert.ToInt32(Console.ReadLine());
            }
            return new Set(name, price, date, products, time);
        }
    }
}
