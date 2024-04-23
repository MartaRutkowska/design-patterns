using System.Xml.Serialization;
using Newtonsoft.Json;

public class XmlAdapter(ExternalService externalService) : IDataLoader
{
    private readonly ExternalService externalService = externalService;

    public string GetJsonData()
    {
        var xmlSerializer = new XmlSerializer(typeof(ExternalPerson));
        var reader = new StringReader(externalService.GetXmlData());
        var result = xmlSerializer.Deserialize(reader);

        if(result != null)
        {
            var person = (ExternalPerson)result;
            return person != null
                ? JsonConvert.SerializeObject(new Person(person.Name, person.Surname))
                : throw new Exception("Could not parse XML data to class");
        }
        else
        {
            throw new Exception("Could not read data from external service.");
        }
    }
}