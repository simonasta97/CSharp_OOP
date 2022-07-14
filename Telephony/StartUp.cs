
using System;

namespace Telephony
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split();
            string[] urls = Console.ReadLine().Split();

            Smartphone smartphone = new Smartphone();
            var stationaryPhone = new StationaryPhone();
    
        foreach (var number in numbers)
            {
                if (number.Length == 10)
                {
                    Console.WriteLine(smartphone.Call(number));
                }
                else if (number.Length == 7)
                {
                    Console.WriteLine(stationaryPhone.Call(number));
                }
            }

            foreach (var url in urls)
            {
                Console.WriteLine(smartphone.Browse(url));
            }
        }
    }
}
