using OOP_Menu_IT2_B;

bool konec = false;
Console.CursorVisible = false;

Menu menu = new Menu();
menu.X = 10;
menu.Y = 5;
menu.BarvaOkraj = ConsoleColor.Red;
menu.BarvaPozadi = ConsoleColor.White;
menu.BarvaText = ConsoleColor.Black;
menu.BarvaKurzor = ConsoleColor.Blue;
menu.BarvaTextKurzor = ConsoleColor.White;
menu.Nadpis = "Moje MENU";
menu.Polozky = new string[6];
for(int i = 0; i < menu.Polozky.Length; i++)
{
  menu.Polozky[i] = $"Položka {i + 1}";
}
menu.VybranaPolozka = 0;

Menu menu2 = new Menu();
menu2.X = 50;
menu2.Y = 5;
menu2.BarvaOkraj = ConsoleColor.White;
menu2.BarvaPozadi = ConsoleColor.Red;
menu2.BarvaText = ConsoleColor.Yellow;
menu2.BarvaKurzor = ConsoleColor.Blue;
menu2.BarvaTextKurzor = ConsoleColor.White;
menu2.Nadpis = "Moje druhé MENU";
menu2.Polozky = new string[10];
for (int i = 0; i < menu2.Polozky.Length; i++)
{
  menu2.Polozky[i] = $"Položka {i + 1}";
}
menu2.VybranaPolozka = 0;

do
{
  Console.BackgroundColor = ConsoleColor.Black;
  Console.Clear();
  menu.Zobraz();
  menu2.Zobraz();
  var klavesa = Console.ReadKey(true);
  if(klavesa.Key == ConsoleKey.UpArrow)
  {
    menu.Nahoru();    
  }
  else if(klavesa.Key == ConsoleKey.DownArrow)
  {
    menu.Dolu();    
  }
  else if (klavesa.Key == ConsoleKey.W)
  {
    menu2.Nahoru();
  }
  else if (klavesa.Key == ConsoleKey.S)
  {
    menu2.Dolu();
  }
  else if(klavesa.Key == ConsoleKey.Escape)
  {
    konec = true;
  }
}while(!konec);
