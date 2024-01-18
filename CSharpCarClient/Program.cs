using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarLibrary;
namespace CSharpCarClient
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** C# CarLibrary Client App *****");
            // Создание объекта спортивной машины.
            SportsCar viper = new SportsCar("Viper", 240, 40);
            Console.WriteLine("Турбоускорение спортивного автомобиля");
            viper.TurboBoost();
            // Создание объекта минивена.
            MiniVan mv = new MiniVan();
            Console.WriteLine("Турбоускорение минивэна");
            mv.TurboBoost();
            
            Console.ReadKey();
        }
    }
}
