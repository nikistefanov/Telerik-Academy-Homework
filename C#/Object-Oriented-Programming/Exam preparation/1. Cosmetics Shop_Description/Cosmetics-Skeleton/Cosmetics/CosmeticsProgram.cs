namespace Cosmetics
{
    using System;
    using System.IO;

    using Cosmetics.Engine;
    using Cosmetics.Products;

    public class CosmeticsProgram
    {
        public static void Main()
        {
            //using (StreamWriter writer = new StreamWriter("../../myOut.txt"))
            //{
            //    Console.SetOut(writer);
            CosmeticsEngine.Instance.Start();
            //}
        }
    }
}
