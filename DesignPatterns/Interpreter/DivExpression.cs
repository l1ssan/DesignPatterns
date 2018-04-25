
namespace DesignPatterns.Interpreter
{
    public class DivExpression:IExpression
    {
        private readonly IExpression rightExpression;
        private readonly IExpression leftExpression;

        public DivExpression(IExpression left, IExpression right)
        {
            leftExpression = left;
            rightExpression = right;
          
        }

        public double Interpret(Context context)
        {
            return leftExpression.Interpret(context) / rightExpression.Interpret(context);
        }
    }
}
