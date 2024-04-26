public class Instalment{
    public double CalculateInstalment(Grades grade, double amount){
        switch(grade){
            case Grades.F:
            return roundInstalment(amount/3);
            case Grades.B:
            return roundInstalment(amount/5);
            case Grades.A:
            return roundInstalment(amount/10);
            case Grades.S:
            return roundInstalment(amount/50);
        }
        return amount*5;
    }

    private double roundInstalment(double amount){
        return Math.Round(amount, 2);
    }
}