using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReducedBruteforce.Core
{
    delegate void ColissionDetectedHandler(VirtualObject obj1, VirtualObject obj2);
    abstract class VirtualObject
    {
        public int ID { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int VX { get; set; }
        public int VY { get; set; }
        public int Radius { get; set; }
        public void Update(VirtualEnvironment env)
        {
            this.X += this.VX;
            this.Y += this.VY;
        }
        public abstract void DetectColission(VirtualEnvironment env);
        protected ColissionDetectedHandler collisionDetectedHandler;
        public event ColissionDetectedHandler CollisionDetected
        {
            add
            {
                collisionDetectedHandler -= value;
                collisionDetectedHandler += value;
            }
            remove
            {
                collisionDetectedHandler -= value;
            }
        }
    }
}
