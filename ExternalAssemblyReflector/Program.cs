using System;
using System.Reflection;
using System.IO; // для использования FileNotFoundException.
namespace ExternalAssemblyReflector
{
    class Program
    {
        static void DisplayTypesInAsm(Assembly asm)
        {
            Console.WriteLine($"\nТипы в сборке {asm.GetName().Name}:\n");
            Console.WriteLine("->{0}", asm.FullName);
            Type[] types = asm.GetTypes();
            foreach (Type t in types) Console.WriteLine("Type: {0}", t);
            Console.WriteLine("");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("***** Просмотр внешней сборки *****");
            string asmName = "";
            Assembly asm = null;
            do
            {
                
                Console.WriteLine("\nВведите сборку для оценки");
                Console.Write("или Q для выхода: ");
                asmName = Console.ReadLine();
                if (asmName.ToUpper() == "Q")
                {
                    break;
                }
                Console.Clear();
                try//Пытаемся загрузить сборку
                {
                    asm = Assembly.Load(asmName);
                    DisplayTypesInAsm(asm);
                }
                catch
                {
                    Console.WriteLine("Sorry, can’t find assembly.");
                }
                
            } while (true);
        }
    }
}
