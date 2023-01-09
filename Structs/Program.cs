using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    internal class Program
    {
        //struct - bundle of related information - example: sword stats incl damage, speed, durabililty can be all used in one struct 
        struct Vector2 // vector 2 used for 2D (x, y) / vector 3 is 3D (x,y,z) / only using it as a name as we've already established position
        {
            public int x;
            public int y; // position made into one idea 
        }

        static Vector2 position;

        struct Weapon
        {
           public int strength; // made public but assumed private if not made public. won't be able to use in main without it being public
           public int damage;
           public int durability;
           public string name;
        }

        static Weapon sword;
        static Weapon bat;


        //player position
        static int x;
        static int y;

        //player name
        static string name;

        //enemy

        static Vector2 enemy1Position;
        //.........
        //.........

        //static int enemyX1;
        //static int enemyY1; 

        //array w struct
        static Vector2[] enemyPositions = new Vector2[100]; // array for all enemies / simplified

        //use an array to differentiate between enemies and player instead
        static int[] enemyX = new int[100];
        static int[] enemyY = new int[100];

        static void Main(string[] args)
        {
            Console.WriteLine("Structs: ");
            Console.WriteLine();

            sword.strength = 100; // setting the integers for the stats of sword, they all now have these properties
            sword.name = "killer";
            sword.damage = 100;

            Console.Write("Strength: " + sword.strength);


            Console.WriteLine();
            Console.ReadKey(true);
        }
    }
}
