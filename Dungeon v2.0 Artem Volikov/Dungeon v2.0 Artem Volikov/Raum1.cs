using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_v2._0_Artem_Volikov
{
    internal class Raum1
    {
        public void raum1()
        {
            Console.Clear();
            Console.WriteLine("Gut gemacht du hast den richtigen Weg gewählt!");
            Console.WriteLine("Du befindest dich jetzt in einem großen Raum.");
            Console.WriteLine("Vor dir siehst du eine große Tür mit einem Schalter");
            Console.WriteLine("Rechst von dir befindet sich der 'Todesbaum' und hinter im sieht man ein paar Lichstrahlen");
            Console.WriteLine("Und Links hörst du ein komisches Geräusch, hört sich an als ob da jemand schläft");
            Console.WriteLine("Triff deine Entscheidung richtig!");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n\n\t\t\t\t\tA----->: Für: die Tür");
            Console.WriteLine("\n\n\t\t\t\t\tB----->: Für: den Todesbaum");
            Console.WriteLine("\n\n\t\t\t\t\tC----->: Für: das komische Geräusch");
            Console.ForegroundColor = ConsoleColor.White;
            string Userinput;
            Userinput = Console.ReadLine().ToLower();

            Console.Clear();

            if (Userinput == "a")
            {
                Console.Clear();
                YouDIED lvl2 = new YouDIED();
                lvl2.youdied();




            }
            else if (Userinput == "b")
            {
                Raum2 lvl3 = new Raum2();
                lvl3.raum2();
            }
            else if (Userinput == "c")
            {
                Console.Clear();
                YouDIED lvl2 = new YouDIED();
                lvl2.youdied();

            }
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\n\n\t\t\t\t\tDrücke das RICHTIGE MAN!!!!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadKey();
                Console.Clear();
                raum1();
            }






        }
    }
}
