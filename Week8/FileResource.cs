namespace Week8;

public class FileResource : Resource, IDisposable
{
    public FileResource(string name) : base(name)
    {
    }

    public override void Open()
    {
        IsOpen = true;
        Console.WriteLine($"file {Name} opened");
    }

    public override void Close()
    {
        if(IsOpen)
        {
            IsOpen = false;
            Console.WriteLine($"{Name} is closed");
        }
    }

    public void Dispose()
    {
        Close();
        Console.WriteLine($"file {Name} disposed");
    }
}