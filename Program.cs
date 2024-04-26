// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices;

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

