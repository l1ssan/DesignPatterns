
namespace DesignPatterns.Interpreter
{
    public class MultExpression:IExpression
    {
    
            private readonly IExpression fExpression;
            private readonly IExpression tExpression;

            public MultExpression(IExpression first, IExpression two)
            {
                fExpression = first;
                tExpression = two;
            }

            public double Interpret(Context context)
            {
                return fExpression.Interpret(context) * tExpression.Interpret(context);
            }
        }
    
}
