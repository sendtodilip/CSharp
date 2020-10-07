namespace CSharp.DelegateLambdaActionFucPredExpressionTree
{
    public class AnnonynousMethodsEx
    {
        delegate double calAreaPointer(int r);

        public static void Main()
        {
            calAreaPointer cpointer = new calAreaPointer(delegate (int r)
            {
                return 3.14 * r * r;
            });
            double area = cpointer(20);
        }
    }
}