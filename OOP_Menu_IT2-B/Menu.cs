using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Menu_IT2_B
{
  public class Menu
  {
    public string Nadpis = "";
    public ConsoleColor BarvaOkraj = ConsoleColor.Green;
    public ConsoleColor BarvaPozadi = ConsoleColor.Black;
    public ConsoleColor BarvaText = ConsoleColor.White;
    public ConsoleColor BarvaKurzor = ConsoleColor.Yellow;
    public int Sirka = 25;
    public string[] Polozky = new string[0];

    public void Zobraz()
    {
      ZobrazOkraj();
      ZobrazNadpis();
      //ZobrazKurzor();
      //ZobrazPolozky();
    }

    private void ZobrazNadpis()
    {
      Console.BackgroundColor = BarvaPozadi;
      Console.ForegroundColor = BarvaText;
      Console.SetCursorPosition(3, 1);
      Console.Write(Nadpis);
    }

    private void ZobrazOkraj()
    {
      Console.BackgroundColor = BarvaPozadi;
      Console.ForegroundColor = BarvaOkraj;
      Console.Write("╔");      
      Console.Write(new String('═',Sirka));
      Console.WriteLine("╗");
      Console.Write("║");     
      Console.Write(new String(' ', Sirka));
      Console.WriteLine("║");
      Console.Write("╠");
      Console.Write(new String('═', Sirka));
      Console.WriteLine("╣");
      for(int i = 0; i < Polozky.Length; i++)
      {
        Console.Write("║");
        Console.Write(new String(' ', Sirka));
        Console.WriteLine("║");
      }
      Console.Write("╚");
      Console.Write(new String('═', Sirka));
      Console.WriteLine("╝");
    }
  }
}
