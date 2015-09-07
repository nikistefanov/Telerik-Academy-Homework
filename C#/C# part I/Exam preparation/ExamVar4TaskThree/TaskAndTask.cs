using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamVar4TaskThree
{
    class TaskAndTask
    {
        static void Main()
        {
            string expresion = Console.ReadLine();
            //string expresion = "4+6/5";

            decimal result = 0;
            decimal currentBracketResult = 0;
            char currentOperator = '+';

            char currentBracketOperator = '+';
            bool inBracket = false;

            foreach (char symbol in expresion)
            {
                if (symbol == '(')
                {
                    inBracket = true;
                    continue;
                }
                if (symbol == ')')
                {
                    inBracket = false;
                    switch (currentOperator)
                    {
                        case '+': result += currentBracketResult; break;
                        case '-': result -= currentBracketResult; break;
                        case '*': result *= currentBracketResult; break;
                        case '/': result /= currentBracketResult; break;
                    }

                    currentBracketResult = 0;
                    currentBracketOperator = '+';
                }

                if (symbol == '+' || symbol == '-' || symbol == '*' || symbol == '/')
                {
                    if (inBracket)
                    {
                        currentBracketOperator = symbol;
                    }
                    else
                    {
                        currentOperator = symbol;
                    }
                }
                //if (Char.IsDigit(symbol))
                if (symbol >= '0' && symbol <= '9')
                {
                    int currentNumber = symbol - '0';
                    if (inBracket)
                    {
                        switch (currentBracketOperator)
                        {
                            case '+': currentBracketResult += currentNumber; break;
                            case '-': currentBracketResult -= currentNumber; break;
                            case '*': currentBracketResult *= currentNumber; break;
                            case '/': currentBracketResult /= currentNumber; break;
                        }
                    }
                    else
                    {
                        switch (currentOperator)
                        {
                            case '+': result += currentNumber; break;
                            case '-': result -= currentNumber; break;
                            case '*': result *= currentNumber; break;
                            case '/': result /= currentNumber; break;
                        }
                    }

                }
            }
            Console.WriteLine("{0:F2}", result);
        }
    }
}

