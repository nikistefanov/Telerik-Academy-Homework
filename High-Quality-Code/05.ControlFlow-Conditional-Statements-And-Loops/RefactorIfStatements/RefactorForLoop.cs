namespace RefactorIfStatements
{
    using System;

    public class RefactorForLoop
    {
        public static void Main()
        {
            var potato = new Potato(15);

            if (potato.IsPeeled == false)
            {
                throw new Exception("The potato is not peeled!");
            }

            if (potato.IsRotten == true)
            {
                throw new Exception("The potato is rotten!");
            }

            if (potato != null && potato.IsPeeled && !potato.IsRotten)
            {
                potato.Cook();
            }
        }
    }
}