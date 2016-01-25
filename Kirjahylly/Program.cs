using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kirjahylly
{
    class Program
    {
        static void Main(string[] args)
        {
            Speaker speaker = new Speaker();
            Console.WriteLine("Turn speakers on? 1 = YES, 0 = NO");
            string rivi = Console.ReadLine();
            int luku1 = int.Parse(rivi);
            speaker.ONOFF = luku1;
            if (luku1 == 1)
            {
                Console.WriteLine("Speakers turned on!");
            }
            else
            {
                Console.WriteLine("Speakers turned off! Enjoy your silence...");
            }
            Console.WriteLine("Set volume (0-10)");
            string rivi2 = Console.ReadLine();
            int luku2 = int.Parse(rivi2);
            speaker.Volume = luku2;
            Console.WriteLine("Volume is now on " + speaker.Volume + " , enjoy!");
            Console.ReadLine();

            Console.WriteLine("Choose u plug in: 1 = BLUETHOOT, 2 = AUX");
            string rivi3 = Console.ReadLine();
            int luku3 = int.Parse(rivi3);
            

        }
    }
}
