namespace paradigm_shift_csharp
{
    internal class BatteryManagementSystemTest
    {
        private static bool actual;
        public static ushort printActualCount;
        private static ushort printExpectedCount = 43;
        private static void ExpectedResult(bool expected, bool actual)
        {
            if (!expected && actual)
                BMS_Util.Print($"Expected {actual}, but got {expected}");
        }

        public static void TestLowWarning(float Temperature, float stateOfCharge, float chargeRate, bool expected)
        {
            actual = BatteryManagementSystem.BatteryIsOk(Temperature, stateOfCharge, chargeRate);
            ExpectedResult(expected, actual);
        }

        public static void TestHighWarning(float temperature, float stateOfCharge, float chargeRate, bool expected)
        {
            actual = BatteryManagementSystem.BatteryIsOk(temperature, stateOfCharge, chargeRate);
            ExpectedResult(expected, actual);
        }
        public static void TestLowBreach(float temperature, float stateOfCharge, float chargeRate, bool expected)
        {
            actual = BatteryManagementSystem.BatteryIsOk(temperature, stateOfCharge, chargeRate);
            ExpectedResult(expected, actual);
        }
        public static void TestHighBreach(float temperature, float stateOfCharge, float chargeRate, bool expected)
        {
            actual = BatteryManagementSystem.BatteryIsOk(temperature, stateOfCharge, chargeRate);
            ExpectedResult(expected, actual);
        }

        public static void TestNormal(float temperature, float stateOfCharge, float chargeRate, bool expected)
        {
            actual = BatteryManagementSystem.BatteryIsOk(temperature, stateOfCharge, chargeRate);
            ExpectedResult(expected, actual);
            if (actual == expected)
                BMS_Util.Print("Battery parameters are within the range!");
        }

        public static void TestPrint()
        {
            if (printActualCount == printExpectedCount)
                BMS_Util.Print("Error!");
        }
    }
}
