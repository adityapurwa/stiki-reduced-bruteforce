using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReducedBruteforce
{
    class Program
    {
        static void RunSimulation(Core.VirtualObject obj1, Core.VirtualObject obj2)
        {
            Core.VirtualEnvironment env = new Core.VirtualEnvironment();
            env.Objects.Add(obj1);
            env.Objects.Add(obj2);

            env.Start();

            for (var i = 0; i < 10; i++)
            {
                env.Update();
                Console.WriteLine(env.CollisionDetected + " / " + env.AverageTimeElapsed.ToString("#.##"));
                if (env.CollisionDetected > 0)
                {
                    break;
                }
            }

        }
        static void Main(string[] args)
        {
            //Bruteforce();
            ReducedBruteforce();
            Console.ReadLine();
        }

        static void ReducedBruteforce()
        {
            //Console.WriteLine("SCENE 1:");
            //RunSimulation(
            //    new Core.ReducedBruteforceVirtualObject { ID = 0, X = 0, Y = 0, VX = 2, Radius = 5 },
            //    new Core.ReducedBruteforceVirtualObject { ID = 1, X = 20, Y = 0, VX = -2, Radius = 5 }
            //);

            //Console.WriteLine("SCENE 2:");
            //RunSimulation(
            //    new Core.ReducedBruteforceVirtualObject { ID = 0, X = 0, Y = 0, VX = 3, Radius = 5 },
            //    new Core.ReducedBruteforceVirtualObject { ID = 1, X = 20, Y = 0, VX = 1, Radius = 5 }
            //);

            //Console.WriteLine("SCENE 3:");
            //RunSimulation(
            //    new Core.ReducedBruteforceVirtualObject { ID = 0, X = 0, Y = 0, VX = 2, Radius = 5 },
            //    new Core.ReducedBruteforceVirtualObject { ID = 1, X = 20, Y = 0, VX = 0, Radius = 5 }
            //);

            //Console.WriteLine("SCENE 4:");
            //RunSimulation(
            //    new Core.ReducedBruteforceVirtualObject { ID = 0, X = 0, Y = 0, VX = 2, Radius = 1 },
            //    new Core.ReducedBruteforceVirtualObject { ID = 1, X = 20, Y = 0, VX = -2, Radius = 5 }
            //);

            Console.WriteLine("SCENE 5:");
            RunSimulation(
                new Core.ReducedBruteforceVirtualObject { ID = 0, X = 0, Y = 0, VX = 0, Radius = 5 },
                new Core.ReducedBruteforceVirtualObject { ID = 1, X = 20, Y = 0, VX = 0, Radius = 5 }
            );


        }

        static void Bruteforce()
        {
            //Console.WriteLine("SCENE 1:");
            //RunSimulation(
            //    new Core.BruteforceVirtualObject { ID = 0, X = 0, Y = 0, VX = 2, Radius = 5 },
            //    new Core.BruteforceVirtualObject { ID = 1, X = 20, Y = 0, VX = -2, Radius = 5 }
            //);

            //Console.WriteLine("SCENE 2:");
            //RunSimulation(
            //    new Core.BruteforceVirtualObject { ID = 0, X = 0, Y = 0, VX = 3, Radius = 5 },
            //    new Core.BruteforceVirtualObject { ID = 1, X = 20, Y = 0, VX = 1, Radius = 5 }
            //);

            //Console.WriteLine("SCENE 3:");
            //RunSimulation(
            //    new Core.BruteforceVirtualObject { ID = 0, X = 0, Y = 0, VX = 2, Radius = 5 },
            //    new Core.BruteforceVirtualObject { ID = 1, X = 20, Y = 0, VX = 0, Radius = 5 }
            //);

            //Console.WriteLine("SCENE 4:");
            //RunSimulation(
            //    new Core.BruteforceVirtualObject { ID = 0, X = 0, Y = 0, VX = 2, Radius = 1 },
            //    new Core.BruteforceVirtualObject { ID = 1, X = 20, Y = 0, VX = -2, Radius = 5 }
            //);

            //Console.WriteLine("SCENE 5:");
            //RunSimulation(
            //    new Core.BruteforceVirtualObject { ID = 0, X = 0, Y = 0, VX = 0, Radius = 5 },
            //    new Core.BruteforceVirtualObject { ID = 1, X = 20, Y = 0, VX = 0, Radius = 5 }
            //);


        }
    }
}
