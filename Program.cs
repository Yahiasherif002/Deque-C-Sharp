internal partial class Program
{
    private static void Main(string[] args)
    {
       Deque<char> deque = new Deque<char>();
        deque.Add('r','o','g','r','a','m','m','e');
        deque.AddFront('P');
        deque.AddRear('r');
        foreach (char c in deque)
        {
            Console.Write(c+" ");
        }


        Console.ReadKey();
    }
}