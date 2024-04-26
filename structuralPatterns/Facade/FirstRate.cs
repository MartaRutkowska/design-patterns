public class FirstRate{
    public Dictionary<Grades, double> firstRates = 
    new Dictionary<Grades, double> 
    {{Grades.F, 70000}, {Grades.B, 50000 }, {Grades.A, 30000}, {Grades.S, 10000}};
    
    public double CalculateFirstRate(Grades grade) => firstRates[grade];
}