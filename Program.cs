
using System.Runtime.InteropServices.Marshalling;

namespace List;

class Program
{
    static void Main(string[] args)
    {
       List<string> fruits = new List<string>();
       fruits.Add("fraises");
       fruits.Add("pommes");
       fruits.Add("bananes");
       

       fruits.RemoveAt(0);
       fruits.Remove("bananes");
       fruits[0] = "cerises";
       
       Console.WriteLine(fruits[0]);
       Console.WriteLine(fruits.Count);
    

        
    }
}
