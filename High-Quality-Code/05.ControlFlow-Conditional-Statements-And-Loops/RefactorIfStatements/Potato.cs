namespace RefactorIfStatements
{
    using System;

    public class Potato
    {
        private const int ExpirationDate = 28;

        private bool isPeeled;
        private bool isRotten;

        /// <summary>
        /// This class creates a potato
        /// </summary>
        /// <param name="days">The days of having the potato</param>
        public Potato(int days)
        {
            this.isPeeled = true;
            this.isRotten = days > ExpirationDate ? true : false;
        }

        public bool IsPeeled
        {
            get
            {
                return this.isPeeled;
            }
        }

        public bool IsRotten
        {
            get
            {
                return this.isRotten;
            }
        }

        public void Cook()
        {
            Console.WriteLine("Cooking in process...");
        }
    }
}
