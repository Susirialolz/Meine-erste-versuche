using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_v2._0_Artem_Volikov
{
    public class Dungeon
    {
        public void start()
        {




            Console.WriteLine("\n\tWilkommen in Dungeon! ");
            Console.WriteLine("\n\tDu bist ein Schatzjäger!");
            Console.WriteLine("\n\tDu befindest dich in Panama vor einer Höhle!");
            Console.WriteLine("\n\tDie soll einen großen Schatz bergen, aber auch große Gefahren");
            Console.WriteLine("\n\tDu freust dich wie ein kleines Mädchen? Also auf was wartest du?");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\n\t\t\t\t\t- Bitte eine Taste drücken -");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
            Console.Clear();
            enter();
        }
        public void enter()
        {
            Console.WriteLine("Du betrittst die Höhle und stehst vor einer Verzweigung");
            Console.WriteLine("Rechst ist ein enger Weg!");
            Console.WriteLine("Links hört man Wasser plätschern ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n\n\t\t\t\t\tA----->: Für: den enger Weg");
            Console.WriteLine("\n\n\t\t\t\t\tB----->: Für: das Wasser");
            Console.ForegroundColor = ConsoleColor.White;
            string Userinput;
            Userinput = Console.ReadLine().ToLower();

            Console.Clear();

            if (Userinput == "a")
            {
                Console.Clear();
                Raum1 lvl1 = new Raum1();
                lvl1.raum1();

                
            }
            else if (Userinput == "b")
            {
                Console.Clear();

                YouDIED lvl2 = new YouDIED();
                lvl2.youdied();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\n\n\t\t\t\t\tDrücke das RICHTIGE MAN!!!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadKey();
                Console.Clear();
                enter();
            }
        }
    }
}
    
    
    
    
    
    
