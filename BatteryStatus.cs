using System;
namespace BatteryManagementSystem_
{
    internal class BatteryStatus
    {
        private const float tolerance = 0.05f;
        public static void Check(float minValue, float maxValue, float value, string batteryState) 
        {
            CheckWarning(minValue, maxValue, value, batteryState); 
        }

        private static void CheckWarning(float minValue, float maxValue, float value, string batteryState)
        {
            if (value > minValue && value <= (minValue + (maxValue * tolerance)))
            {
                Console.WriteLine($"LOW_{batteryState}_WARNING");
            }
            else if (value > (maxValue - (maxValue * tolerance)) && value <= maxValue)
            {
                Console.WriteLine($"HIGH_{batteryState}_WARNING");
            }
            CheckBreach(minValue, maxValue, value, batteryState);
        }

        private static void CheckBreach(float minValue, float maxValue, float value, string batteryState)
        {
            if(value >= (minValue - minValue) && value  <= minValue)
            {

                Console.WriteLine($"LOW_{batteryState}_BREACH");
                Console.WriteLine($"LOW_{batteryState}_WARNING");
            }
            else if(value > maxValue && value <= (maxValue + minValue))
            {
                Console.WriteLine($"HIGH_{batteryState}_BREACH");
                Console.WriteLine($"HIGH_{batteryState}_WARNING");
            }
        }
    }
}
