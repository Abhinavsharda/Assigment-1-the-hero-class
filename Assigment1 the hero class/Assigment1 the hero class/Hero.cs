using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hero
{
    /**
     * This class gives the defination of Hero
     * 
     * @class Hero
     * @field {int} _strength
     * @field {int} _speed
     * @field {int} _health
     * @field {string} _name

     */
    public class Hero
    {
        //PRIVATE INSTANCE VARIABLES ***************
        private string _name;
        private int _strength;
        private int _health;
        private int _speed;

        //Initilizing a Random Object
        Random no = new Random();



        // PUBLIC PROPERTIES +++++++++++++++++++++++++++++++++
        /**
         * <summary>
         * this define property for our private name field
         * </summary>
         * @property {string} Name
         */
        public string Name
        {
            get
            {
                return this._name;
            }

            set
            {

                this._name = Name;
            }
        }

        //CONSTRUCTOR++++++++++++++++++++++++++++++++++++++++++++++++
        /**
         * <summary>
         * This is a constructor that takes name as as paramater.
         * </summary>
         *           
         * @constructor Hero
         * @parm {string} _name
         */

        public Hero(string name)
        {
            this._name = name;
            _generateAbilities();
        }

        // PRIVATE METHODS -----------------------------------------------
        /**
        * <summary>
        * This method provide abilities randomly for the
        * strength, speed and health variables
        * </summary>
        * @method _generateAbilities
        * @return {void}
        */

        private void _generateAbilities()
        {
            _strength = no.Next(1, 199);
            _speed = no.Next(1, 199);
            _health = no.Next(1, 199);
        }
        /**
         * <summary>
         * This method tells if the hero hits 
         * </summary>
         * @method _hitAttempt
         * @return {bool}
         */
        private bool _hitAttempt()
        {
            //Generating a random number between 1-200 
            int hit = no.Next(1, 199);
            if (hit <= 70)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /**
         * <summary>
         * Method thatprovide information on the damage the Hero causes to target
         *  by hero by multiplying a number between 1, 6 by strenght.
         * </summary>
         * @method _hitDamage
         * @return {int}
         */
        private int _hitDamage()
        {
            int damage = this._strength * no.Next(1, 6);
            return damage;
        }
        //PUBLIC METHODS +++++++++++++++++++++++++++++++
        /**
         * <summary>
         * This method calls the _hitAttempt method and if returns
         * true it calls the _hitDamage method and the damaged amount is passed 
         * to the console
         * </summary>
         * @method Fight
         * @return {void}
         */
        public void Fight()
        {
            int damage;

            if (_hitAttempt())
            {
                damage = _hitDamage();
                Console.WriteLine("That's the power of a hero");
                Console.WriteLine("{0} made {3}% damage to the devil :", this.Name, damage);
            }
            else
            {
                Console.WriteLine("Be perpared next time!");
                Console.WriteLine("{0} is mice in front of enemy.", this.Name);
            }
        }
        /**
        * <summary>
        * This method compute the Hero's velocity and Show it to the console.
        * </summary>
        * @method speed
        * @return {void}
        */
        public void speed()
        {
            if (this._speed <= 60)
            {
                Console.WriteLine("hahaha---that's what is your speed -.-");
            }
            else
            {
                Console.WriteLine("Oh My God You  can beat the flash <_>");
            }
        }
        /**
         * <summary>
         * This method gives overviewof the health of the Hero to the console.
         * </summary>
         * @method health 
         * @return {void}
         */
        public void health()
        {
            if (this._health <= 75)
            {
                Console.WriteLine("You'er gonna die.");
            }
            else
            {
                Console.WriteLine("Unbeatable!!!.");
            }
        }
        /**
         * <summary>
         * This method will Show abilities of the Hero’s scores to the console
         * </summary>
         * @method Show
         * @return {void}
         */
        public void Show()
        {
            _hitAttempt();
            _hitDamage();
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("+{0} is the Hero!  \t\t\t\t/", this.Name);
            Console.WriteLine("+These are {0}'s abilities\t\t\t/ ", this.Name);
            Console.WriteLine("+Health  ==== {0}\t\t\t\t/", _health);
            Console.WriteLine("+Strength  ====  {0}\t\t\t\t/", _strength);
            Console.WriteLine("+Speed ====  {0} \t\t\t\t/", _speed);
            Console.WriteLine("-----------------------------------------------");
        }
    }
}