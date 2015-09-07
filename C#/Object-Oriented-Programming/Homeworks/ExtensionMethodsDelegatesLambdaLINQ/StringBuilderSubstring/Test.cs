namespace StringBuilderSubstring
{
    using System.Text;

    class Test
    {
        static void Main()
        {
            var builder = new StringBuilder("I am just a text, you know!");
            System.Console.WriteLine("Before the use of MySubstring \n{0}", builder.ToString());
            var result = builder.MySubstring(5, 11);
            System.Console.WriteLine("After the use of MySubstring \n{0}", result.ToString());
        }
    }
}
