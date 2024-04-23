// class representing external service that provides XML data
using System.Xml;

public sealed class ExternalService
{
    public string GetXmlData(){
        XmlDocument xmlDocument = new XmlDocument();
        xmlDocument.Load("..\\..\\..\\structuralPatterns\\Adapter\\ExternalService\\xmlObject.xml"); 
        return xmlDocument.InnerXml;
    }
}