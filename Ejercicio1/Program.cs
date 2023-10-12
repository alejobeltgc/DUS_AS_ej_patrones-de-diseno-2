using System;
using PatronesDeDiseno2.Ejercicio1;

public class Program
{
    public static void Main(string[] args)
    {
        IFormatStrategy strategy = new ExcelFormatStrategy();
        Formater formater = new Formater(strategy);

        Console.WriteLine(formater.formatDocument("api:1"));

        strategy = new HtmlFormatStrategy();
        formater.setStrategy(strategy);
        Console.WriteLine(formater.formatDocument("api:1"));

        strategy = new PdfFormatStrategy();
        formater.setStrategy(strategy);
        Console.WriteLine(formater.formatDocument("api:2"));
    }
}
