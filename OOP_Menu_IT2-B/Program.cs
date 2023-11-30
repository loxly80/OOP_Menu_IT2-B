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

do
{
  Console.BackgroundColor = ConsoleColor.Black;
  Console.Clear();
  menu.Zobraz();
  var klavesa = Console.ReadKey();
  if(klavesa.Key == ConsoleKey.UpArrow)
  {
    menu.Nahoru();    
  }
  else if(klavesa.Key == ConsoleKey.DownArrow)
  {
    menu.Dolu();    
  }
  else if(klavesa.Key == ConsoleKey.Escape)
  {
    konec = true;
  }
}while(!konec);
