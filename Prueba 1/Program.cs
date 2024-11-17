
    using System;
   
    Console.WriteLine("Por favor introduce tu nombre");
     string? nombre = Console.ReadLine();
    Console.WriteLine("Por favor introduce tu edad");
    int edad = int.Parse(Console.ReadLine());

    Console.WriteLine("Buenos días {0}, con una dedad de {1} años", nombre, edad);

