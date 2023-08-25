
namespace ConsoleApp5
{
    public class Program
    {
        static void Main(string[] args)

        {
            
            string input = Console.ReadLine()!;  
            DateTime dateTime = DateTime.ParseExact(input, "dd/MM/yyyy", null);
            TimeSpan timeSpan1 = new TimeSpan(30,6,17,0);
            DateTime dateTime2 =dateTime.Add(timeSpan1);
            Console.WriteLine(dateTime2.ToString("dd/MM/yyyy"));
            
            Console.WriteLine(dateTime2.ToString("mm/HH/dd/MM/yyyy"));//added for showing minutes and hours
        }
    }
}