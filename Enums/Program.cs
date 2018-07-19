using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }


    class Program
    {
        static void Main(string[] args)
        {
            // Given the name, print out the number
            ShippingMethod method = ShippingMethod.Express;
            Console.WriteLine((int)method);

            // Given the number, print out the name
            int methodID = 3;
            Console.WriteLine((ShippingMethod)methodID);

            // Print out the name
            Console.WriteLine(method.ToString());

            // Convert from string to enum
            string methodName = "Express";
            ShippingMethod shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);





        }
    }
}
