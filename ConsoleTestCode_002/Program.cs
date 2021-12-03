using System;

namespace ConsoleTestCode_002
{
    enum direct : byte
    {
        east=1,south,west,north
    };

    struct Route
    {
        public direct direction;
        public double distance;
    }

    class Program
    {
        static void Main(string[] args)
        {
            int direction = -1;
            Route MyRoute;
            Console.Write("select direction, 1.east 2.south 3.west 4.north:  ");
            while (true)
            {
                try
                {
                    direction = Convert.ToInt32(Console.ReadLine());
                    if (direction > 0 && direction < 5)
                    {
                        break;
                    }
                    else
                    {
                        Console.Write("select error, select 1-4:  ");
                    }
                }
                catch
                {
                    Console.Write("input error, input 1-4:  ");
                }
            }
            MyRoute.direction = (direct)direction;
            Console.Write("input distance:  ");
            while (true)
            {
                try
                {
                    MyRoute.distance = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.Write("error, input distance:  ");
                }
            }
            Console.WriteLine($"MyRoute, direction is {MyRoute.direction}, distance is {MyRoute.distance}.");
        }
    }
}
