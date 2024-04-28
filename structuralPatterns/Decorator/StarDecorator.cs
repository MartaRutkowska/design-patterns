public class StarDecorator : MessegeDecorator
{
    public StarDecorator(IMessegePrinter messege) : base(messege)
    {
    }

    public override void PrintMessege(string messege){
        Console.Write(" * ");
        base.PrintMessege(messege);
        Console.Write(" * ");
    }
}