using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Machine
    {
        private string name;
        protected string model;

        public Machine(string s)
        {
            Console.WriteLine("Machine Constructor...");
        }
        //~Machine() {
        //    Console.WriteLine("Machine Destructor ~~~");
        //}


        public void create() {
            Console.WriteLine("Machine was created!");
        }
    }

    class Robot : Machine {
        public Robot():base("Robot")
        {

            Console.WriteLine("Robot Constructor...");
        }


        //~Robot()
        //{
        //    Console.WriteLine("Robot Destructor ~~~");
        //}

        public void create()
        {
            base.create();
            Console.WriteLine("Robot was created!");
        }


    }

    class Mixer : Robot {
        //public Mixer() {
        //    Console.WriteLine("Mixer Constructor...");
        //}

        //~Mixer() {
        //    Console.WriteLine("Mixer Destructor ~~~");
        //}

    }


}
