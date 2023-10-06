using System;
namespace PatronesDeDiseno2.Ejercicio1
{
	public class ExcelFormatStrategy : IFormatStrategy
	{
		public ExcelFormatStrategy()
		{
		}

        public string getData(string api)
        {
            return "DOCUMENTO_" + api;
        }


        public string calc(string data)
        {
            return data + "CalculadoExcel";
        }

        public string format(string calcData)
        {
            return calcData + ".xlsx";
        }
    }
}

