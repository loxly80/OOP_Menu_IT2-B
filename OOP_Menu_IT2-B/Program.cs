// See https://aka.ms/new-console-template for more information

//Console.CursorVisible = false;
//Console.ForegroundColor = ConsoleColor.Green;
//Console.WriteLine("╔════════════════════╗");
//Console.WriteLine("║                    ║");
//Console.WriteLine("╠════════════════════╣");
//Console.WriteLine("║                    ║");
//Console.WriteLine("║                    ║");
//Console.WriteLine("║                    ║");
//Console.WriteLine("╚════════════════════╝");
//Console.ForegroundColor = ConsoleColor.White;
//Console.SetCursorPosition(6,1);
//Console.Write("SUPER MENU");
//Console.SetCursorPosition(6, 3);
//Console.Write("Položka 1");
//Console.BackgroundColor = ConsoleColor.Yellow;
//Console.ForegroundColor = ConsoleColor.Black;
//Console.SetCursorPosition(1, 4);
//Console.Write("                    ");
//Console.SetCursorPosition(6, 4);
//Console.Write("Položka 2");
//Console.BackgroundColor = ConsoleColor.Black;
//Console.ForegroundColor = ConsoleColor.White;

//Console.SetCursorPosition(6, 5);
//Console.Write("Položka 3");

using OOP_Menu_IT2_B;
Console.CursorVisible = false;

Menu menu = new Menu();
menu.Nadpis = "Moje MENU";
menu.Zobraz();
menu.Polozky = new string[5];
menu.Zobraz();

Console.ReadKey();