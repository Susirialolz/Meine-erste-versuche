using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_v2._0_Artem_Volikov
{
    internal class Raum2
    {
        public void raum2()
        {
            Console.Clear();
            Console.WriteLine("Das war die richtige Wahl. Der Todesbaum ist zwar giftig, aber nur wenn man die Früchte davon isst");
            Console.WriteLine("Du bist an dem Todesbaum vorbei und in das Licht rein gegangen, nun befindest du dich wieder in einem großen Raum ");
            Console.WriteLine("Vor dir ist ein Tunnel, aber der ist zugeschüttet mit Steinen, neben den Steinen stehen 2 Fässer mit Schwarzpulver");
            Console.WriteLine("Rechst von dir ist eine kleiner Durchgang, und man sieht das am  Ende ein Licht brennt ");
            Console.WriteLine("Und Links von dir ist eine Leiter die nach unten führt");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n\n\t\t\t\t\tA----->: Für: die Leiter");
            Console.WriteLine("\n\n\t\t\t\t\tB----->: Für: den zugeschüteten Tunnel");
            Console.WriteLine("\n\n\t\t\t\t\tC----->: Für: den Gang mit Licht");
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
                Boom bam = new Boom();
                bam.Tiktak();
                
                Raum3 next = new Raum3();
                next.raum3();
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
                raum2();
            }












        }
 }  }
