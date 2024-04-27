public class MonsterFlyweightFactory{

    private Dictionary<string , MonsterFlyweight> monsters;
    public MonsterFlyweightFactory(){
        monsters = new();
        monsters["chimera"] = new MonsterFlyweight("chimera", 10, 10);
        monsters["dragon"] = new MonsterFlyweight("dragon", 5, 50);
        monsters["griffin"] = new MonsterFlyweight("griffin", 20, 5);
    }

    public MonsterFlyweight CreateMonster(string name)
    {
        return monsters[name] ?? throw new Exception("no monster of such type");
    }
}