namespace Week8;

public class NetworkResource : Resource, IDisposable
{
    public NetworkResource(string name) : base(name)
    {
    }

    public override void Open()
    {
        IsOpen = true;
        Console.WriteLine($"{Name} is open");
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
        Console.WriteLine($"{Name} is disposed");
    }
}