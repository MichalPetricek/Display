using System;


namespace Display
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WindowWidth = 200;
            Console.WindowHeight = 50;    //určí rozměr cmd
            Screen array = new Screen(100); //vytvoří nové pole
            array.AddElement(90, 25, "kočka");
            array.AddElement(100, 25, "pes");
            array.AddElement(110, 25, "papušek"); 
            array.RepaintScreen();  
            Console.ReadKey();  //
            array.ClearScreen();
            array.ClearArray();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Cyan;
            array.Rectangle(10);
            array.GetExtract();
            Console.ReadKey();  //
            array.ClearScreen();
            array.ClearArray();
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Red;
            array.Rectangle(20);
            array.GetExtract();
            Console.ReadKey();  //
            array.ClearScreen();
            array.ClearArray();
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Green;
            array.FullRectangle(10);
            array.GetExtract();
            Console.ReadKey();  //
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            array.ClearScreen();
            array.ClearArray();
            array.CoverText("PES",20,30);
            array.GetExtract();
            Console.ReadKey(); //
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            array.ClearScreen();
            array.ClearArray();
            array.CoverText("KOČKA",30,5);
            array.CoverText("ZIRAFA", 47, 17);
            array.GetExtract();
            Console.ReadKey(); //
            array.ClearScreen();
            array.ClearArray();
            array.Cover(4,35, "nejzdevětadevadesáteronásobitelnějšího", 60,30);
            array.GetExtract();
            Console.ReadKey(); //
            array.ClearScreen();
            array.ClearArray();


        }
    }
}
