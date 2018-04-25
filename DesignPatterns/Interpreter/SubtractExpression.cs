
namespace DesignPatterns.Interpreter
{
    public class SubtractExpression : IExpression
    {
        private readonly IExpression leftExpression;
        private readonly IExpression rightExpression;

        public SubtractExpression(IExpression left, IExpression right)
        {
            leftExpression = left;
            rightExpression = right;
        }

        public double Interpret(Context context)
        {
            return leftExpression.Interpret(context) - rightExpression.Interpret(context);
        }
    }
}
