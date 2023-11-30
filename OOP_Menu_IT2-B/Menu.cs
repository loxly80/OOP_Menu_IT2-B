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
    public ConsoleColor BarvaTextKurzor = ConsoleColor.Black;
    public int Sirka = 25;
    public string[] Polozky = new string[0];
    public int VybranaPolozka = -1;
    public int X = 0;
    public int Y = 0;

    public void Zobraz()
    {
      ZobrazOkraj();
      ZobrazNadpis();
      ZobrazKurzor();
      ZobrazPolozky();
    }

    public void Nahoru()
    {
      VybranaPolozka--;
      if (VybranaPolozka < 0)
      {
        VybranaPolozka = Polozky.Length - 1;
      }
    }

    public void Dolu()
    {
      VybranaPolozka++;
      if (VybranaPolozka >= Polozky.Length)
      {
        VybranaPolozka = 0;
      }
    }

    private void ZobrazKurzor()
    {
      if (VybranaPolozka >= 0)
      {
        Console.BackgroundColor = BarvaKurzor;
        Console.SetCursorPosition(1, 3 + VybranaPolozka);
        Console.Write(new String(' ', Sirka));
      }
    }

    private void ZobrazPolozky()
    {

      for (int i = 0; i < Polozky.Length; i++)
      {
        if (i == VybranaPolozka)
        {
          Console.BackgroundColor = BarvaKurzor;
          Console.ForegroundColor = BarvaTextKurzor;
        }
        else
        {
          Console.BackgroundColor = BarvaPozadi;
          Console.ForegroundColor = BarvaText;
        }
        Console.SetCursorPosition(3, 3 + i);
        Console.Write(Polozky[i]);
      }
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
      ZobrazRadek('╔', '═', '╗', X, Y);
      ZobrazRadek('║', ' ', '║', X, Y + 1);
      ZobrazRadek('╠', '═', '╣', X, Y + 2);
      for (int i = 0; i < Polozky.Length; i++)
      {
        ZobrazRadek('║', ' ', '║', X, Y + 3 + i);
      }
      ZobrazRadek('╚', '═', '╝', X, Y + 3 + Polozky.Length);
    }

    private void ZobrazRadek(char levy, char stred, char pravy)
    {
      Console.Write(levy);
      Console.Write(new String(stred, Sirka));
      Console.WriteLine(pravy);
    }

    private void ZobrazRadek(char levy, char stred, char pravy, int x, int y)
    {
      Console.SetCursorPosition(x, y);
      Console.Write(levy);
      Console.Write(new String(stred, Sirka));
      Console.Write(pravy);
    }
  }
}
