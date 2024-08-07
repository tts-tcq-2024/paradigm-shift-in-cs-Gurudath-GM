namespace paradigm_shift_csharp
{
    internal class BatteryManagementSystem
    {
        private static bool IsBatteryTemperatureOk(float temperature)
        {
            float minTemperature = 5, maxTemperature = 45;
            return BatteryParameter.Check(minTemperature, maxTemperature, temperature, "TEMPERATURE");
        }

        private static bool IsBatteryStateOfChargeOk(float stateOfCharge)
        {
            float minStateOfCharge = 20, maxStateOfCharge = 80;
            return BatteryParameter.Check(minStateOfCharge, maxStateOfCharge, stateOfCharge, "SoC");
        }

        private static bool IsBatteryChargeRateOk(float chargeRate)
        {
            float minChargeRate = 0.2f, maxChargeRate = 0.8f;
            return BatteryParameter.Check(minChargeRate, maxChargeRate, chargeRate, "CHARGE_RATE");
        }

        public static bool BatteryIsOk(float temperature, float stateOfCharge, float chargeRate)
        {
            return (IsBatteryTemperatureOk(temperature) & IsBatteryStateOfChargeOk(stateOfCharge) & IsBatteryChargeRateOk(chargeRate));
        }
    }
}
