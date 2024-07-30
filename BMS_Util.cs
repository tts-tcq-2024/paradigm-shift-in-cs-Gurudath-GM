namespace BatteryManagementSystem_
{
    internal class BMS_Util
    {
        private const float tolerance = 0.05f;

        public static void LowWarning(float minValue, float maxValue, float value, string batteryState)
        {
            if (value > minValue && value <= (minValue + (maxValue * tolerance)))
                BatteryStatus.Print($"LOW_{batteryState}_WARNING");
        }

        public static void HighWarning(float minValue, float maxValue, float value, string batteryState)
        {
            if (value > (maxValue - (maxValue * tolerance)) && value <= maxValue)
                BatteryStatus.Print($"HIGH_{batteryState}_WARNING");
        }

        public static void LowBreach(float minValue, float maxValue, float value, string batteryState)
        {
            if (value >= (minValue - minValue) && value <= minValue)
            {
                BatteryStatus.Print($"LOW_{batteryState}_WARNING");
                BatteryStatus.Print($"LOW_{batteryState}_BREACH");
            }
        }

        public static void HighBreach(float minValue, float maxValue, float value, string batteryState)
        {
            if (value > maxValue && value <= (maxValue + minValue))
            {
                BatteryStatus.Print($"HIGH_{batteryState}_WARNING");
                BatteryStatus.Print($"HIGH_{batteryState}_BREACH");
            }
        }
    }
}
