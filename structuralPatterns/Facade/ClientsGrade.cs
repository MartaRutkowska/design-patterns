public class ClientGrade{
    public Grades CalculateGrade(double annualEarnings){
        switch(annualEarnings){
            case > 0 and < 50000:
            return Grades.F;
            case > 50000 and <= 150000:
            return Grades.B;
            case > 150000 and <= 300000:
            return Grades.A;
            case > 300000:
            return Grades.S;
        }
        return Grades.F;
    }
}