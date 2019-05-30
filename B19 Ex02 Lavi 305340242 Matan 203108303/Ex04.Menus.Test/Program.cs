namespace Ex04.Menus.Test
{
    public class Program
    {
        public static void Main()
        {
            DelegateMenuTester delegateTester = new DelegateMenuTester();
            delegateTester.RunDelegateTester();

            InterfaceMenuTester interfaceMenu = new InterfaceMenuTester();
            interfaceMenu.RunInterfaceTester();
        }
    }
}
