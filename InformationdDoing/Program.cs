// See https://aka.ms/new-console-template for more information
using InformationdDoing;
using System.Security.Cryptography.X509Certificates;

Console.WriteLine("Enter people: ");
Information person = new Information("Stefan", 12);
person.Output();
var n = int.Parse(Console.ReadLine());
string searchName = Console.ReadLine();
for (int i = 0; i < n; i++)
{
   var danni = Console.ReadLine().Split();
    Information person2 = new Information(danni[0], int.Parse(danni[1]));
    List<Information> list = new List<Information>();
    list.Add(person2);
    Console.WriteLine(list.Min(x => x.Age));
    list.Where(x => x.Name == searchName).ToList().ForEach(x => x.Output());
    list.OrderBy(x => x.Name).ToList().ForEach(x => x.Output());
  
}

try
{

}
catch (ArgumentNullException ex)
{
    Console.WriteLine(ex.Message);
}
catch (ArgumentOutOfRangeException ex)
{
    Console.WriteLine(ex.Message);
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}

