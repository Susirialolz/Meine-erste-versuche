using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace Dungeon_v2._0_Artem_Volikov
{
    public class Fictory
    {
        public void win()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Du hast den schatz gefunden!!!!!!!!");
            Console.WriteLine("GG WP!!!!!!!");

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
                win();
            }














        }
        
               
} 
    
    
    
    
    
    }

