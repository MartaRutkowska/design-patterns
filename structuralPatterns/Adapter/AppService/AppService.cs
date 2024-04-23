using Newtonsoft.Json;

public class AppService : IDataLoader
{
    public string GetJsonData(){
        return JsonConvert.SerializeObject(new Person("Andy","Warhol"));
    }
}