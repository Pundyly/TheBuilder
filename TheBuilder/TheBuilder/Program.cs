using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBuilder
{
    class Program
    {
        public int width, height, tmp_height, heightOfFoundation, tmp_heightOfFoundation;
        public string doAHouse, temp;
        static void Main(string[] args)
        {
            var debil = new Program();
            while (true)
            {
                Console.WriteLine("Do a house?(y/n): ");
                debil.doAHouse = Console.ReadLine();
                switch (debil.doAHouse)
                {
                    case "y":
                        debil.BuildAHouse();
                        break;
                    case "n":
                        Console.WriteLine("Okey, D.");
                        break;
                    default:
                        Console.WriteLine("ERROR: YOU ARE DUMB!");
                        break;
                }
            }
        }

        public void BuildAHouse()
        {
            //questions
            Console.WriteLine("Width: ");
            width = int.Parse(Console.ReadLine());
            Console.WriteLine("Height: ");
            height = int.Parse(Console.ReadLine());
            Console.WriteLine("Height of foundation: ");
            heightOfFoundation = int.Parse(Console.ReadLine());

            //build
            temp = string.Concat(Enumerable.Repeat("#", width));
            Console.WriteLine(temp);
            tmp_height = height - 1;
            tmp_height = tmp_height - heightOfFoundation;
            while( tmp_height > 0)
            {
                temp = " " + "#" + string.Concat(Enumerable.Repeat(" ", width - 4)) + "#" + " ";
                Console.WriteLine(temp);
                tmp_height--;
            }

            temp = string.Concat(Enumerable.Repeat("#", width));
            tmp_heightOfFoundation = heightOfFoundation;

            while (tmp_heightOfFoundation > 0)
            {
                temp = " " + "#" + string.Concat(Enumerable.Repeat("#", width - 4)) + "#" + " ";
                Console.WriteLine(temp);
                tmp_heightOfFoundation--;
            }
            Console.WriteLine("Sucksfull!");
        }
    }
}
