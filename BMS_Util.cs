namespace BatteryManagementSystem_
{
    internal class BMS_Util
    {
        private const float tolerance = 0.05f;

        public static void LowWarning(float minValue, float maxValue, float value, string batteryState)
        {
            if (value > minValue && value <= (minValue + (maxValue * tolerance)))
                Console.WriteLine($"LOW_{batteryState}_WARNING");
        }

        public static void HighWarning(float minValue, float maxValue, float value, string batteryState)
        {
            if (value > (maxValue - (maxValue * tolerance)) && value <= maxValue)
                Console.WriteLine($"HIGH_{batteryState}_WARNING");
        }

        public static void LowBreach(float minValue, float maxValue, float value, string batteryState)
        {
            if (value >= (minValue - minValue) && value <= minValue)
            {
                Console.WriteLine($"LOW_{batteryState}_BREACH");
                Console.WriteLine($"LOW_{batteryState}_WARNING");
            }
        }

        public static void HighBreach(float minValue, float maxValue, float value, string batteryState)
        {
            if (value > maxValue && value <= (maxValue + minValue))
            {
                Console.WriteLine($"HIGH_{batteryState}_BREACH");
                Console.WriteLine($"HIGH_{batteryState}_WARNING");
            }
        }
    }
}
