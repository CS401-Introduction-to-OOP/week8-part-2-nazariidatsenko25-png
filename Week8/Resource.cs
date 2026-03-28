namespace Week8;

public abstract class Resource
{
    public string Name { get; }
    public bool IsOpen { get; private set; }
    protected Resource(string name)
    {
        Name = name;
        IsOpen = false;
    }

    public abstract void Open();
    public abstract void Close();
    

}