using System;
using System.IO;
using System.Reflection;

public class Program
{


    static void Main(string[] args)
    {
        Console.WriteLine("***** Функция с поздним связыванием *****");
        // Попытка загрузить локальную копию CarLibrary.
        Assembly a = null;
        try
        {
            a = Assembly.Load("CarLibrary");
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
            return;
        }
        if (a != null)
        {
            CreateUsingLateBinding(a);
            InvokeMethodWithArgsUsingLateBinding(a);
        }
        

        Console.ReadKey();
    }

    static void CreateUsingLateBinding(Assembly asm)
    {
        try
        {
            Type miniVan = asm.GetType("CarLibrary.MiniVan");

            // Создание экземпляра типа Minivan динамически.
            object obj = Activator.CreateInstance(miniVan);
            Console.WriteLine("Created a {0} using late binding!", obj);
            MethodInfo mi = miniVan.GetMethod("TurboBoost");
            //Вызываем метод для объекта Activator.CreateInstance(miniVan);
            mi.Invoke(obj, null);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    static void InvokeMethodWithArgsUsingLateBinding(Assembly asm)
    {
        try
        {
            Console.WriteLine("Turning radio:");
            // Сначала получим метаданные для типа SportsCar.
            Type sport = asm.GetType("CarLibrary.SportsCar");

            //Получаем объект метода от экземпляра CarLibrary.SportsCar, передаавая в Invoke свою "ссылку" и список аргументов
            object obj = Activator.CreateInstance(sport);
            MethodInfo mi = sport.GetMethod("TurnOnRadio");
            mi.Invoke(obj, new object[] { true, 2 });
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

}
