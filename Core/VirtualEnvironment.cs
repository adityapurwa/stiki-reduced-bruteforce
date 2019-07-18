using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReducedBruteforce.Core
{
    class VirtualEnvironment
    {
        public List<VirtualObject> Objects { get; set; } = new List<VirtualObject>();
        private List<double> elapseds = new List<double>();
        public int CollisionDetected { get; private set; }
        public void Start()
        {
            foreach (var obj in Objects)
            {
                obj.CollisionDetected += HandleCollisionDetected;
            }
        }

        private void HandleCollisionDetected(VirtualObject obj1, VirtualObject obj2)
        {
            this.CollisionDetected++;
        }

        public void Update()
        {
            foreach (var obj in Objects)
            {
                obj.Update(this);
                var watch = new System.Diagnostics.Stopwatch();
                watch.Start();
                obj.DetectColission(this);
                watch.Stop();
                elapseds.Add(watch.ElapsedTicks);
            }
        }
        public void Debug()
        {
            foreach (var obj in Objects)
            {
                Console.WriteLine($"{obj.ID} {{X: {obj.X}, Y: {obj.Y}}}");
            }
        }
        public double AverageTimeElapsed
        {
            get
            {
                return elapseds.Average();
            }
        }
    }
}
