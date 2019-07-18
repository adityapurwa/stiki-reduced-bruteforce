using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReducedBruteforce.Core
{
    class ReducedBruteforceVirtualObject : VirtualObject
    {
        private int? _collisionRankCache = null;
        private int _collisionRank
        {
            get
            {
                if (!_collisionRankCache.HasValue)
                {
                    _collisionRankCache = Math.Abs(VX * Radius + VY * Radius);
                }
                return _collisionRankCache.Value;
            }
        }
        private int _collisionDecay = 0;
        public override void DetectColission(VirtualEnvironment env)
        {
            // Not important for colission check
            if (_collisionRank < 20 && _collisionDecay < 5)
            {
                _collisionDecay++;
                return;
            }
            _collisionDecay = 0;
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
