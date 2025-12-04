using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFirst
{
    class Device
    {
        public virtual void TurnOn(string user,string time)
        {
            Console.WriteLine($" Turning On {user} on this {time}");
        }
    
    }
    class TV : Device 
    {
        public override void TurnOn(string user,string time)
        {
            Console.WriteLine($" Turning On {user} on this {time}");    
        }
    }
    class AC : Device
    {
        public override void TurnOn(string user, string time)
        { 
            Console.WriteLine($" Turning On {user} on this {time}");
        }
    }
    class Music_System: Device
    {
        public override void TurnOn(string user, string time)
        {
            Console.WriteLine($" Turning On {user} on this {time}");
        }
    }
    internal class method_overriding
    {
        static void Main(string[] args)
        {
            Device d1 = new TV();
            d1.TurnOn("Dipali","7:30");
            Device d2 = new AC();
            d1.TurnOn("Apeksh","4:30");
            Device d3 = new Music_System();
            d1.TurnOn("Lokesh","5:14");
            Console.ReadLine();
        }
    }
}
