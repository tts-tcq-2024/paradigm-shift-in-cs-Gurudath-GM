namespace BatteryManagementSystem_
{
    internal class BatteryManagementSystem
    {
        static bool check = true;
        private static bool IsBatteryTemperatureOk(float temperature)
        {
            float minTemperature = 5, maxTemperature = 45;
            if (temperature < minTemperature || temperature > maxTemperature)
            {
                Console.WriteLine("Temperature is out of range!");
                check =  false;
            }
            BatteryStatus.Check(minTemperature, maxTemperature, temperature, "Temperature");
            return check;
        }

        private static bool IsBatteryStateOfChargeOk(float stateOfCharge)
        {
            float minStateOfCharge = 20, maxStateOfCharge = 80;
            if (stateOfCharge < minStateOfCharge || stateOfCharge > maxStateOfCharge)
            {
                Console.WriteLine("State of Charge(SoC) is out of range!");
                check = false;
            }
            BatteryStatus.Check(minStateOfCharge, maxStateOfCharge, stateOfCharge, "StateOfCharge");
            return check;
        }

        private static bool IsBatteryChargeRateOk(float chargeRate)
        {
            float minChargeRate = 0.2f, maxChargeRate = 0.8f;
            if (chargeRate < minChargeRate || chargeRate > maxChargeRate)
            {
                Console.WriteLine("Charge Rate is out of range!");
                check = false;                                           
            }
            BatteryStatus.Check(minChargeRate, maxChargeRate, chargeRate, "ChargeRate");
            return check;
        }

        public static bool BatteryIsOk(float temperature, float stateOfCharge, float chargeRate)
        {
            return (IsBatteryTemperatureOk(temperature) 
                & IsBatteryStateOfChargeOk(stateOfCharge) 
                & IsBatteryChargeRateOk(chargeRate));
        }
    }
}
