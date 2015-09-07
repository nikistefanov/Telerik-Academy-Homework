//Problem 7. Encode/decode

//Write a program that encodes and decodes a string using given encryption key (cipher).
//The key consists of a sequence of characters.
//The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string with the first of the key, the second – with the second, etc. When the last key character is reached, the next is the first.

using System;
using System.Text;

class DecodingOrEncoding
{
    static StringBuilder Encode(string text, string cipher)
    {
        StringBuilder encodedText = new StringBuilder();

        for (int i = 0; i < text.Length; i++)
        {
            encodedText.Append((char)(text[i] ^ cipher[i]));
        }
        return encodedText;
    }
    static StringBuilder Decode(string enText, string cipher)
    {
        StringBuilder decodedText = new StringBuilder();
        for (int i = 0; i < enText.Length; i++)
        {
            decodedText.Append((char)(enText[i] ^ cipher[i]));
        }
        return decodedText;
    }

    static void Main()
    {
        Console.Write("Text to be encoded: ");
        string inputedText = Console.ReadLine();
        Console.Write("Enter key here: ");
        string textKey = Console.ReadLine();

        //string inputedText = "1111111";
        //string textKey = "ABCD";


        string longerTextKey = textKey;

        while (inputedText.Length > longerTextKey.Length)
        {
            longerTextKey += textKey;
        }

        var entext = Encode(inputedText, longerTextKey).ToString();
        Console.WriteLine("Your text encoded --> {0}", entext);
        var decText = Decode(entext, longerTextKey).ToString();
        Console.WriteLine("Your text dencoded --> {0}", decText);
    }
}
