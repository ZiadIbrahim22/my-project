namespace CLL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CLL c = new CLL();

            Console.Write("Add Element At End : ");
            int n1 = int.Parse(Console.ReadLine());
            c.append(n1);
            c.print();

            Console.Write("Add Element At End : ");
            int n2 = int.Parse(Console.ReadLine());
            c.append(n2);
            c.print();

            Console.Write("Add Element At End : ");
            int n3 = int.Parse(Console.ReadLine());
            c.append(n3);
            c.print();

            Console.Write("Add Element At Front : ");
            int n4 = int.Parse(Console.ReadLine());
            c.addfront(n4);
            c.print();


            Console.ReadKey();
        }
    }
}