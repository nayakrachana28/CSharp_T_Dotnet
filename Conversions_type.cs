using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_CSharp
{
    
        interface I
        {
            void Name();
        }

        struct S : I
        {
            public void Name()
            {
                Console.WriteLine("Name is Rachana");
            }
        }

    struct Point
    {
        public int x, y;
        public Point(int x,int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    //Implicit Converstion

    class Vechicle
    {
        public int velId;
        public static implicit operator Brand(Vechicle v)
        {
            Brand brand = new Brand();
            brand.brandId = v.velId+2;
            return brand;
        }
    }

    class Brand
    {
        public int brandId;
        public static implicit operator Vechicle(Brand b)
        {
            Vechicle v = new Vechicle();
            v.velId = b.brandId - 1;
            return v;
        }
    }
    
    internal class Conversions_type
    {
        public static void Main()
        {
            S s = new S();
            s.Name();
            //Object box = s;

            Point p = new Point(10,20);
            Object box = p;
            p.x = 20;
            Console.WriteLine(((Point)box).x);

            Vechicle vechicle = new Vechicle();
            vechicle.velId = 1;
            Console.WriteLine(vechicle.velId);
            Brand b = vechicle;
            Console.WriteLine(b.brandId);
            Vechicle v1 = b;
            Console.WriteLine(v1.velId);
        }
    }
}
