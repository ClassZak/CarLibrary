﻿Imports CarLibrary
Module Module1

    Sub Main()
        Console.WriteLine("***** VB CarLibrary Client App *****")
        ' Локальные переменные объявляются с помощью ключевого слова Dim.
        Dim myMiniVan As New MiniVan()
        myMiniVan.TurboBoost()
        Dim mySportsCar As New SportsCar()
        mySportsCar.TurboBoost()


        Console.WriteLine("Вызываем метод PerformanceCar")
        Dim dreamCar As New PerformanceCar()
        dreamCar.PetName = "Hank"
        dreamCar.TurboBoost()
        Console.ReadLine()

    End Sub


End Module
