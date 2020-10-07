namespace CSharp.DelegateLambdaActionFucPredExpressionTree
{
    public class DelegateEx
    {
        delegate double calAreaPointer(int r);
        static calAreaPointer cpointer = CalculateArea;

        private static double CalculateArea(int r)
        {
            return 3.14 * r * r;
        }

        static void Main1(string[] args)
        {
            double area = cpointer.Invoke(20);
        }
    }
}