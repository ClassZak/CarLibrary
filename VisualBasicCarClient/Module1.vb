Imports CarLibrary
Module Module1

    Sub Main()
        Console.WriteLine("***** VB CarLibrary Client App *****")
        ' Локальные переменные объявляются с помощью ключевого слова Dim.
        Dim myMiniVan As New MiniVan()
        Console.WriteLine("Турбоускорение минивэна")
        myMiniVan.TurboBoost()
        Dim mySportsCar As New SportsCar()
        Console.WriteLine("Турбоускорение спортивного автомобиля")
        mySportsCar.TurboBoost()


        Console.WriteLine("Вызываем метод PerformanceCar:")
        Dim dreamCar As New PerformanceCar()
        dreamCar.TurboBoost()
        Console.ReadKey()

    End Sub


End Module
