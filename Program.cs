double metros;

Console.Write("Entre com metros: ");
metros = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Km = {metros / 1000}");
Console.WriteLine($"Cm = {metros * 100}");
Console.WriteLine($"M = {metros}");