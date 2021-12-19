using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab18
{
    internal class Program
    {
        /*1.    Дана строка, содержащая скобки трёх видов (круглые, квадратные и фигурные) и любые другие символы. Проверить, корректно ли в ней расставлены скобки.
         * Например, в строке ([]{})[] скобки расставлены корректно, а в строке ([]] — нет.
         * Указание: задача решается однократным проходом по символам заданной строки слева направо; для каждой открывающей скобки в строке в стек помещается
         * соответствующая закрывающая, каждая закрывающая скобка в строке должна соответствовать скобке из вершины стека (при этом скобка с вершины стека
         * снимается); в конце прохода стек должен быть пуст.*/

        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            Stack<char> stack = new Stack<char>();
            bool err=false;
            for (int i = 0; i < str.Length; i++)
            {
                switch (str[i])
                {
                    case '(':
                        stack.Push(')');
                        break;
                    case '[':
                        stack.Push(']');
                        break;

                    case '{':
                        stack.Push('}');
                        break;

                    case ')':
                        if (stack.Count == 0 || stack.Pop()!= ')')
                        {
                            err = true;
                        }
                        break;

                    case ']':
                        if (stack.Count == 0 || stack.Pop() != ']')
                        {
                            err = true;
                        }
                        break;
                    case '}':
                        if (stack.Count == 0 || stack.Pop() != '}')
                        {
                            err = true;
                            
                        }
                        break;
                    default:
                        break;
                }
            
            }

            if (stack.Count == 0&err==false)
            {
               Console.WriteLine("В строке нет ошибок со скобками");
            }
            else
            {  
            Console.WriteLine("Не закрыты скобки");
            }
            
            Console.ReadKey();
            
        }
    }
}
