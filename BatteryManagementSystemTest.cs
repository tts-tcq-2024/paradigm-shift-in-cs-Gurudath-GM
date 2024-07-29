namespace BatteryManagementSystem_
{
    internal class BatteryManagementSystemTest
    {
        private static void ExpectTrue(bool expression)
        {
            if (!expression)
            {
                Console.WriteLine("Expected true, but got false");
            }
        }

        private static void ExpectFalse(bool expression)
        {
            if (expression)
            {
                Console.WriteLine("Expected false, but got true");
            }
        }

        public static void Execution()
        {
            Console.WriteLine("Valid test");
            BatteryManagementSystemTest.ExpectTrue(BatteryManagementSystem.BatteryIsOk(5, 21, 0.22f));
            BatteryManagementSystemTest.ExpectTrue(BatteryManagementSystem.BatteryIsOk(20, 45, 0.7f));
            BatteryManagementSystemTest.ExpectTrue(BatteryManagementSystem.BatteryIsOk(45, 80, 0.8f));

            Console.WriteLine("\nInvalid test");
            BatteryManagementSystemTest.ExpectTrue(BatteryManagementSystem.BatteryIsOk(46, 81, 0.9f));
            BatteryManagementSystemTest.ExpectFalse(BatteryManagementSystem.BatteryIsOk(5, 20, 0.2f));
            BatteryManagementSystemTest.ExpectFalse(BatteryManagementSystem.BatteryIsOk(46, 81, 0.9f));
        }
    }
}
