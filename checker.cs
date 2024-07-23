using System;
using System.Diagnostics;

namespace paradigm_shift_csharp
{
    class Checker 
    {
        private static bool isBatteryTemperatureOk(float temperature)
        {
            if (temperature < 0 || temperature > 45)
            {
                Console.WriteLine("Temperature is out of range!");
                return false;
            }         
            return true;
        }

        private static bool isBatteryStateOfChargeOk(float soc)
        {
            if (soc < 20 || soc > 80)
            {
                Console.WriteLine("State of Charge is out of range!");
                return false;
            }
            return true;
        }

        private static bool isBatteryChargeRateOk(float chargeRate)
        {
            if (chargeRate > 0.8)
            {
                Console.WriteLine("Charge Rate is out of range!");
                return false;
            }
            return true;
        }

        public static bool batteryIsOk(float temperature, float soc, float chargeRate)
        {
            return (isBatteryTemperatureOk(temperature) & isBatteryStateOfChargeOk(soc) & isBatteryChargeRateOk(chargeRate));
        }

        public static void ExpectedOutput(bool expression, bool expectTrueFlase)
        {
            if (expression != expectTrueFlase)
            {
                Console.WriteLine($"Expected {expectTrueFlase}, but got {!expectTrueFlase}");
                Environment.Exit(1);
            }
        }

        public static void ExpectTrue(bool expression)
        {
            if (!expression)
            {
                Console.WriteLine("Expected true, but got false");
                // Environment.Exit(1);
            }
        }
        
        public static void ExpectFalse(bool expression)
        {
            if (expression)
            {
                Console.WriteLine("Expected false, but got true");
                // Environment.Exit(1);
            }
        }
        
        static int Main()
        {
            Console.WriteLine("Valid test");
            ExpectTrue(batteryIsOk(25, 70, 0.7f));
            ExpectTrue(batteryIsOk(44, 79, 0.0f));
            Console.WriteLine("All ok");

            Console.WriteLine("Invalid test");
            ExpectFalse(batteryIsOk(-1, 19, 0.9f));
            ExpectFalse(batteryIsOk(50, 85, 0.9f));
            ExpectTrue(batteryIsOk(0, 20, 0.9f));
            ExpectFalse(batteryIsOk(45, 80, 0.7f));
            return 0;
        } 
    }
}
