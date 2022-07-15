using System;
namespace ConsoleApp44
{
    class Program
    {
        public static void Main(string[] mrgs)
        {
            //creating object 
            DemoEncap demoEncap = new DemoEncap();

            //calls set accessor of the property Age,
            //and pass "21" as value of the standard field 'value'
            demoEncap.Age = 21;

            //calls set accessor of the property Name and pass "Irada" as value of the standard field 
            demoEncap.Name = "Irada";

            //displaying values of the variables

            Console.WriteLine("Name: " + demoEncap.Name);
            Console.WriteLine("Age : " +demoEncap.Age);
        }
    }
}
