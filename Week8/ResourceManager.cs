namespace Week8;

public class ResourceManager<T> where T : Resource
{
    private List<T> _resources = new();

    public void Add(T resource)
    {
        
        _resources.Add(resource);
        Console.WriteLine($"that file: {resource.Name} was added to manager");
    }

    public void OpenAll()
    {
        foreach (var resource in _resources)
        {
            resource.Open();
        }
    }

    public void CloseAll()
    {
        foreach (var resource in _resources)
        {
            resource.Close();
        }
    }
    

}