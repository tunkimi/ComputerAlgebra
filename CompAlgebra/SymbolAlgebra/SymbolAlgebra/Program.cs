
using SymbolAlgebra;

static class Program
{
    public static void Main(string[] args)
    {
        Value v1 = new Value(1);
        Value v2 = new Value(2);
        Value v3 = new Value(3);
        Plus p1 = new Plus("") { Calculated = false, Val = null, Operands = new List<Operator> { v1, v2, v3 } };
        Console.WriteLine(p1.Calc());
        Console.ReadKey();
    }
}