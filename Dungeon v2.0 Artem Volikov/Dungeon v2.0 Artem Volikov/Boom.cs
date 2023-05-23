using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_v2._0_Artem_Volikov
{
    internal class Boom
    {
        public void Tiktak()
        {


            var sec = 5;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.CursorVisible = false;
            var d = new DateTime(2000, 1, 1, 0, 0, sec);

            for (int i = 0; i <= 5; i++)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\n\tDu zündes das Schwarz pulver an " + d.ToString("ss") + " sekunden warten!");


                Console.WriteLine("\n\t\t\t               *********");
                Console.WriteLine("\n\t\t\t              *         ||");
                Console.WriteLine("\n\t\t\t              *  (||||||||||||||||||||||||)                                                 ");
                Console.WriteLine("\n\t\t\t             *   (||||||||||||||||||||||||)                                                  ");
                Console.WriteLine("\n\t\t\t            *    (||||||||||||||||||||||||)");
                Console.WriteLine("\n\t\t\t           *     (||||||||||||||||||||||||)");
                Console.WriteLine("\n\t\t\t          *      (||||||||||||||||||||||||)");
                Console.WriteLine("\n\t\t\t                 (||||||||||||||||||||||||)");
                Console.WriteLine("\n\t\t\t                 (||||||||||||||||||||||||)");
                Console.WriteLine("\n\t\t\t                 (||||||||||||||||||||||||)");
                Console.WriteLine("\n\t\t\t                 (||||||||||||||||||||||||)");
                Console.WriteLine("\n\t\t\t                 (||||||||||||||||||||||||)");
                Console.WriteLine("\n\t\t\t                 (||||||||||||||||||||||||)");
                d = d.AddSeconds(-1);
                System.Threading.Thread.Sleep(1000);

                Console.Clear();
                
            }

        }






    }
}
