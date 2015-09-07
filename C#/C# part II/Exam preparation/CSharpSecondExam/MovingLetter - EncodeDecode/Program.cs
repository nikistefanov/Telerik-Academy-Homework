using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTask
{
    class MovingLetters
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ');

            StringBuilder result = ExctractLetters(words);

            result = MoveLetters(result);
            Console.WriteLine(result.ToString());

        }

        private static StringBuilder MoveLetters(StringBuilder builder)
        {
            for (int i = 0; i < builder.Length; i++)
            {
                char letter = builder[i];
                int indexInAlphabet = Char.ToLower(letter) - 'a' + 1;
                MoveRight(builder, i, indexInAlphabet);
            }
            return builder;
        }

        private static void MoveRight(StringBuilder builder, int index, int count)
        {
            char letter = builder[index]; ;
            int postion = index + count;
            postion %= builder.Length;
            builder.Remove(index, 1);
            builder.Insert(postion, letter);
        }

        private static StringBuilder ExctractLetters(string[] words)
        {
            StringBuilder builder = new StringBuilder();
            int maxWordLength = words.Max(word => word.Length);

            for (int i = 0; i < maxWordLength; i++)
            {

                foreach (string word in words)
                {
                    int index = word.Length - i - 1;
                    bool condition = index >= 0;
                    if (condition)
                    {
                        builder.Append(word[index]);
                    }
                }
            }
            return builder;
        }
    }
}
