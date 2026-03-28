using Week8;

var file = new FileResource("report.txt");
var network = new NetworkResource("api.company.local");
var manager  = new ResourceManager<Resource>();

manager.Add(file);
manager.Add(network);
manager.OpenAll();
manager.CloseAll();
using (var res = new FileResource("report.txt"))
{
    res.Open();
}
Console.WriteLine("Done");
