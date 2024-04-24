public class Folder: IComponent
{
    private List<IComponent> Children;

    public string Name {get;}

    public Folder( string name )
    {
        Name = name;
        Children = [];
    }

    public void AddComponent(IComponent component)
    {
        Children.Add(component);
    }

    public void RemoveComponent(IComponent component)
    {
        var child = Children.FirstOrDefault(x => x.Name == component.Name);
        if(child != null) Children.Remove(child);
    }

    public void DisplayPath(string currentPath)
    {
        Console.WriteLine(currentPath + Name + Path.DirectorySeparatorChar);
    }

    public void DisplayChildren(string currentPath){

         foreach (var item in Children) 
        {
            item.DisplayPath(currentPath + Name + Path.DirectorySeparatorChar);
            if (item is Folder folder) 
            {
                folder.DisplayChildren(currentPath + Name + Path.DirectorySeparatorChar);
            } 
        }
    }
}