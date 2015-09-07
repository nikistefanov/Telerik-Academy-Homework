using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthTask
{
    class EncodeAnd
    {
        static void Main()
        {
            //string message = "TELERIKACADEMY";
            //string cypher = "SOFTWARE";

            string message = Console.ReadLine();
            string cypher = Console.ReadLine();

            StringBuilder encryptedMessage = Encrypt(message, cypher);

            encryptedMessage.Append(cypher);

            StringBuilder encodedAndEncryptedMessage = Encode(encryptedMessage);
            Console.WriteLine(encodedAndEncryptedMessage.ToString() + cypher.Length);
        }

        private static StringBuilder Encrypt(string message, string cypher)
        {
            StringBuilder encrypted = new StringBuilder(message);
            int maxLen = Math.Max(message.Length, cypher.Length);
            for (int i = 0; i < maxLen; i++)
            {
                char messageSymbol = encrypted[i % encrypted.Length];
                char cypherSymbol = cypher[i % cypher.Length];

                int messageSymbolValue = messageSymbol - 'A';
                int cypherSymbolValue = cypherSymbol - 'A';

                int result = (messageSymbolValue ^ cypherSymbolValue) + 'A';

                encrypted[i % encrypted.Length] = (char)result;
            }
            return encrypted;
        }

        private static StringBuilder Encode(StringBuilder encryptedMessage)
        {
            StringBuilder result = new StringBuilder();
            int index = 0;
            while (index < encryptedMessage.Length)
            {
                char current = encryptedMessage[index];
                int count = 0;
                int scanIndex = index;
                while (scanIndex < encryptedMessage.Length)
                {
                    char next = encryptedMessage[scanIndex];
                    if (next != current)
                    {
                        break;
                    }
                    ++count;
                    scanIndex++;
                }
                index = scanIndex;
                if (count <= 2)
                {
                    result.Append(current, count);
                }
                else
                {
                    result.Append(count);
                    result.Append(current);
                }

            }
            return result;
        }


    }
}