using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CetvrtiZadatak.Classes
{
    public class CollisionDetector
    {
        public static bool Overlaps(IPhysicalObject2D a, IPhysicalObject2D b)
        {
            // return true if overlaps , false otherwise ...
            Rectangle objA = new Rectangle((int)a.X, (int)a.Y, a.Width, a.Height);
            Rectangle objB = new Rectangle((int)b.X, (int)b.Y, b.Width, b.Height);
            if (objA.Intersects(objB))
            {
                return true;
            }
            return false;
        }
    }
}
