using System;
namespace PatronesDeDiseno2.Ejercicio1
{
	public class HtmlFormatStrategy : IFormatStrategy
	{
		public HtmlFormatStrategy()
		{
		}

        public string getData(string api)
        {
            return "DOCUMENTO_" + api;
        }


        public string calc(string data)
        {
            return data + "CalculadoHTML";
        }

        public string format(string calcData)
        {
            return calcData + ".html";
        }
    }
}

