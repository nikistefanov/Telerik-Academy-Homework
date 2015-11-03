using System;
using System.Text;
namespace Company.TestDataGenerator.Content
{
    public static class RandomGenerator
    {
        private const string Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz123456789";

        private static Random random = new Random();

        public static int GetRandomNumber(int min = 0, int max = int.MaxValue /2)
        {
            return random.Next(min, max + 1);
        }

        public static string GetRandomString(int minLength = 0, int maxLength = int.MaxValue /2)
        {
            var length = random.Next(minLength, maxLength);
            var result = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                var symbol = Alphabet[random.Next(0, Alphabet.Length)];
                result.Append(symbol);
            }

            return result.ToString();
        }

        public static DateTime GetRandomDate(DateTime? after = null, DateTime? before = null)
        {
            var minDate = after ?? new DateTime(1995, 1, 1, 0, 0, 0);
            var maxDate = before ?? new DateTime(2030, 12, 28, 23, 59, 59);

            var second = GetRandomNumber(minDate.Second, maxDate.Second);
            var minute = GetRandomNumber(minDate.Minute, maxDate.Minute);
            var hour = GetRandomNumber(minDate.Hour, maxDate.Hour);
            var day = GetRandomNumber(minDate.Day, maxDate.Day);
            var month = GetRandomNumber(minDate.Month, maxDate.Month);
            var year = GetRandomNumber(minDate.Year, maxDate.Year);

            return new DateTime(year, month, day, hour, minute, second);
        }
    }
}
