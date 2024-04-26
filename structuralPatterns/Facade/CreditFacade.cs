public class CreditFacade{
    private readonly ClientGrade clientGrade;
    private readonly FirstRate firstRate;
    private readonly Instalment instalment;

    public CreditFacade(){
        clientGrade = new ClientGrade();
        firstRate = new FirstRate();
        instalment = new Instalment();
    }

    public void CalculateClientsCredit(double amount, double annualEarnings){
        var grade = clientGrade.CalculateGrade(annualEarnings);
        var rate = firstRate.CalculateFirstRate(grade);
        var instal = instalment.CalculateInstalment(grade, amount);

        Console.WriteLine($"Your grade is: {grade}, for loan of {amount} your first rate will be {rate} and your monthly instalment will be: {instal}");
    }

}