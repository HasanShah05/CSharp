using System.Text;

namespace learningApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var builder = new StringBuilder();
            for (int i = 0; i <= 5; i++)
            {
                builder.Append("item ").Append(i).Append(",");
            }
            var result = builder.ToString();
            Console.WriteLine(result);
            string name = "Hasan";
            if (name is not null)
            {
                Console.WriteLine($"Name has {name.Length} characters.");
            }
            else
            {
                Console.WriteLine("Name is null.");
            }
            string a = "Hello";
            String b = "Hello";
            Console.WriteLine(a == b);
            Console.WriteLine(typeof(string) == typeof(String));
        }
    }
}
