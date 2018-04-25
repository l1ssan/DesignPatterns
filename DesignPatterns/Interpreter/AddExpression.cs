
namespace DesignPatterns.Interpreter
{
    public class AddExpression : IExpression
    {
        private readonly IExpression fExpression;
        private readonly IExpression tExpression;

        public AddExpression(IExpression first, IExpression two)
        {
            fExpression = first;
            tExpression = two;
        }

        public double Interpret(Context context)
        {
            return fExpression.Interpret(context) + tExpression.Interpret(context);
        }
    }
}
