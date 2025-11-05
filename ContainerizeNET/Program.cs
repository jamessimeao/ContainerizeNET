using System.Threading.Tasks;

namespace ContainerizeNET
{
    internal class Program
    {
        public static async Task Main()
        {
            int i = 0;
            while (true)
            {
                Console.WriteLine(i);
                i++;
                await Task.Delay(TimeSpan.FromSeconds(1));
            }
        }
    }
}