namespace WarMachines
{
    using System;
    using System.IO;
    using WarMachines.Engine;

    public class WarMachinesProgram
    {
        public static void Main()
        {
            using (var sw = new StreamWriter("../../myOut.txt"))
            {
                Console.SetOut(sw);

                WarMachineEngine.Instance.Start();
            }
        }
    }
}
