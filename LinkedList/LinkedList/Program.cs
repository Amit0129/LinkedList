namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is UnOrdered LinkedList API Program");

            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.Display();

            //The Append Method is Same As Add Method Show in Program But We need Ins Sequence

        }
    }
}