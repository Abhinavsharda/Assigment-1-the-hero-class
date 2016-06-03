using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hero
{
    /**
     * this class is the "driver" class for my program
     * @class Program
     */
    class Program
    {
        /**Main method of driver class
         * 
         * @method Main
         * param {string} args
         */
        static void Main(string[] args)
        {
            //Hero Name
            Console.WriteLine("Which hero will you choose ? ");
            string Daredevil = Console.ReadLine();
            //Create a new instance of the Hero class
            Hero hero = new Hero(Daredevil);
            //calling the Public show method
            hero.Show();
            //calling the public fight method
            hero.Fight();
            Console.ReadLine();
        }
    }
}

