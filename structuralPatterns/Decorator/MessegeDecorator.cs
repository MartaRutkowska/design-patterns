public abstract class MessegeDecorator: IMessegePrinter
{
    public IMessegePrinter messege {get; set;}

    public MessegeDecorator(IMessegePrinter messege){
        this.messege = messege;
    }


    public virtual void PrintMessege(string messege){
        this.messege.PrintMessege(messege);
    }
}