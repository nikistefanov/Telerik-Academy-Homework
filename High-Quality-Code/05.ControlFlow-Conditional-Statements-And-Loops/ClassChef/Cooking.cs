namespace ChefClass
{
    using System;

    public class Cooking
    {
        public static void Main()
        {
            var chefMancho = new Chef();
            var tendjera = chefMancho.Cook();
            Console.WriteLine(tendjera);
        }
    }
}
