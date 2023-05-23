using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_v2._0_Artem_Volikov
{
    internal class YouDIED
    {
        public void youdied()
        {


            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\t\t                                                   ^^                   ");
            Console.WriteLine("\t\t         |||||    |||||||||||||  |||  |||     888  ||              888  ");
            Console.WriteLine("\t\t          ||||    |||| |||  |||  |||  |||     888  ||              888  ");
            Console.WriteLine("\t\t            ||    ||   |||  |||  |||  ||| .d88888  ||  .d88b.  .d88888  ");
            Console.WriteLine("\t\t            ||||||     |||  |||  |||  ||| d88' 888 || d8P  Y8b d88' 888 ");
            Console.WriteLine("\t\t              ||       |||  |||  |||  ||| 888  888 || 88888888 888  888 ");
            Console.WriteLine("\t\t              ||       |||  |||  |||  ||| Y88b 888 || Y8b.     Y88b 888 ");
            Console.WriteLine("\t\t              ||       ||||||||  |||||||| 'Y88888  || 'Y8888    'Y88888 ");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\n\n\n\t\t\t\tMöchtest Du das Spiel von vorne beginnen ? (j) oder (n)");
            string userinput;

            userinput = Console.ReadLine().ToLower();
            Console.Clear();

            if (userinput == "j")
            {
                Dungeon lvl = new Dungeon();
                lvl.start();
            }
            
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\n\n\t\t\t\t\tDrücke das RICHTIGE MAN!!!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadKey();
                Console.Clear();
                youdied();
            }






        }
}   }
