namespace Week8;

public static class BoxingTester
{
    public static void Test()
    {
        int a = 10;
        object b = a;
        int c = (int)b;
        
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);
    }

}