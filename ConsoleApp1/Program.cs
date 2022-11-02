using System.Xml.Serialization;


internal class Program
{
    static async Task Main(string[] args)
    {

        var client = new ServiceReference1.SOAPDemoSoapClient();

        var soma = await client.AddIntegerAsync(1, 5);
        var division = await client.DivideIntegerAsync(5, 1);
        var city = await client.LookupCityAsync("10001");


        Console.WriteLine(soma);
        Console.WriteLine(division);
        Console.WriteLine(city.City);

    }

}