using System.ComponentModel.Design;

namespace ConsoleApp4
{
    
    
    









    public class Program

    {
           
        static void Main(string[] args)
        {

         void Except()
            {
                DateMethodClass dateMethod = new DateMethodClass();
                try
                {
                    dateMethod.DateMethod();
                    Console.WriteLine("That is right");

                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message + " try again");
                    
                    Except();

                }
                
              
            }
            Except();
        
        }
    }
}
