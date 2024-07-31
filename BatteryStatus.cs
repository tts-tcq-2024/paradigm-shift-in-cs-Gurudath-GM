namespace paradigm_shift_csharp
{
    internal class BatteryStatus
    {
        public static void Check(float minValue, float maxValue, float value, string batteryState) 
        {
            Warning(minValue, maxValue, value, batteryState); 
            Breach(minValue, maxValue, value, batteryState);
        }

        private static void Warning(float minValue, float maxValue, float value, string batteryState)
        {
            BMS_Util.LowWarning(minValue, maxValue, value, batteryState);
            BMS_Util.HighWarning(minValue, maxValue, value, batteryState);
        }

        private static void Breach(float minValue, float maxValue, float value, string batteryState)
        {

            BMS_Util.LowBreach(minValue, maxValue, value, batteryState);
            BMS_Util.HighBreach(minValue, maxValue, value, batteryState);
        }

        public static void Print(string batteryStatus) 
        {
            Console.WriteLine(Language.Translator(batteryStatus, Language.selectedLanguage));
        }
    }
}
