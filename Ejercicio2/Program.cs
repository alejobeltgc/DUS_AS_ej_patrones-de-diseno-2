using System;
using Ejercicio2.Adapter;
using Ejercicio2.Adapter.Adapters;
using Ejercicio2.Adapter.Services;

public class Program
{
    public static void Main(string[] args)
    {
        JsonService jsonService = new JsonService();
        MapProcesor mapProcesor = new MapProcesor(jsonService);
        Console.WriteLine(mapProcesor.data());


        KmlService kmlService = new KmlService();
        KmlAdapter kmlAdapter = new KmlAdapter(kmlService);

        MapProcesor mapProcesor2 = new MapProcesor(kmlAdapter);
        Console.WriteLine(mapProcesor2.data());
    }
}
