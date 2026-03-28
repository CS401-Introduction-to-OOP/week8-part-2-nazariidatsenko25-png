using Week8;
var container  = new DataContainer<DataItem>();
for (int i = 0; i < 10000;  i++)
{
    var item = new DataItem
    {
        Id = $"item{i}",
        Payload = new byte[1024]
    };
    container.Add(item);
}
Console.WriteLine($"total size before GC: {container.GetTotalSize()}");
GC.Collect();
Console.WriteLine("GC.Collect() was called ");
Console.WriteLine($"total size after GC: {container.GetTotalSize()}");

Console.WriteLine("total size did not changed after calling GC.Collect(), that happened because objects still holding active reference");

