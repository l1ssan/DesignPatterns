
namespace DesignPatterns.Interpreter
{
    public class NumberExpression : IExpression
    {
       private readonly string _name;
        public NumberExpression(string variableName)
        {
            _name = variableName;
        }
        public double Interpret(Context context)
        {
            return context.GetVariable(_name);
        }
    }
}
