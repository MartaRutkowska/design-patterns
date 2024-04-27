// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

//Adapter usage example - our service operates on JSON and external service on XML
var myAppService = new AppService();
Console.WriteLine(myAppService.GetJsonData());

var externalService = new ExternalService();
var XmlAdapter = new XmlAdapter(externalService);
Console.WriteLine(XmlAdapter.GetJsonData());

Console.WriteLine();

//Composite design pattern example - folders and files
var root = new Folder("root");
root.AddComponent(new File("file1"));

var folder1 = new Folder("folder1");
folder1.AddComponent(new Folder("folder2"));
folder1.AddComponent(new File("file2"));
root.AddComponent(folder1);

root.AddComponent(new File("file3"));

root.DisplayChildren(string.Empty);

Console.WriteLine();

//Illustrating Facade pattern with absurd loan calculation system
var CreditFacade = new CreditFacade();
CreditFacade.CalculateClientsCredit(10000, 10000);
CreditFacade.CalculateClientsCredit(100000, 300000);
CreditFacade.CalculateClientsCredit(1000000, 80000);

//Illustrate flyweight design pattern
var factory = new MonsterFlyweightFactory();
var monsters = new Dictionary<int, MonsterFlyweight>();
for (int i = 0; i < 40; i ++){
    monsters[i] = factory.CreateMonster("dragon");
}
for (int i = 40; i< 80; i++){
    monsters[i] = factory.CreateMonster("chimera");
}
for(int i = 81; i< 100; i++){
    monsters[i] = factory.CreateMonster("griffin");
}

monsters[51].Hit();
monsters[3].Move();
monsters[98].Hit();