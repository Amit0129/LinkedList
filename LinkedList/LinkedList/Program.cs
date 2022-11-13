namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is UnOrdered LinkedList API Program");

            LinkedList<int> numberLst = new LinkedList<int>();
            numberLst.AddLast(56);
            numberLst.AddLast(30);
            numberLst.AddLast(70);

            foreach (int item in numberLst)
            {
                Console.WriteLine(item);
            }

        }
    }
}