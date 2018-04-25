
namespace DesignPatterns.Interpreter
{
    public interface IExpression
    {
        double Interpret(Context context);
        
    }
}
