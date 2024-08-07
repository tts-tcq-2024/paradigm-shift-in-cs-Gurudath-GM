namespace paradigm_shift_csharp
{
    internal class BMS_Util
    {
        private const float tolerance = 0.05f;

        public static bool LowWarning(float minValue, float maxValue, float value, string batteryState)
        {
            if (value > minValue && value <= (minValue + (maxValue * tolerance)))
                Print($"LOW_{batteryState}_WARNING");
            return true;
        }

        public static bool HighWarning(float minValue, float maxValue, float value, string batteryState)
        {
            if (value > (maxValue - (maxValue * tolerance)) && value <= maxValue)
                Print($"HIGH_{batteryState}_WARNING");
            return true;
        }

        public static bool LowBreach(float minValue, float maxValue, float value, string batteryState)
        {
            if (value >= (minValue - minValue) && value <= minValue)
            {
                Print($"{batteryState} is out of range!");
                Print($"LOW_{batteryState}_BREACH");
                return false;
            }
            return true;
        }

        public static bool HighBreach(float minValue, float maxValue, float value, string batteryState)
        {
            if (value > maxValue && value <= (maxValue + minValue))
            {
                Print($"{batteryState} is out of range!");
                Print($"HIGH_{batteryState}_BREACH");
                return false;
            }
            return true;
        }

        public static void Print(string parameter)
        {
            Console.WriteLine(Language.Translator(parameter, Language.selectedLanguage));
            BatteryManagementSystemTest.printActualCount++;
        }
    }
}
