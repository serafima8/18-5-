using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Компьютерный_практикум_5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Commodity> commoditys = new List<Commodity>();
            while (true)
            {
                Console.Write("Введите количество товара: ");
                int n = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    Console.Write("Введите товар: ");
                    string a = Console.ReadLine();
                    switch (a)
                    {
                        case "Продукт":
                            commoditys.Add(Product.Show());
                            break;
                        case "Партия":
                            commoditys.Add(Consignment.Show());
                            break;
                        case "Комплект":
                            commoditys.Add(Set.Show());
                            break;
                        default:
                            Console.WriteLine("Товар введен некорректно");
                            break;
                    }
                  
                    foreach (var elem in commoditys)
                    {
                        elem.Print();
                      //  Console.WriteLine("Просроченные продукты: ");
                      //  elem.DeadLineExpirationDate();
                    }
              
                    Console.ReadKey();
                }
            }
        }
    
    }
}
