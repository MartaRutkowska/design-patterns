// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Adapter usage example - our service operates on JSON and external service on XML
var myAppService = new AppService();
Console.WriteLine(myAppService.GetJsonData());

var externalService = new ExternalService();
var XmlAdapter = new XmlAdapter(externalService);
Console.WriteLine(XmlAdapter.GetJsonData());