namespace BatteryManagementSystem_
{
    internal class BatteryManagementSystem
    {
        static bool check = true;
        private static bool IsBatteryTemperatureOk(float temperature)
        {
            check = true;
            float minTemperature = 5, maxTemperature = 45;
            if (temperature < minTemperature || temperature > maxTemperature)
            {
                BatteryStatus.Print("Temperature is out of range!");
                check =  false;
            }
            BatteryStatus.Check(minTemperature, maxTemperature, temperature, "TEMPERATURE");
            return check;
        }

        private static bool IsBatteryStateOfChargeOk(float stateOfCharge)
        {
            check = true;
            float minStateOfCharge = 20, maxStateOfCharge = 80;
            if (stateOfCharge < minStateOfCharge || stateOfCharge > maxStateOfCharge)
            {
                BatteryStatus.Print("State of Charge is out of range!");
                check = false;
            }
            BatteryStatus.Check(minStateOfCharge, maxStateOfCharge, stateOfCharge, "SoC");
            return check;
        }

        private static bool IsBatteryChargeRateOk(float chargeRate)
        {
            check = true;
            float minChargeRate = 0.2f, maxChargeRate = 0.8f;
            if (chargeRate < minChargeRate || chargeRate > maxChargeRate)
            {
                BatteryStatus.Print("Charge Rate is out of range!");
                check = false;                                           
            }
            BatteryStatus.Check(minChargeRate, maxChargeRate, chargeRate, "CHARGE_RATE");
            return check;
        }

        public static bool BatteryIsOk(float temperature, float stateOfCharge, float chargeRate)
        {
            return (IsBatteryTemperatureOk(temperature) & IsBatteryStateOfChargeOk(stateOfCharge) & IsBatteryChargeRateOk(chargeRate));
        }
    }
}
