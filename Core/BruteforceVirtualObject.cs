using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReducedBruteforce.Core
{
    class BruteforceVirtualObject : VirtualObject
    {
        public override void DetectColission(VirtualEnvironment env)
        {
            foreach (var obj in env.Objects)
            {
                if (obj.ID != this.ID)
                {
                    if (
                        obj.X + obj.Radius >= this.X - this.Radius &&
                        obj.X - obj.Radius <= this.X + this.Radius &&
                        obj.Y + obj.Radius >= this.Y - this.Radius &&
                        obj.Y - obj.Radius <= this.Y + this.Radius
                        )
                    {
                        this.collisionDetectedHandler?.Invoke(this, obj);
                    }
                }
            }
        }

    }
}
