using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace Формулы
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "formula.txt";
            if (File.Exists(path))
            { string text = File.ReadAllText(path);
                Stack<char> functions = new Stack<char>();
                Stack<int> numbers = new Stack<int>();

                foreach (char symbol in text)
                {
                    if (Char.IsLetter(symbol))
                        functions.Push(symbol);
                    if (Char.IsDigit(symbol))
                        numbers.Push(Int32.Parse(symbol.ToString()));
                    if (symbol == ')')
                        if (functions.Peek() == 'm')
                        {
                            functions.Pop();
                            int a = numbers.Pop();
                            int b = numbers.Pop();
                            numbers.Push(Math.Min(a, b));
                        }
                        else
                        {
                            functions.Pop();
                            int a = numbers.Pop();
                            int b = numbers.Pop();
                            numbers.Push(Math.Max(a, b));
                        }
                }

                Console.WriteLine(numbers.Peek());
            }

            Console.ReadLine();
        }
    }
}
