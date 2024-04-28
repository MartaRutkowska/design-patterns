public class DollarDecorator: MessegeDecorator
{
    public DollarDecorator(IMessegePrinter messege) : base(messege)
    {
    }

    public override void PrintMessege(string messege){
        Console.Write(" $ ");
        base.PrintMessege(messege);
        Console.Write(" $ ");
    }
}