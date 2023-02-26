namespace SymbolAlgebra
{
    interface Operator
    {
        public double Calc();
        public bool Calculated { get; set; }
        public List<Operator>? Operands { get; set; }
        public double? Val { get; set; }
    }
    class Plus : Operator
    {
        public Plus(string param)
        {

        }
        public double Calc()
        {
            double result = 0;
            for (int i = 0; i < Operands.Count; i++)
            {
                result+= Operands[i].Calc();
            }
            return result;
        }
        public bool Calculated { get; set; } = false;
        public List<Operator>? Operands { get; set; } = null;
        public double? Val { get; set; } = null;
    }
    class Value : Operator
    {
        public Value(double val)
        {
            Val = val;
        }
        public double Calc() => (double)Val;
        public bool Calculated { get; set; } = true;
        public List<Operator>? Operands { get; set; } = null;
        public double? Val { get; set; }
    }
}
