using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul
{
    interface IOperation
    {
       int OP(int a , int b);
    }
    class ConcreteOPAdd : IOperation
    {
        public int OP(int a, int b)
        {
            return a + b;
        }
    }
    class ConcreteOPSubtract : IOperation
    {
        public int OP(int a, int b)
        {
            return a - b;
        }
    }
    class ConcreteOPMultiply : IOperation
    {
        public int OP(int a, int b)
        {
            return a * b;
        }
    }
    class Context
    {
        private IOperation operation;

        public void setIOperation(IOperation operation)
        {
            this.operation = operation;
        }
        public int GetResult(int a, int b)
        {
            return this.operation.OP(a,b);
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();
            Console.WriteLine("Write first number : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Write second number : ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Select math operation + or - or * : ");
            string choise = Console.ReadLine();
            Console.Clear();
            if (choise == "+")
            {
                context.setIOperation(new ConcreteOPAdd());
            }
            else if (choise == "-")
            {
                context.setIOperation(new ConcreteOPSubtract());
            }
            else if (choise == "*")
            {
                context.setIOperation(new ConcreteOPMultiply());
            }
            else
            {
                Console.WriteLine("You write wrong math operation");
            }
            Console.WriteLine(context.GetResult(a, b));
            Console.ReadKey();
        }
    }
}
