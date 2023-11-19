using AbstractClass_Interface.Interfaces;
namespace AbstractClass_Interface.Services
{
    public class Calculate : ICalculate
    {
        public void Divide(int x, int y)
        {
            Console.WriteLine(x/y);
        }
        public void Minus(int x, int y)
        {
            Console.WriteLine(x - y);
        }
        public void Multiply(int x, int y)
        {
            Console.WriteLine(x * y);
        }
        public void Plus(int x, int y)
        {
            Console.WriteLine(x + y);
        }
    }
}
