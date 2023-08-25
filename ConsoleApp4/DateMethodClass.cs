using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
   


        public class DateMethodClass
        {

            public void DateMethod()
            {

                string input = Console.ReadLine()!;


                //if (input != DateTime.ParseExact(input, "dd|MM|yyyy", null).ToString("dd|MM|yyyy"))
                //{
                //    throw new FormatException("Wrong Format");
                //}




                DateTime dateTime = DateTime.ParseExact(input, "dd|MM|yyyy", null);




                Console.WriteLine(dateTime.ToString("dd|MM|yyyy"));


            }
        }
}
