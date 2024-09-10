// See https://aka.ms/new-console-template for more information
Console.WriteLine("Velkommen til tegn Sæt");
Console.WriteLine();



for (int i = 32; i < 255; i++)
{
    if (i % 10 == 0) Console.WriteLine();
    Console.Write($"{i:000}={(char)i}  ");
}
Console.WriteLine();



Console.WriteLine(); 
Console.Write("Press any key");
Console.ReadKey();
