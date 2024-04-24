public class File(string name) : IComponent
{
    public string Name => name;

    public void DisplayPath(string currentPath)
    {
        Console.WriteLine(currentPath + Name);
    }
}