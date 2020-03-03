using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eat_It_
{
    class Funkcje
    {
        public static Boolean InAirNoCollision(Gracz p, WorldObject[] worldObjects)
        {
            foreach (WorldObject Obj in worldObjects)
            {
                if (!p.Bounds.IntersectsWith(Obj.Bounds))
                {
                    return true;
                }
            }
            return false;
        }

        public static Boolean Collision_Bottom(Gracz p, WorldObject[] worldObjects)
        {
            foreach (WorldObject x in worldObjects)
            {
                if (x != null)
                {
                    WorldObject temp = new WorldObject();
                    temp.Bounds = x.Bounds;
                    temp.SetBounds(temp.Location.X, temp.Location.Y + temp.Height, temp.Width, 1);
                    if (p.Bounds.IntersectsWith(temp.Bounds))
                        return true;
                }
            }
            return false;
        }

        public static Boolean Collision_Top(Gracz p, WorldObject[] worldObjects)
        {
            foreach (WorldObject x in worldObjects)
            {
                if (x != null)
                {
                    WorldObject temp = new WorldObject();
                    temp.Bounds = x.Bounds;
                    temp.SetBounds(temp.Location.X - 3, temp.Location.Y - 1, temp.Width + 6, 1);
                    if (p.Bounds.IntersectsWith(temp.Bounds))
                        return true;
                }
            }
            return false;
        }

        public static Boolean Collision_Left(Gracz p, WorldObject[] worldObjects)
        {
            foreach (WorldObject x in worldObjects)
            {
                if (x != null)
                {
                    WorldObject temp = new WorldObject();
                    temp.Bounds = x.Bounds;
                    temp.SetBounds(temp.Location.X - 1, temp.Location.Y + 1, 1, temp.Height - 1);
                    if (p.Bounds.IntersectsWith(temp.Bounds))
                        return true;
                }
            }
            return false;
        }
        public static Boolean Collision_Right(Gracz p, WorldObject[] worldObjects)
        {
            foreach (WorldObject x in worldObjects)
            {
                if (x != null)
                {
                    WorldObject temp = new WorldObject();
                    temp.Bounds = x.Bounds;
                    temp.SetBounds(temp.Location.X + temp.Width, temp.Location.Y + 1, 1, temp.Height - 1);
                    if (p.Bounds.IntersectsWith(temp.Bounds))
                        return true;
                }
            }
            return false;
        }

        public static int RandomNumber(int min, int max)
        {
            Random _generator = new Random();
            return _generator.Next(min, max + 1);   
        }

    }
}
