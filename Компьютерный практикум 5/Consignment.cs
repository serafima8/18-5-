using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Компьютерный_практикум_5
{
    /// <summary>
    /// Производный класс Партия 
    /// </summary>
    class Consignment : Commodity
    {
        /// <summary>
        /// Свойства Quantity
        /// </summary>
        public int Quantity { get; set; }
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
        public Consignment() { }
        /// <summary>
        /// Конструктор с параметрами 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="price"></param>
        /// <param name="quantity"></param>
        /// <param name="date"></param>
        /// <param name="time"></param>
        public Consignment(string name, double price, int quantity, DateTime date, int time) : base(name, price)
        {
            this.Quantity = quantity;
            this.Date = date;
            this.Time = time;
        }
        /// <summary>
        /// Метод для вывода информации о партии 
        /// </summary>
        public override void Print()
        {
            Console.WriteLine($"Название: {Name}\nЦена: {Price}\nКоличество: {Quantity}\nДата производства: {Date}\nСрок годности: {Time}");
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
        /// Метод для ввода информации о партии
        /// </summary>
        /// <returns></returns>
        static public Consignment Show()
        {
            Console.Write("Название: ");
            string name = Console.ReadLine();
            Console.Write("Цена: ");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.Write("Количество: ");
            int quantity = Convert.ToInt32(Console.ReadLine());
            Console.Write("Дата производства: ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.Write("Срок годности: ");
            int time = Convert.ToInt32(Console.ReadLine());
            return new Consignment(name, price, quantity, date, time);
        }

    }
}
