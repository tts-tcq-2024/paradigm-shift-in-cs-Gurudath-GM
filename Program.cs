namespace paradigm_shift_csharp
{
        internal class Program
    {
        #region Test data
        private enum Range
        {
            lowBreach, 
            lowWarning, 
            normal, 
            highWarning, 
            highBreach
        }

        private static List<float> temperature = new List<float>() { 4, 5.5f, 20, 45, 46 };
        private static List<float> stateOfCharge = new List<float>() { 18, 20.5f, 45, 80, 81 };
        private static List<float> chargeRate = new List<float>() { 0.1f, 0.22f, 0.7f, 0.8f, 0.9f };
        #endregion

        static int Main()
        {
            TestRun();
            return 0;
        }

        static void TestRun()
        {
            BMS_Util.Print("Valid tests");
            BatteryManagementSystemTest.TestLowWarning(temperature[(int)Range.lowWarning], stateOfCharge[(int)Range.lowWarning], chargeRate[(int)Range.lowWarning], true);
            BatteryManagementSystemTest.TestNormal(temperature[(int)Range.normal], stateOfCharge[(int)Range.normal], chargeRate[(int)Range.normal], true);
            BatteryManagementSystemTest.TestHighWarning(temperature[(int)Range.highWarning], stateOfCharge[(int)Range.highWarning], chargeRate[(int)Range.highWarning], true);
            BatteryManagementSystemTest.TestLowBreach(temperature[(int)Range.lowBreach], stateOfCharge[(int)Range.lowBreach], chargeRate[(int)Range.lowBreach], true);
            BatteryManagementSystemTest.TestHighBreach(temperature[(int)Range.highBreach], stateOfCharge[(int)Range.highBreach], chargeRate[(int)Range.highBreach], true);

            Console.WriteLine();
            BMS_Util.Print("Invalid tests");
            BatteryManagementSystemTest.TestLowWarning(temperature[(int)Range.lowWarning], stateOfCharge[(int)Range.lowWarning], chargeRate[(int)Range.lowWarning], false);
            BatteryManagementSystemTest.TestHighWarning(temperature[(int)Range.highWarning], stateOfCharge[(int)Range.highWarning], chargeRate[(int)Range.highWarning], false);
            BatteryManagementSystemTest.TestNormal(temperature[(int)Range.normal], stateOfCharge[(int)Range.normal], chargeRate[(int)Range.normal], false);
            BatteryManagementSystemTest.TestLowBreach(temperature[(int)Range.lowBreach], stateOfCharge[(int)Range.lowBreach], chargeRate[(int)Range.lowBreach], false);
            BatteryManagementSystemTest.TestHighBreach(temperature[(int)Range.highBreach], stateOfCharge[(int)Range.highBreach], chargeRate[(int)Range.highBreach], false);
        }
    }
}
