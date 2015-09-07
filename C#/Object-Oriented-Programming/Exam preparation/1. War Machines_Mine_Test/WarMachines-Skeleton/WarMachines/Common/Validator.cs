namespace WarMachines.Common
{
    using System;

    public static class Validator
    {
        public static void CheckIfNull(object obj, string message = null)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(message);
            }
        }

        public static void CheckIfNullOrEmpty(string str, string message = null)
        {
            if (string.IsNullOrEmpty(str))
            {
                 throw new ArgumentException(message);
            }
        }
    }
}
