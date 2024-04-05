using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Компьютерный_практикум_5
{
    /// <summary>
    /// Производный класс Продукт
    /// </summary>
    class Product : Commodity
    {
        /// <summary>
        /// Свойства Date
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// Свойства Time
        /// </summary>
        public int Time { get; set; }
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Product() { }
        /// <summary>
        /// Конструктор с параметрами 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="price"></param>
        /// <param name="date"></param>
        /// <param name="time"></param>
        public Product(string name, double price, DateTime date, int time) : base(name, price)
        {
            this.Date = date;
            this.Time = time;
        }
        /// <summary>
        /// Метод для вывода информации о продукте 
        /// </summary>
        public override void Print()
        {
            Console.WriteLine($"Название: {Name}\nЦена: {Price}\nДата производства: {Date}\nСрок годности: {Time}");
        }
        /// <summary>
        /// метод для вывода информации о просроченности 
        /// </summary>
        /// <returns></returns>
        public override string DeadLineExpirationDate()
        {
            if (DateTime.Now > Date.AddMonths(Time))
            {
                return " ";
            }
            else
            {
                return $"Просроченный товар: {Name}";
            }
        }
        /// <summary>
        /// Метод для ввода информации о продукте 
        /// </summary>
        /// <returns></returns>
        static public Product Show()
        {
            Console.Write("Название: ");
            string name = Console.ReadLine();
            Console.Write("Цена: ");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.Write("Дата производства: ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.Write("Срок годности: ");
            int time = Convert.ToInt32(Console.ReadLine());
            return new Product(name, price, date, time);
        }


    }
}
