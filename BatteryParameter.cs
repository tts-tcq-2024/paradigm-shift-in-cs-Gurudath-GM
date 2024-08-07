namespace paradigm_shift_csharp
{
    internal class BatteryParameter
    {
        private static bool bLowCheck, bHighCheck, bWarning, bBreach;
        public static bool Check(float minValue, float maxValue, float value, string parameter) 
        {
            bWarning = earlyWarning(minValue, maxValue, value, parameter);
            bBreach = Breach(minValue, maxValue, value, parameter);
            if (bWarning && bBreach)
                return true;
            return false;
        }

        private static bool earlyWarning(float minValue, float maxValue, float value, string Parameter)
        {
            bLowCheck = BMS_Util.LowWarning(minValue, maxValue, value, Parameter);
            bHighCheck = BMS_Util.HighWarning(minValue, maxValue, value, Parameter);
            if (bLowCheck || bHighCheck)
                return true;
            return false;

        }

        private static bool Breach(float minValue, float maxValue, float value, string parameter)
        {

            bLowCheck = BMS_Util.LowBreach(minValue, maxValue, value, parameter);
            bHighCheck = BMS_Util.HighBreach(minValue, maxValue, value, parameter);
            if (!bLowCheck || !bHighCheck)
                return false;
            return true;
        }
    }
}
