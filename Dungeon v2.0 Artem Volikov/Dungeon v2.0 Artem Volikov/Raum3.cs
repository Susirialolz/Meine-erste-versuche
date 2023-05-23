using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_v2._0_Artem_Volikov
{
    internal class Raum3
    {
        public void raum3()
        {
            Console.Clear();
            Console.WriteLine("Boom die Steine fliegen in alle Richtungen");
            Console.WriteLine("Nun steht dir der Tunnel frei");
            Console.WriteLine("Du gehst durch den Tunnel und am des Tunnels sieht du das PARADIS");
            Console.WriteLine("Seitlich fliessen Wasserfälle, Bäume blühen überall");
            Console.WriteLine("Und in der Mitte des Raumes befindet sich eine große Kiste ");
            Console.WriteLine("Und ehrlich gesagt fällt mir kein Ende ein, also wähle was du willst");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n\n\t\t\t\t\tA----->::  Den Schatz schappen");
            Console.WriteLine("\n\n\t\t\t\t\tB----->::  Nach Hause gehen");
            Console.WriteLine("\n\n\t\t\t\t\tC----->::  Du fängst einfach so zu tanzen _/('.')/-  ");
            Console.WriteLine("\t\t\t\t\t                                             | |");
            Console.ForegroundColor = ConsoleColor.White;
            string Userinput;
            Userinput = Console.ReadLine().ToLower();

            Console.Clear();

            if (Userinput == "a")
            {
                Console.Clear();
                Fictory andwin= new Fictory();
                andwin.win();


            }
            else if (Userinput == "b")
            {
                Console.Clear();
                YouDIED lvl2 = new YouDIED();
                lvl2.youdied();

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
                Console.WriteLine("\n\n\n\t\t\t\t\tDrücke das RICHTIGE MAN!!!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadKey();
                Console.Clear();
                raum3();
            }













        }
}   }
