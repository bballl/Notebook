using Notebook.Database;

namespace Notebook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            FillDatabase.Fill();

            Console.WriteLine("Выполнено.");

            var list = GetListEntries.Get();
            
            foreach (var entry in list)
            {
                Console.WriteLine(entry.Id);
            }

            Console.ReadKey();
        }
    }
}