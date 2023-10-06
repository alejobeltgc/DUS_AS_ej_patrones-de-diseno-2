using System;
namespace PatronesDeDiseno2.Ejercicio1
{
	public class PdfFormatStrategy : IFormatStrategy
	{
		public PdfFormatStrategy()
		{
		}

        public string getData(string api)
        {
            return "DOCUMENTO_" + api;
        }


        public string calc(string data)
        {
            return data + "CalculadoPDF";
        }

        public string format(string calcData)
        {
            return calcData + ".pdf";
        }
    }
}

