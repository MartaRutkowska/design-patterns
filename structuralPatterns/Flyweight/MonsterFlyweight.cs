public class MonsterFlyweight(string name, int speed, int damage)
{

public void Hit()
{
    Console.WriteLine($"{name} hit with {damage} damage");
}

public void Move(){
        Console.WriteLine($"{name} moved with {speed} speed");
}

}