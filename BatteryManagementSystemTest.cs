namespace paradigm_shift_csharp
{
    internal class BatteryManagementSystemTest
    {
        private static void ExpectTrue(bool expression)
        {
            if (!expression)
            {
                BatteryStatus.Print("Expected true, but got false");
            }
        }

        private static void ExpectFalse(bool expression)
        {
            if (expression)
            {
                BatteryStatus.Print("Expected false, but got true");
            }
        }

        public static void Execution()
        {
            BatteryStatus.Print("Valid tests");
            BatteryManagementSystemTest.ExpectTrue(BatteryManagementSystem.BatteryIsOk(5.5f, 20.5f, 0.22f));
            BatteryManagementSystemTest.ExpectTrue(BatteryManagementSystem.BatteryIsOk(20, 45, 0.7f));
            BatteryManagementSystemTest.ExpectTrue(BatteryManagementSystem.BatteryIsOk(45, 80, 0.8f));

            Console.WriteLine();
            BatteryStatus.Print("Invalid tests");
            BatteryManagementSystemTest.ExpectTrue(BatteryManagementSystem.BatteryIsOk(46, 81, 0.9f));
            BatteryManagementSystemTest.ExpectFalse(BatteryManagementSystem.BatteryIsOk(20, 45, 0.7f));
            BatteryManagementSystemTest.ExpectTrue(BatteryManagementSystem.BatteryIsOk(4, 18, 0.1f));
        }
    }
}
